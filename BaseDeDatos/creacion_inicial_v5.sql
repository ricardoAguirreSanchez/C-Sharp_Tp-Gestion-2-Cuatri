/*
-------------------------------------------------------------------------------
SECCIONES
-------------------------------------------------------------------------------
SECCION_0 : HISTORIAL DE CAMBIOS
SECCION_1 : CREACION DEL ESQUEMA
SECCION_2 : ELIMINACIÓN DE TABLAS
SECCION_3 : CREACIÓN DE LAS TABLAS & DEFINICIÓN DE CONSTRAINTS
SECCION_4 : DEFINICION DE ROLES Y USUARIOS
SECCION_5 : MIGRACION DE DATOS DE TABLA MAESTRA
SECCION_6 : CREACIÓN DE VIEWS
SECCION_7 : CREACIÓN DE FUNCTIONS, PROCEDURES, TRIGGERS
SECCION_8 : ACTIVACIÓN DE CONSTRAINTS POST-MIGRACIÓN

-------------------------------------------------------------------------------
*/

/* ****************************************************************************
* SECCION_0 : HISTORIAL DE CAMBIOS
**************************************************************************** */

/*

FECHA			DESCRIPCIÓN DEL CAMBIO
-------------------------------------------------------------------------------
09/SEP/2016		Creación del archivo (v1).
09/SEP/2016		Conformación de las secciones del archivo.
17/SEP/2016		Definicion nombre del esquema a usar y se comienza con la definición de tablas.
20/SEP/2016		Se agrega comentario sobre constraint en tabla 'SOLARIS.Paciente'.
20/SEP/2016		Cambio en orden de secciones. 'MIGRACION DE DATOS DE TABLA MAESTRA' pasa de sección 8 a 6.
21/SEP/2016		Se eliminan secciones de PK & FK. Estas definiciones se incorporan a la sección de definicion de tablas para mayor claridad.
21/SEP/2016		Se agrega la seccion de 'Eliminacion de tablas' para eliminar las tablas en correcto orden antes de la creación.
21/SEP/2016		Se definen PKs.
21/SEP/2016		(v2).
21/SEP/2016		Se definen FKs.
21/SEP/2016		Correccion tipo dato 'pac_plan_medico' en tabla 'Paciente'.
24/SEP/2016		Correcciones en numeracion de secciones.
24/SEP/2016		Se agrega la carga manual de tabla 'Estado_Turno' en sección 4.
24/SEP/2016		Correcciones en Sección 1. Se agregó el paréntesis del IF.
24/SEP/2016		Se cambia tabla para verificar schema en seccion 1. ANTES: 'sys.schemas'. AHORA: 'INFORMATION_SCHEMA.SCHEMATA'.
24/SEP/2016		Se modificó el orden del la eliminación de tablas para corregir errores al eliminar tablas.
24/SEP/2016		Se comienza con la sección 5 (Migración). [Plan_Medico, Tipo_Especialidades, Especialidades, Medico, Medico_x_Especialidad].
xx/SEP/2016		Se corrige el nombre del schema [DE: Solaris A: SOLARIS].
xx/SEP/2016		Se corrige el campo para el password en la tabla Usuario.
xx/SEP/2016		(v3).
01/OCT/2016		Se agrega tabla 'Hist_Plan_Afiliado'.
01/OCT/2016		Se agrega campo 'esta_activo' en tablas: Paciente & Rol & Medico.
01/OCT/2016		Se cambia el nombre de tabla 'Bono' a 'Bono_Consulta'.
01/OCT/2016		Se cambia el campo bon_estado (tinyint) a bon_fue_utilizado (bit) en 'Bono_Consulta'.
01/OCT/2016		Se elimina la tabla 'Dia' y las referencias a ella en otras tablas.
01/OCT/2016		Se agregan constraints CK para verificar el dia de la semana en tablas 'Horario' & 'Agenda'.
01/OCT/2016		Se agrega la tabla 'Relación' y se cargan sus datos manualmente en sección 4.
01/OCT/2016		Se agrega el campo 'pac_codigo' en tabla 'Paciente' y se setea como PK única.
01/OCT/2016		Se modifican las referencias (FK) a tabla 'Paciente' usando la nueva PK.
01/OCT/2016		Se migran los datos a la tabla 'Paciente'.
01/OCT/2016		(v4).
05/OCT/2016		Se agrega la fecha de baja en la tabla Paciente.
05/OCT/2016		Se agrega la seccion 8, para ctivar constraints post-migración.
06/OCT/2016		Se modifica el cod del afiliado y el nro del afiliado, todo a un sólo campo.
06/OCT/2016		Como resultado de la modificación anterior, no es necesario la sección 8 y es eliminada.
06/OCT/2016		Se crea el procedimiento para la migración de Pacientes, genrando un nro de afiliado titular durante la migración.
07/OCT/2016		Se agrega el campo 'hpa_plan_nuevo' en tabla Hist_Plan_Afiliado.
07/OCT/2016		En 'Estado_Turno' se agraga el estado = 4 & se modifica el tamaño del campo descripcion del estado.
09/OCT/2016		Se agregan los primeros procedimientos en el apartado 7, los mismos son usados en la app.
06/NOV/2016		Se agrega usuario: admin y se agrega como ID de medico y paciente : nombre+dni (idem para contraseña)
*/


--Indico DB a utilizar
USE GD2C2016;


/* ****************************************************************************
* SECCION_1 : CREACION DEL ESQUEMA
**************************************************************************** */

--Si no existe el esquema, entonces, lo creo
IF (NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'SOLARIS'))
	BEGIN
		PRINT 'Creando schema ...';
		EXEC ('CREATE SCHEMA SOLARIS AUTHORIZATION gd');
	END;



/* ****************************************************************************
* SECCION_2 : ELIMINACIÓN DE TABLAS
**************************************************************************** */

PRINT 'Eliminando tablas ...';

-- Tabla "Roles x Usuario"
IF OBJECT_ID('SOLARIS.Rol_x_Usuario') IS NOT NULL
	DROP TABLE SOLARIS.Rol_x_Usuario;

-- Tabla "Funcionalidades x Rol"
IF OBJECT_ID('SOLARIS.Funcionalidad_x_Rol') IS NOT NULL
	DROP TABLE SOLARIS.Funcionalidad_x_Rol;

-- Tabla "Rol"
IF OBJECT_ID('SOLARIS.Rol') IS NOT NULL
	DROP TABLE SOLARIS.Rol;

-- Tabla "Funcionalidades"
IF OBJECT_ID('SOLARIS.Funcionalidad') IS NOT NULL
	DROP TABLE SOLARIS.Funcionalidad;

-- Tabla "Especialidad x Medico"
-- Precede a: "Medico", "Especialidad"
IF OBJECT_ID('SOLARIS.Especialidad_x_Medico') IS NOT NULL
	DROP TABLE SOLARIS.Especialidad_x_Medico;

-- Tabla "Item_Factura"
IF OBJECT_ID('SOLARIS.Item_Factura') IS NOT NULL
	DROP TABLE SOLARIS.Item_Factura;

-- Tabla "Factura"
IF OBJECT_ID('SOLARIS.Factura') IS NOT NULL
	DROP TABLE SOLARIS.Factura;
	
-- Tabla "Bono"
-- Precede a: "Paciente"
IF OBJECT_ID('SOLARIS.Bono') IS NOT NULL
	DROP TABLE SOLARIS.Bono;

-- Tabla "Tipo_Bono"
IF OBJECT_ID('SOLARIS.Tipo_Bono') IS NOT NULL
	DROP TABLE SOLARIS.Tipo_Bono;

-- Tabla "Consulta_Sintoma_Diagnostico"
IF OBJECT_ID('SOLARIS.Consulta_Sintoma_Diagnostico') IS NOT NULL
	DROP TABLE SOLARIS.Consulta_Sintoma_Diagnostico;

-- Tabla "Consulta"
IF OBJECT_ID('SOLARIS.Consulta') IS NOT NULL
	DROP TABLE SOLARIS.Consulta;


-- Tabla "Turno_Cancelado"
IF OBJECT_ID('SOLARIS.Turno_Cancelado') IS NOT NULL
	DROP TABLE SOLARIS.Turno_Cancelado;

-- Tabla "Tipo Cancelacion"
IF OBJECT_ID('SOLARIS.Tipo_Cancelacion') IS NOT NULL
	DROP TABLE SOLARIS.Tipo_Cancelacion;

-- Tabla "Turno"
IF OBJECT_ID('SOLARIS.Turno') IS NOT NULL
	DROP TABLE SOLARIS.Turno;

-- Tabla "Estado Turno"
IF OBJECT_ID('SOLARIS.Estado_Turno') IS NOT NULL
	DROP TABLE SOLARIS.Estado_Turno;

-- Tabla "Agenda"
-- Precede a: "Medico", "Especialidad", "Dia"
IF OBJECT_ID('SOLARIS.Agenda') IS NOT NULL
	DROP TABLE SOLARIS.Agenda;

-- Tabla "Especialidad"
-- Precede a: "Tipo_Especialidad"
IF OBJECT_ID('SOLARIS.Especialidad') IS NOT NULL
	DROP TABLE SOLARIS.Especialidad;

-- Tabla "Tipo Especialidad"
IF OBJECT_ID('SOLARIS.Tipo_Especialidad') IS NOT NULL
	DROP TABLE SOLARIS.Tipo_Especialidad;
	

-- Tabla "Medico"
-- Precede a: "Usuario", "Tipo de Documento"
IF OBJECT_ID('SOLARIS.Medico') IS NOT NULL
	DROP TABLE SOLARIS.Medico;

-- Tabla "Horario" (Para los horarios de la clínica)
-- Precede a: "Dia"
IF OBJECT_ID('SOLARIS.Horario') IS NOT NULL
	DROP TABLE SOLARIS.Horario;
	
-- Tabla "Hist_Plan_Afiliado"
IF OBJECT_ID('SOLARIS.Hist_Plan_Afiliado') IS NOT NULL
	DROP TABLE SOLARIS.Hist_Plan_Afiliado;

-- Tabla "Paciente"
-- Precede a: "Usuario", "Plan_Medico", "Tipo de Documento", "Estado Civil".
IF OBJECT_ID('SOLARIS.Paciente') IS NOT NULL
	DROP TABLE SOLARIS.Paciente;

-- Tabla "Relacion"
IF OBJECT_ID('SOLARIS.Relacion') IS NOT NULL
	DROP TABLE SOLARIS.Relacion;

-- Tabla "Estado Civil"
IF OBJECT_ID('SOLARIS.Estado_Civil') IS NOT NULL
	DROP TABLE SOLARIS.Estado_Civil;

-- Tabla "Tipo de Documento"
IF OBJECT_ID('SOLARIS.Tipo_Documento') IS NOT NULL
	DROP TABLE SOLARIS.Tipo_Documento;

-- Tabla "Plan_Medico"
IF OBJECT_ID('SOLARIS.Plan_Medico') IS NOT NULL
	DROP TABLE SOLARIS.Plan_Medico;
	
-- Tabla "Usuario"
IF OBJECT_ID('SOLARIS.Usuario') IS NOT NULL
	DROP TABLE SOLARIS.Usuario;

-- Tabla "Estado Usuario"
IF OBJECT_ID('SOLARIS.Usuario_Estado') IS NOT NULL
	DROP TABLE SOLARIS.Usuario_Estado;


PRINT 'Tablas eliminadas ...';


/* ****************************************************************************
* SECCION_3 : CREACIÓN DE LAS TABLAS & DEFINICIÓN DE CONSTRAINTS
**************************************************************************** */

PRINT 'Creando tablas ...';



-- Tabla "Estado Usuario"
CREATE TABLE SOLARIS.Usuario_Estado (
	ues_codigo		TINYINT	NOT NULL,
	ues_descipcion	VARCHAR(11)
);

ALTER TABLE SOLARIS.Usuario_Estado ADD CONSTRAINT PK_Estado_Usuario PRIMARY KEY(ues_codigo);


-- Tabla "Usuario"
CREATE TABLE SOLARIS.Usuario (
	usu_codigo			INT IDENTITY(1,1),
	usu_usuario			VARCHAR(255)	NOT NULL,
	usu_passwd			VARBINARY(255)  	NOT NULL,
	usu_fecha_creacion	DATETIME,
	usu_estado			TINYINT,		-- [FK] Ref 'Estado Usuarios'
	usu_login_fallidos	TINYINT	
);

ALTER TABLE SOLARIS.Usuario ADD CONSTRAINT PK_Usuario PRIMARY KEY(usu_codigo);
ALTER TABLE SOLARIS.Usuario ADD CONSTRAINT FK_Usuario_01 FOREIGN KEY (usu_estado) REFERENCES SOLARIS.Usuario_Estado(ues_codigo);

ALTER TABLE SOLARIS.Usuario ADD CONSTRAINT UQ_Nombre_Usuario UNIQUE (usu_usuario);
ALTER TABLE SOLARIS.Usuario ADD CONSTRAINT DF_Login_Fallido_En_Cero DEFAULT 0 FOR usu_login_fallidos;


-- Tabla "Rol"
CREATE TABLE SOLARIS.Rol (
	rol_codigo		TINYINT	IDENTITY(1,1) NOT NULL,
	rol_nombre		VARCHAR(25) NOT NULL,
	rol_esta_activo	BIT
);

ALTER TABLE SOLARIS.Rol ADD CONSTRAINT PK_Rol PRIMARY KEY(rol_codigo);
ALTER TABLE SOLARIS.Rol ADD CONSTRAINT DF_Activo_Al_Crearse DEFAULT 1 FOR rol_esta_activo;
ALTER TABLE SOLARIS.Rol ADD CONSTRAINT CK_EstaActivo CHECK (rol_esta_activo = 0 OR rol_esta_activo = 1);


-- Tabla "Roles x Usuario"
CREATE TABLE SOLARIS.Rol_x_Usuario (
	rxu_usuario		INT	NOT NULL,
	rxu_rol			TINYINT NOT NULL
);

