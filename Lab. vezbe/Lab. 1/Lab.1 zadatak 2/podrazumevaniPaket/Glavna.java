package podrazumevaniPaket;
import literatura.*;
import Izuzeci.*;
import java.util.*; // Scanner sa tastature

public class Glavna {

	public static void main(String[] args)
	{
		
		Biblioteka<Referenca> b1 = new Biblioteka<Referenca>();
		Referenca k1 = new Knjige(1988, "Knjiga ima ime");
		Referenca k2 = new Knjige(1988, "Nema knjiga");
		
		Referenca r1 = new Radovi(1999, 12345);
		Referenca r2 = new Radovi(2000, 98765);
		
		b1.staviNaPolicu(k1);
		b1.staviNaPolicu(k2);
		b1.staviNaPolicu(r1);
		b1.staviNaPolicu(r2);
		
		
		Knjige unos;
		
		try
		{
			Scanner tast = new Scanner(System.in);
			System.out.println("godina: ");
			int godina = tast.nextInt();
			
			if(godina == 0)
				throw new Bozic("godina ne moze biti 0");
			
			tast.nextLine();
			System.out.println("Unesite naslov: ");
			String naslov = tast.nextLine();
			
			unos = new Knjige(godina, naslov);
			
		}
		catch(Bozic e)
		{
			System.out.println(e);
			unos = new Knjige(2024, "Ris papira");
		}
		
		b1.staviNaPolicu(unos);
		b1.urediPolicu();
		
	
	}
}
