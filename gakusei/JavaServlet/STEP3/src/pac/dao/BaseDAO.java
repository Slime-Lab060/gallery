package pac.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

import pac.exception.DatabaseException;
import pac.exception.SystemException;
import pac.parameter.DataBaseParameter;
import pac.parameter.ExceptionParameters;

/**
 * データーベースコア<br>
 * ドライバー設定&リソース解放
 * */
public class BaseDAO {

	Connection con;

	protected void open() throws DatabaseException, SystemException {
		try {

			Class.forName(DataBaseParameter.DRIVER_NAME80);
			con = DriverManager.getConnection(DataBaseParameter.CONNECT_STRING, DataBaseParameter.USERID, DataBaseParameter.PASSWORD);

		} catch (ClassNotFoundException e) {
		      throw new SystemException(
		              ExceptionParameters.SYSTEM_EXCEPTION_MESSAGE, e);
		        } catch (SQLException e) {
		          throw new DatabaseException(
		              ExceptionParameters.DATABASE_CONNECTION_EXCEPTION_MESSAGE, e);
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
		      throw new DatabaseException(
		              ExceptionParameters.DATABASE_CLOSE_EXCEPTION_MESSAGE, e);
		}
	}
}