ALTER TABLE SOLARIS.Rol_x_Usuario ADD CONSTRAINT PK_Rol_x_Usuario PRIMARY KEY(rxu_usuario, rxu_rol);
ALTER TABLE SOLARIS.Rol_x_Usuario ADD CONSTRAINT FK_Rol_x_Usuario_01 FOREIGN KEY (rxu_usuario) REFERENCES SOLARIS.Usuario(usu_codigo);
ALTER TABLE SOLARIS.Rol_x_Usuario ADD CONSTRAINT FK_Rol_x_Usuario_02 FOREIGN KEY (rxu_rol) REFERENCES SOLARIS.Rol(rol_codigo);


-- Tabla "Funcionalidades"
CREATE TABLE SOLARIS.Funcionalidad (
	fun_codigo	TINYINT NOT NULL,
	fun_nombre	VARCHAR(22)
);

ALTER TABLE SOLARIS.Funcionalidad ADD CONSTRAINT PK_Funcionalidad PRIMARY KEY(fun_codigo);
ALTER TABLE SOLARIS.Funcionalidad ADD CONSTRAINT UQ_Nombre_Funcionalidad UNIQUE (fun_nombre);


-- Tabla "Funcionalidades x Rol"
CREATE TABLE SOLARIS.Funcionalidad_x_Rol (
	fxr_rol				TINYINT NOT NULL,
	fxr_funcionalidad	TINYINT NOT NULL
);

ALTER TABLE SOLARIS.Funcionalidad_x_Rol ADD CONSTRAINT PK_Funcionalidad_x_Rol PRIMARY KEY(fxr_rol, fxr_funcionalidad);

ALTER TABLE SOLARIS.Funcionalidad_x_Rol 
	ADD CONSTRAINT FK_Funcionalidad_x_Rol_01 FOREIGN KEY (fxr_rol) REFERENCES SOLARIS.Rol(rol_codigo);
ALTER TABLE SOLARIS.Funcionalidad_x_Rol 
	ADD CONSTRAINT FK_Funcionalidad_x_Rol_02 FOREIGN KEY (fxr_funcionalidad) REFERENCES SOLARIS.Funcionalidad(fun_codigo);


-- Tabla "Tipo de Documento"
CREATE TABLE SOLARIS.Tipo_Documento (
	tdc_codigo		TINYINT IDENTITY(1,1),
	tdc_sigla		CHAR(3),
	tdc_descripcion	VARCHAR(34)
);

ALTER TABLE SOLARIS.Tipo_Documento ADD CONSTRAINT PK_Tipo_Documento PRIMARY KEY(tdc_codigo);
ALTER TABLE SOLARIS.Tipo_Documento ADD CONSTRAINT UQ_Sigla_Documento UNIQUE (tdc_sigla);


-- Tabla "Estado Civil"
CREATE TABLE SOLARIS.Estado_Civil (
	ecv_codigo		TINYINT IDENTITY(1,1),
	ecv_descripcion	VARCHAR(13)
);

ALTER TABLE SOLARIS.Estado_Civil ADD CONSTRAINT PK_Estado_Civil PRIMARY KEY(ecv_codigo);
ALTER TABLE SOLARIS.Estado_Civil ADD CONSTRAINT UQ_Estado_Civil UNIQUE (ecv_descripcion);


-- Tabla "Plan_Medico"
CREATE TABLE SOLARIS.Plan_Medico (
	plm_codigo					NUMERIC(18,0) NOT NULL,
	plm_descripcion				VARCHAR(255),
	plm_precio_bono_consulta	NUMERIC(18,0),
	plm_precio_bono_farmacia	NUMERIC(18,0),
	plm_esta_activo				BIT
);

ALTER TABLE SOLARIS.Plan_Medico ADD CONSTRAINT PK_Plan_Medico PRIMARY KEY(plm_codigo);
ALTER TABLE SOLARIS.Plan_Medico ADD CONSTRAINT CK_Precio_Consulta_Positivo CHECK (plm_precio_bono_consulta >= 0);
ALTER TABLE SOLARIS.Plan_Medico ADD CONSTRAINT CK_Precio_Farmacia_Positivo CHECK (plm_precio_bono_farmacia >= 0);
ALTER TABLE SOLARIS.Plan_Medico ADD CONSTRAINT CK_Plan_EstaActivo CHECK (plm_esta_activo = 0 OR plm_esta_activo = 1);


-- Tabla "Relacion"
CREATE TABLE SOLARIS.Relacion (
	rel_codigo		TINYINT IDENTITY NOT NULL,
	rel_descripcion	VARCHAR(20)
);

ALTER TABLE SOLARIS.Relacion ADD CONSTRAINT PK_Relacion PRIMARY KEY(rel_codigo);


-- Tabla "Paciente"
CREATE TABLE SOLARIS.Paciente (
	pac_nro_afiliado	INT NOT NULL,
	pac_usuario			INT,		-- [FK]
	pac_apellido		VARCHAR(255),
	pac_nombre			VARCHAR(255),
	pac_tipo_doc		TINYINT,	-- [FK]
	pac_nro_doc			NUMERIC(18,0),
	pac_direccion		VARCHAR(255),
	pac_telefono		NUMERIC(18,0),
	pac_mail			VARCHAR(255),
	pac_fecha_nac		DATETIME,
	pac_sexo			CHAR(1),
	pac_estado_civil	TINYINT,	-- [FK]
	pac_cant_familiares	TINYINT,
	pac_plan_medico		NUMERIC(18,0),	-- [FK]
	--pac_titular			INT,			-- [FK]
	pac_tit_relacion	TINYINT,		-- [FK]
	pac_esta_activo		BIT,
	pac_fecha_baja		DATETIME
);


ALTER TABLE SOLARIS.Paciente ADD CONSTRAINT PK_Paciente PRIMARY KEY(pac_nro_afiliado);

ALTER TABLE SOLARIS.Paciente ADD CONSTRAINT FK_Paciente_01 FOREIGN KEY (pac_usuario) REFERENCES SOLARIS.Usuario(usu_codigo);
ALTER TABLE SOLARIS.Paciente ADD CONSTRAINT FK_Paciente_02 FOREIGN KEY (pac_tipo_doc) REFERENCES SOLARIS.Tipo_Documento(tdc_codigo);
ALTER TABLE SOLARIS.Paciente ADD CONSTRAINT FK_Paciente_03 FOREIGN KEY (pac_estado_civil) REFERENCES SOLARIS.Estado_Civil(ecv_codigo);
ALTER TABLE SOLARIS.Paciente ADD CONSTRAINT FK_Paciente_04 FOREIGN KEY (pac_plan_medico) REFERENCES SOLARIS.Plan_Medico(plm_codigo);
ALTER TABLE SOLARIS.Paciente ADD CONSTRAINT FK_Paciente_06 FOREIGN KEY (pac_tit_relacion) REFERENCES SOLARIS.Relacion(rel_codigo);

ALTER TABLE SOLARIS.Paciente ADD CONSTRAINT CK_Afiliado_EstaActivo CHECK (pac_esta_activo = 0 OR pac_esta_activo = 1);


-- Tabla "Hist_Plan_Afiliado"

CREATE TABLE SOLARIS.Hist_Plan_Afiliado (
	hpa_cod_afiliado	INT NOT NULL,				-- [FK]
	hpa_plan_anterior	NUMERIC(18,0)	NOT NULL,	-- [FK]
	hpa_plan_nuevo		NUMERIC(18,0)	NOT NULL,	-- [FK]
	hpa_fecha_cambio	DATETIME		NOT NULL,
	hpa_comentarios		VARCHAR(1022)
);

ALTER TABLE SOLARIS.Hist_Plan_Afiliado 
	ADD CONSTRAINT PK_Hist_Plan_Afiliado PRIMARY KEY(hpa_cod_afiliado, hpa_plan_anterior, hpa_plan_nuevo, hpa_fecha_cambio);

ALTER TABLE SOLARIS.Hist_Plan_Afiliado 
	ADD CONSTRAINT FK_Hist_Plan_Afiliado_01 FOREIGN KEY (hpa_cod_afiliado) REFERENCES SOLARIS.Paciente(pac_nro_afiliado);
ALTER TABLE SOLARIS.Hist_Plan_Afiliado 
	ADD CONSTRAINT FK_Hist_Plan_Afiliado_02 FOREIGN KEY (hpa_plan_anterior) REFERENCES SOLARIS.Plan_Medico(plm_codigo);
ALTER TABLE SOLARIS.Hist_Plan_Afiliado 
	ADD CONSTRAINT FK_Hist_Plan_Afiliado_03 FOREIGN KEY (hpa_plan_nuevo) REFERENCES SOLARIS.Plan_Medico(plm_codigo);



-- Tabla "Tipo Especialidad"
CREATE TABLE SOLARIS.Tipo_Especialidad (
	tes_codigo		NUMERIC(18,0)	NOT NULL,
	tes_descripcion	VARCHAR(255)
);

ALTER TABLE SOLARIS.Tipo_Especialidad ADD CONSTRAINT PK_Tipo_Especialidad PRIMARY KEY(tes_codigo);


-- Tabla "Especialidad"
CREATE TABLE SOLARIS.Especialidad (
	esp_codigo				NUMERIC(18,0)	NOT NULL,
	esp_descripcion			VARCHAR(255),
	esp_tipo_especialidad	NUMERIC(18,0)	-- [FK]
);

ALTER TABLE SOLARIS.Especialidad ADD CONSTRAINT PK_Especialidad PRIMARY KEY(esp_codigo);

ALTER TABLE SOLARIS.Especialidad 
	ADD CONSTRAINT FK_Especialidad_01 FOREIGN KEY (esp_tipo_especialidad) REFERENCES SOLARIS.Tipo_Especialidad(tes_codigo);


-- Tabla "Medico"
CREATE TABLE SOLARIS.Medico (
	med_cod_medico			INT IDENTITY(1,1),
	med_cod_usuario			INT,		-- [FK]
	med_apellido			VARCHAR(255),
	med_nombre				VARCHAR(255),
	med_tipo_doc			TINYINT,		-- [FK]
	med_nro_doc				NUMERIC(18,0),
	med_direccion			VARCHAR(255),
	med_telefono			NUMERIC(18,0),
	med_mail				VARCHAR(255),
	med_fecha_nac			DATETIME,
	med_sexo				CHAR(1),
	med_matricula			VARCHAR(22),
	med_esta_activo			BIT
);

ALTER TABLE SOLARIS.Medico ADD CONSTRAINT PK_Medico PRIMARY KEY(med_cod_medico);

ALTER TABLE SOLARIS.Medico ADD CONSTRAINT FK_Medico_01 FOREIGN KEY (med_cod_usuario) REFERENCES SOLARIS.Usuario(usu_codigo);
ALTER TABLE SOLARIS.Medico ADD CONSTRAINT FK_Medico_02 FOREIGN KEY (med_tipo_doc) REFERENCES SOLARIS.Tipo_Documento(tdc_codigo);

ALTER TABLE SOLARIS.Medico ADD CONSTRAINT CK_Medico_EstaActivo CHECK (med_esta_activo = 0 OR med_esta_activo = 1);


-- Tabla "Especialidad x Medico"
CREATE TABLE SOLARIS.Especialidad_x_Medico (
	exm_cod_medico			INT				NOT NULL,
	exm_cod_especialidad	NUMERIC(18,0)	NOT NULL
);

ALTER TABLE SOLARIS.Especialidad_x_Medico ADD CONSTRAINT PK_Especialidad_x_Medico PRIMARY KEY(exm_cod_medico, exm_cod_especialidad);

ALTER TABLE SOLARIS.Especialidad_x_Medico 
	ADD CONSTRAINT FK_Especialidad_x_Medico_01 FOREIGN KEY (exm_cod_medico) REFERENCES SOLARIS.Medico(med_cod_medico);
ALTER TABLE SOLARIS.Especialidad_x_Medico 
	ADD CONSTRAINT FK_Especialidad_x_Medico_02 FOREIGN KEY (exm_cod_especialidad) REFERENCES SOLARIS.Especialidad(esp_codigo);
	

-- Tabla "Dia"
/*CREATE TABLE SOLARIS.Dia (
	dia_numero		INT		NOT NULL,	
	dia_nombre		CHAR(9)
);

ALTER TABLE SOLARIS.Dia ADD CONSTRAINT PK_Dia PRIMARY KEY(dia_numero);
*/

-- Tabla "Agenda"
CREATE TABLE SOLARIS.Agenda (
	age_cod_entrada			INT IDENTITY(1,1) primary key,
	age_cod_medico			INT,			-- [FK]
	age_med_especialidad	NUMERIC(18,0),	-- [FK]
	age_fecha_desde			datetime,
	age_fecha_hasta			datetime
);

--ALTER TABLE SOLARIS.Agenda ADD CONSTRAINT PK_Agenda PRIMARY KEY(age_cod_entrada);

ALTER TABLE SOLARIS.Agenda ADD CONSTRAINT FK_Agenda_00 FOREIGN KEY (age_cod_medico) REFERENCES SOLARIS.Medico(med_cod_medico);
ALTER TABLE SOLARIS.Agenda ADD CONSTRAINT FK_Agenda_01 FOREIGN KEY (age_med_especialidad) REFERENCES SOLARIS.Especialidad(esp_codigo);
--ALTER TABLE SOLARIS.Agenda ADD CONSTRAINT FK_Agenda_03 FOREIGN KEY (age_dia) REFERENCES SOLARIS.Dia(dia_numero);




-- Tabla "Horario" (Para los horarios de la clínica)
CREATE TABLE SOLARIS.Horario (
	hor_codigo		INT IDENTITY(1,1),
	hor_dia			INT,
	hor_hora_desde	TIME,
	hor_hora_hasta	TIME
);

ALTER TABLE SOLARIS.Horario ADD CONSTRAINT PK_Horario PRIMARY KEY(hor_codigo);

--ALTER TABLE SOLARIS.Horario ADD CONSTRAINT FK_Horario_01 FOREIGN KEY (hor_dia) REFERENCES SOLARIS.Dia(dia_numero);

