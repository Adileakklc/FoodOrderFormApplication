CREATE DATABASE IF NOT EXISTS YemekSiparisiDB;

USE YemekSiparisiDB;

CREATE TABLE IF NOT EXISTS YemekKategorileri (
    KategoriID INT PRIMARY KEY AUTO_INCREMENT,
    KategoriAdi VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE IF NOT EXISTS Yemekler (
    YemekID INT PRIMARY KEY AUTO_INCREMENT,
    YemekAdi VARCHAR(50) NOT NULL,
    KategoriID INT,
    FOREIGN KEY (KategoriID) REFERENCES YemekKategorileri(KategoriID)
);

INSERT INTO YemekKategorileri (KategoriAdi) VALUES ('Fast Food');
INSERT INTO YemekKategorileri (KategoriAdi) VALUES ('İtalyan Mutfağı');
INSERT INTO YemekKategorileri (KategoriAdi) VALUES ('Tatlılar');
INSERT INTO YemekKategorileri (KategoriAdi) VALUES ('Çorbalar');
INSERT INTO YemekKategorileri (KategoriAdi) VALUES ('Deniz Ürünleri');

INSERT INTO Yemekler (YemekAdi, KategoriID) 
VALUES 
('Hamburger', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Fast Food' LIMIT 1)),
('Pizza', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Fast Food' LIMIT 1)),
('Tavuk Nugget', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Fast Food' LIMIT 1)),
('Hot Dog', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Fast Food' LIMIT 1)),
('Patates Kızartması', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Fast Food' LIMIT 1)),
('Cheeseburger', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Fast Food' LIMIT 1)),
('Döner', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Fast Food' LIMIT 1)),
('Taco', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Fast Food' LIMIT 1)),
('Kumpir', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Fast Food' LIMIT 1)),
('Quesadilla', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Fast Food' LIMIT 1));

INSERT INTO Yemekler (YemekAdi, KategoriID) 
VALUES 
('Spaghetti Bolognese', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'İtalyan Mutfağı' LIMIT 1)),
('Lasagna', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'İtalyan Mutfağı' LIMIT 1)),
('Fettuccine Alfredo', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'İtalyan Mutfağı' LIMIT 1)),
('Margherita Pizza', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'İtalyan Mutfağı' LIMIT 1)),
('Ravioli', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'İtalyan Mutfağı' LIMIT 1)),
('Carbonara', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'İtalyan Mutfağı' LIMIT 1)),
('Bruschetta', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'İtalyan Mutfağı' LIMIT 1)),
('Risotto', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'İtalyan Mutfağı' LIMIT 1)),
('Tiramisu', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'İtalyan Mutfağı' LIMIT 1)),
('Panna Cotta', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'İtalyan Mutfağı' LIMIT 1));

INSERT INTO Yemekler (YemekAdi, KategoriID) 
VALUES 
('Cheesecake', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Tatlılar' LIMIT 1)),
('Baklava', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Tatlılar' LIMIT 1)),
('Tiramisu', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Tatlılar' LIMIT 1)),
('Sütlaç', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Tatlılar' LIMIT 1)),
('Künefe', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Tatlılar' LIMIT 1)),
('Profiterol', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Tatlılar' LIMIT 1)),
('Magnolia', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Tatlılar' LIMIT 1)),
('Mousse', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Tatlılar' LIMIT 1)),
('Revani', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Tatlılar' LIMIT 1)),
('Kazandibi', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Tatlılar' LIMIT 1));

INSERT INTO Yemekler (YemekAdi, KategoriID) 
VALUES 
('Mercimek Çorbası', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Çorbalar' LIMIT 1)),
('Tarhana Çorbası', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Çorbalar' LIMIT 1)),
('Domates Çorbası', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Çorbalar' LIMIT 1)),
('Tavuk Suyu Çorbası', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Çorbalar' LIMIT 1)),
('Ezogelin Çorbası', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Çorbalar' LIMIT 1)),
('Kremalı Mantar Çorbası', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Çorbalar' LIMIT 1)),
('Brokoli Çorbası', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Çorbalar' LIMIT 1)),
('İşkembe Çorbası', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Çorbalar' LIMIT 1)),
('Balık Çorbası', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Çorbalar' LIMIT 1)),
('Yayla Çorbası', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Çorbalar' LIMIT 1));

INSERT INTO Yemekler (YemekAdi, KategoriID) 
VALUES 
('Kalamar', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Deniz Ürünleri' LIMIT 1)),
('Karides', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Deniz Ürünleri' LIMIT 1)),
('Levrek Izgara', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Deniz Ürünleri' LIMIT 1)),
('Somon Füme', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Deniz Ürünleri' LIMIT 1)),
('Midye Dolma', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Deniz Ürünleri' LIMIT 1)),
('Ahtapot Salatası', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Deniz Ürünleri' LIMIT 1)),
('Sardalya Tava', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Deniz Ürünleri' LIMIT 1)),
('Balık Köftesi', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Deniz Ürünleri' LIMIT 1)),
('Tereyağlı Karides', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Deniz Ürünleri' LIMIT 1)),
('Lagos Şiş', (SELECT KategoriID FROM YemekKategorileri WHERE KategoriAdi = 'Deniz Ürünleri' LIMIT 1));
