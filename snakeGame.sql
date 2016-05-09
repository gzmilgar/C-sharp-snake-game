create database SnakeGame
create table highScore
(
siralama int IDENTITY(1,1) NOT NULL,
KullaniciAdi varchar Not null,
Score int
)
select *from highScore