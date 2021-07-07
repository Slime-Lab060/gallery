package pac;

public class UserList {

	private String userid="nan";
	private String password="nan";
	private String role="nan";

	public UserList() { super();}
	
	public void setuserid(String userid) {this.userid = userid;}
	
	public void setpassword(String password) {this.password = password;}

	public void setrole(String role) {this.role = role;}

	public String getuserid(){return userid;}
	
	public String getpassword() {return password;}

	public String getrole(){return role;}

}
