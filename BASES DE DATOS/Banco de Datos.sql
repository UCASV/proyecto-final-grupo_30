DROP DATABASE PROJECT;
CREATE DATABASE PROJECT;
USE PROJECT;
SET LANGUAGE us_english;

-- Tables section
CREATE TABLE EMPLOYEE_TYPE(
	id_type INT PRIMARY KEY IDENTITY,
	typename VARCHAR(50) NOT NULL
);

CREATE TABLE EMPLOYEE(
	id_employee INT PRIMARY KEY IDENTITY,
	employee_name VARCHAR(50) NOT NULL,
	email VARCHAR(50) UNIQUE NOT NULL,
	employee_address VARCHAR(50) NOT NULL,
	employee_username VARCHAR(50),
	employee_password VARCHAR(50),
	id_type INT NOT NULL,
	id_booth INT,
);

CREATE TABLE BOOTH(
	id_booth INT PRIMARY KEY IDENTITY,
	booth_address VARCHAR(50) NOT NULL,
	telephone INT UNIQUE NOT NULL,
	email VARCHAR(50) NOT NULL
);

CREATE TABLE MANAGEMENT(
	id_management INT PRIMARY KEY IDENTITY,
	id_employee INT NOT NULL,
	id_booth INT NOT NULL,
	date_time_login DATETIME,
);

CREATE TABLE APPOINTMENT(
	id_appointment INT PRIMARY KEY IDENTITY,
	date_time_appointment_1 DATETIME,
	date_time_appointment_2 DATETIME,
	id_employee INT NOT NULL,
	id_vaccination_place INT NOT NULL,
	id_citizen INT NOT NULL
);

CREATE TABLE VACCINATION_PLACE(
	id_vaccination_place INT PRIMARY KEY IDENTITY,
	vaccination_place VARCHAR(50) NOT NULL,
	vaccination_place_address VARCHAR(200) NOT NULL
);

CREATE TABLE CITIZEN(
	id_citizen INT PRIMARY KEY IDENTITY,
	dui VARCHAR(15) UNIQUE NOT NULL,
	citizen_name VARCHAR(50) NOT NULL,
	citizen_address VARCHAR(50) NOT NULL,
	telephone VARCHAR(15) UNIQUE NOT NULL,
	email VARCHAR(50),
	id_institution INT NOT NULL,
	disability BIT DEFAULT(0)
);

CREATE TABLE INSTITUTION(
	id_institution INT PRIMARY KEY IDENTITY,
	institution VARCHAR(50) NOT NULL
);

CREATE TABLE VACCINATION(
	id_vaccination INT PRIMARY KEY IDENTITY,
	date_time_wait_1 DATETIME,
	date_time_vaccine_1 DATETIME,
	date_time_wait_2 DATETIME,
	date_time_vaccine_2 DATETIME,
	id_citizen INT NOT NULL,
	id_vaccination_place INT NOT NULL
);

CREATE TABLE SIDE_EFFECT(
	id_side_effect INT PRIMARY KEY IDENTITY,
	side_effect VARCHAR(50) NOT NULL,
	side_effect_description VARCHAR(200)
);

CREATE TABLE VACCINATIONxSIDE_EFFECT(
	id_side_effect INT NOT NULL,
	id_vaccination INT NOT NULL,
	minutes_showup INT
);

CREATE TABLE CHRONIC_DISEASE(
	id_chronic_disease INT PRIMARY KEY IDENTITY,
	chronic_disease VARCHAR(50) NOT NULL,
	chronic_disease_description VARCHAR(200)
);

CREATE TABLE CITIZENxCHRONIC_DISEASE(
	id_chronic_disease INT NOT NULL,
	id_citizen INT NOT NULL
);

-- PK/FK section
-- PK DEFINITION
ALTER TABLE VACCINATIONxSIDE_EFFECT ADD PRIMARY KEY (id_side_effect, id_vaccination);
ALTER TABLE CITIZENxCHRONIC_DISEASE ADD PRIMARY KEY (id_chronic_disease, id_citizen);

