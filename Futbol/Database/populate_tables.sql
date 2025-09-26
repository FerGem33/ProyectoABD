USE futbol;

-- ============================
--  ESTADIOS
-- ============================
INSERT INTO estadios (nombre, capacidad, direccion) VALUES
('Estadio Azteca', 87000, 'Calzada de Tlalpan, CDMX'),
('Estadio BBVA', 53000, 'Guadalupe, Nuevo Leon'),
('Estadio Jalisco', 55000, 'Guadalajara, Jalisco'),
('Estadio Universitario', 42000, 'San Nicolas, Nuevo Leon');

-- ============================
--  LIGAS
-- ============================
INSERT INTO ligas (nombre, fechaInicio, fechaFin, genero) VALUES
('Liga MX Clausura 2025', '2025-01-10', '2025-05-25', 'Varonil'),
('Liga MX Femenil Clausura 2025', '2025-01-15', '2025-05-20', 'Femenil');

-- ============================
--  POSICIONES
-- ============================
INSERT INTO posiciones (nombre) VALUES
('Portero'),
('Defensa'),
('Medio'),
('Delantero');

-- ============================
--  ENTRENADORES
-- ============================
INSERT INTO entrenadores (nombre, apellidoPaterno, apellidoMaterno, fechaNac, telefono) VALUES
('Miguel', 'Herrera', 'Aguilar', '1968-03-18', '5551234567'),
('Ricardo', 'Ferretti', 'Oliveira', '1954-02-22', '5559876543'),
('Javier', 'Aguirre', 'Oncala', '1958-12-01', '5556789123'),
('Ana', 'Martinez', 'Lopez', '1975-06-15', '5551112233');

-- ============================
--  ARBITROS
-- ============================
INSERT INTO arbitros (nombre, apellidoPat, apellidoMat, fechaNac, telefono) VALUES
('Fernando', 'Guerrero', 'Ramirez', '1980-07-15', '5544445566'),
('Cesar', 'Ramos', 'Palazuelos', '1983-12-05', '5533331122'),
('Adonai', 'Escobedo', 'Gonzalez', '1985-01-20', '5522223344');

-- ============================
--  EQUIPOS
-- ============================
INSERT INTO equipos (idEntrenador, nombre) VALUES
(1, 'America'),
(2, 'Tigres UANL'),
(3, 'Rayados'),
(4, 'Chivas');

-- ============================
--  JUGADORES
-- ============================
INSERT INTO jugadores (idPosicion, idEquipo, nombre, apellidoPat, apellidoMat, fechaNac, altura, peso, telefono) VALUES
(1, 1, 'Guillermo', 'Ochoa', 'Magaña', '1985-07-13', 1.85, 78, '5512340001'),
(4, 1, 'Henry', 'Martin', 'Mex', '1992-11-18', 1.77, 75, '5512340002'),
(2, 2, 'Hugo', 'Ayala', 'Castro', '1987-03-31', 1.83, 80, '5523450001'),
(3, 2, 'Rafael', 'Carioca', 'Silva', '1989-06-18', 1.79, 76, '5523450002'),
(4, 3, 'Rogelio', 'Funes', 'Mori', '1991-03-05', 1.86, 81, '5534560001'),
(3, 3, 'Luis', 'Romo', 'Barron', '1995-06-05', 1.82, 78, '5534560002'),
(2, 4, 'Antonio', 'Briseño', 'Vazquez', '1994-02-05', 1.84, 79, '5545670001'),
(4, 4, 'Alexis', 'Vega', 'Garcia', '1997-11-25', 1.74, 72, '5545670002');

-- ============================
--  PARTIDOS
-- ============================
INSERT INTO partidos (idEstadio, idLocal, idVisitante, idArbitro, idLiga, fecha, hora) VALUES
(1, 1, 4, 1, 1, '2025-02-01', '20:00:00'),
(2, 3, 2, 2, 1, '2025-02-02', '19:00:00'),
(3, 4, 2, 3, 1, '2025-02-08', '21:00:00'),
(4, 2, 1, 1, 1, '2025-02-15', '18:00:00');

-- ============================
--  RESULTADOS
-- ============================
INSERT INTO resultados (idPartido, marcadorLocal, marcadorVisitante) VALUES
(1, 2, 1),
(2, 1, 1),
(3, 0, 3),
(4, 2, 2);
