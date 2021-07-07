package pac.exception;

public class MysqlException extends Exception {
 
  public MysqlException() {
    super();
  }

  public MysqlException(String message, Throwable cause,
      boolean enableSuppression, boolean writableStackTrace) {
    super(message, cause, enableSuppression, writableStackTrace);
  }

  public MysqlException(String message, Throwable cause) {
    super(message, cause);
  }

  public MysqlException(String message) {
    super(message);
  }

  public MysqlException(Throwable cause) {
    super(cause);
  }

}

