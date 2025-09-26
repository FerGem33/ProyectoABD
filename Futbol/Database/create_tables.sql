USE futbol;

CREATE TABLE usuarios (
  id INT UNSIGNED NOT NULL AUTO_INCREMENT,
  usuario VARCHAR(50) NOT NULL UNIQUE,
  contraseña VARCHAR(20) NOT NULL,
  CONSTRAINT pk_usuarios PRIMARY KEY (id),
);

CREATE TABLE estadios (
  idEstadio INT UNSIGNED NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(45) BINARY NOT NULL,
  capacidad INT UNSIGNED NULL,
  direccion VARCHAR(80) NOT NULL,
  CONSTRAINT pk_estadios PRIMARY KEY(idEstadio),
  CONSTRAINT chk_estadios_capacidad CHECK (capacidad IS NULL OR capacidad > 0)
);

CREATE TABLE ligas (
  idLiga INT UNSIGNED NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(45) NOT NULL,
  fechaInicio DATE NULL,
  fechaFin DATE NULL,
  genero VARCHAR(15) NOT NULL,
  CONSTRAINT pk_ligas PRIMARY KEY(idLiga),
  CONSTRAINT chk_ligas_fechas CHECK (fechaFin IS NULL OR fechaInicio IS NULL OR fechaFin >= fechaInicio)
);

CREATE TABLE posiciones (
  idPosicion INT UNSIGNED NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(30) NOT NULL,
  CONSTRAINT pk_posiciones PRIMARY KEY(idPosicion)
);

CREATE TABLE entrenadores (
  idEntrenador INT UNSIGNED NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(45) NULL,
  apellidoPaterno VARCHAR(45) NULL,
  apellidoMaterno VARCHAR(45) NULL,
  fechaNac DATE NULL,
  telefono VARCHAR(15) NULL,
  CONSTRAINT pk_entrenadores PRIMARY KEY(idEntrenador),
  CONSTRAINT chk_entrenadores_fecha CHECK (fechaNac IS NULL OR fechaNac < CURDATE())
);

CREATE TABLE arbitros (
  idArbitro INT UNSIGNED NOT NULL AUTO_INCREMENT,
  nombre VARCHAR(45) NOT NULL,
  apellidoPaterno VARCHAR(45) NOT NULL,
  apellidoMaterno VARCHAR(45) NULL,
  fechaNac DATE NULL,
  telefono VARCHAR(15) NOT NULL,
  CONSTRAINT pk_arbitros PRIMARY KEY(idArbitro),
  CONSTRAINT chk_arbitros_fecha CHECK (fechaNac IS NULL OR fechaNac < CURDATE())
);

CREATE TABLE equipos (
  idEquipo INT UNSIGNED NOT NULL AUTO_INCREMENT,
  idEntrenador INT UNSIGNED NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  CONSTRAINT pk_equipos PRIMARY KEY(idEquipo),
  CONSTRAINT fk_equipos_entrenadores FOREIGN KEY(idEntrenador)
    REFERENCES entrenadores(idEntrenador)
);

CREATE TABLE jugadores (
  idJugador INT UNSIGNED NOT NULL AUTO_INCREMENT,
  idPosicion INT UNSIGNED NOT NULL,
  idEquipo INT UNSIGNED NOT NULL,
  nombre VARCHAR(45) NOT NULL,
  apellidoPaterno VARCHAR(50) NOT NULL,
  apellidoMaterno VARCHAR(50) NULL,
  fechaNac DATE NULL,
  altura DECIMAL(5,2) NULL,
  peso DECIMAL(5,2) NULL,
  telefono VARCHAR(15) NULL,
  CONSTRAINT pk_jugadores PRIMARY KEY(idJugador),
  CONSTRAINT fk_jugadores_equipos FOREIGN KEY(idEquipo)
    REFERENCES equipos(idEquipo),
  CONSTRAINT fk_jugadores_posiciones FOREIGN KEY(idPosicion)
    REFERENCES posiciones(idPosicion),
  CONSTRAINT chk_jugadores_altura CHECK (altura IS NULL OR altura > 0),
  CONSTRAINT chk_jugadores_peso CHECK (peso IS NULL OR peso > 0),
  CONSTRAINT chk_jugadores_fecha CHECK (fechaNac IS NULL OR fechaNac < CURDATE())
);

CREATE TABLE partidos (
  idPartido INT UNSIGNED NOT NULL AUTO_INCREMENT,
  idEstadio INT UNSIGNED NOT NULL,
  idLocal INT UNSIGNED NOT NULL,
  idVisitante INT UNSIGNED NOT NULL,
  idArbitro INT UNSIGNED NOT NULL,
  idLiga INT UNSIGNED NOT NULL,
  fecha DATE NOT NULL,
  hora TIME NOT NULL,
  CONSTRAINT pk_partidos PRIMARY KEY(idPartido),
  CONSTRAINT fk_partidos_ligas FOREIGN KEY(idLiga)
    REFERENCES ligas(idLiga),
  CONSTRAINT fk_partidos_equipoLocal FOREIGN KEY(idLocal)
    REFERENCES equipos(idEquipo),
  CONSTRAINT fk_partidos_equipoVisitante FOREIGN KEY(idVisitante)
    REFERENCES equipos(idEquipo),
  CONSTRAINT fk_partidos_arbitros FOREIGN KEY(idArbitro)
    REFERENCES arbitros(idArbitro),
  CONSTRAINT fk_partidos_estadios FOREIGN KEY(idEstadio)
    REFERENCES estadios(idEstadio),
  CONSTRAINT chk_partidos_equipos CHECK (idLocal <> idVisitante)
);

CREATE TABLE resultados (
  idResultado INT UNSIGNED NOT NULL AUTO_INCREMENT,
  idPartido INT UNSIGNED NOT NULL,
  marcadorLocal INT NOT NULL,
  marcadorVisitante INT NOT NULL,
  CONSTRAINT pk_resultados PRIMARY KEY(idResultado),
  CONSTRAINT fk_resultados_partidos FOREIGN KEY(idPartido)
    REFERENCES partidos(idPartido),
  CONSTRAINT chk_resultados_marcadores CHECK (marcadorLocal >= 0 AND marcadorVisitante >= 0)
);
