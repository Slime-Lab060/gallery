package pac.generator;

import java.text.SimpleDateFormat;
import java.util.Date;

public class Datetime {

	public static String GetTime() {
		Date d = new Date();
		SimpleDateFormat f = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
		String date = f.format(d);
		return date;
	}
}
