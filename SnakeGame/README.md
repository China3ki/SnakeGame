=== Snake ===
Ogólne założenia projektu:

1. Ogólne założenia
  1.1 Rozmiary okna
  - Szerokość: 80
  - Wysokość: 20
2. Menu
- Menu początkowe oraz końcowe ma mieć obramowanie w postaci znaków "=". 
  2.1 Menu start
  - Menu startowe z nazwą aplikacji.
  - Komunikat o wciśnięciu dowolnego przycisku aby zacząc grę.
  2.2 Menu end
  - Napis game over
    2.2.1 Opcje do wyboru
    - "Zagraj ponownie [Enter]" - Pozwala rozpocząć nową grę użytkownikowi.
    - "Wyjdź [Esc]" - Wychodzi z aplikacji.
3. Gra
  3.1 Wygląd
    3.1.1 Wąż
    - Wąż będzie się składać się z symboli "█".
    3.1.2 Jedzenie
    - Jedzenie "ε".
    3.1.3 Plansza
    - Bez obramowania, w prawym górnym rogu będzie wyświetlana punktacja.
  3.2 Rozgrywka
    3.2.1 Sterowanie
    - Strzałkami odpowiednio do kierunki.
    3.2.2 Jedzenie
    - Jedzenie renderowane co około od 2 do 5 sekund.
    - Jedzenie będzie znikać po 3 - 5 sekundach do wyrenderowania.
    3.2.3 Punktacja
    - Każde zjedzenie przez węża żarcia powoduje zwiększenie punktacji o 1.
    3.2.4 Poruszanie 
    - Wraz z przekroczniem szerokości lub wysokości ekranu, wąż renderuje się po drugiej stronie okna
  3.3 Porażka
    - Gracz może przegrać kiedy dotknie początkiem węża swojego ogona.