-- FK Definition
ALTER TABLE EMPLOYEE ADD FOREIGN KEY (id_type) REFERENCES EMPLOYEE_TYPE (id_type);
ALTER TABLE EMPLOYEE ADD FOREIGN KEY (id_booth) REFERENCES BOOTH (id_booth);
ALTER TABLE MANAGEMENT ADD FOREIGN KEY (id_booth) REFERENCES BOOTH (id_booth);
ALTER TABLE MANAGEMENT ADD FOREIGN KEY (id_employee) REFERENCES EMPLOYEE (id_employee);
ALTER TABLE APPOINTMENT ADD FOREIGN KEY (id_employee) REFERENCES EMPLOYEE (id_employee);
ALTER TABLE APPOINTMENT ADD FOREIGN KEY (id_vaccination_place) REFERENCES VACCINATION_PLACE (id_vaccination_place);
ALTER TABLE APPOINTMENT ADD FOREIGN KEY (id_citizen) REFERENCES CITIZEN (id_citizen);
ALTER TABLE CITIZEN ADD FOREIGN KEY (id_institution) REFERENCES INSTITUTION (id_institution);
ALTER TABLE VACCINATION ADD FOREIGN KEY (id_citizen) REFERENCES CITIZEN (id_citizen);
ALTER TABLE VACCINATION ADD FOREIGN KEY (id_vaccination_place) REFERENCES VACCINATION_PLACE (id_vaccination_place);
ALTER TABLE CITIZENxCHRONIC_DISEASE ADD FOREIGN KEY (id_citizen) REFERENCES CITIZEN (id_citizen);
ALTER TABLE CITIZENxCHRONIC_DISEASE ADD FOREIGN KEY (id_chronic_disease) REFERENCES CHRONIC_DISEASE (id_chronic_disease);
ALTER TABLE VACCINATIONxSIDE_EFFECT ADD FOREIGN KEY (id_side_effect) REFERENCES SIDE_EFFECT (id_side_effect);
ALTER TABLE VACCINATIONxSIDE_EFFECT ADD FOREIGN KEY (id_vaccination) REFERENCES VACCINATION (id_vaccination);

-- Seeding Data in Chronic Disease
INSERT INTO CHRONIC_DISEASE VALUES ('Problemas Pulmonares', 'Tales como EPOC, Cancer de Pulmon, Fibrosis Quistica, Fibrosis Pulmonar, Asma');
INSERT INTO CHRONIC_DISEASE VALUES ('Enfermedad Cardiaca', 'Tales como Miocardiopatia, Hipertension Pulmonar, Enfermedad Cardiaca Congenita, Insuficiencia Cardiac, Enfermedad de las Arterias Coronoarias');
INSERT INTO CHRONIC_DISEASE VALUES ('Diabetes', 'Enfermedad en la que los niveles de glucosa (azúcar) de la sangre están muy altos');
INSERT INTO CHRONIC_DISEASE VALUES ('Obesidad', 'Estado patológico que se caracteriza por un exceso o una acumulación excesiva y general de grasa en el cuerpo');
INSERT INTO CHRONIC_DISEASE VALUES ('Sistema Inmunitario Debilitado', 'Trasplante de Organos, Tratamientos Oncologicos, Transplante de Medula Osea, VIH/SIDA');
INSERT INTO CHRONIC_DISEASE VALUES ('Enfermedad Renal o Hepatica', 'Insuficiencia Hepatica Aguda, Hepatitis Alcoholica, Cirrosis, Liquido Abdominal Infectado');

-- Seeding Data in Side Effects
INSERT INTO SIDE_EFFECT VALUES ('Enrojecimiento', 'Enrojecimiento en la zona donde fue aplicada la vacuna');
INSERT INTO SIDE_EFFECT VALUES ('Fatiga', 'Falta de energia y motivacion');
INSERT INTO SIDE_EFFECT VALUES ('Dolor de Cabeza', 'Dolor o molestia en la cabeza, el cuero cabelludo o el cuello');
INSERT INTO SIDE_EFFECT VALUES ('Fiebre', 'Temperatura del cuerpo mas elevada de lo normal');
INSERT INTO SIDE_EFFECT VALUES ('Mialgia', 'Tambien llamados dolores musculares, consisten en dolores o molestias que puede afecta a uno o varios musculos del cuerpo');
INSERT INTO SIDE_EFFECT VALUES ('Artralgia', 'Presencia de dolor en una zona articular, suele ir acompañado de inflamacion, rigidez articular, enrojecimiento de la piel');
INSERT INTO SIDE_EFFECT VALUES ('Anafilaxia', 'Reaccion alergica grave que puede poner en riesgo la vida');

