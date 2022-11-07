using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Becas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Becas.Services
{
    public class AlumnoService
    {
        static List<Alumno> Alumnos {get;}

        static int nextId = 3;

        static AlumnoService ()
        {
            Alumnos = new List <Alumno> {
                new Alumno {Id = 1, Nombres = "Jesús Antonio", ApellPat = "Velazquez", ApellMat = "Balan", Matricula = "0987653753", Carrera = "T.S.U. en Tecnologias de la informacion", Correo = "jesusbalan1232@gmail.com", Telefono = "9821088683", Origen = "Candelaria", Estancia = "Candelaria" },
                new Alumno {Id = 2, Nombres = "Jordy", ApellPat = "Cabrera", ApellMat = "Luis", Matricula = "8521100014", Carrera = "T.S.U. en Tecnologias de la Informacion", Correo = "jordycabrera12@gmail.com", Telefono = "98216588474", Origen = "Rio Caribe", Estancia = "Candelaria" },
            };
        }

        public ActionResult<List<Alumno>> GetAll()
        {
            throw new NotImplementedException();
        }

        public static List<Alumno> Get()=> Alumnos;

    public static Alumno Get(int Id) => Alumnos.FirstOrDefault(p => p.Id == Id);


    public static void Add(Alumno alumno) 
    {
        alumno.Id = nextId++;
        Alumnos.Add(alumno);

    }
    public async void Delete(int Id )
    {
        var alumno = Get(Id);
        if(alumno is null)
            return;

            Alumnos.Remove(alumno);
           
    }

    public async void Update(Alumno alumno)
    {
        var index = Alumnos.FindIndex(p => p.Id == alumno.Id);
        if (index == -1)
        return;

        Alumnos[index] = alumno;
    }


    }
}