namespace ECS.Legacy
{
   public class Application
   {
      public static void Main(string[] args)
      {
         //Create dependencies 
         ITempSensor _tempSensor = new TempSensor();
         IHeater _heater = new Heater();

         //Create ECS sytem class
         var ecs = new ECS(28, _tempSensor, _heater);

         ecs.Regulate();

         
         ecs.SetThreshold(20);

    
      }
   }
}
