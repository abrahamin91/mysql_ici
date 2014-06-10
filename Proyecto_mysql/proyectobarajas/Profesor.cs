using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoBarajas
{
    class Profesor : ConnectionMySQL
    {
        private Parametros[] para;
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
        public string Id_Curso { get; set; }


        public Profesor() { }
        public Profesor(string pId, string pContrasena, string pNombre, string pApepat, string pApemat, string pDomicilio, string pCp,
                      string pColonia, string pMunicipio, string pEstado, string pId_Centro, string pId_Carrera, string pId_Curso)
        {
            this.Id = pId;
            this.Contrasena = pContrasena;
            this.Nombre = pNombre;
            this.Apepat = pApepat;
            this.Apemat = pApemat;
            this.Domicilio = pDomicilio;
            this.Cp = pCp;
            this.Colonia = pColonia;
            this.Municipio = pMunicipio;
            this.Estado = pEstado;
            this.Id_Centro = pId_Centro;
            this.Id_Carrera = pId_Carrera;
            this.Id_Curso = pId_Curso;
        }
        public bool leerProfesor()
        {
            return leerTabla("consultar_profesores");
        }
        public bool AgregarProfesor()
        {
            para = new Parametros[9];
            para[0] = new Parametros("p_contrasena", Contrasena);
            para[1] = new Parametros("p_nombre", Nombre);
            para[2] = new Parametros("p_apepat", Apepat);
            para[3] = new Parametros("p_apemat", Apemat);
            para[4] = new Parametros("p_domicilio", Domicilio);
            para[5] = new Parametros("p_cp", Cp);
            para[6] = new Parametros("p_colonia", Colonia);
            para[7] = new Parametros("p_municipio", Municipio);
            para[8] = new Parametros("p_estado", Estado);


            return EjecutarStoredProcedure("insertar_profesor", para);
        }
        public bool ModificarProfesor()
        {
            para = new Parametros[10];
            para[0] = new Parametros("p_idprofesor", Id);
            para[1] = new Parametros("p_contrasena", Contrasena);
            para[2] = new Parametros("p_nombre", Nombre);
            para[3] = new Parametros("p_apepat", Apepat);
            para[4] = new Parametros("p_apemat", Apemat);
            para[5] = new Parametros("p_domicilio", Domicilio);
            para[6] = new Parametros("p_cp", Cp);
            para[7] = new Parametros("p_colonia", Colonia);
            para[8] = new Parametros("p_municipio", Municipio);
            para[9] = new Parametros("p_estado", Estado);

            return EjecutarStoredProcedure("modificar_profesor", para);
        }
        public bool EliminarProfesor()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idprofesor", Id);
            return EjecutarStoredProcedure("eliminar_profesor", para);
        }
        public bool BuscarProfesor()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idprofesor", Id);
            return EjecutarStoredProcedure("buscar_profesor", para);
        }
        public bool Login_Profesor()
        {
            para = new Parametros[2];
            para[0] = new Parametros("p_idprofesor", Id);
            para[1] = new Parametros("p_contrasena", Contrasena);
            return EjecutarStoredProcedure("login_profesor", para);
        }
        public bool Logout_Profesor()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idprofesor", Id);
            return EjecutarStoredProcedure("logout_profesor", para);
        }
        public bool obtener_nombreP()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idprofesor", Id);
            return EjecutarStoredProcedure("obtener_nombreP", para);
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
        public bool consultar_cursosP()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idcentro", Id_Centro);
            return EjecutarStoredProcedure("consultar_carrerasC", para);
        }
        public bool mostrar_cursos_disponibles()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idcarrera", Id_Carrera);
            return EjecutarStoredProcedure("mostrar_cursos_disponibles", para);
        }
        public bool impartir_Cursos()
        {
            para = new Parametros[2];
            para[0] = new Parametros("p_idcurso", Id_Curso);
            para[1] = new Parametros("p_idprofesor", Id);
            return EjecutarStoredProcedure("impartir_curso", para);
        }
        public bool cursos_a_impartir()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idprofesor", Id);
            return EjecutarStoredProcedure("cursos_a_impartir", para);
        }
        public bool alumnos_inscritos()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idcurso", Id_Curso);
            return EjecutarStoredProcedure("alumnos_inscritos", para);
        }
        public bool no_impartir_curso()
        {
            para = new Parametros[1];
            para[0] = new Parametros("p_idcurso", Id_Curso);
            return EjecutarStoredProcedure("no_impartir_cursos", para);
        }
    
    }
}
