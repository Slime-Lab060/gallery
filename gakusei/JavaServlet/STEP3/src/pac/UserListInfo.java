package pac;

import java.util.ArrayList;
import java.util.Iterator;

public class UserListInfo {

	private ArrayList<UserList> Usr;

	public UserListInfo() {Usr = new ArrayList<UserList>();}

	public void addUserListArray(UserList obj) {Usr.add(obj);}

	public void deleteTweetListArray() {
		Iterator<UserList> iterator = Usr.iterator();
		while (iterator.hasNext()) {
			iterator.next().getuserid();
			iterator.remove();
			System.out.println("REQUEST_DELETE_USR");
		}
	}

	public ArrayList<UserList> getUserListArray(){return Usr;}

}
