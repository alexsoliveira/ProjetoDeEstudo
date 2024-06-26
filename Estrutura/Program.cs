﻿using ConstructingClasses;
using UsingCommonReferenceTypes;
using UsingValueTypes;

namespace Estrutura;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        ////Lesson One
        //ValueTypes();
        //LabValueTypes();

        //Lesson Two
        //ComparingBehaviorReferenceAndValueTypes();
        //LabCommonReferenceTypes();

        ConstructingClasses();
    }

    public static void ConstructingClasses()
    {
        AulaConstructingClasses constructingClasses = new AulaConstructingClasses();
        //constructingClasses.DerivedException();
        constructingClasses.ConsumeGenericType();
    }

    //UsingCommonReferenceTypes
    public static void LabCommonReferenceTypes()
    {
        AulaUsingCommonReferenceTypes referenceTypes = new AulaUsingCommonReferenceTypes();
        //referenceTypes.ListValueTypes();
        //referenceTypes.SortString();
        referenceTypes.WorkWithStreamsAndExceptions();
    }

    public static void ComparingBehaviorReferenceAndValueTypes()
    {
        AulaUsingCommonReferenceTypes referenceTypes = new AulaUsingCommonReferenceTypes();
        //referenceTypes.StructTypeValue();
        //referenceTypes.StringsAndStringBuilders();
        //referenceTypes.CreateSortArrays();
        //referenceTypes.UseStreams();
        referenceTypes.CatchExceptions();
    }

    //UsingValueTypes
    public static void LabValueTypes()
    {
        Person person = new Person("Tony","Allen",32, Person.Genders.Male);
        
        Console.WriteLine(person.ToString());
        Console.ReadLine();
    }   

    public static void ValueTypes()
    {
        AulaUsingValueTypes valueTypes = new AulaUsingValueTypes();
        //valueTypes.AulaBuiltInValueTypes();
        valueTypes.AulaEnumerations();
    }
}
