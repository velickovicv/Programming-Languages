package podrazumevaniPaket;
import java.util.*;
import java.io.*;
import literatura.Referenca;

public class Biblioteka<T extends Referenca> {

	private ArrayList<T> lista;
	
	public <T>Biblioteka()
	{
		lista = new ArrayList<>();
	}
	
	
	public void staviNaPolicu(T o) // Stavlja referencu u list
	
	// Znaci treba nam neki parametar neki objekat koji stavljamo  
	
	{
		lista.add(o);
	}
	
	public void urediPolicu()
	{
		lista.sort(null);
		lista.get(0).upisi();
		lista.get(lista.size() -1).upisi();
		
		try
		{
			FileOutputStream fos = new FileOutputStream("broj.bin");
			BufferedOutputStream bos = new BufferedOutputStream(fos);
			DataOutputStream dos = new DataOutputStream(bos);
			
			dos.writeInt(lista.size());
			dos.close();
		}
		catch(IOException e)
		{
			System.out.println(e);
		}
	}
}
