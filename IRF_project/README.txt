A szoftver funkciói: 

Egy olyan szoftver létrehozása a célom, amely segítségével sportesemények eredményeit listázhatjuk ki, 
szűrhetünk rá bizonyos szempontok alapján, illetve az eredményeket kiexportálhatjuk .csv kiterjesztésű fájlba.

Egy oldalsó menüben lehet választani sportágat, teniszt illetve labdarúgást, rákattintva egy user control tölt be a formon belül.
(Az ablak bezárására a "Kilépés" gomb megnyomásával van lehetőség, miután rányomunk megkérdezi, hogy biztosan ki akarunk-e lépni az alkalmazásból.)
Technikailag úgy oldottam meg, hogy xml fájlt olvasok be, és annak bizonyos értékeit listázom ki egy datagridview-ba.
A labdarúgás eredményeket szűrhetővé tettem hazai győzelem, döntetlen, illetve vendég győzelmek szerint. 
Ilyenkor ha újra betöltjük az adatokat, a listából törli a nem releváns adatokat. 
A kimeneteleket enumba definiáltam. 
Mind a szűrt adatokat, mind pedig a teljes listát képes a program csv-be kiexportálni.



