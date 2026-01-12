# ParkingSystem

ParkingSystem to aplikacja stworzona jako praca inżynierska prezentująca system monitorowania dostępności miejsc parkingowych z wykorzystaniem mikrokontrolera Arduino i aplikacji desktopowej Windows Forms.

→ Opis projektu

System składa się z dwóch głównych części:

  Arduino – urządzenie sprawdza zajętość miejsc parkingowych za pośrednictwem fotorezysotrów i wysyła dane przez port szeregowy.

  Aplikacja Windows Forms – odbiera dane z Arduino, wyświetla status miejsc parkingowych oraz umożliwia

  - konfigurację połączenia szeregowego,
  - monitorowanie aktualnego stanu miejsc (wolne/zajęte),
  - przeglądanie danych historycznych,
  - analizę statystyk dla wybranego miejsca.

→ Funkcjonalności

  - Połączenie z Arduino przez port szeregowy
  - Wyświetlanie w czasie rzeczywistym stanu miejsc parkingowych
  - Ustawienia portu COM i parametrów transmisji
  - Moduł historii danych i statystyk
  - Intuicyjny interfejs użytkownika

→ Technologie

Projekt wykorzystuje:

  - C# / .NET Windows Forms – aplikacja desktopowa
  - SerialPort – komunikacja UART
  - Arduino – odczyt sensorów i wysyłanie danych
  - Bazę danych MSSQL do przechowywania danych.
