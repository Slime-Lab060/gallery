package pac;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.Iterator;

public class TweetListInfo implements Serializable {

	private ArrayList<TweetList> Tw;
	
	public TweetListInfo() {Tw = new ArrayList<TweetList>();
	System.out.println("REQUEST_initialize");
	}
	
	
	public int getTweetListSize() {return Tw.size();}
	
	public void setTweetListArray(ArrayList<TweetList> Tw) {this.Tw = Tw;}
	
	public void addTweetListArray(TweetList obj) {Tw.add(obj);}
	
	public void deleteTweetListArray() {
		Iterator<TweetList> iterator = Tw.iterator();
		while (iterator.hasNext()) {
			iterator.next().getname();
			iterator.remove();
			System.out.println("REQUEST_DELETE_TW");
		}
	}
	
	public ArrayList<TweetList> getTweetListArray(){return Tw;}
	
}
