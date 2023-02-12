using Demo2022.Model;
using MyPlantDiary;

namespace Demo2022
{
    public static class SpecimenRoster
    {
        static SpecimenRoster()
        {
            allSpecimens = new List<Specimen>();
        }

        public static IList<Specimen> allSpecimens { get; set; }
    }
}
