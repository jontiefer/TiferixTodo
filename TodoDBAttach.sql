CREATE DATABASE TodoDB
    ON (FILENAME = '$(FullScriptDir)\Tiferix.TodoData\TodoDB.mdf'),   
    (FILENAME = '$(FullScriptDir)\Tiferix.TodoData\TodoDB_Log.ldf')   
    FOR ATTACH;  