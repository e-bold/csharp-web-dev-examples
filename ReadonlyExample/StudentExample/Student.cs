﻿public class Student {

   private static int nextStudentId = 1;
   public string Name { get; set; }
   private readonly int studentId;
   public int NumberOfCredits { get; set; }
   public double Gpa { get; set; }

   public Student(string name, int sId, int numberOfCredits, double gpa)
   {
      Name = name;
      studentId = sId;
      NumberOfCredits = numberOfCredits;
      Gpa = gpa;
   }

   public Student(string name, int sId)
   {
      Name = name;
      studentId = sId;
      NumberOfCredits = 0;
      Gpa = 0.0;
   }

   public Student(string name)
   {
      Name = name;
      studentId = nextStudentId;
      nextStudentId++;
      NumberOfCredits = 0;
      Gpa = 0.0;
   }

   public string StudentInfo()
   {
      return (Name + " has a GPA of: " + Gpa);
   }

   public void AddGrade(int courseCredits, double grade)
   {
      // Update the appropriate fields: NumberOfCredits, Gpa
      NumberOfCredits = courseCredits;
      Gpa = grade;
   }

   public string GetGradeLevel()
   {
      // Determine the grade level of the student based on NumberOfCredits
   }
}