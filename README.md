# BisectionMaster3k
Windows forms program created for root-finding using Bisection Method

### Metodę Bisekcji można uznać za nudną, powtarzalną. 

Podobnie jest z innymi, podobnymi co do czasochłonności, zadaniami matematycznymi powinna być ona rozwiązywana przez komputer.
Samą Metodę porównać można do gry w "zgadnij liczbę z przedziału". 
Gdzie jeden gracz (zgadujący) próbuje odgadnąć liczbę przeciwnika, np. od 1 do 100. 
Optymalnym rozwiązaniem tej gry, w kontekście problemu matematycznego, jest wybieranie liczby będącej średnią granic przedziałów. 
Pozwoli to systematycznie pomniejszać przedział, aż do momentu, w którym trafimy na, np. 75 które jest większe od podanego przez nas 50, w pierwszej iteracji odgadywania.

**Podobnie jest w przypadku Metody Bisekcji. Kroki do wyznaczenia m. zerowego Funkcji Ciągłej są następujące:**

1. należy wybrać sobie przedział x'ów tak by f(x lewo) miała przeciwny znak do f(x prawo)
2.  trzeba sobie uświadomić, że Funkcja Ciągła nie może zmienić znaku na zadanym przedziale x'ów bez przecięcia osi odciętych (X)
3.  teraz wystarczy dzielić przedział na pół wybierając jako kandydata na m. zerowe x'a będącego średnią x'ów granicznych, jeśli wartość tego x'a nas zadowala (jest to dobre przybliżenie według błędu na jaki możemy sobie pozwolić) znaleźliśmy Przybliżenie m. zerowego.