ALTER TABLE SOLARIS.Horario ADD CONSTRAINT CK_hor_dia CHECK (hor_dia >= 1 AND hor_dia <= 7);


-- Tabla "Estado Turno"
CREATE TABLE SOLARIS.Estado_Turno (
	etu_codigo	TINYINT NOT NULL,
	etu_nombre	VARCHAR(37)
);

ALTER TABLE SOLARIS.Estado_Turno ADD CONSTRAINT PK_Estado_Turno PRIMARY KEY(etu_codigo);


/*
	0 = RESERVADO
	1 = FINALIZADO PARCIALMENTE (esto ocurre cuando se registra la llegada y el medico aun no aseguro q se realizo la consulta correctamente)
	2 = FINALIZADO (esto ocurre cuando el medico sube su resultado de la atencion e informa que la consulta ya se realizo correctamente)
	3 = CANCELADO POR PACIENTE
	4 = CANCELADO POR MEDICO
	5 = CANCELADO POR BAJA DEL AFILIADO
*/

-- Tabla "Turno"
CREATE TABLE SOLARIS.Turno (
	tur_numero			INT NOT NULL,
	tur_agenda_cod		INT,		-- [FK]
	tur_afiliado		INT,		-- [FK]
	--tur_medico			INT,		-- [FK]
	tur_fecha_solicitud	datetime,
	tur_fecha_turno		datetime,
	tur_estado			TINYINT		-- [FK]
);

ALTER TABLE SOLARIS.Turno ADD CONSTRAINT PK_Turno PRIMARY KEY(tur_numero);

ALTER TABLE SOLARIS.Turno 
	ADD CONSTRAINT FK_Turno_01 FOREIGN KEY (tur_afiliado) REFERENCES SOLARIS.Paciente(pac_nro_afiliado);

--ALTER TABLE SOLARIS.Turno ADD CONSTRAINT FK_Turno_02 FOREIGN KEY (tur_medico) REFERENCES SOLARIS.Medico(med_cod_medico);
ALTER TABLE SOLARIS.Turno ADD CONSTRAINT FK_Turno_03 FOREIGN KEY (tur_estado) REFERENCES SOLARIS.Estado_Turno(etu_codigo);
ALTER TABLE SOLARIS.Turno ADD CONSTRAINT FK_Turno_04 FOREIGN KEY (tur_agenda_cod) REFERENCES SOLARIS.Agenda(age_cod_entrada);

ALTER TABLE SOLARIS.Turno ADD CONSTRAINT CK_Nro_Turno CHECK (tur_numero > 0);


-- Tabla "Tipo Cancelacion"
CREATE TABLE SOLARIS.Tipo_Cancelacion (
	tca_codigo	TINYINT NOT NULL,
	tca_nombre	VARCHAR(37)
);

ALTER TABLE SOLARIS.Tipo_Cancelacion ADD CONSTRAINT PK_Tipo_Cancelacion PRIMARY KEY(tca_codigo);


-- Tabla "Turno_Cancelado"

CREATE TABLE SOLARIS.Turno_Cancelado (
	tcl_turno			INT NOT NULL,
	tcl_tipo_cancel		TINYINT,
	tcl_motivo_cancel	VARCHAR(255)	-- se carga el motivo en este campo.
);

ALTER TABLE SOLARIS.Turno_Cancelado ADD CONSTRAINT PK_Turno_Cancelado PRIMARY KEY(tcl_turno);

ALTER TABLE SOLARIS.Turno_Cancelado
	ADD CONSTRAINT FK_Turno_Cancelado_01 FOREIGN KEY (tcl_turno) REFERENCES SOLARIS.Turno(tur_numero);
ALTER TABLE SOLARIS.Turno_Cancelado 
	ADD CONSTRAINT FK_Turno_Cancelado_02 FOREIGN KEY (tcl_tipo_cancel) REFERENCES SOLARIS.Tipo_Cancelacion(tca_codigo);


-- Tabla "Consulta"
CREATE TABLE SOLARIS.Consulta (
	--esto lo completa el administrativo
	con_numero				INT IDENTITY(1,1),
	con_fecha				datetime,
	con_turno				INT,			-- [FK]
	--con_afiliado			INT,			-- [FK] [ELIMINADA POR PEDIDO EN CORRECCION DER]
	--con_cod_medico		INT,			-- [FK]
	con_hora_llegada		datetime,
	--esto lo completa el medico
	con_hora_medico			datetime
);

ALTER TABLE SOLARIS.Consulta ADD CONSTRAINT PK_Consulta PRIMARY KEY(con_numero);

ALTER TABLE SOLARIS.Consulta 
	ADD CONSTRAINT FK_Consulta_01 FOREIGN KEY (con_turno) REFERENCES SOLARIS.Turno(tur_numero);

/*ALTER TABLE SOLARIS.Consulta 
	ADD CONSTRAINT FK_Consulta_02 FOREIGN KEY (con_afiliado) REFERENCES SOLARIS.Paciente(pac_nro_afiliado);*/
/*ALTER TABLE SOLARIS.Consulta 
	ADD CONSTRAINT FK_Consulta_03 FOREIGN KEY (con_bono_relacionado) REFERENCES SOLARIS.Bono_Consulta(bon_numero);*/
/*ALTER TABLE SOLARIS.Consulta 
	ADD CONSTRAINT FK_Consulta_04 FOREIGN KEY (con_cod_medico) REFERENCES SOLARIS.Medico(med_cod_medico);*/


-- Tabla "Consulta_Sintoma_Diagnostico"
CREATE TABLE SOLARIS.Consulta_Sintoma_Diagnostico (
	csd_consulta			INT NOT NULL,
	csd_item				INT IDENTITY(1,1) NOT NULL,
	csd_sintoma				VARCHAR(255),
	csd_diagnostico			VARCHAR(255)
);

ALTER TABLE SOLARIS.Consulta_Sintoma_Diagnostico ADD CONSTRAINT PK_CSD PRIMARY KEY(csd_consulta, csd_item);

ALTER TABLE SOLARIS.Consulta_Sintoma_Diagnostico 
	ADD CONSTRAINT FK_CSD_01 FOREIGN KEY (csd_consulta) REFERENCES SOLARIS.Consulta(con_numero);

-- Tabla "Tipo_Bono"

CREATE TABLE SOLARIS.Tipo_Bono (
	tbn_tipo_bono	CHAR NOT NULL,
	tbn_descripcion	VARCHAR(29)
);

ALTER TABLE SOLARIS.Tipo_Bono ADD CONSTRAINT PK_Tipo_Bono PRIMARY KEY(tbn_tipo_bono);


-- Tabla "Bono"
CREATE TABLE SOLARIS.Bono (
	bon_numero				INT NOT NULL,
	--bon_precio				NUMERIC(18,0),	... Pasa a la factura
	bon_fecha_compra		datetime,
	bon_fecha_impresion		datetime,
	bon_afiliado_compra		INT,				-- [FK]
	bon_plan_afiliado		NUMERIC(18,0),		-- [FK]
	bon_nro_consulta_med	INT,				-- [FK]
	bon_fue_utilizado		BIT,
	bon_afiliado_uso		INT,					-- [FK]
	bon_tipo_bono			CHAR					-- [FK]
);


ALTER TABLE SOLARIS.Bono ADD CONSTRAINT PK_Bono PRIMARY KEY(bon_numero);

ALTER TABLE SOLARIS.Bono 
	ADD CONSTRAINT FK_Bono_01 FOREIGN KEY (bon_plan_afiliado) REFERENCES SOLARIS.Plan_Medico(plm_codigo);
ALTER TABLE SOLARIS.Bono 
	ADD CONSTRAINT FK_Bono_02 FOREIGN KEY (bon_afiliado_compra) REFERENCES SOLARIS.Paciente(pac_nro_afiliado);
ALTER TABLE SOLARIS.Bono 
	ADD CONSTRAINT FK_Bono_03 FOREIGN KEY (bon_nro_consulta_med) REFERENCES SOLARIS.Consulta(con_numero);
ALTER TABLE SOLARIS.Bono 
	ADD CONSTRAINT FK_Bono_04 FOREIGN KEY (bon_afiliado_uso) REFERENCES SOLARIS.Paciente(pac_nro_afiliado);
ALTER TABLE SOLARIS.Bono 
	ADD CONSTRAINT FK_Bono_05 FOREIGN KEY (bon_tipo_bono) REFERENCES SOLARIS.Tipo_Bono(tbn_tipo_bono);

ALTER TABLE SOLARIS.Bono ADD CONSTRAINT DF_Bono_Nuevo_Sin_Usar DEFAULT 0 FOR bon_fue_utilizado;
ALTER TABLE SOLARIS.Bono ADD CONSTRAINT CK_bon_fue_utilizado CHECK (bon_fue_utilizado = 0 OR bon_fue_utilizado = 1);



-- Tabla "Factura"

CREATE TABLE SOLARIS.Factura (
	fac_numero				INT IDENTITY(1,1) NOT NULL,
	fac_nro_afiliado		INT,			-- [FK]
	fac_fecha				DATETIME,
	fac_total				NUMERIC(18,0)
);

ALTER TABLE SOLARIS.Factura ADD CONSTRAINT PK_Factura PRIMARY KEY(fac_numero);

ALTER TABLE SOLARIS.Factura 
	ADD CONSTRAINT FK_Factura_01 FOREIGN KEY (fac_nro_afiliado) REFERENCES SOLARIS.Paciente(pac_nro_afiliado);


-- Tabla "Item_Factura"

CREATE TABLE SOLARIS.Item_Factura (
	itf_numero				INT NOT NULL,
	itf_nro_bono			INT NOT NULL,	-- [FK]
	itf_precio				NUMERIC(18,0)
);

ALTER TABLE SOLARIS.Item_Factura ADD CONSTRAINT PK_ItemFactura PRIMARY KEY(itf_numero, itf_nro_bono);

ALTER TABLE SOLARIS.Item_Factura 
	ADD CONSTRAINT FK_Item_Factura_01 FOREIGN KEY (itf_nro_bono) REFERENCES SOLARIS.Bono(bon_numero);

ALTER TABLE SOLARIS.Item_Factura 
	ADD CONSTRAINT FK_Item_Factura_02 FOREIGN KEY (itf_numero) REFERENCES SOLARIS.Factura(fac_numero);


PRINT 'Tablas creadas ...';


/* ****************************************************************************
* SECCION_4 : DEFINICION DE ROLES Y USUARIOS
**************************************************************************** */


-- Tabla "Usuario_Estado"

INSERT INTO SOLARIS.Usuario_Estado 
		(ues_codigo, ues_descipcion)
	VALUES 
		(0,'HABILITADO'),
		(1,'BLOQUEADO'),
		(2,'ELIMINADO');


-- Tabla "Rol"

INSERT INTO SOLARIS.Rol
		(rol_nombre)
	VALUES 
		('ADMIN'),
		('PACIENTE'),
		('MEDICO');
-- Tabla "Funcionalidades"
INSERT INTO SOLARIS.Funcionalidad
		(fun_codigo,fun_nombre)
	VALUES 
		(1,'Administrar Roles'),
		(2,'Administrar Afiliados'),
		(3,'Consultar Estadisticas'),
		(4,'Registrar Llegada'),
		(5,'Comprar Bonos'),
		(6,'Pedir Turno'),
		(7,'Registrar Resultados'),
		(8,'Cancelar Atencion'),
		(9,'Registrar Agenda');

-- Tabla "Roles x Funcionalidades"
INSERT INTO SOLARIS.Funcionalidad_x_Rol
		(fxr_rol, fxr_funcionalidad)
	VALUES
		((SELECT rol_codigo FROM  SOLARIS.Rol  WHERE rol_nombre = 'ADMIN'), (SELECT fun_codigo FROM SOLARIS.Funcionalidad WHERE fun_nombre = 'Administrar Roles')),
		((SELECT rol_codigo FROM  SOLARIS.Rol  WHERE rol_nombre = 'ADMIN'), (SELECT fun_codigo FROM SOLARIS.Funcionalidad WHERE fun_nombre = 'Administrar Afiliados')),
		((SELECT rol_codigo FROM  SOLARIS.Rol  WHERE rol_nombre = 'ADMIN'), (SELECT fun_codigo FROM SOLARIS.Funcionalidad WHERE fun_nombre = 'Consultar Estadisticas')),
		((SELECT rol_codigo FROM  SOLARIS.Rol  WHERE rol_nombre = 'ADMIN'), (SELECT fun_codigo FROM SOLARIS.Funcionalidad WHERE fun_nombre = 'Registrar Llegada')),
		((SELECT rol_codigo FROM  SOLARIS.Rol  WHERE rol_nombre = 'ADMIN'), (SELECT fun_codigo FROM SOLARIS.Funcionalidad WHERE fun_nombre = 'Comprar Bonos')),
		((SELECT rol_codigo FROM  SOLARIS.Rol  WHERE rol_nombre = 'ADMIN'), (SELECT fun_codigo FROM SOLARIS.Funcionalidad WHERE fun_nombre = 'Pedir Turno')),
		((SELECT rol_codigo FROM  SOLARIS.Rol  WHERE rol_nombre = 'PACIENTE'), (SELECT fun_codigo FROM SOLARIS.Funcionalidad WHERE fun_nombre = 'Comprar Bonos')),
		((SELECT rol_codigo FROM  SOLARIS.Rol  WHERE rol_nombre = 'PACIENTE'), (SELECT fun_codigo FROM SOLARIS.Funcionalidad WHERE fun_nombre = 'Pedir Turno')),
		((SELECT rol_codigo FROM  SOLARIS.Rol  WHERE rol_nombre = 'PACIENTE'), (SELECT fun_codigo FROM SOLARIS.Funcionalidad WHERE fun_nombre = 'Cancelar Atencion')),
		((SELECT rol_codigo FROM  SOLARIS.Rol  WHERE rol_nombre = 'MEDICO'), (SELECT fun_codigo FROM SOLARIS.Funcionalidad WHERE fun_nombre = 'Cancelar Atencion')),
		((SELECT rol_codigo FROM  SOLARIS.Rol  WHERE rol_nombre = 'MEDICO'), (SELECT fun_codigo FROM SOLARIS.Funcionalidad WHERE fun_nombre = 'Registrar Agenda')),
		((SELECT rol_codigo FROM  SOLARIS.Rol  WHERE rol_nombre = 'MEDICO'), (SELECT fun_codigo FROM SOLARIS.Funcionalidad WHERE fun_nombre = 'Registrar Resultados'))

	;

