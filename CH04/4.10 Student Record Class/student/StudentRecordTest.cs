// StudentRecordTest.cs
// Create and Manipulate Student Records

using System;

class StudentRecordTest
{
    static void Main()
    {
        Student s0965541 = new Student("0965541", "John Smith", 50m, 40m ,-30m); // m is used for decimal literal

        s0965541.getRecords();
        s0965541.getAggregate();
        s0965541.getPercentage();
    }
}