using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppeveliEconomics
{
    class MacroEcon
    {
        /**
    * 
    * @param GDP Gross Domestic Product 
    * @param Population population of the economy 
    * @return Gross Domestic Product / Population 
    */
        public static double PerCapia(double GDP, double Population)
        {
            return GDP / Population;
        }
        /**
         * 
         * @param CpiCurrentYear Consumer price index in current year
         * @param CpiPreviousYear consumer price index in previous year
         * @return (Consumer price index in current year - consumer price index in previous year) 
         * / consumer price index in previous year *100
         */
        public static double PercentIncreaseGDP(double CpiCurrentYear, double CpiPreviousYear)
        {
            return (CpiCurrentYear - CpiPreviousYear) / CpiPreviousYear * 100;
        }
        /**
         * 
         * @param NominalGDP measures a country's overall economic output
         * @param GDPdeflator measures the level of prices oof all new domestically produced
         * @return Nominal Gross Domestic Product / Gross Domestic Product deflator * 100
         */
        public static double GDP(double NominalGDP, double GDPdeflator)
        {
            return NominalGDP / GDPdeflator * 100;
        }
        /**
         * 
         * @param CurrentPrice current price
         * @param PreviousPrice previous price
         * @return (Current Price - Previous Price) / Previous Price
         */
        public static double PercentageChange(double CurrentPrice, double PreviousPrice)
        {
            return (CurrentPrice - PreviousPrice) / PreviousPrice;
        }
        /**
         * 
         * @param NumUnemployed Number of individuals unemployed
         * @param LaborForce Number of the Labor Force
         * @return Number Unemployed / Labor Force
         */
        public static double UnemploymentRate(double NumUnemployed, double LaborForce)
        {
            return NumUnemployed / LaborForce;
        }
    }
}
