# LINQ GroupJoin Example - Grouping Students by Class

This example demonstrates how to use LINQ's GroupJoin method to group students by their respective classes.

Explanation:

*Students List (students): Contains 5 students, each associated with a ClassId that represents the class the student belongs to.

*Classes List (classes): Contains 3 classes, each with a unique ClassId.

*The goal is to group students by their class and display the class name along with the list of students in that class.

LINQ Query:

*GroupJoin is used to join the students list with the classes list, matching each class to its corresponding students based on the ClassId.
*The query projects an anonymous object containing the class name and the list of students for that class.
Key Steps:

*GroupJoin: Combines data from two lists (students and classes) based on a common key (ClassId).

*The result is a collection where each class has a list of its students.

*The output is displayed by iterating through each class and printing its name, followed by the names of students in that class.
