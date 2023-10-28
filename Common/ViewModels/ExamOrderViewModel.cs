using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BPACS.Common.ViewModels
{
    public class ExamOrderViewModel
    {

        [Display(Name = "Nome do Paciente")]
        public string PatientName { get; set; }

        [Display(Name = "Tipo de Exame")]
        public string ExamType { get; set; }
    }

}