-- Tabla "Tipo_Documento"

INSERT INTO SOLARIS.Tipo_Documento
		(tdc_sigla, tdc_descripcion)
	VALUES
		('DNI','DOCUMENTO NACIONAL DE IDENTIDAD'),
		('LE', 'LIBRETA DE ENROLAMIENTO'),
		('LC', 'LIBRETA CIVICA');

-- Tabla "Estado_Civil"

INSERT INTO SOLARIS.Estado_Civil
		(ecv_descripcion)
	VALUES
		('SOLTERO/A'),
		('CASADO/A'),
		('VIUDO/A'),
		('CONCUBINATO'),
		('DIVORCIADO/A');


-- Tabla "Relacion"

INSERT INTO SOLARIS.Relacion
		(rel_descripcion)
	VALUES
		('CONYUGE'),
		('HIJO/A'),
		('HERMANO/A'),
		('PADRE'),
		('MADRE'),
		('ABUELO/A'),
		('OTRO')
	;


-- Tabla "Dia"
-- 1 (Sunday) to 7 (Saturday).
/*
INSERT INTO SOLARIS.Dia
		(dia_numero, dia_nombre)
	VALUES
		(1,'DOMINGO'),
		(2,'LUNES'),
		(3,'MARTES'),
		(4,'MIERCOLES'),
		(5,'JUEVES'),
		(6,'VIERNES'),
		(7,'SABADO');
*/

-- Tabla "Horario" (Para los horarios de la clínica)
-- hh:mm:ss
INSERT INTO SOLARIS.Horario
		(hor_dia, hor_hora_desde, hor_hora_hasta)
	VALUES
		(2, '07:00:00', '20:00:00'),	-- Día Lunes ...
		(3, '07:00:00', '20:00:00'),
		(4, '07:00:00', '20:00:00'),
		(5, '07:00:00', '20:00:00'),
		(6, '07:00:00', '20:00:00'),
		(7, '10:00:00', '15:00:00');	-- Día Sábado.


-- Tabla "Tipo Cancelacion"

INSERT INTO SOLARIS.Tipo_Cancelacion
		(tca_codigo, tca_nombre)
	VALUES
		(1, 'Enfermedad'),
		(2, 'Accidente'),
		(3, 'Tragedia personal');


-- Tabla "Estado_Turno"

INSERT INTO SOLARIS.Estado_Turno
		(etu_codigo, etu_nombre)
	VALUES
		(0, 'RESERVADO'),
		(1, 'FINALIZADO PARCIALMENTE'),
		(2, 'FINALIZADO'),
		(3, 'CANCELADO POR PACIENTE'),
		(4, 'CANCELADO POR MEDICO'),
		(5, 'CANCELADO POR BAJA AFILIADO');
		

-- Tabla "Tipo_Bono" 

INSERT INTO SOLARIS.Tipo_Bono
		(tbn_tipo_bono, tbn_descripcion)
	VALUES
		('C', 'Bono Consulta'),
		('F', 'Bono Farmacia')
	;

-- Tabla "Usuario" 

INSERT INTO SOLARIS.Usuario
		(usu_usuario, usu_passwd, usu_fecha_creacion, usu_estado)
	VALUES
		('ariel', HASHBYTES('SHA2_256','ariel'), NULL, 0),
		('jose', HASHBYTES('SHA2_256','jose'), NULL, 0),
		('matias', HASHBYTES('SHA2_256','matias'), NULL, 0),
		('ricardo',HASHBYTES('SHA2_256','ricardo'), NULL, 0),
		('admin', HASHBYTES('SHA2_256','w23e'), NULL, 0);


-- Tabla "Roles x Usuario"

INSERT INTO SOLARIS.Rol_x_Usuario
		(rxu_usuario, rxu_rol)
	VALUES
		((SELECT u.usu_codigo FROM SOLARIS.Usuario u WHERE u.usu_usuario = 'ariel'), (SELECT r.rol_codigo FROM SOLARIS.Rol r WHERE r.rol_nombre = 'ADMIN')),
		((SELECT u.usu_codigo FROM SOLARIS.Usuario u WHERE u.usu_usuario = 'jose'), (SELECT r.rol_codigo FROM SOLARIS.Rol r WHERE r.rol_nombre = 'ADMIN')),
		((SELECT u.usu_codigo FROM SOLARIS.Usuario u WHERE u.usu_usuario = 'matias'), (SELECT r.rol_codigo FROM SOLARIS.Rol r WHERE r.rol_nombre = 'ADMIN')),
		((SELECT u.usu_codigo FROM SOLARIS.Usuario u WHERE u.usu_usuario = 'ricardo'), (SELECT r.rol_codigo FROM SOLARIS.Rol r WHERE r.rol_nombre = 'ADMIN')),
		((SELECT u.usu_codigo FROM SOLARIS.Usuario u WHERE u.usu_usuario = 'ricardo'), (SELECT r.rol_codigo FROM SOLARIS.Rol r WHERE r.rol_nombre = 'PACIENTE')),
		((SELECT u.usu_codigo FROM SOLARIS.Usuario u WHERE u.usu_usuario = 'admin'), (SELECT r.rol_codigo FROM SOLARIS.Rol r WHERE r.rol_nombre = 'ADMIN')),
		((SELECT u.usu_codigo FROM SOLARIS.Usuario u WHERE u.usu_usuario = 'ricardo'), (SELECT r.rol_codigo FROM SOLARIS.Rol r WHERE r.rol_nombre = 'MEDICO'))
	;





/* ****************************************************************************
* SECCION_5 : 
**************************************************************************** */
GO

IF OBJECT_ID('SOLARIS.ufn_getNroUltimoAfiliado') IS NOT NULL
	DROP FUNCTION SOLARIS.ufn_getNroUltimoAfiliado;
GO
CREATE FUNCTION SOLARIS.ufn_getNroUltimoAfiliado()
	RETURNS INT
AS
BEGIN
	DECLARE @nro_afiliado INT;
	
	set @nro_afiliado = (SELECT TOP 1 pac_nro_afiliado
		FROM SOLARIS.Paciente 
		ORDER BY pac_nro_afiliado DESC);

	IF (@nro_afiliado IS NULL)
		set @nro_afiliado = 0; 
	
	RETURN @nro_afiliado;

END;



GO
IF OBJECT_ID('SOLARIS.usp_MigrarAfiliados') IS NOT NULL
	DROP PROCEDURE SOLARIS.usp_MigrarAfiliados;
GO
CREATE PROCEDURE SOLARIS.usp_MigrarAfiliados
AS
BEGIN

	SET NOCOUNT ON;

	-- Declaración de variables
	declare @nro_afiliado		INT;
	declare @cur_apellido		VARCHAR(255);
	declare @cur_nombre			VARCHAR(255);
	declare @cur_dni			NUMERIC(18,0);
	declare @cur_direccion		VARCHAR(255);
	declare @cur_telefono		NUMERIC(18,0);
	declare @cur_mail			VARCHAR(255);
	declare @cur_fecha_nac		DATETIME;
	declare @cur_plan_medico	NUMERIC(18,0);
	
	DECLARE cur_Afiliados_tmp CURSOR FOR
		select distinct Paciente_Apellido, 
						Paciente_Nombre, 
						Paciente_Dni, 
						Paciente_Direccion, 
						Paciente_Telefono, 
						Paciente_Mail, 
						Paciente_Fecha_Nac, 
						Plan_Med_Codigo			
		from gd_esquema.Maestra
		where Paciente_Dni IS NOT NULL
		;

	OPEN cur_Afiliados_tmp;
	FETCH NEXT FROM cur_Afiliados_tmp INTO @cur_apellido,
							@cur_nombre,
							@cur_dni,
							@cur_direccion,
							@cur_telefono,
							@cur_mail,
							@cur_fecha_nac,
							@cur_plan_medico;
							
	WHILE (@@FETCH_STATUS = 0)
	BEGIN	
		set @nro_afiliado = ((FLOOR(SOLARIS.ufn_getNroUltimoAfiliado()/100) + 1) * 100) + 1;

		INSERT INTO SOLARIS.Paciente
			(	
				pac_nro_afiliado,
				pac_apellido, 
				pac_nombre, 
				pac_nro_doc, 
				pac_direccion, 
				pac_telefono, 
				pac_mail, 
				pac_fecha_nac, 
				pac_plan_medico, 
				pac_cant_familiares, 
				pac_estado_civil, 
				pac_usuario, 
				--pac_titular, 
				pac_tit_relacion, 
				pac_sexo, 
				pac_tipo_doc,
				pac_esta_activo,
				pac_fecha_baja
			)
			VALUES 
			(
				@nro_afiliado,
				@cur_apellido,
				@cur_nombre,
				@cur_dni,
				@cur_direccion,
				@cur_telefono,
				@cur_mail,
				@cur_fecha_nac,
				@cur_plan_medico,
				0,		-- Cant Familiares
				NULL,	-- Estado Civil
				NULL,	-- Usuario
				NULL,	-- Relacion con el titular
				NULL,	-- Sexo
				(select t.tdc_codigo from SOLARIS.Tipo_Documento t where t.tdc_sigla = 'DNI'),	-- Se elige DNI por default para aquellos que son migrados ...
				1,		-- Se setea el Afiliado como ACTIVO.
				NULL
			);

		FETCH NEXT FROM cur_Afiliados_tmp INTO @cur_apellido,
							@cur_nombre,
							@cur_dni,
							@cur_direccion,
							@cur_telefono,
							@cur_mail,
							@cur_fecha_nac,
							@cur_plan_medico;

	END;	-- End while

	CLOSE cur_Afiliados_tmp;
	DEALLOCATE cur_Afiliados_tmp;

END;
GO



IF OBJECT_ID('SOLARIS.usp_actzBono') IS NOT NULL
	DROP PROCEDURE SOLARIS.usp_actzBono;
GO
CREATE PROCEDURE SOLARIS.usp_actzBono
AS
BEGIN
	SET NOCOUNT ON;

	-- Declaracion de variables
	DECLARE @nroAfiliado	INT;
	DECLARE @nroBono		INT;
	DECLARE @nroConsulta	INT;

	DECLARE cur_Bono_tmp CURSOR FOR
		select pac_nro_afiliado,m.Bono_Consulta_Numero, (select c.con_numero from SOLARIS.Consulta c where c.con_turno = Turno_Numero)
		from gd_esquema.Maestra m
			JOIN SOLARIS.Paciente ON Paciente_Dni = pac_nro_doc
		where Turno_Numero IS NOT NULL and Bono_Consulta_Numero IS NOT NULL;
				
	OPEN cur_Bono_tmp;
	FETCH NEXT FROM cur_Bono_tmp INTO
		@nroAfiliado,
		@nroBono,
		@nroConsulta;

	WHILE (@@FETCH_STATUS = 0)
	BEGIN	
	
		UPDATE SOLARIS.Bono
			SET	bon_fue_utilizado = 0,
				bon_afiliado_uso = @nroAfiliado,
				bon_nro_consulta_med = @nroConsulta
			WHERE bon_numero = @nroBono;

		FETCH NEXT FROM cur_Bono_tmp INTO
			@nroAfiliado,
			@nroBono,
			@nroConsulta;
	END;

	CLOSE cur_Bono_tmp;
	DEALLOCATE cur_Bono_tmp;

END;
GO



/* ****************************************************************************
* SECCION_5 : MIGRACION DE DATOS DE TABLA MAESTRA
**************************************************************************** */

-- Carga de tabla: "Plan_Medico"

INSERT INTO SOLARIS.Plan_Medico 
		(plm_codigo, plm_descripcion, plm_precio_bono_consulta, plm_precio_bono_farmacia,plm_esta_activo)
	select	Plan_Med_Codigo, 
			Plan_Med_Descripcion, 
			Plan_Med_Precio_Bono_Consulta, 
			Plan_Med_Precio_Bono_Farmacia,
			1
	from gd_esquema.Maestra
	group by Plan_Med_Codigo, Plan_Med_Descripcion, Plan_Med_Precio_Bono_Consulta, Plan_Med_Precio_Bono_Farmacia
	order by 1
	;


-- Carga de tabla: "Tipo_Especialidad"

INSERT INTO SOLARIS.Tipo_Especialidad
		(tes_codigo, tes_descripcion)
	select	Tipo_Especialidad_Codigo, 
			Tipo_Especialidad_Descripcion
	from gd_esquema.Maestra
	where Tipo_Especialidad_Codigo IS NOT NULL
	group by Tipo_Especialidad_Codigo, Tipo_Especialidad_Descripcion
	order by 1,2
	;


-- Carga de tabla: "Especialidad"

INSERT INTO SOLARIS.Especialidad
		(esp_codigo, esp_descripcion, esp_tipo_especialidad)
	select distinct Especialidad_Codigo, Especialidad_Descripcion, Tipo_Especialidad_Codigo
	from gd_esquema.Maestra
	where Especialidad_Codigo IS NOT NULL
	order by 1
	;

-- Carga de tabla: "Medico" 

INSERT INTO SOLARIS.Medico
		(med_nro_doc, med_apellido, med_nombre, med_tipo_doc, med_direccion, med_telefono, med_mail, med_fecha_nac, med_sexo, med_matricula, med_cod_usuario, med_esta_activo)
	select distinct Medico_Dni, 
			Medico_Apellido, 
			Medico_Nombre, 
			(select tdc_codigo from SOLARIS.Tipo_Documento where tdc_sigla = 'DNI'), 
			Medico_Direccion,
			Medico_Telefono,
			Medico_Mail,
			Medico_Fecha_Nac,
			NULL,
			NULL,
			NULL,
			0
	from gd_esquema.Maestra
	where Medico_Dni IS NOT NULL
	;


