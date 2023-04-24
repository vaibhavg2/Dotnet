using System;

//user-defined value type
struct Investment
{
   private double payment;
   private int count;
   private bool risk;

   public Investment(double amount, int years)
   {
      payment = amount;
      count = years;
      risk = false;
   }

   public double Sum()
   {
      return payment * count;
   }

   public void AllowRisk(bool yes)
   {
      risk = yes;
   }

   public double FutureValue()
   {
      float i = InterestRate(risk);
      return (payment / i) * (Math.Pow(1 + i, count) - 1);
   }

   private static float InterestRate(bool risky)
   {
      return risky ? 0.08f : 0.06f;
   }
}