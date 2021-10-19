using Subject.Models;
using System.Collections.Generic;
using System.Linq;

namespace Subject.Services
{
    public static class LearningSubjectService
    {
        static List<LearningSubject> Subjects { get; }
        static int nextId = 3;
        static LearningSubjectService()
        {
            Subjects = new List<LearningSubject>
            {
                new LearningSubject { Id = 1, Name = "UX Design", IncludesCoding = false, SkillLevel= Level.Intermediate },
                new LearningSubject { Id = 2, Name = "Beginner Javascript", IncludesCoding = true, SkillLevel=Level.Beginner }
            };
        }

        public static List<LearningSubject> GetAll() => Subjects;

        public static LearningSubject Get(int id) => Subjects.FirstOrDefault(s => s.Id == id);

        public static void Add(LearningSubject subject)
        {
            subject.Id = nextId++;
            Subjects.Add(subject);
        }

        public static void Delete(int id)
        {
            var subject = Get(id);
            if(subject is null)
                return;

            Subjects.Remove(subject);
        }

        public static void Update(LearningSubject subject)
        {
            var index = Subjects.FindIndex(p => p.Id == subject.Id);
            if(index == -1)
                return;
            Subjects[index] = subject;
        }
    }
}