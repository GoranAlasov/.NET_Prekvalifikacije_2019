/* 1. Predmet informacioni sistemi premestiti u prvi semestar */
UPDATE predmet SET sem = 1 WHERE nazp = 'Informacioni sistemi'; 

/* 2. Prikazati nazive predmeta koji se predaju u prvom semestru
i koji na drugom mesu u nazivu imaju slovo N sortirane u opadajucem redosledu*/
SELECT nazp from predmet 
WHERE sem = 1 
AND nazp LIKE '_N%' 
ORDER BY nazp DESC;

/* 3. Prikazati imena i prezimena nastavnika koji drze nastavu u prvom semestru. 
Ukoliko natavnik drzi vise predmeta u prvom semestru ne treba ponavljati njegovo ime vise puta.*/
SELECT DISTINCT nast.imen, nast.prezn 
FROM nastavnik nast JOIN predaje predaje
ON  nast.idn = predaje.idn
JOIN predmet predmet
ON predaje.spr = predmet.spr
WHERE predmet.sem = 1;

/* 4. Prikazati nazive predmeta koje predaje vise od dva nastavnika. */

SELECT nazp 
FROM predmet JOIN predaje
ON predmet.spr = predaje.spr
GROUP BY nazp
HAVING COUNT(predaje.idn) > 2;

/*5. Kreirati Pogled_predaje koji ce za svakog nastavnika (ime i prezime) prikazati ukupan fond casova. 
Za nastavnike koji ne predaju nijedan predmet prikazati da je fond casova nula.*/

CREATE OR REPLACE VIEW Pogled_predaje (Ime, Prezime, Fond) AS 
SELECT nastavnik.imen, nastavnik.prezn, ifnull(SUM(predaje.fond), 0)
FROM nastavnik LEFT JOIN predaje
ON nastavnik.idn = predaje.idn
GROUP BY nastavnik.idn;