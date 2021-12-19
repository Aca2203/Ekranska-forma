CREATE DATABASE [Ekranska forma];
USE [Ekranska forma];

CREATE TABLE Racun(
  id INT IDENTITY(1, 1),
  broj_racuna INT NOT NULL,
  kupac NVARCHAR(50) NOT NULL,
  datum CHAR(10) NOT NULL,
  vrednost INT NOT NULL,
  br_stavki INT NOT NULL
);

DROP TABLE Racun;

INSERT INTO Racun(broj_racuna, kupac, datum, vrednost, br_stavki) VALUES(562, 'Marko Peric', '2021-12-19', 7, 3);
INSERT INTO Racun(broj_racuna, kupac, datum, vrednost, br_stavki) VALUES(123, 'Nikola Maric', '2021-12-16', 4, 9);
INSERT INTO Racun(broj_racuna, kupac, datum, vrednost, br_stavki) VALUES(647, 'Aleksa Vucic', '2020-06-29', 2, 4);
INSERT INTO Racun(broj_racuna, kupac, datum, vrednost, br_stavki) VALUES(253, 'Marija Stankovic', '2019-01-07', 1, 7);

SELECT *
FROM Racun;