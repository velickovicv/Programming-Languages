package literatura;
import java.io.*;

public class Knjige implements Referenca, Comparable<Referenca>{

	private int godina;
	private String naslov;
	
	
	public Knjige(int _godina, String _naslov)
	{
		this.godina = _godina;
		this.naslov = _naslov;
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
			BufferedWriter b  = new BufferedWriter(f);
			b.write(naslov.split(" ") [0]);
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
