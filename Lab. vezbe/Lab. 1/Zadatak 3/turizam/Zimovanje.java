package turizam;

import java.io.*;

public class Zimovanje implements IPut, Comparable<IPut>{

	private String nazivDestinacije;
	public int brojDana;
	public double cenaPoDanu;
	public double cenaSkiPasaNaDan;
	
	public Zimovanje()
	{
		nazivDestinacije = null;
		brojDana = 0;
		cenaPoDanu = 0.0;
		cenaSkiPasaNaDan = 0.0;
	}
	
	public Zimovanje(String _nazivDestinacije, int _brojDana, double _cenaPoDanu, double _cenaSkiPasaNaDan )
	{
		this.nazivDestinacije = _nazivDestinacije;
		this.brojDana = _brojDana;
		this.cenaPoDanu = _cenaPoDanu;
		this.cenaSkiPasaNaDan = _cenaSkiPasaNaDan;
	}
	
	public double vratiCenu()
	{
		return((brojDana - 2) + (brojDana * cenaPoDanu) * cenaSkiPasaNaDan);
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
	
	public int compareTo(IPut o)
	{
		if(o.vratiCenu() > this.vratiCenu())
			return -1;
		else if(o.vratiCenu() == this.vratiCenu())
			return 0;
		else
			return 1;
	}
	
}
