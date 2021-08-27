CREATE OR REPLACE FUNCTION "RegisterUser"(
"UserId" SERIAL NOT NULL PRIMARY KEY,
"USername" CHARACTER VARYING(50),
"FullName" CHARACTER VARYING(255),
"Email" CHARACTER VARYING(50),
"Msisdn" CHARACTER VARYING(20),
"Password" CHARACTER VARYING(50),
"Active" BOOLEAN
)
RETURNS INTEGER 
LANGUAGE'plpgsql'
AS $BODY$ 
DECLARE newUserId INTEGER;
BEGIN
    INSERT INTO "User" ("UserId","USername","FullName","Email","Msisdn","Password","Active")
    VALUES ("pUserId","pUSername","pFullName","pEmail","pMsisdn","pPassword","pActive")
    RETURNING "UserId" INTO newUserId;
    RETURN newUserId;
END 
$BODY$

