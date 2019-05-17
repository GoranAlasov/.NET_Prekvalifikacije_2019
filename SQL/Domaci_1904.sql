/* Zadatak 1*/ 	SELECT idd 'ID', nazd 'Naziv dobavljaca' 
				FROM dobavljac 
				ORDER BY nazd DESC;
                
/*Zadatak 2*/	SELECT nazdeo 'Naziv dela' 
				FROM deo 
				WHERE cena BETWEEN 1200 AND 8000;
                
/*Zadatak 3*/	SELECT p.nazp 'Naziv projekta'
				FROM projekti p, nabavka n, deo d
                WHERE p.idp = n.idp AND d.iddeo = n.iddeo
                AND NOT EXISTS (SELECT d1.nazdeo FROM deo d1 WHERE d.cena < d1.cena);
                /*Gledajuci u podatke zakljucujem da su na projektima koji su u rezultatu upita nabavljani delovi sa cenom
                NULL. Medjutim, u zadatku pise "Prikazati projekat", u jednini. Da li sam napravio gresku? Takoje, testirao sam upit
                i nakon sto sam ubacio u bazu deo sa cenom 0, i definitivno upit prikazuje samo delove sa cenom NULL (dakle NULL je "manje" od 0).
                Da li semanticki ima smisla prikazati i delove kojima je cena ili NULL ili 0? Ili sam pak trebao prikazati samo projekat na kome
                se nabavlja deo koji IMA vrednost cene NOT NULL (pvc cev po 1000 dinara)?*/
                
/*Zadatak 4*/	SELECT nazp 'Naziv projekta'
				FROM projekti
                WHERE nazp LIKE '%k%'
                ORDER BY mesp ASC, nazp DESC;
                
/*Zadatak 5*/	SELECT nazp 'Nazip projekta'
				FROM projekti p, nabavka n, deo d
                WHERE p.idp = n.idp AND d.iddeo = n.iddeo
                AND d.nazdeo = 'sraf';
                
/*Zadatak 6*/	UPDATE deo SET cena = cena - 300;
				UPDATE deo SET cena = 500 WHERE cena IS NULL;
                /*Da li ovo ikako moze da se uradi u jednom upitu? Pokusavao sam, 
                ali cini mi se da mogu imati samo jedan SET - WHERE par u jednom upitu 
                (iako u samom SET-u moze da se naredja vise promena)*/
                
/*Dodatno*/		/*Prikazati mbr, prezime i ime radnika u jednoj koloni, godišnju platu radnika, 
				nazive projekata na kojima radi, kao i broj sati angažovanja na svakom projektu 
				za radnike čije ime na drugom mestu ima slovo v. 
				Rezultat sortirati u opadajućem redosledu prezimena i imena.*/
                
                SELECT CONCAT(r.mbr, ', ', r.prz, ' ', r.ime) 'ID, Ime i prezime radnika', 
					CONCAT (ROUND(r.plt * 12, 0), ' RSD') 'Godisnja plata', 
                    p.nap 'Naziv projekta',
                    rp.brc 'Broj sati angazovanja na projektu'
				FROM radnik r, projekat p, radproj rp
                WHERE r.mbr = rp.mbr AND p.spr = rp.spr
                AND r.ime LIKE '_v%'
                ORDER BY r.prz DESC, r.ime DESC;