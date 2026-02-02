package podrazumevaniPaket;
import java.util.*;
import izuzeci.NevalidnaPoruka;
import korespondencija.IPoruka;

public class Telefon <T extends IPoruka> {
	
	private Arraylist<T> lista;
	
	public Telefon()
	{
		lista = new ArrayList<>();
	}
	
	
	public void dodajPoruku(t poruka)
	{
		lista.add(poruka);
	}
	
	public int zavediRed()
	{
		lista.sort(null);
	}
	
	public int procitajPoruku() throws NevalidnaPoruka;
	{
      
		if(lista.isEmpty())
			return -1;
		
		IPoruka temp = lista.remove(lista.size() -1);
		
		if(temp.validiraj() == -1)
			throw new NevalidnaPoruka("nevalidna poruka!\n")
		
	}
	
	temp.ispisi();
	temp.arhiviraj();
	return 1;

}
