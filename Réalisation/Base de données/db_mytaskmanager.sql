USE db_mytaskmanager;

CREATE TABLE t_user (
    idUser INT NOT NULL AUTO_INCREMENT,
    useFirstName varchar(50) NOT NULL,
    useLastName varchar(50) NOT NULL,
    useLogin varchar(50) NOT NULL,
    usePassword varchar(50) NOT NULL,
    PRIMARY KEY (idUser)
);

CREATE TABLE t_task (
    idTask INT NOT NULL AUTO_INCREMENT,
    tasTitle varchar(50) NOT NULL,
    tasText varchar(200),
    tasCreationDate DATE,
    tasEndDate DATE,
    tasPriority INT,
    tasUrl varchar(255),
    tasImage BLOB, 
    fkUser INT NOT NULL,
    PRIMARY KEY (idTask),
    FOREIGN KEY (fkUser) REFERENCES t_user(idUser)
);