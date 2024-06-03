USE db_mytaskmanager;

CREATE TABLE t_user (
    idUser INT NOT NULL AUTO_INCREMENT,
    useFirstName varchar(40) NOT NULL,
    useLastName varchar(40) NOT NULL,
    useLogin varchar(40) UNIQUE NOT NULL,
    usePassword varchar(255) NOT NULL,
    PRIMARY KEY (idUser)
);

CREATE TABLE t_task (
    idTask INT NOT NULL AUTO_INCREMENT,
    tasTitle varchar(20) NOT NULL,
    tasText varchar(80),
    tasCreationDate DATE,
    tasEndDate DATE,
    tasPriority varchar(20),
    tasUrl varchar(255),
    tasImage BLOB, 
    fkUser INT NOT NULL,
    PRIMARY KEY (idTask),
    FOREIGN KEY (fkUser) REFERENCES t_user(idUser)
);