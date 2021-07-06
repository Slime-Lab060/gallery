package pac.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

import pac.Parameter;
import pac.exception.DatabaseException;
import pac.exception.SystemException;

/**
 * データーベースコア<br>
 * ドライバー設定&リソース解放
 * */
public class BaseDAO {

	Connection con;

	protected void open() throws DatabaseException, SystemException {
		try {

			Class.forName(Parameter.DRIVER_NAME80);
			con = DriverManager.getConnection(Parameter.CONNECT_STRING, Parameter.USERID, Parameter.PASSWORD);

		} catch (ClassNotFoundException e) {
			System.out.println(e);
		} catch (SQLException e) {
			System.out.println(e);
		}
	}

	protected void close(Statement stmt) throws DatabaseException {
		try {
			if (stmt != null) {
				stmt.close();
			}
			if (con != null) {
				con.close();
			}
		} catch (SQLException e) {
			System.out.println(e);
		}
	}
}