-- Carga de tabla: "Especialidad_x_Medico" 
	
INSERT INTO SOLARIS.Especialidad_x_Medico
		(exm_cod_medico, exm_cod_especialidad)
	select distinct (select med_cod_medico from SOLARIS.Medico where med_nro_doc = Medico_Dni), 
		Especialidad_Codigo
	from gd_esquema.Maestra
	where Medico_Dni IS NOT NULL
	order by 1,2
	;


-- Carga de los Pacientes ...
EXEC SOLARIS.usp_MigrarAfiliados;



-- Carga de tabla "Agenda"

INSERT INTO SOLARIS.Agenda 
		(age_fecha_desde, age_fecha_hasta, age_cod_medico, age_med_especialidad)	
	select distinct Turno_Fecha,
					DATEADD(minute, 30, Turno_Fecha),
					(select med_cod_medico from SOLARIS.Medico where med_nro_doc = Medico_Dni),
					Especialidad_Codigo
	from gd_esquema.Maestra 
	where Turno_Numero IS NOT NULL 
		AND Consulta_Sintomas IS NULL
	order by Turno_Fecha
	;


-- Tabla "Agenda"
--anio,dia,mes
/*INSERT INTO SOLARIS.Agenda
		(age_cod_medico, age_med_especialidad, age_fecha_desde,age_fecha_hasta)
	VALUES
		(2,10047,'2015-01-01 08:00:00.000', '2015-01-01 08:30:00.000'),
		(2,10047,'2015-01-01 08:30:00.000', '2015-01-01 09:00:00.000'),
		(2,10047,'2015-01-01 09:00:00.000', '2015-01-01 09:30:00.000'),
		(2,10047,'2015-01-01 09:30:00.000', '2015-01-01 10:00:00.000'),

		(2,10047,'2015-02-01 08:00:00.000', '2015-02-01 08:30:00.000'),
		(2,10047,'2015-02-01 08:30:00.000', '2015-02-01 09:00:00.000'),
		(2,10047,'2015-04-01 08:30:00.000', '2015-02-01 09:00:00.000'),
		(2,10047,'2015-03-01 08:30:00.000', '2015-03-01 09:00:00.000')
	;*/


-- Carga de Turnos ...

INSERT INTO SOLARIS.Turno
		(tur_numero, tur_agenda_cod, tur_afiliado, tur_fecha_solicitud, tur_estado)
select distinct		Turno_Numero,
					(
					select age_cod_entrada
					from SOLARIS.Agenda
					where age_fecha_desde = Turno_Fecha
						AND age_cod_medico = (select med_cod_medico from SOLARIS.Medico where med_nro_doc = Medico_Dni)
						AND age_med_especialidad = Especialidad_Codigo
					),
					p.pac_nro_afiliado,
					NULL,
					0
	from gd_esquema.Maestra m
		JOIN SOLARIS.Paciente p ON m.Paciente_Dni = p.pac_nro_doc
	where Turno_Numero IS NOT NULL 
		AND Consulta_Sintomas IS NULL
	;


/*INSERT INTO SOLARIS.Turno
		(tur_numero, tur_agenda_cod, tur_fecha_turno, tur_afiliado, tur_fecha_solicitud, tur_estado, tur_motivo_cancel)
	select distinct	Turno_Numero,
					NULL, 
					Turno_Fecha, 
					p.pac_nro_afiliado,
					mm.med_cod_medico,
					NULL,
					0,
					NULL
	from gd_esquema.Maestra m
		JOIN SOLARIS.Paciente p ON m.Paciente_Dni = p.pac_nro_doc
		JOIN SOLARIS.Medico mm ON m.Medico_Dni = mm.med_nro_doc
	where Turno_Numero IS NOT NULL
	;
*/

-- Carga de Bonos_Consulta ...

INSERT INTO SOLARIS.Bono
		(	bon_numero, 
			bon_fecha_compra, 
			bon_fecha_impresion, 
			bon_afiliado_compra, 
			bon_plan_afiliado, 
			bon_nro_consulta_med, 
			bon_fue_utilizado,
			bon_afiliado_uso,
			bon_tipo_bono
		)
	select distinct Bono_Consulta_Numero, 
					Compra_Bono_Fecha, 
					Bono_Consulta_Fecha_Impresion,
					p.pac_nro_afiliado,
					Plan_Med_Codigo,
					NULL,
					0,
					NULL,
					'C'
	from gd_esquema.Maestra m
		JOIN SOLARIS.Paciente p ON m.Paciente_Dni = p.pac_nro_doc
	where Bono_Consulta_Numero IS NOT NULL
		AND Compra_Bono_Fecha IS NOT NULL
	;
	


-- Carga de las Consultas ...
--EXEC SOLARIS.usp_MigrarConsultas;

--ESTE INSERT GENERA PARA 3 NUMEROS DE CONULTA DISTINTA, LA MISMA FECHA Y MISMO TURNO
--ej: select * from SOLARIS.Consulta where con_turno = 186576 and con_fecha='2015-01-01 13:30:00.000' 

INSERT INTO SOLARIS.Consulta
		(con_turno, con_fecha, con_hora_llegada, con_hora_medico)
	select distinct Turno_Numero, Turno_Fecha, Turno_Fecha, Turno_Fecha
	from gd_esquema.Maestra 
	where Turno_Numero IS NOT NULL and Bono_Consulta_Numero IS NOT NULL
	;

-- Carga de Sintomas & Diagnosticos ...
INSERT INTO SOLARIS.Consulta_Sintoma_Diagnostico
		(csd_consulta, csd_sintoma, csd_diagnostico)
	SELECT	con_numero,			  
			(select distinct Consulta_Sintomas from gd_esquema.Maestra where Consulta_Sintomas IS NOT NULL),
			(select distinct Consulta_Enfermedades from gd_esquema.Maestra where Consulta_Sintomas IS NOT NULL)
	FROM SOLARIS.Consulta;


-- Actualizar Bono (Se setean como utilizados y se vincula al paciente que lo utilizó)
EXEC SOLARIS.usp_actzBono;


-- Carga de Tabla "Factura" ...
INSERT INTO SOLARIS.Factura
		(fac_nro_afiliado, fac_fecha, fac_total)
	select b.bon_afiliado_compra, b.bon_fecha_compra, count(*) * (select pm.plm_precio_bono_consulta from SOLARIS.Paciente p JOIN SOLARIS.Plan_Medico pm ON p.pac_plan_medico = pm.plm_codigo WHERE p.pac_nro_afiliado = b.bon_afiliado_compra)
	from SOLARIS.Bono b
	group by b.bon_afiliado_compra, b.bon_fecha_compra;


-- Carga de Tabla "Item_Factura" ...
INSERT INTO SOLARIS.Item_Factura
		(itf_numero, itf_nro_bono, itf_precio)
	SELECT f.fac_numero, b.bon_numero, (select pm.plm_precio_bono_consulta from SOLARIS.Paciente p JOIN SOLARIS.Plan_Medico pm ON p.pac_plan_medico = pm.plm_codigo WHERE p.pac_nro_afiliado = b.bon_afiliado_compra)
	FROM SOLARIS.Factura f
		JOIN SOLARIS.Bono b ON f.fac_nro_afiliado = b.bon_afiliado_compra
			AND f.fac_fecha = b.bon_fecha_compra;
	
-- PARA AFILIAFO!!
-- Carga de Tabla "usuario"..
INSERT INTO SOLARIS.Usuario(usu_usuario,usu_passwd,usu_estado) SELECT  p.pac_nombre + CONVERT(varchar(125),p.pac_nro_doc), HASHBYTES('SHA2_256',(p.pac_nombre + CONVERT(varchar(125),p.pac_nro_doc))) , 0 FROM SOLARIS.Paciente p
-- Cargo campo usuario..
UPDATE SOLARIS.Paciente  set pac_usuario = (select usu_codigo from SOLARIS.Usuario  
where pac_nombre + CONVERT(varchar(125),pac_nro_doc) = usu_usuario)
-- Cargo Tabla "rol x usuario"
INSERT INTO SOLARIS.Rol_x_Usuario (rxu_usuario,rxu_rol) SELECT pac_usuario,2 FROM SOLARIS.Paciente


-- PARA MEDICO!!
INSERT INTO SOLARIS.Usuario(usu_usuario,usu_passwd,usu_estado) SELECT  m.med_nombre + CONVERT(varchar(125),m.med_nro_doc), HASHBYTES('SHA2_256',(m.med_nombre + CONVERT(varchar(125),m.med_nro_doc))) , 0 FROM SOLARIS.Medico m
-- Cargo campo usuario..
UPDATE SOLARIS.Medico  set med_cod_usuario = (select usu_codigo from SOLARIS.Usuario  
where med_nombre + CONVERT(varchar(125),med_nro_doc) = usu_usuario)
-- Cargo Tabla "rol x usuario"
INSERT INTO SOLARIS.Rol_x_Usuario (rxu_usuario,rxu_rol) SELECT med_cod_usuario,3 FROM SOLARIS.Medico

/* ****************************************************************************
* SECCION_7 : CREACIÓN DE FUNCTIONS, PROCEDURES, TRIGGERS
**************************************************************************** */
-- procedimiento de verificar logeo
GO

IF OBJECT_ID('SOLARIS.buscarUsuario') IS NOT NULL
	DROP PROCEDURE SOLARIS.buscarUsuario;
GO

GO
CREATE PROCEDURE SOLARIS.buscarUsuario
	@usu_passwd varchar(255),
	@usu_usuario varchar(255)
	as
		select usu_usuario from SOLARIS.Usuario where HASHBYTES('SHA2_256',@usu_passwd) = usu_passwd and
		usu_estado = 0 and @usu_usuario = usu_usuario
GO

--verificarLogeoInhabilitado
GO

IF OBJECT_ID('SOLARIS.verificarLogeoInhabilitado') IS NOT NULL
	DROP PROCEDURE SOLARIS.verificarLogeoInhabilitado;
GO

GO
CREATE PROCEDURE SOLARIS.verificarLogeoInhabilitado
	@usu_usuario varchar(255)
	as
		select usu_usuario from SOLARIS.Usuario where @usu_usuario = usu_usuario and
		usu_estado = 1
GO

--inhabilitoUsuario
GO

IF OBJECT_ID('SOLARIS.inhabilitoUsuario') IS NOT NULL
	DROP PROCEDURE SOLARIS.inhabilitoUsuario;
GO

GO
CREATE PROCEDURE SOLARIS.inhabilitoUsuario
	@usu_usuario varchar(255)
	as
		update  SOLARIS.Usuario set usu_estado=1 where @usu_usuario = usu_usuario
		
GO
-- procedimiento de buscar roles de un usuario especifico
GO

IF OBJECT_ID('SOLARIS.buscarRoles') IS NOT NULL
	DROP PROCEDURE SOLARIS.buscarRoles;
GO

GO
CREATE PROCEDURE SOLARIS.buscarRoles
	@usuario varchar(255)
	as
		select rol_nombre as Rol from SOLARIS.Rol_x_Usuario join SOLARIS.Rol on (rxu_rol = rol_codigo) join SOLARIS.Usuario on (rxu_usuario = usu_codigo) where usu_usuario = @usuario and rol_esta_activo=1

GO

-- procedimiento de buscar roles totales
GO

IF OBJECT_ID('SOLARIS.buscarRolesTotal') IS NOT NULL
	DROP PROCEDURE SOLARIS.buscarRolesTotal;
GO

GO
CREATE PROCEDURE SOLARIS.buscarRolesTotal
	
	as
		select rol_nombre,rol_codigo as Rol from SOLARIS.Rol;

GO
-- procedimiento de buscar roles de un codigo especifico y activo
GO

IF OBJECT_ID('SOLARIS.buscarRolesPorNombreHabilitado') IS NOT NULL
	DROP PROCEDURE SOLARIS.buscarRolesPorNombreHabilitado;
GO

GO
CREATE PROCEDURE SOLARIS.buscarRolesPorNombreHabilitado
@codigo VARCHAR(25)
	
	as
		select rol_nombre as Rol from SOLARIS.Rol where rol_nombre = @codigo and rol_esta_activo=1 ;
GO

-- procedimiento de buscar funcionalidades restantes
GO

IF OBJECT_ID('SOLARIS.funcionalidadesRestantes') IS NOT NULL
	DROP PROCEDURE SOLARIS.funcionalidadesRestantes;
GO

GO
CREATE PROCEDURE SOLARIS.funcionalidadesRestantes
@rol_codigo		int
	
	as
		select fun_nombre as Funcionalidades from SOLARIS.Funcionalidad 
		where fun_codigo not in (select fxr_funcionalidad from SOLARIS.Funcionalidad_x_Rol where fxr_rol = @rol_codigo ) ;
GO

-- procedimiento de buscar funcionalidades totales
GO

IF OBJECT_ID('SOLARIS.funcionalidadesTotales') IS NOT NULL
	DROP PROCEDURE SOLARIS.funcionalidadesTotales;
GO

GO
CREATE PROCEDURE SOLARIS.funcionalidadesTotales

	
	as
		select fun_nombre as Funcionalidades from SOLARIS.Funcionalidad  
GO







-- procedimiento de buscar funcionalidades totales por nombre de Rol
GO

IF OBJECT_ID('SOLARIS.funcionalidadesTotalesPorRol') IS NOT NULL
	DROP PROCEDURE SOLARIS.funcionalidadesTotalesPorRol;
GO

GO
CREATE PROCEDURE SOLARIS.funcionalidadesTotalesPorRol
@nomreROL VARCHAR(25)
	
	as
		select f.fun_nombre as Funcionalidades from SOLARIS.Funcionalidad f join SOLARIS.Funcionalidad_x_Rol fxr 
		on (f.fun_codigo = fxr.fxr_funcionalidad) join  SOLARIS.Rol r on (fxr.fxr_rol=r.rol_codigo) 
		where r.rol_nombre = @nomreROL
GO



