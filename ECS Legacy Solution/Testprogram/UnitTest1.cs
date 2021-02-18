using System;
using NUnit.Framework;
using ECS;

namespace ECS.Testprogram
{
   public class Tests
   {
      private ECS uut;
      private FakeHeater heater;
      private StubSensor fakeSensor;
      [SetUp]
      public void Setup()
      {
         heater = new FakeHeater();
         fakeSensor = new StubSensor();
         uut = new ECS(30, fakeSensor, heater);
      }

      [TestCase(32)]
      [TestCase(250)]
      [TestCase(40)]

      public void heaterTurnOff_tempAboveThreshold30_true(int testtemp)
      {
         fakeSensor.temp = testtemp;
         uut.Regulate();
         Assert.That(heater.turnedOff, Is.True);
      }

      [TestCase(-2)]
      [TestCase(0)]
      [TestCase(29)]

      public void heaterTurnOn_tempBelowThreshold30_true(int testtemp)
      {
         fakeSensor.temp = testtemp;
         uut.Regulate();
         Assert.That(heater.turnedOn, Is.True);
      }


      [TestCase(-2)]
      [TestCase(0)]
      [TestCase(29)]

      public void heaterTurnOff_tempBelowThreshold30_false(int testtemp)
      {
         fakeSensor.temp = testtemp;
         uut.Regulate();
         Assert.That(heater.turnedOff, Is.False);
      }

      [TestCase(32)]
      [TestCase(250)]
      [TestCase(40)]

      public void heaterTurnOn_tempAboveThreshold30_false(int testtemp)
      {
         fakeSensor.temp = testtemp;
         uut.Regulate();
         Assert.That(heater.turnedOn, Is.False);
      }
   }
}