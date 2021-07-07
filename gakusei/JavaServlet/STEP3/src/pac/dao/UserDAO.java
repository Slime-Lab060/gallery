package pac.dao;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.SQLIntegrityConstraintViolationException;
import java.sql.Statement;

import pac.UserList;
import pac.UserListInfo;
import pac.exception.DatabaseException;
import pac.exception.MysqlException;
import pac.exception.SystemException;
import pac.parameter.MysqlParameters;

public class UserDAO extends BaseDAO{
	private Statement stmt;

	public int addUser(UserList usr) throws DatabaseException, SystemException,MysqlException {

		int ret=0;
		this.open();
		try {	
			stmt = con.createStatement();
			String sql = "INSERT INTO USERS VALUES ('" +
					usr.getuserid() + "','" +
					usr.getpassword() + "');";
			stmt.executeUpdate(sql);

			sql = "INSERT INTO USER_ROLES VALUES ('" +
					usr.getuserid() + "','" +
					usr.getrole() +"');";
			ret =stmt.executeUpdate(sql);
			System.out.println(ret+"件ユーザ作成しました。");

		} catch (SQLIntegrityConstraintViolationException e) {
	          throw new MysqlException(
		              MysqlParameters.Integrity_Constraint_Violation, e);
		}catch (SQLException e){
			e.printStackTrace();
		}finally {
			this.close(stmt);
		}
		return ret;
	}

	public UserListInfo getUser() throws DatabaseException,SystemException{
		UserListInfo Usr = new UserListInfo();
		this.open();
		try {
			stmt = con.createStatement();
			ResultSet rs = null;

			rs = stmt.executeQuery("SELECT * FROM USER_ROLES");

			while (rs.next()) {
				UserList usrlist = new UserList();
				usrlist.setuserid(rs.getString("USERID"));
				usrlist.setrole(rs.getString("ROLE"));
				Usr.addUserListArray(usrlist);
			}

		}catch(SQLException e) {
			e.printStackTrace();
		}finally {
			this.close(stmt);
		}

		return Usr;
	}
	
	
	public int UpdateUser(UserList usr) throws DatabaseException, SystemException {

		int ret=0;
		this.open();
		try {	
			stmt = con.createStatement();
			String sql = "UPDATE USERS SET PASSWORD='"+ usr.getpassword() +
					"' WHERE USERID='"+ usr.getuserid() +"';";
			ret =stmt.executeUpdate(sql);
			sql = "UPDATE USER_ROLES SET ROLE='"+ usr.getrole() +
					"' WHERE USERID='"+ usr.getuserid() +"';";
			ret =stmt.executeUpdate(sql);
			System.out.println(ret+"件ユーザ更新しました。");

		} catch (SQLException e) {
			e.printStackTrace();
		}finally {
			this.close(stmt);
		}
		return ret;
	}
	
	
	public int deleteUser(String userid) throws DatabaseException, SystemException {

		int ret=0;
		this.open();
		try {	
			stmt = con.createStatement();
			String sql = "DELETE FROM USERS WHERE USERID='"+ userid +"';";
			stmt.executeUpdate(sql);

			sql = "DELETE FROM USER_ROLES WHERE USERID='"+ userid +"';";
			ret =stmt.executeUpdate(sql);
			System.out.println(ret+"件削除しました。");

		} catch (SQLException e) {
			e.printStackTrace();
		}finally {
			this.close(stmt);
		}
		return ret;
	}
}