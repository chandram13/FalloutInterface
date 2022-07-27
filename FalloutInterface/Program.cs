// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Marvish Chandra
// This program is intended to simulate the S.P.E.C.I.A.L. distribution of points that is used in the new character screen.

interface PointsMessage
{
    void introMessage():
    int totalPoints = 21; 
    Console.WriteLine("What total stats have you chosen in this category?")
}

class FalloutPoints : PointsMessage
{
    public static void Strength():
        for (int i = 21; i.length < 3 ; i--)
    {
        assignedStrength = Console.ReadLine("How many points (out of three) do you intend to dedicate to strength?");
        Console.WriteLine(assignedStrength);
}
class PerceptionPoints : PointsMessage:
public static void Perception():
for (int i = 21; i.length < 3; i--)
{
    assignedPerception = Console.ReadLine("How many points (out of three) do you intend to dedicate to perception?");
    Console.WriteLine(assignedPerception);
}
class EndurancePoints : PointsMessage:
public static void Endurance():
for (int i = 21; i.length < 3; i--)
{
    assignedEndurance = Console.ReadLine("How many points (out of three) do you intend to dedicate to endurance?");
    Console.WriteLine(assignedEndurance);    
}
class CharismaPoints : PointsMessage:
public static void Charisma():
for (int i = 21; i.length < 3; i--)
{
    assignedCharisma = Console.ReadLine("How many points (out of three) do you intend to dedicate to charisma?");
    Console.WriteLine(assignedCharisma);
}
class IntelligencePoints : PointsMessage
public static void Intelligence():
for (int i = 21; i.length < 3; i--)
{
    assignedIntelligence = Console.ReadLine("How many points (out of three) do you intend to dedicate to intelligence?"); 
    Console.WriteLine(assignedIntelligence);
}
class AgilityPoints : PointsMessage
public static void Agility():
for (int i = 21; i.length < 3; i--)
{
    assignedAgility = Console.ReadLine("How many points (out of three) do you intend to dedicate to agility?");
    Console.WriteLine(assignedAgility);
}
class LuckPoints : PointsMessage
public static void Luck():
for (int i = 21; i.length < 3; i--)
{
    assignedLuck = Console.ReadLine("How many points (out of three) do you intend to dedicate to luck?"); 
    Console.WriteLine(assignedLuck);
}

class Program
{
    static void Main(string[] args)
    {
        FalloutPoints myObj1 = new FalloutPoints();
        myObj1.pointsmessage();
        PerceptionPoints myObj2 = new PerceptionPoints();
        myObj2.pointsmessage();
        myObj2.perception();
        EndurancePoints myObj3 = new EndurancePoints();
        myObj3.pointsmessage();
        myObj3.endurance();
        CharismaPoints myObj4 = new CharismaPoints();
        myObj4.pointsmessage();
        myObj4.charisma();
        IntelligencePoints myObj5 = new IntelligencePoints();
        myObj5.pointsmessage();
        myObj5.intelligence();
        AgilityPoints myObj6 = new AgilityPoints();
        myObj6.pointsmessage();
        myObj6.agiility();
        LuckPoints myObj7 = new LuckPoints();
        myObj7.pointsmessage();
        myObj7.luck();
    }
}