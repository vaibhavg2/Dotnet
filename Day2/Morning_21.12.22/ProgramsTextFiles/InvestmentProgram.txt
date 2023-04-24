using System;

enum RiskLevel {None, Low, High}

struct Investment
{
   private double payment;
   private int count;
   private RiskLevel risk;

   public Investment(double amount, int years)
   {
      payment = amount;
      count = years;
      risk = RiskLevel.None;
   }

   public double Sum()
   {
      return payment * count;
   }

   //method over-loading
   public void AllowRisk(bool yes)
   {
      risk = yes ? RiskLevel.Low : RiskLevel.None;
   }

   public void AllowRisk(RiskLevel level)
   {
      risk = level;
   }

   public double FutureValue()
   {
      float i = InterestRate(risk);
      return (payment / i) * (Math.Pow(1 + i, count) - 1);
   }

   private static float InterestRate(RiskLevel risky)
   {
      float rate;
      switch(risky)
      {
         case RiskLevel.Low:
            rate = 0.08f;
            break;
         case RiskLevel.High:
            rate = 0.11f;
            break;
         default:
            rate = 0.06f;
            break;
      }
      return rate;
   }
}