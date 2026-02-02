package literatura;
import java.io.*;

public class Radovi implements Referenca, Comparable<Referenca> {

	private int godina;
	private int isbn;
	
	public Radovi(int _godina, int _isbn)
	{
		this.godina = _godina;
		this.isbn = _isbn;
	}
	
	public int vratigod()
	{
		return this.godina;
	}
	
	public void upisi()
	{
		try
		{
			FileWriter f = new FileWriter(godina + ".txt");
			BufferedWriter b = new BufferedWriter(f);
			b.write(isbn % 10);
			b.close();
		}
		catch(IOException e)
		{
			System.out.println(e);
		}
	}
	
	public int compareTo(Referenca o)
	{
		if(o.vratigod() > this.vratigod())
			return -1;
		else if(o.vratigod() == this.vratigod())
			return 0;
		else
			return 1;
	}
}
