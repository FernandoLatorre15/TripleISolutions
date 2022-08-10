create table CAT_SONG
(
  SongId int Primary key Identity(1,1)NOT NULL,
  TitleName VARCHAR(75),
  BandName VARCHAR(30),
  LaunchYear int,
  MusicGenre VARCHAR(30)
)
select * from cat_song
INSERT INTO CAT_SONG (TitleName,
                             BandName,
                             LaunchYear,
                             MusicGenre)
VALUES('I am going slightly mad', 'Queen', 1990, 'Rock');