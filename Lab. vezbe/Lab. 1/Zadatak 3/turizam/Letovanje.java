package turizam;

import java.io.*;

public class Letovanje implements IPut, Comparable<IPut>{

	public String nazivDestinacije;
	public int brojDana;
	public double cenaPoDanu;
	
	
	public Letovanje()
	{
		nazivDestinacije = null;
		brojDana = 0;
		cenaPoDanu = 0.0;
		
	}
	
	public Letovanje(String _naziv, int _brojDana, double _cenaPoDanu)
	{
		this.nazivDestinacije = _naziv;
		this.brojDana = _brojDana;
		this.cenaPoDanu = _cenaPoDanu;
	}
	
	public double vratiCenu()
	{
		return(brojDana * cenaPoDanu) * (1 + Math.random());
	}
	
	public int compareTo(IPut o)
	{
		if(o.vratiCenu() > this.vratiCenu())
			return -1;
		else if(o.vratiCenu() == this.vratiCenu())
			return 0;
		else 
			return 1;
	}
	
	public void upisi()
	{
		try
		{
			FileWriter f = new FileWriter(this.vratiCenu() + ".txt");
			BufferedWriter b = new BufferedWriter(f);
			b.write(nazivDestinacije.split(" ") [0]);
			b.close();
		}
		catch(IOException e)
		{
			System.out.println(e);
		}
	}
}
