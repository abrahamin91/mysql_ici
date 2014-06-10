using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoBarajas
{
    class Alumno : ConnectionMySQL
    {
        private Parametros []para;
        public string Id { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Apepat { get; set; }
        public string Apemat { get; set; }
        public string Domicilio { get; set; }
        public string Cp { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Id_Centro { get; set; }
        public string Id_Carrera { get; set; }
        public string Id_Materia { get; set; }
        

        public Alumno() { }
        public Alumno(string pId, string pCotrasena, string pNombre, string pApepat, string pApemat, string pDomicilio, string pCp,
                      string pColonia, string pMunicipio, string pEstado, string pId_Centro, string Id_Carrera)
        {
            this.Id = pId;
            this.Contrasena = pCotrasena;
            this.Nombre = pNombre;
            this.Apepat = pApepat;
            this.Apemat = pApemat;
            this.Domicilio = pDomicilio;
            this.Cp = pCp;
            this.Colonia = pColonia;
            this.Municipio = pMunicipio;
            this.Estado = pEstado;
            this.Id_Centro = pId_Centro;
        }
        public bool leerAlumnos()
        {
            return leerTabla("consultar_alumnos");
        }


        public bool AgregarAlumno()
        {
            para = new Parametros[9];
            para[0] = new Parametros("p_nombre", Nombre);
            para[1] = new Parametros("p_contrasena", Contrasena);
            para[2] = new Parametros("p_apepat",Apepat);
            para[3] = new Parametros("p_apemat",Apemat);
            para[4] = new Parametros("p_domicilio",Domicilio);
            para[5] = new Parametros("p_cp",Cp);
            para[6] = new Parametros("p_colonia", Colonia);
            para[7] = new Parametros("p_municipio", Municipio);
            para[8] = new Parametros("p_estado", Estado);

            return EjecutarStoredProcedure("insertar_alumno",para);
        }
        public bool ModificarAlumno()
        {
            para = new Parametros[10];
            para[0] = new Parametros("p_idalumno", Id);
            para[1] = new Parametros("p_contrasena", Contrasena);
            para[2] = new Parametros("p_nombre", Nombre);
            para[3] = new Parametros("p_apepat", Apepat);
            para[4] = new Parametros("p_apemat", Apemat);
            para[5] = new Parametros("p_domicilio", Domicilio);
            para[6] = new Parametros("p_cp", Cp);
            para[7] = new Parametros("p_colonia", Colonia);
            para[8] = new Parametros("p_municipio", Municipio);
            para[9] = new Parametros("p_estado", Estado);

            return EjecutarStoredProcedure("modificar_alumno", para);
        }
        public bool EliminarAlumno()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idalumno", Id);
            return EjecutarStoredProcedure("eliminar_alumno", para);
        }
        public bool BuscarAlumno()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idalumno", Id);
            return EjecutarStoredProcedure("buscar_alumno", para);
        }
        public bool Login_Alumno()
        {
            para = new Parametros[2];
            para[0] = new Parametros("p_idalumno", Id);
            para[1] = new Parametros("p_contrasena", Contrasena);
            return EjecutarStoredProcedure("login_alumno", para);
        }
        public bool Logout_Alumno()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idalumno", Id);
            return EjecutarStoredProcedure("logout_alumno", para);
        }

        public bool obtener_nombreA()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idalumno", Id);
            return EjecutarStoredProcedure("obtener_nombreA", para);
        }

        public bool leer_centros()
        {
            return leerTabla("consultar_centros");
        }

        public bool consultar_carrerasC()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idcentro", Id_Centro);
            return EjecutarStoredProcedure("consultar_carrerasC", para);
        }

        public bool consultar_materias()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idcarrera", Id_Carrera);
            return EjecutarStoredProcedure("consultar_materias", para);
        }

        public bool consultar_materiasinscritas()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idalumno", Id);
            return EjecutarStoredProcedure("consultar_materias_inscritas", para);
        }

        public bool inscribirAlumno()
        {
            para = new Parametros[2];
            para[0] = new Parametros("p_idalumno", Id);
            para[1] = new Parametros("p_idcurso", Id_Materia);
            return EjecutarStoredProcedure("inscribir_alumno", para);
        }

        public bool desinscribirAlumno()
        {
            para = new Parametros[2];
            para[0] = new Parametros("p_idalumno", Id);
            para[1] = new Parametros("p_idcurso", Id_Materia);
            return EjecutarStoredProcedure("desinscribir_alumno", para);
        }

        public bool consultar_calificaciones()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idalumno", Id);
            return EjecutarStoredProcedure("consultar_calificaciones", para);
        }
        public bool mostrar_cursos_disponibles()
        {
            para = new Parametros[2];
            para[0] = new Parametros("p_idcarrera", Id_Carrera);
            para[1] = new Parametros("p_idalumno", Id);
            return EjecutarStoredProcedure("mostrar_cursos_disponiblesA", para);
        }
    }
}