-- procedimiento para insertar roles  
		
GO
IF OBJECT_ID('SOLARIS.insertaRol') IS NOT NULL
	DROP PROCEDURE SOLARIS.insertaRol;
GO

GO
CREATE PROCEDURE SOLARIS.insertaRol
@nomreROL VARCHAR(25)
	
	as
		INSERT INTO SOLARIS.Rol
		(rol_nombre,rol_esta_activo)
	VALUES 
		(@nomreROL,1)
GO
	
-- procedimiento para asociar funcionalidad a un rol  
		
GO

IF OBJECT_ID('SOLARIS.insertaFuncionalidadARol') IS NOT NULL
	DROP PROCEDURE SOLARIS.insertaFuncionalidadARol;
GO

GO
CREATE PROCEDURE SOLARIS.insertaFuncionalidadARol
@nomreROL VARCHAR(25),
@nomreFUNCIONALIDAD VARCHAR(22)	
	as
		INSERT INTO SOLARIS.Funcionalidad_x_Rol
		(fxr_rol, fxr_funcionalidad)
	VALUES
		((SELECT rol_codigo FROM  SOLARIS.Rol  WHERE rol_nombre = @nomreROL), (SELECT fun_codigo FROM SOLARIS.Funcionalidad WHERE fun_nombre = @nomreFUNCIONALIDAD));
GO
IF OBJECT_ID('[SOLARIS].[buscarPacientePorID]') IS NOT NULL
	DROP PROCEDURE  [SOLARIS].[buscarPacientePorID];
GO
GO
CREATE PROCEDURE [SOLARIS].[buscarPacientePorID]
	@ID_Paciente varchar(255)
	as
	
	 SELECT
	  p.pac_nombre 
	 ,p.pac_apellido
	 ,p.pac_fecha_nac
	 ,p.pac_nro_doc
	 ,p.pac_direccion
	 ,p.pac_telefono
	 ,p.pac_mail
	 ,p.pac_sexo
	 ,p.pac_plan_medico
	 ,p.pac_nro_doc
	FROM [SOLARIS].[Paciente] p
	
	WHERE p.pac_nro_afiliado = @ID_Paciente and p.pac_esta_activo = 1

GO


GO

IF OBJECT_ID('SOLARIS.borrarRol') IS NOT NULL
	DROP PROCEDURE SOLARIS.borrarRol;
GO

GO
CREATE PROCEDURE SOLARIS.borrarRol
@nomreROL VARCHAR(25)
	
	as
		Update SOLARIS.Rol set rol_esta_activo = 0 where rol_nombre = @nomreROL
GO

--modifica el nombre y estado de un rol especifico
GO

IF OBJECT_ID('SOLARIS.modificarNombreEstado') IS NOT NULL
	DROP PROCEDURE SOLARIS.modificarNombreEstado;
GO

GO
CREATE PROCEDURE SOLARIS.modificarNombreEstado
@rol_codigo		int,
@rol_nombre		VARCHAR(25),
@rol_esta_activo	BIT
	
	as
		Update SOLARIS.Rol set rol_esta_activo = @rol_esta_activo, rol_nombre = @rol_nombre where rol_codigo = @rol_codigo
		
GO

--borra la funcionalidad de un rol especifico
GO

IF OBJECT_ID('SOLARIS.modificarFuncionalidadActual') IS NOT NULL
	DROP PROCEDURE SOLARIS.modificarFuncionalidadActual;
GO

GO
CREATE PROCEDURE SOLARIS.modificarFuncionalidadActual
@rol_codigo		int,
@fun_nombre		VARCHAR(22)

	
	as
		delete from SOLARIS.Funcionalidad_x_Rol where fxr_rol = @rol_codigo and 
		fxr_funcionalidad = (select fun_codigo from SOLARIS.Funcionalidad where fun_nombre = @fun_nombre)

		
GO


--agrego la funcionalidad de un rol especifico
GO

IF OBJECT_ID('SOLARIS.agregoFuncionalidadActual') IS NOT NULL
	DROP PROCEDURE SOLARIS.agregoFuncionalidadActual;
GO

GO
CREATE PROCEDURE SOLARIS.agregoFuncionalidadActual
@rol_codigo		int,
@fun_nombre		VARCHAR(22)

	
	as
		
				
		begin
			declare @rol_nombre VARCHAR(22)
			set @rol_nombre= (select rol_nombre as Rol from SOLARIS.Rol where rol_codigo = @rol_codigo)
			execute SOLARIS.insertaFuncionalidadARol @rol_nombre ,  @fun_nombre	
		end

		
GO

IF OBJECT_ID('SOLARIS.especialidadesNombreCodigo') IS NOT NULL
	DROP PROCEDURE SOLARIS.especialidadesNombreCodigo;
GO

GO
CREATE PROCEDURE SOLARIS.especialidadesNombreCodigo

	as
		
				
		begin
			select  esp_codigo as Codigo, esp_descripcion as Especialidad from SOLARIS.Especialidad 
		end

		
GO


GO

IF OBJECT_ID('SOLARIS.especialidadPorCodigoMedico') IS NOT NULL
	DROP PROCEDURE SOLARIS.especialidadPorCodigoMedico;
GO

GO
CREATE PROCEDURE SOLARIS.especialidadPorCodigoMedico
@codigoMedico int
	as
		
				
		begin
			select  exm_cod_especialidad as Codigo , esp_descripcion as Especialidad 
			from SOLARIS.Especialidad_x_Medico JOIN	SOLARIS.Especialidad
			on (esp_codigo = exm_cod_especialidad)
			where exm_cod_medico = @codigoMedico 
		end

		
GO


GO

IF OBJECT_ID('SOLARIS.nombreMedicoPorCodigoEspecialidad') IS NOT NULL
	DROP PROCEDURE SOLARIS.nombreMedicoPorCodigoEspecialidad;
GO

GO
CREATE PROCEDURE SOLARIS.nombreMedicoPorCodigoEspecialidad
@esp_codigo		numeric(18,0)
	as
		
				
		begin
			select  med_cod_medico as Codigo, med_nombre as Nombre, med_apellido as Apellido 
			from SOLARIS.Medico m join SOLARIS.Especialidad_x_Medico exm on (m.med_cod_medico=exm.exm_cod_medico)  
			where exm.exm_cod_especialidad = @esp_codigo 
		end

		
GO


GO

IF OBJECT_ID('SOLARIS.datosTurnoPorCodigoMedico') IS NOT NULL
	DROP PROCEDURE SOLARIS.datosTurnoPorCodigoMedico;
GO

GO
CREATE PROCEDURE SOLARIS.datosTurnoPorCodigoMedico
@med_cod_medico		int,
@tur_fecha_turno_dia	int,
@tur_fecha_turno_mes	int,
@tur_fecha_turno_anio	int,
@esp_cod_medico		int
	as
		
				
		begin
			select tur.tur_numero as Codigo, ag.age_fecha_desde as Fecha, tur.tur_afiliado as 'Codigo afiliado'
			from SOLARIS.Turno tur join SOLARIS.Agenda ag
			on (tur.tur_agenda_cod = ag.age_cod_entrada)
			where ag.age_cod_medico = @med_cod_medico and
			@esp_cod_medico = ag.age_med_especialidad and
			@tur_fecha_turno_dia = DAY(ag.age_fecha_desde) and
			@tur_fecha_turno_mes = MONTH(ag.age_fecha_desde) and
			@tur_fecha_turno_anio = YEAR(ag.age_fecha_desde) and
			tur_estado = 0

		end

		
GO


GO

IF OBJECT_ID('SOLARIS.bonosDisponiblesPorAfiliado') IS NOT NULL
	DROP PROCEDURE SOLARIS.bonosDisponiblesPorAfiliado;
GO

GO
--devuelve los bonos disponibles para ese afiliado tomando encuenta el plan actual q tiene y q no fue usado
CREATE PROCEDURE SOLARIS.bonosDisponiblesPorAfiliado
@codigoAfiliado	int
	as
		
				
		begin
			select bon_numero as 'Codigo de Bono Disponible' 
			from SOLARIS.Bono
			where bon_afiliado_compra/ 100 = @codigoAfiliado / 100 and
			bon_plan_afiliado = (select pac_plan_medico from SOLARIS.Paciente where pac_nro_afiliado = @codigoAfiliado) and
			bon_fue_utilizado = 0 and bon_tipo_bono='C'
		end

		
GO

IF OBJECT_ID('SOLARIS.registrarConsulta') IS NOT NULL
	DROP PROCEDURE SOLARIS.registrarConsulta;
GO

GO
--insert la consulta (esto activara los triggers correspondientes)
CREATE PROCEDURE SOLARIS.registrarConsulta
@codigoTurno	int,
@codigoBono	    int,
@fechaSistema	datetime
	as
		
		
				
		begin

			declare @fechaDeConsulta datetime
			
			set @fechaDeConsulta = (select age_fecha_desde from SOLARIS.Agenda join SOLARIS.Turno
			                        on (SOLARIS.Agenda.age_cod_entrada = SOLARIS.Turno.tur_agenda_cod)
									where tur_numero = @codigoTurno)
		    
									
			insert into SOLARIS.Consulta (con_fecha,con_turno,con_hora_llegada,con_hora_medico)
			values (@fechaDeConsulta,@codigoTurno,@fechaSistema,NULL)
		end

		
GO


GO

--TRIGGER QUE CAMBIA EL ESTADO DE UN TURNO
IF OBJECT_ID('SOLARIS.cambioEstadoTurnoPorUnaConsulta') IS NOT NULL
	DROP TRIGGER SOLARIS.cambioEstadoTurnoPorUnaConsulta;
GO

GO
CREATE TRIGGER SOLARIS.cambioEstadoTurnoPorUnaConsulta
ON SOLARIS.Consulta
AFTER INSERT
	as
	 begin
		declare cursorConsulta cursor
		for select con_turno from inserted

		declare @con_turno int
		
		open cursorConsulta
		fetch next from cursorConsulta
		into @con_turno
		while @@FETCH_STATUS = 0
		 begin
			UPDATE SOLARIS.Turno set tur_estado = 1 where tur_numero = @con_turno
			fetch next from cursorConsulta
			into @con_turno

		 end
		close cursorConsulta
		deallocate cursorConsulta
	end
GO


GO

IF OBJECT_ID('SOLARIS.completarCamposEnBonoPorUnaConsulta') IS NOT NULL
	DROP PROCEDURE SOLARIS.completarCamposEnBonoPorUnaConsulta;
GO

GO
CREATE PROCEDURE SOLARIS.completarCamposEnBonoPorUnaConsulta
@codigoTurno	int,
@codigoBono	    int
	as
		
				
		begin
			declare @fechaDeConsulta datetime
			
			set @fechaDeConsulta = (select age_fecha_desde from SOLARIS.Agenda join SOLARIS.Turno
			                        on (SOLARIS.Agenda.age_cod_entrada = SOLARIS.Turno.tur_agenda_cod)
									where tur_numero = @codigoTurno)
			

			declare @bon_nro_consulta int
			set @bon_nro_consulta= (select con_numero from SOLARIS.Consulta where con_turno = @codigoTurno and con_fecha = @fechaDeConsulta)

			declare @bon_afiliado_uso int
			set @bon_afiliado_uso= (select tur_afiliado from SOLARIS.Turno where tur_numero= @codigoTurno)

			UPDATE  SOLARIS.Bono set  bon_nro_consulta_med = @bon_nro_consulta, bon_fue_utilizado = 1,
			bon_afiliado_uso = @bon_afiliado_uso where bon_numero =  @codigoBono
			
		end

		
GO


GO

IF OBJECT_ID('SOLARIS.buscarConsultasPorID') IS NOT NULL
	DROP PROCEDURE SOLARIS.buscarConsultasPorID;
GO

GO
CREATE PROCEDURE SOLARIS.buscarConsultasPorID
@med_cod_medico		int,
@dia	int,
@mes	int,
@anio	int
	as
		
				
		begin
			select con_numero as 'Codigo Consulta', tur_afiliado as 'Codigo Afiliado', con_fecha as 'Fecha del Turno'
			from SOLARIS.Consulta join SOLARIS.Turno on (con_turno = tur_numero)
			join SOLARIS.Agenda on (tur_agenda_cod = age_cod_entrada)
			where age_cod_medico = @med_cod_medico and 
			@dia = DAY(con_fecha) and
			@mes = MONTH(con_fecha) and
			@anio = YEAR(con_fecha) and
			--esto para saber q el turno de esa consulta sigue como finalizado parcialmente--
			tur_estado = 1
			

		end

		
GO


GO

--esto completa lo q faltaba en consulta
IF OBJECT_ID('SOLARIS.completarCamposEnConsultaPorRegistroResultado') IS NOT NULL
	DROP PROCEDURE SOLARIS.completarCamposEnConsultaPorRegistroResultado;
GO

GO

CREATE PROCEDURE SOLARIS.completarCamposEnConsultaPorRegistroResultado
@consulta	int,
@sintoma varchar(255),
@diagnostico varchar(255),
@fecha datetime
	as
		
				
		begin
			UPDATE SOLARIS.Consulta set con_hora_medico=@fecha
			where con_numero=@consulta

			insert into SOLARIS.Consulta_Sintoma_Diagnostico (csd_consulta,csd_sintoma,csd_diagnostico)
			values(@consulta,@sintoma,@diagnostico)
		end

		
GO



--esto cambia de estado el turno
IF OBJECT_ID('SOLARIS.cambioEstadoTurnoPorUnaConsultaFinalizada') IS NOT NULL
	DROP PROCEDURE SOLARIS.cambioEstadoTurnoPorUnaConsultaFinalizada;
GO

GO

CREATE PROCEDURE SOLARIS.cambioEstadoTurnoPorUnaConsultaFinalizada
@codigoConsulta	int
	as
		
				
		begin
			UPDATE SOLARIS.Turno set tur_estado = 2
			where tur_numero = (select con_turno from SOLARIS.Consulta WHERE con_numero = @codigoConsulta )
		end

		
GO


