﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Datos.Data;
using Datos.Models;

namespace Datos.Admin
{
        
    public static class AdmPaciente
    {
        static DbClinicaContext context = new DbClinicaContext();
        
        public static List<Paciente> Listar()
        {
            
            return context.Pacientes.ToList(); //retornamos todos los pacientes
        }

        public static Paciente TraerPorId(int id)
        {
            //TODO implementar Listar()
            return context.Pacientes.Find(id);
        }

        public static int Insertar(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            int filasAfectadas = context.SaveChanges();
            return filasAfectadas;
        }

        public static int Modificar(Paciente paciente)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(paciente);

            if (pacienteOrigen != null)
            {
                pacienteOrigen.Nombre = paciente.Nombre;
                pacienteOrigen.Apellido = paciente.Apellido;
                pacienteOrigen.FechaNacimiento = paciente.FechaNacimiento;
                pacienteOrigen.NroHistoriaClinica = paciente.NroHistoriaClinica;
                pacienteOrigen.MedicoId = paciente.NroHistoriaClinica;

                return context.SaveChanges();
            }

            else
            {
                return 0;
            }
        }

        public static int Eliminar(int id)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(id);

            if (pacienteOrigen != null)
            {
                context.Pacientes.Remove(pacienteOrigen);

                return context.SaveChanges();
            }
            else
            {
                return 0;
            }

            
        }
    }
}
