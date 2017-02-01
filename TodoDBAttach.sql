CREATE DATABASE TodoDB
    ON (FILENAME = '$(FullScriptDir)\Trellis.TodoData\TodoDB.mdf'),   
    (FILENAME = '$(FullScriptDir)\Trellis.TodoData\TodoDB_Log.ldf')   
    FOR ATTACH;  