IF OBJECT_ID('SOLARIS.traigoIDPlan') IS NOT NULL
	DROP PROCEDURE SOLARIS.traigoIDPlan;
GO

GO

CREATE PROCEDURE SOLARIS.traigoIDPlan
@plm_descripcion varchar(255),
@plm_codigo int OUTPUT
	as
		select @plm_codigo = plm_codigo from SOLARIS.Plan_Medico where plm_descripcion = @plm_descripcion
		
GO

IF OBJECT_ID('SOLARIS.traigoDescripcionPlan') IS NOT NULL
	DROP PROCEDURE SOLARIS.traigoDescripcionPlan;
GO

GO

CREATE PROCEDURE SOLARIS.traigoDescripcionPlan
@plm_descripcion varchar(255) OUTPUT,
@plm_codigo int
	as
		select @plm_descripcion = plm_descripcion from SOLARIS.Plan_Medico where plm_codigo = @plm_codigo
		
GO

IF OBJECT_ID('SOLARIS.bajarPacientes') IS NOT NULL
	DROP PROCEDURE SOLARIS.bajarPacientes;
GO

GO

CREATE PROCEDURE SOLARIS.bajarPacientes
@plm_codigo int
	as
		update SOLARIS.Paciente set pac_esta_activo = 0 where pac_nro_afiliado = @plm_codigo
GO

GO
IF OBJECT_ID('SOLARIS.insertarUsuario') IS NOT NULL
	DROP PROCEDURE SOLARIS.insertarUsuario;
GO

GO
CREATE PROCEDURE SOLARIS.insertarUsuario
@usu_usuario VARCHAR(8)
	as
		INSERT INTO SOLARIS.Usuario (usu_usuario, usu_passwd, usu_fecha_creacion, usu_estado)
		VALUES (@usu_usuario, HASHBYTES('SHA2_256',@usu_usuario), NULL, 0)
	
GO


GO
IF OBJECT_ID('SOLARIS.insertaPaciente') IS NOT NULL
	DROP PROCEDURE SOLARIS.insertaPaciente;
GO

GO
CREATE PROCEDURE SOLARIS.insertaPaciente
@pac_apellido VARCHAR(255),
@pac_nombre VARCHAR(255),
@pac_nro_doc numeric(18,0),
@pac_direccion VARCHAR(255),
@pac_telefono numeric(18,0),
@pac_mail VARCHAR(255),
@pac_fecha_nac datetime,
@pac_sexo char(1),
@pac_plan_medico numeric(18,0)
As

BEGIN TRANSACTION
		DECLARE @pac_usuario int
		--Creo el usuario para el nuevo paciente
		EXEC SOLARIS.insertarUsuario @pac_nombre
		--Busco el ID que le toco como usuario
		SELECT @pac_usuario = max(usu_codigo) from SOLARIS.Usuario
		--Inserto paciente
		INSERT INTO SOLARIS.Paciente
		(pac_nro_afiliado,
		pac_usuario,
		pac_apellido,
		pac_nombre,
		pac_tipo_doc,
		pac_nro_doc,
		pac_direccion,
		pac_telefono,
		pac_mail,
		pac_fecha_nac,
		pac_sexo,
		pac_estado_civil,
		pac_cant_familiares,
		pac_plan_medico,
		pac_tit_relacion,
		pac_esta_activo,
		pac_fecha_baja)
	VALUES 
		((SELECT (MAX(pac_nro_afiliado) + 100) from SOLARIS.Paciente),@pac_usuario,@pac_apellido,@pac_nombre,1,@pac_nro_doc,@pac_direccion,@pac_telefono,@pac_mail,@pac_fecha_nac,@pac_sexo,NULL,0,
		@pac_plan_medico, NULL, 1, NULL)

COMMIT TRANSACTION
GO

-------------
GO
IF OBJECT_ID('SOLARIS.calcularPrecioCompraBono') IS NOT NULL
	DROP PROCEDURE SOLARIS.calcularPrecioCompraBono;
GO

GO
CREATE PROCEDURE SOLARIS.calcularPrecioCompraBono
@pac_nro_afiliado int,
@pac_precio_bono_consulta int OUTPUT
	as
	SELECT @pac_precio_bono_consulta = pl.plm_precio_bono_consulta FROM SOLARIS.Plan_Medico pl inner join SOLARIS.Paciente pa ON pl.plm_codigo = pa.pac_plan_medico 
	WHERE pa.pac_nro_afiliado = @pac_nro_afiliado
GO
-------------
-------------
GO
IF OBJECT_ID('SOLARIS.calcularPrecioCompraFarmacia') IS NOT NULL
	DROP PROCEDURE SOLARIS.calcularPrecioCompraFarmacia;
GO

GO
CREATE PROCEDURE SOLARIS.calcularPrecioCompraFarmacia
@pac_nro_afiliado int,
@pac_precio_bono_farmacia int OUTPUT
	as
	SELECT @pac_precio_bono_farmacia = pl.plm_precio_bono_farmacia FROM SOLARIS.Plan_Medico pl inner join SOLARIS.Paciente pa ON pl.plm_codigo = pa.pac_plan_medico 
	WHERE pa.pac_nro_afiliado = @pac_nro_afiliado
GO


GO
IF OBJECT_ID('SOLARIS.insertarUnBonoConsulta') IS NOT NULL
	DROP PROCEDURE SOLARIS.insertarUnBonoConsulta;
GO
GO
CREATE PROCEDURE SOLARIS.insertarUnBonoConsulta
@bon_afiliado_compra int

	as

	DECLARE @bon_precio int
	DECLARE @bon_plan_afiliado int
	DECLARE @bon_numero int
	SELECT @bon_precio = pl.plm_precio_bono_farmacia, @bon_plan_afiliado = pl.plm_codigo FROM solaris.plan_medico pl 
	INNER JOIN SOLARIS.Paciente p ON pl.plm_codigo = p.pac_plan_medico 
	WHERE p.pac_nro_afiliado = @bon_afiliado_compra
	SELECT @bon_numero = (MAX(bon_numero) + 1) from SOLARIS.Bono_Consulta
	INSERT INTO [SOLARIS].[Bono_Consulta]
           ([bon_numero]
		   ,[bon_precio]
           ,[bon_fecha_compra]
           ,[bon_fecha_impresion]
           ,[bon_afiliado_compra]
           ,[bon_plan_afiliado]
           ,[bon_nro_consulta_med]
           ,[bon_fue_utilizado]
           ,[bon_afiliado_uso])
     VALUES
           (@bon_numero
		   ,@bon_precio
           ,GETDATE()
           ,GETDATE()
           ,@bon_afiliado_compra
           ,@bon_plan_afiliado
           ,NULL
           ,0
           ,NULL)
GO
GO
IF OBJECT_ID('SOLARIS.insertarUnBonoFarmacia') IS NOT NULL
	DROP PROCEDURE SOLARIS.insertarUnBonoFarmacia;
GO
GO
CREATE PROCEDURE SOLARIS.insertarUnBonoFarmacia
@bfm_afiliado_compra int

	as

	DECLARE @bfm_precio int
	DECLARE @bfm_plan_afiliado int
	DECLARE @bfm_numero int
	SELECT @bfm_precio = pl.plm_precio_bono_farmacia, @bfm_plan_afiliado = pl.plm_codigo FROM solaris.plan_medico pl 
	INNER JOIN SOLARIS.Paciente p ON pl.plm_codigo = p.pac_plan_medico 
	WHERE p.pac_nro_afiliado = @bfm_afiliado_compra
	SELECT @bfm_numero = (MAX(bfm_numero) + 1) from SOLARIS.Bono_Farmacia
INSERT INTO [SOLARIS].[Bono_Farmacia]
           ([bfm_precio]
           ,[bfm_fecha_compra]
           ,[bfm_afiliado_compra]
           ,[bfm_plan_afiliado])
     VALUES
           (@bfm_precio
           ,GETDATE()
           ,@bfm_afiliado_compra
		   ,@bfm_plan_afiliado)
GO

--trae los tipos de cancelacion y codigo
GO
IF OBJECT_ID('SOLARIS.tiposCancelacion') IS NOT NULL
	DROP PROCEDURE SOLARIS.tiposCancelacion;
GO

GO
CREATE PROCEDURE SOLARIS.tiposCancelacion

	as
	SELECT tca_codigo as 'Codigo', tca_nombre as 'Tipo' FROM SOLARIS.Tipo_Cancelacion 
GO



--trae los dias de la agenda del medico posteriores a la fecha recibida (falta)
GO
IF OBJECT_ID('SOLARIS.diasDeAgendaParaCancelar') IS NOT NULL
	DROP PROCEDURE SOLARIS.diasDeAgendaParaCancelar;
GO

GO
CREATE PROCEDURE SOLARIS.diasDeAgendaParaCancelar
@age_cod_med int,
@fecha_sistema datetime
 as

 SELECT DISTINCT convert(date ,age_fecha_desde) as 'DIA-MES-ANIO'
 FROM SOLARIS.Agenda 
 WHERE age_cod_medico = @age_cod_med and age_fecha_desde > @fecha_sistema
  
GO

--cancela todos los turnos de ese dia
GO
IF OBJECT_ID('SOLARIS.cancelarTurnos') IS NOT NULL
	DROP PROCEDURE SOLARIS.cancelarTurnos;
GO

GO
CREATE PROCEDURE SOLARIS.cancelarTurnos
@fecha datetime,
@codigoMedico int,
@motivo_cancel varchar(255),
@tipo_turno int
 as
	update SOLARIS.Turno set tur_estado = 4 
	where tur_numero in (select tur_numero from SOLARIS.Turno t join SOLARIS.Agenda a on (t.tur_agenda_cod=a.age_cod_entrada) where
						   --cancelo todo el DIA ---
	                      convert(date,a.age_fecha_desde) = convert(date ,@fecha) and
						  a.age_cod_medico = @codigoMedico)
	
	insert into SOLARIS.Turno_Cancelado(tcl_turno,tcl_tipo_cancel,tcl_motivo_cancel)
	select tur_numero,@tipo_turno,@motivo_cancel from SOLARIS.Turno t1 join SOLARIS.Agenda a1 on (t1.tur_agenda_cod=a1.age_cod_entrada) where
						   --cancelo todo el DIA ---
	                      convert(date,a1.age_fecha_desde) = convert(date ,@fecha) and
						  a1.age_cod_medico = @codigoMedico
 
GO


--borra los horarios del medico de su agenda
GO
IF OBJECT_ID('SOLARIS.borrarDiaDeAgenda') IS NOT NULL
	DROP PROCEDURE SOLARIS.borrarDiaDeAgenda;
GO

GO
CREATE PROCEDURE SOLARIS.borrarDiaDeAgenda
@fecha datetime,
@codigoMedico int
 as
	
	--UNA MANERA DE DESABIHILITAR LA AGENDA ES DEJANDO EN NULL LA FECHA DESDE - HASTA
	update SOLARIS.Agenda set age_fecha_desde = NULL, age_fecha_hasta = NULL
	where age_cod_medico = @codigoMedico and 
	      convert(date,age_fecha_desde) = convert(date ,@fecha)

 
GO

--HORARIO

--cancela todos los turnos de ese dia en el horario indicado, dejando como estado cancelado y sin codigo de agenda asociado
GO
IF OBJECT_ID('SOLARIS.cancelarTurnosHorarios') IS NOT NULL
	DROP PROCEDURE SOLARIS.cancelarTurnosHorarios;
GO

GO
CREATE PROCEDURE SOLARIS.cancelarTurnosHorarios
@fecha datetime,
@codigoMedico int,
@motivo_cancel varchar(255),
@tipo_turno int,
@desde datetime,
@hasta datetime
 as
	update SOLARIS.Turno set tur_estado = 4, tur_agenda_cod = NULL
	where tur_numero in (select tur_numero from SOLARIS.Turno t join SOLARIS.Agenda a on (t.tur_agenda_cod=a.age_cod_entrada) where
						   --cancelo rango del DIA ---
						  a.age_cod_medico = @codigoMedico and
						  convert(date,a.age_fecha_desde) = convert(date ,@fecha) and
	                      convert(time,a.age_fecha_desde) >= convert(time ,@desde) and
	                      convert(time,a.age_fecha_desde) <= convert(time ,@hasta) )

	
	insert into SOLARIS.Turno_Cancelado(tcl_turno,tcl_tipo_cancel,tcl_motivo_cancel)
	select tur_numero,@tipo_turno,@motivo_cancel from SOLARIS.Turno t1 join SOLARIS.Agenda a1 on (t1.tur_agenda_cod=a1.age_cod_entrada) where
						   --cancelo  rango del DIA  ---
	                      convert(date,a1.age_fecha_desde) = convert(date ,@fecha) and
	                      convert(time,a1.age_fecha_desde) >= convert(time ,@desde) and
	                      convert(time,a1.age_fecha_desde) <= convert(time ,@hasta) and
						  a1.age_cod_medico = @codigoMedico
 
GO


--borra los horarios del medico de su agenda en el horario indicado
GO
IF OBJECT_ID('SOLARIS.borrarDiaDeAgendaHorarios') IS NOT NULL
	DROP PROCEDURE SOLARIS.borrarDiaDeAgendaHorarios;
GO

GO
CREATE PROCEDURE SOLARIS.borrarDiaDeAgendaHorarios
@fecha datetime,
@codigoMedico int,
@desde datetime,
@hasta datetime
 as
	
	--UNA MANERA DE DESABIHILITAR LA AGENDA ES DEJANDO EN NULL LA FECHA DESDE - HASTA
	update SOLARIS.Agenda set age_fecha_desde = NULL, age_fecha_hasta = NULL
	where age_cod_medico = @codigoMedico and  
	convert(date,age_fecha_desde) = convert(date ,@fecha) and  
    convert(time,age_fecha_desde) >= convert(time ,@desde) and 
	convert(time,age_fecha_desde) <= convert(time ,@hasta)
 
GO

--traigo el listado de especialidades
GO
IF OBJECT_ID('SOLARIS.traigoEspecialidad') IS NOT NULL
	DROP PROCEDURE SOLARIS.traigoEspecialidad;
