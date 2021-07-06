package pac.dao;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import pac.TweetList;
import pac.TweetListInfo;
import pac.exception.DatabaseException;
import pac.exception.SystemException;

public class TweetDAO extends BaseDAO {
	private Statement stmt;

	public int addTweet(TweetList tw) throws DatabaseException, SystemException {

		int ret=0;
		this.open();
		try {	

			stmt = con.createStatement();
			String sql = "INSERT INTO TWEET VALUES('" +
					tw.getname() + "','" +
					tw.gettweet() + "','" +
					tw.getdate() + "');";
			ret = stmt.executeUpdate(sql);
			System.out.println(ret+"件追加しました。");

		} catch (SQLException e) {
			e.printStackTrace();
		}finally {
			this.close(stmt);
		}
		return ret;
	}

	public TweetListInfo getTweet(boolean peason, TweetList twt)throws DatabaseException, SystemException  {
		TweetListInfo tw = new TweetListInfo();
		this.open();
		try {
			stmt = con.createStatement();
			ResultSet rs = null;
			if(peason) {
				rs = stmt.executeQuery("SELECT * FROM TWEET WHERE NAME='"+ twt.getname()  +"';");
			}else {
				rs = stmt.executeQuery("SELECT * FROM TWEET");
			}
			while (rs.next()) {
				TweetList twlist = new TweetList();
				twlist.setname(rs.getString("NAME"));
				twlist.settweet(rs.getString("TWEET"));
				twlist.setdate(rs.getString("DATE"));
				tw.addTweetListArray(twlist);
			}

		}catch(SQLException e) {
			e.printStackTrace();
		}finally {
			this.close(stmt);
		}
		return tw;
	}

	public void DeleteTweet(String name) throws DatabaseException, SystemException {
		try {
			this.open();
			stmt = con.createStatement();
			stmt.executeUpdate("DELETE FROM TWEET WHERE NAME='"+ name  +"';");
		}catch(SQLException e) {
			e.printStackTrace();
		}finally {
			this.close(stmt);
		}
	}
}