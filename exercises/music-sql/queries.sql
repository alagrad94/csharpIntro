-- #1
SELECT
  GenreId,
  Label
FROM "Genre";

-- #2
INSERT INTO "Artist" ("ArtistName", "YearEstablished") VALUES ("Jimmy Buffett","1973");

-- #3
INSERT INTO "Album" ("Title", "ReleaseDate", "AlbumLength", "Label", "ArtistId", "GenreId") VALUES ("Changes in Latitudes, Changes in Attitudes", "01/01/1977", "2488", "ABC", "28", "2");

-- #4
INSERT INTO "Song" ("Title", "SongLength", "ReleaseDate", "GenreId", "ArtistId", "AlbumId") VALUES ("Changes in Latitudes, Changes in Attitudes", "195", "01/01/1977", "2", "28", "23");
INSERT INTO "Song" ("Title", "SongLength", "ReleaseDate", "GenreId", "ArtistId", "AlbumId") VALUES ("Margaritaville", "195", "01/01/1977", "2", "28", "23");

-- #5
SELECT
  a.Title AS AlbumTitle,
  s.Title AS SongTitle
FROM "Album" a
LEFT JOIN "Song" s ON s."AlbumId" = a."AlbumId"
WHERE a.ArtistId = "28";

-- #6
SELECT
  a.Title AS AlbumTitle,
  COUNT(s.Title) AS SongCount
FROM "Album" a
LEFT JOIN "Song" s ON s."AlbumId" = a."AlbumId"
GROUP BY a.Title;

-- #7
SELECT
  a.ArtistName AS Artist,
  COUNT(s.Title) AS SongCount
FROM "Artist" a
LEFT JOIN "Song" s ON s."ArtistId" = a."ArtistId"
GROUP BY a.ArtistName;

-- #8
SELECT
  g.Label AS Genre,
  COUNT(s.Title) AS SongCount
FROM "Genre" g
LEFT JOIN "Song" s ON s."GenreId" = g."GenreId"
GROUP BY g.Label;

-- #9
SELECT
  Title,
  MAX(AlbumLength)
FROM "Album";

-- #10
SELECT
  Title,
  MAX(SongLength)
FROM "Song";

-- #11
SELECT
  a.Title AS AlbumTitle,
  s.Title AS SongTitle,
  MAX(s.SongLength)
FROM "Song" s
LEFT JOIN "Album" a ON s."AlbumId" = a."AlbumId";