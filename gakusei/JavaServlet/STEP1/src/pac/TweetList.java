package pac;

import java.io.Serializable;

public class TweetList implements Serializable {
	private String name="nan";
	private String tweet="nan";
	private String date="nan";
	

public void setname(String Name) {this.name = Name;}

public void settweet(String Tweet) {this.tweet = Tweet;}

public void setdate(String Date) {this.date = Date;}

public String getname(){return name;}

public String gettweet(){return tweet;}

public String getdate(){return date;}
}
