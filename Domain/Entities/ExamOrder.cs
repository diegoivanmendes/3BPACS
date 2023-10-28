namespace _3BPACS.Domain.Entities
{
    public class ExamOrder
    {
        public int Id { get; private set; }
        public string PatientName { get; private set; }
        public string ExamType { get; private set; }

        public ExamOrder(string patientName, string examType)
        {
            PatientName = patientName;
            ExamType = examType;
        }

    }

}