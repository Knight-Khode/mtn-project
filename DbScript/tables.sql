CREATE TABLE "User"(
"UserId" SERIAL NOT NULL PRIMARY KEY,
"USername" CHARACTER VARYING(50) NOT NULL,
"FullName" CHARACTER VARYING(255) NOT NULL,
"Email" CHARACTER VARYING(50) NOT NULL,
"Msisdn" CHARACTER VARYING(20) NOT NULL,
"Password" CHARACTER VARYING(50) NOT NULL,
"Active" BOOLEAN NOT NULL DEFAULT TRUE
);
