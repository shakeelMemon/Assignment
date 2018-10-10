using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerTests
    {
        [TestMethod]
        public void TestHasCredits()
        {
            var tracker = new GraduationTracker();

            var diploma = TestUtility.GenerateDiploma();
            var students = TestUtility.GenerateStudents(4);                
            var graduated = new List<Tuple<bool, STANDING>>();
            foreach(var student in students)            
                graduated.Add(tracker.HasGraduated(diploma, student));    

            Assert.IsTrue(graduated.Any());
            Assert.IsTrue(graduated.Count == 4);
            Assert.IsTrue(graduated.Where(x => x.Item2 == STANDING.Average).Count() == 2);
            Assert.IsTrue(graduated.Where(x => x.Item2 == STANDING.Remedial).Count() == 2);
            Assert.IsTrue(graduated.Where(x => x.Item1 == true).Count() == 2);
            Assert.IsTrue(graduated.Where(x => x.Item1 == false).Count() == 2);
        }



    }
}
