using System;
using System.Collections.Generic;
using System.Linq;

namespace ESGMetricsCalculator
{
    public class SASBCALCULATOR
    {
        public class ApparelSustainabilityAccountingStandard
        {
            public class WastewaterParameter
            {
                public string Name { get; set; }
                public double MaximumConcentration { get; set; }
            }

            public class SupplierFacilityData
            {
                public SupplierFacilityType Type { get; set; }
                public WastewaterStandard[] Standards { get; set; }
                public WastewaterParameter[] Parameters { get; set; }
                public bool InCompliance { get; set; }
            }

            public enum SupplierFacilityType
            {
                Tier1,
                BeyondTier1,
            }

            public enum WastewaterStandard
            {
                ZDHC,
                BSR,
                IPE,
            }

            public static double CalculatePercentageOfSupplierFacilitiesInComplianceWithWastewaterStandards(IEnumerable<SupplierFacilityData> supplierFacilityData)
            {
                // Compte le nombre d'installations de fournisseurs conformes
                int numberOfInComplianceFacilities = 0;
                foreach (var supplierFacility in supplierFacilityData)
                {
                    if (supplierFacility.InCompliance)
                    {
                        numberOfInComplianceFacilities++;
                    }
                }

                // Compte le nombre total d'installations de fournisseurs
                int numberOfFacilities = supplierFacilityData.Count();

                // Calcule le pourcentage
                return numberOfInComplianceFacilities / (double)numberOfFacilities;
            }

            public class EnvironmentalImpactsInTheSupplyChain
            {
                public static double PercentageOfTier1InCompliance(int numberOfTier1SupplierFacilitiesInCompliance, int totalNumberOfTier1SupplierFacilities)
                {
                    return numberOfTier1SupplierFacilitiesInCompliance / (double)totalNumberOfTier1SupplierFacilities;
                }

                public static double PercentageOfBeyondTier1InCompliance(int numberOfSupplierFacilitiesBeyondTier1InCompliance, int totalNumberOfSupplierFacilitiesBeyondTier1)
                {
                    return numberOfSupplierFacilitiesBeyondTier1InCompliance / (double)totalNumberOfSupplierFacilitiesBeyondTier1;
                }

                public static double CalculatePercentage(int numberOfInComplianceFacilities, int numberOfFacilities)
                {
                    return numberOfInComplianceFacilities / (double)numberOfFacilities;
                }
            }
        }
    }

    public static class ESGMetricsCalculator
    {
        public static double CalculateVerySevereControversiesPercentage(double[] weights, int[] verySevereControversiesFactors)
        {
            double numerator = 0;
            double denominator = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                numerator += weights[i] * verySevereControversiesFactors[i];
                denominator += weights[i];
            }

            return numerator / denominator;
        }

        public static double CalculateEnvironmentalPillarScore(double[] weights, double[] environmentalPillarWeights, double[] environmentalPillarScores)
        {
            double numerator = 0;
            double denominator = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                numerator += weights[i] * environmentalPillarWeights[i] * environmentalPillarScores[i];
                denominator += weights[i] * environmentalPillarWeights[i];
            }

            return numerator / denominator;
        }
    }
    public static double CalculateSocialPillarScoreDistribution(double[] weights, double[] socialPillarWeights, double[] socialPillarScores, int socialPillarScoreRange)
    {
        double numerator = 0;
        double denominator = 0;

        for (int i = 0; i < weights.Length; i++)
        {
            if (socialPillarScores[i] >= socialPillarScoreRange && socialPillarScores[i] < socialPillarScoreRange + 1)
            {
                numerator += weights[i] * socialPillarWeights[i];
                denominator += weights[i] * socialPillarWeights[i];
            }
        }

        return numerator / denominator;
    }

    public static double CalculateControversialWeaponsPercentage(double[] weights, int[] controversialWeaponsFactors)
    {
        double numerator = 0;
        double denominator = 0;

        for (int i = 0; i < weights.Length; i++)
        {
            numerator += weights[i] * controversialWeaponsFactors[i];
            denominator += weights[i];
        }

        return numerator / denominator;
    }

    static Dictionary<string, double> CalculateESGRatingDistribution(List<double> weights, List<string> ESGRatings, List<int> IVA_COMPANY_RATING)
    {
        // Créer un dictionnaire pour stocker la distribution
        Dictionary<string, double> distribution = new Dictionary<string, double>();

        // Récupérer la liste distincte des notations ESG
        var distinctESGRatings = ESGRatings.Distinct().ToList();

        // Calculer le dénominateur (Σ(Weighti))
        double denominator = weights.Sum();

        // Parcourir les notations ESG distinctes
        /*  foreach (var ESGRating in distinctESGRatings)
          {
              // Calculer le numérateur (Σ(Weighti * ESG Rating Factori,k))
              double numerator = 0.0;
              for (int i = 0; i < weights.Count; i++)
              {
                  if (IVA_COMPANY_RATING[i] == ESGRating)
                  {
                      numerator += weights[i];
                  }
              }

              // Calculer la distribution pour cette notation ESG
              double ESGRatingDistribution = numerator / denominator;

              // Ajouter la distribution au dictionnaire
              distribution[ESGRating] = ESGRatingDistribution;
          }*/

        return distribution;
    }
}

}