-- Seeding Data in Employee Type
INSERT INTO EMPLOYEE_TYPE VALUES ('Gestor');
INSERT INTO EMPLOYEE_TYPE VALUES ('Vacunador');
INSERT INTO EMPLOYEE_TYPE VALUES ('Asistente de Salud');
INSERT INTO EMPLOYEE_TYPE VALUES ('Supervisor');

-- Seeding Data in Institution
INSERT INTO INSTITUTION VALUES ('Ninguna');
INSERT INTO INSTITUTION VALUES ('Educacion');
INSERT INTO INSTITUTION VALUES ('Salud');
INSERT INTO INSTITUTION VALUES ('Policia');
INSERT INTO INSTITUTION VALUES ('Fuerza Armada');
INSERT INTO INSTITUTION VALUES ('Gobierno');
INSERT INTO INSTITUTION VALUES ('Periodismo');

-- Seeding Data in Booth
INSERT INTO BOOTH VALUES ('(Galerias) Paseo Gral. Escalón 3700, San Salvador', 22505300, 'galerias@gmail.com');
INSERT INTO BOOTH VALUES ('(Santa Rosa) Calle Real, Santa Tecla', 22293757, 'santarosa@gmail.com');
INSERT INTO BOOTH VALUES ('(UCA) Bulevar Los Proceres', 22106600, 'uca@gmail.com');
INSERT INTO BOOTH VALUES ('(Metrocentro) Calle Los Sisimiles, San Salvador', 25045555, 'metrocentro@gmail.com');
INSERT INTO BOOTH VALUES ('(Las Cascadas) Avenida Jerusalén y Carretera Panamericana', 25015400, 'cascadas@gmail.com');

-- Seeding Data in Vaccination Place
INSERT INTO VACCINATION_PLACE VALUES ('UCA', 'Bulevar Los Proceres');
INSERT INTO VACCINATION_PLACE VALUES ('Megacentro', 'Salon Centro Americano, Avenida De La Revolucion 222, San Salvador');
INSERT INTO VACCINATION_PLACE VALUES ('La Gran Via', 'Carretera Panamericana y Calle Chiltiupan Antiguo Cuscatlán, La Libertad Centroamérica, Cd Merliot');
INSERT INTO VACCINATION_PLACE VALUES ('Policlinica MQ Santa Ana', '5ª Av Norte, entre 4ª y, 6a Calle Oriente # 9, Santa Ana');
INSERT INTO VACCINATION_PLACE VALUES ('Hospital Nacional de La Union', 'Carretera Panamericana Km 180, Cantón Huisquil, Conchagua');

INSERT INTO EMPLOYEE VALUES ('Bruce Wayne', 'imnotbatman@salud.gob.sv', 'Gotham City', 'Batman', 'Joker', 1, 1);
INSERT INTO EMPLOYEE (employee_name, email, employee_address, id_type) VALUES ('Clark Kent', 'imnotsuperman@salud.gob.sv', 'Metropolis', 2);
INSERT INTO EMPLOYEE (employee_name, email, employee_address, id_type) VALUES ('Tony Stark', 'imnotironman@salud.gob.sv', 'New York City', 3);
INSERT INTO EMPLOYEE VALUES ('James Logan', 'imnotwolverine@salud.gob.sv', 'Canada', 'Wolverine', 'Lobezno', 1, 3);
INSERT INTO EMPLOYEE VALUES ('Wade Winston', 'imnotdeadpool@salud.gob.sv', 'New York City', 'Deadpool', 'Chimichanga', 1, 2);
INSERT INTO EMPLOYEE (employee_name, email, employee_address, id_type, id_booth) VALUES ('Lee Sang-Hyeok', 'imnotfaker@salud.gob.sv', 'South Korea', 4,3);