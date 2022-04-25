using System;
using System.ComponentModel.DataAnnotations;

namespace MainsoftTesting.Domain.Models
{
    public enum Gender
    {
        Masculino,
        Femenino
    }

    public enum DocumentType
    {
        CC,
        CE,
        PA,
        PEP,
        PPE,
        RC,
        TI
    }

    public enum MaritalStatus
    {
        Soltero,
        Casado,
        Viudo,
        Separado,
        UnionLibre,
        Otro
    }
    public enum JobStatuis
    {
        Empleado,
        Desempleado,
        Independiente,
        Freelance
    }

    public enum StudyLevel
    {
        Bachiller,
        Aprendiz,
        Técnico,
        Tecnólogo,
        Profesional,
        Posgrado,
        Especializacion,
        Maestría,
        Doctorado
    }

}
