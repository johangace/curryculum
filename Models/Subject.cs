namespace Subject.Models
{
      public enum Level {
    None         = 0,
    Beginner     = 1,  
    Intermediate = 2,  
    Advanced     = 3,      
    Pro          = 4,  
}
    public class LearningSubject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IncludesCoding { get; set; }
        public Level SkillLevel { get; set; }
      
    }
}