GO

GO
CREATE PROCEDURE SOLARIS.traigoEspecialidad
 as
	select distinct esp_descripcion from [SOLARIS].[Especialidad]
GO

--traigo el horario
GO
IF OBJECT_ID('SOLARIS.traigoHorario') IS NOT NULL
	DROP PROCEDURE SOLARIS.traigoHorario;
GO

GO
CREATE PROCEDURE SOLARIS.traigoHorario
 as
	select hor_codigo as Codigo,hor_dia as DiaCodigo, Dia = case hor_dia 
													 when 2 then 'Lunes'
													 when 3 then 'Martes'
													 when 4 then 'Miercoles'
													 when 5 then 'Jueves'
													 when 6 then 'Viernes'
													 when 7 then 'Sabado'
													 else 'No hay dia' end	from [SOLARIS].[Horario]

GO




--traigo el listado de turnos disponibles para el afiliado (codigo turno y fecha)
GO
IF OBJECT_ID('SOLARIS.datosTurnoPorNumeroAfiliado') IS NOT NULL
	DROP PROCEDURE SOLARIS.datosTurnoPorNumeroAfiliado;
GO

GO
CREATE PROCEDURE SOLARIS.datosTurnoPorNumeroAfiliado
@numeroAfiliado	int,
@fecha datetime
 as
			select tur.tur_numero as Codigo, ag.age_fecha_desde as Fecha, age_cod_medico as 'Codigo Medico'
			from SOLARIS.Turno tur join SOLARIS.Agenda ag
			on (tur.tur_agenda_cod = ag.age_cod_entrada)
			where tur_afiliado = @numeroAfiliado and
			--solo puedo cancelar dias posteriores al dia actual
			convert(date,age_fecha_desde) > convert(date ,@fecha) and
			tur_estado = 0
GO


/*Cancela el turno elegido 
    cancelarTurnoElegido(codigoTurno, numeroAfiliado, detalle, codigoTipoTurno);
        public void cancelarTurnoElegido(int codigoTurno, int numeroAfiliado, String detalle, int codigoTipoTurno)
*/        
GO
IF OBJECT_ID('SOLARIS.cancelarTurnoElegido') IS NOT NULL
	DROP PROCEDURE SOLARIS.cancelarTurnoElegido;
GO

GO
CREATE PROCEDURE SOLARIS.cancelarTurnoElegido
@codigoTurno	int,
@numeroAfiliado	int,
@detalle varchar(255),
@codigoTipoTurno int
 as
	update SOLARIS.Turno set tur_estado = 3 , tur_agenda_cod = NUll
	where tur_numero = @codigoTurno
	
	insert into SOLARIS.Turno_Cancelado(tcl_turno,tcl_tipo_cancel,tcl_motivo_cancel)
	values(@codigoTurno,@codigoTipoTurno,@detalle)
GO
-- inserta en la agenda del medico
GO
IF OBJECT_ID('SOLARIS.insertarAgendaMedico') IS NOT NULL
	DROP PROCEDURE SOLARIS.insertarAgendaMedico;
GO

GO
CREATE PROCEDURE SOLARIS.insertarAgendaMedico
@codigoMedico int,
@codigoEspecialidad int,
@fechafinal datetime
 as
	INSERT INTO SOLARIS.Agenda(age_cod_medico,age_med_especialidad,age_fecha_desde,age_fecha_hasta)
	VALUES (@codigoMedico, @codigoEspecialidad, @fechafinal, DATEADD(minute, 30, @fechafinal))
GO

--TRIGGER QUE CONTROLA NO SUPERAR LAS 48 LABORALES POR SEMANA
IF OBJECT_ID('SOLARIS.control48LaboralesPorSemana') IS NOT NULL
	DROP TRIGGER SOLARIS.control48LaboralesPorSemana;
GO

GO
CREATE TRIGGER SOLARIS.control48LaboralesPorSemana
ON SOLARIS.Agenda
INSTEAD OF INSERT
	as
	 begin
		declare cursorConsulta cursor
		for select age_cod_medico,age_med_especialidad,age_fecha_desde,age_fecha_hasta from inserted

		declare @codigoMedico int
		declare @codigoEspecialidad int
		declare @fechaDesde datetime
		declare @fechaHasta datetime
		
		open cursorConsulta
		fetch next from cursorConsulta
		into @codigoMedico,@codigoEspecialidad,@fechaDesde,@fechaHasta
		while @@FETCH_STATUS = 0
		 begin
			
			if isnull((select COUNT(*)*0.5 from SOLARIS.Agenda 
			   where age_cod_medico = @codigoMedico and
			   age_med_especialidad = @codigoEspecialidad and
			   DATEPART(week, age_fecha_desde) = DATEPART(week, @fechaDesde) and
			   YEAR(age_fecha_desde) = YEAR(@fechaDesde)
			   group by age_cod_medico),0) < 48
			begin
				INSERT INTO SOLARIS.Agenda(age_cod_medico,age_med_especialidad,age_fecha_desde,age_fecha_hasta)
				VALUES (@codigoMedico, @codigoEspecialidad, @fechaDesde, @fechaHasta)
			end
			
			fetch next from cursorConsulta
		    into @codigoMedico,@codigoEspecialidad,@fechaDesde,@fechaHasta

		 end
		close cursorConsulta
		deallocate cursorConsulta
	end
GO


-- traigo datos del horario segun la fecha y medico buscado
GO
IF OBJECT_ID('SOLARIS.datosHorarios') IS NOT NULL
	DROP PROCEDURE SOLARIS.datosHorarios;
GO

GO
CREATE PROCEDURE SOLARIS.datosHorarios
@codigoMedico int,
@codigoEspecialidad int,
@fechaInicial datetime,
@fechaFinal datetime
 as
	SELECT age_cod_entrada as Codigo, age_fecha_desde as 'Horario Desde', age_fecha_hasta as 'Horario Hasta'
	FROM SOLARIS.Agenda
	WHERE age_cod_medico = @codigoMedico and
	age_med_especialidad = @codigoEspecialidad and 
	convert(date,age_fecha_desde) >= convert(date ,@fechaInicial) and
	convert(date,age_fecha_hasta) <= convert(date ,@fechaFinal) and
	age_cod_entrada not in (select tur_agenda_cod from SOLARIS.Turno)
GO

--SOLARIS.crearTurno " + codigoPaciente + "," + codigoAgenda, cn);
 GO
IF OBJECT_ID('SOLARIS.crearTurno') IS NOT NULL
	DROP PROCEDURE SOLARIS.crearTurno;
GO

GO
CREATE PROCEDURE SOLARIS.crearTurno
@codigoPaciente int,
@codigoAgenda int
 as
 begin

    declare @tur_numero int
	 set @tur_numero = (select max(tur_numero) + 1 from SOLARIS.Turno)
	INSERT INTO SOLARIS.Turno (tur_numero,tur_agenda_cod,tur_afiliado,tur_estado)
	VALUES (@tur_numero,@codigoAgenda,@codigoPaciente,0)
  end
GO             

--especialidadesMasCanceladas(int anioConsultado, int semestreConsultado)
GO
IF OBJECT_ID('SOLARIS.devuelveNumeroSemestre') IS NOT NULL
	DROP FUNCTION SOLARIS.devuelveNumeroSemestre;
GO

GO

CREATE FUNCTION SOLARIS.devuelveNumeroSemestre
(@numeroMes int)
returns int
as
	begin
		if ((@numeroMes >= 1) AND (@numeroMes <= 6))
		begin
			return 1
		end
		if ((@numeroMes >= 7) AND (@numeroMes <= 12))
		begin
			return 2		
		end

	return 0	
	end

GO


GO
IF OBJECT_ID('SOLARIS.especialidadesMasCanceladas') IS NOT NULL
	DROP PROCEDURE SOLARIS.especialidadesMasCanceladas;
GO

GO
CREATE PROCEDURE SOLARIS.especialidadesMasCanceladas
@anioConsultado int,
@semestreConsultado int
 as

 SELECT TOP 5 e.esp_codigo as 'Codigo de especialidad' FROM SOLARIS.Especialidad e 
 JOIN SOLARIS.Agenda a on (e.esp_codigo=a.age_med_especialidad)
 JOIN SOLARIS.Turno t on (t.tur_agenda_cod = a.age_cod_entrada)
 WHERE YEAR(a.age_fecha_desde) = @anioConsultado and 
       SOLARIS.devuelveNumeroSemestre (MONTH(a.age_fecha_desde)) = @semestreConsultado and
	   t.tur_estado = 3 or t.tur_estado = 4
 GROUP BY e.esp_codigo
 ORDER BY count(t.tur_numero) desc 
  
GO


GO
IF OBJECT_ID('SOLARIS.profesionalesMasConsultados') IS NOT NULL
	DROP PROCEDURE SOLARIS.profesionalesMasConsultados;
GO

GO
CREATE PROCEDURE SOLARIS.profesionalesMasConsultados
@anioConsultado int,
@semestreConsultado int
 as

 SELECT TOP 5 a.age_cod_medico as 'Codigo de medico', 
              b.bon_plan_afiliado as 'Codigo de plan',
			  a.age_med_especialidad as 'Codigo de especialida'
 FROM SOLARIS.Consulta c JOIN SOLARIS.Bono b 
 on (c.con_numero = b.bon_nro_consulta_med)
 JOIN SOLARIS.Turno t 
 on (t.tur_numero = c.con_turno)
 JOIN SOLARIS.Agenda a
 on (a.age_cod_entrada = t.tur_agenda_cod)
 
 WHERE YEAR(c.con_fecha) = @anioConsultado and 
       SOLARIS.devuelveNumeroSemestre (MONTH(c.con_fecha)) = @semestreConsultado 
 GROUP BY a.age_cod_medico,b.bon_plan_afiliado,a.age_med_especialidad
 ORDER BY count(c.con_numero) desc 
  
GO

--
GO
IF OBJECT_ID('SOLARIS.especialidadesMasBonosConsultaUsados') IS NOT NULL
	DROP PROCEDURE SOLARIS.especialidadesMasBonosConsultaUsados;
GO

GO
CREATE PROCEDURE SOLARIS.especialidadesMasBonosConsultaUsados
@anioConsultado int,
@semestreConsultado int
 as

 SELECT TOP 5 a.age_med_especialidad as 'Codigo de especialidad'
 FROM SOLARIS.Agenda a JOIN SOLARIS.Turno t
 on (a.age_cod_entrada = t.tur_agenda_cod)
 JOIN SOLARIS.Consulta c 
 on (t.tur_numero = c.con_turno)
 JOIN SOLARIS.Bono b
 on(c.con_numero = b.bon_nro_consulta_med)
 
 WHERE YEAR(c.con_fecha) = @anioConsultado and 
       SOLARIS.devuelveNumeroSemestre (MONTH(c.con_fecha)) = @semestreConsultado and
	   b.bon_tipo_bono = 'C' and
	   bon_fue_utilizado = 1

 GROUP BY a.age_med_especialidad
 ORDER BY count(b.bon_numero) desc 
  
GO
---
GO
IF OBJECT_ID('SOLARIS.afiliadosMayorCantidadBonoComprado') IS NOT NULL
	DROP PROCEDURE SOLARIS.afiliadosMayorCantidadBonoComprado;
GO

GO
CREATE PROCEDURE SOLARIS.afiliadosMayorCantidadBonoComprado
@anioConsultado int,
@semestreConsultado int
 as

 
   SELECT TOP 5 b.bon_afiliado_compra as 'Codigo de afiliado' , 'Pertenece a un grupo familiar' = 
 case when (select count(*) from SOLARIS.Paciente p1 where p1.pac_nro_afiliado / 100 = b.bon_afiliado_compra / 100) > 1 then 'si pertenece'
      else 'no pertenece' end
  FROM SOLARIS.Bono b
  
 WHERE YEAR(b.bon_fecha_compra) = @anioConsultado and 
       SOLARIS.devuelveNumeroSemestre (MONTH(b.bon_fecha_compra)) = @semestreConsultado 
	   

 GROUP BY b.bon_afiliado_compra
 ORDER BY count(b.bon_numero) desc 
  
GO

--profesionalMenosHorasTrabajadas 


GO
IF OBJECT_ID('SOLARIS.profesionalMenosHorasTrabajadas') IS NOT NULL
	DROP PROCEDURE SOLARIS.profesionalMenosHorasTrabajadas;
GO

GO

CREATE PROCEDURE SOLARIS.profesionalMenosHorasTrabajadas
@anioConsultado int,
@semestreConsultado int,
@codigoPlan int,
@codigoEspecialidad int
 as
 begin
 --usamos tabla temporal
CREATE TABLE #tablatemporal (
	codigoMedico int,
	horasTrabajadas	decimal(10,4)
);

 INSERT INTO #tablatemporal(codigoMedico,horasTrabajadas) 
 SELECT a.age_cod_medico,count(a.age_fecha_desde)*0.5    FROM SOLARIS.Agenda a
  
 WHERE YEAR(a.age_fecha_desde) = @anioConsultado and 
       SOLARIS.devuelveNumeroSemestre (MONTH(a.age_fecha_desde)) = @semestreConsultado and
	   exists(select * from SOLARIS.Turno t where t.tur_agenda_cod = a.age_cod_entrada and
	           tur_estado = 2) and
	   a.age_med_especialidad = @codigoEspecialidad and
	   @codigoPlan = (select b.bon_plan_afiliado FROM SOLARIS.Bono b
	                  JOIN SOLARIS.Consulta c on (c.con_numero = b.bon_nro_consulta_med)
					  JOIN SOLARIS.Turno t1 on (t1.tur_numero = c.con_turno)
					  Where t1.tur_agenda_cod = a.age_cod_entrada )
  	   

 GROUP BY a.age_cod_medico
 ORDER BY count(a.age_fecha_desde)*0.5 asc 
  
  SELECT TOP 5 codigoMedico
  FROM #tablatemporal
  ORDER BY horasTrabajadas desc 
end
GO

-- [EOF]
