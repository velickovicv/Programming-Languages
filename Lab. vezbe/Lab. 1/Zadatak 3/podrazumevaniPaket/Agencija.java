package podrazumevaniPaket;
import java.util.*;
import java.io.*;
import inflacija.*;

public class Agencija <T extends IPut>{

	public ArrayList<T> list;
	
	public Agencija()
	{
		list = new ArrayList<T>();
	}
	
	public void dodajPut(t o)
	{
		list.add(o);
	}
	public void zavediRed() throws Preskupo
	{
		list.sort(null);
		
		if(list.get(list.size() -1).vratiCenu > 2000)
			throw new Preskupo("preskupo je \n");
	}
}
