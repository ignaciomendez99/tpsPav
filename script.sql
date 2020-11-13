
INSERT INTO Categorias(id_categoria,nombre,borrado) VALUES (1,'CS. BÁSICAS', 0);
INSERT INTO Categorias(id_categoria,nombre,borrado) VALUES (2,'PROGRAMACIÓN', 0);
INSERT INTO Categorias(id_categoria,nombre,borrado) VALUES (3,'SISTEMAS', 0);
INSERT INTO Categorias(id_categoria,nombre,borrado) VALUES (4,'INDUSTRIAL', 0);
INSERT INTO Categorias(id_categoria,nombre,borrado) VALUES (5,'QUÍMICA', 0);
INSERT INTO Categorias(id_categoria,nombre,borrado) VALUES (6,'AERONATICA', 0);

INSERT INTO Cursos(id_curso,nombre, descripcion, fecha_vigencia,id_categoria,borrado) VALUES (1,'PROGRAMACIÓN I','PROGRAMACIÓN JUNIOR','10/10/2018',2,0);
INSERT INTO Cursos(id_curso,nombre, descripcion, fecha_vigencia,id_categoria,borrado) VALUES (2,'PROGRAMACIÓN II','PROGRAMACIÓN INTERMEDIATE','10/5/2019',2,0);
INSERT INTO Cursos(id_curso,nombre, descripcion, fecha_vigencia,id_categoria,borrado) VALUES (3,'ANÁLISIS MATEMÁTICO I','PROGRAMACIÓN JUNIOR','10/10/2018',1,0);
INSERT INTO Cursos(id_curso,nombre, descripcion, fecha_vigencia,id_categoria,borrado) VALUES (4,'ÁLGEBRA','ALGEBRA Y GEOMETRÍA ANALÍTICA','10/10/2018',1,0);
INSERT INTO Cursos(id_curso,nombre, descripcion, fecha_vigencia,id_categoria,borrado) VALUES (5,'PROGRAMACIÓN III','PROGRAMACIÓN SENIOR','10/9/2020',2,0);
INSERT INTO Cursos(id_curso,nombre, descripcion, fecha_vigencia,id_categoria,borrado) VALUES (6,'ÁLGEBRA II','PROGRAMACIÓN JUNIOR','10/10/2018',1,1);
INSERT INTO Cursos(id_curso,nombre, descripcion, fecha_vigencia,id_categoria,borrado) VALUES (7,'PAV IV','PROGRAMACIÓN DE APLICACIONES VISUALES','10/9/2020',2,1);

INSERT INTO Objetivos(id_objetivo, nombre_corto, nombre_largo, borrado) VALUES (1, 'PYTHON 3', 'PYTHON 3 BEGGINER COURSE', 0);
INSERT INTO Objetivos(id_objetivo, nombre_corto, nombre_largo, borrado) VALUES (2, 'PYTHON 3', 'PYTHON 3 INTERMEDIATE COURSE', 0);
INSERT INTO Objetivos(id_objetivo, nombre_corto, nombre_largo, borrado) VALUES (3, 'PYTHON 3', 'PYTHON 3 ADVANCED COURSE', 0);
INSERT INTO Objetivos(id_objetivo, nombre_corto, nombre_largo, borrado) VALUES (4, 'JAVA', 'POO BEGGINER COURSE', 0);
INSERT INTO Objetivos(id_objetivo, nombre_corto, nombre_largo, borrado) VALUES (5, 'JAVA', 'POO INTERMEDIATE COURSE', 0);
INSERT INTO Objetivos(id_objetivo, nombre_corto, nombre_largo, borrado) VALUES (6, 'ECUACIONES DIFERENCIALES', 'ECUACIONES DIFERENCIALES ORDINARIAS', 0);
INSERT INTO Objetivos(id_objetivo, nombre_corto, nombre_largo, borrado) VALUES (7, 'VECTORES Y MATRICES', 'OPERACIONES CON VECTORES Y MATRICES. SEL', 0);
INSERT INTO Objetivos(id_objetivo, nombre_corto, nombre_largo, borrado) VALUES (8, 'JAVA', 'NULL', 1);
INSERT INTO Objetivos(id_objetivo, nombre_corto, nombre_largo, borrado) VALUES (9, 'JAVA', 'NULL', 1);

INSERT INTO ObjetivosCursos(id_curso,id_objetivo,puntos,borrado) VALUES (1,1,2,0);
INSERT INTO ObjetivosCursos(id_curso,id_objetivo,puntos,borrado) VALUES (1,2,5,0);
INSERT INTO ObjetivosCursos(id_curso,id_objetivo,puntos,borrado) VALUES (2,3,6,0);
INSERT INTO ObjetivosCursos(id_curso,id_objetivo,puntos,borrado) VALUES (4,7,34,0);
INSERT INTO ObjetivosCursos(id_curso,id_objetivo,puntos,borrado) VALUES (5,4,2,0);
INSERT INTO ObjetivosCursos(id_curso,id_objetivo,puntos,borrado) VALUES (5,5,7,0);
INSERT INTO ObjetivosCursos(id_curso,id_objetivo,puntos,borrado) VALUES (3,6,234,0);

