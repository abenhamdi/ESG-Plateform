using System;
using System.Collections.Generic;
using System.Linq;

class Metrics
{
    static void Main()
    {
        // Supposons que vous ayez déjà les données nécessaires dans les listes suivantes :
        List<double> Weight = new List<double>(); // Liste des poids
        List<string> ESGRating = new List<string>(); // Liste des notations ESG
        List<int> IVA_COMPANY_RATING = new List<int>(); // Liste des notations ESG attribuées aux entreprises, ajouter les listes des attributs

        // Remplissez ces listes avec les données appropriées

        // Calcul de la distribution de la notation ESG
        //Dictionary<string, double> ESGRatingDistribution = CalculateESGRatingDistribution(Weight, ESGRating, IVA_COMPANY_RATING);

        // Affichage des résultats
        /*foreach (var kvp in ESGRatingDistribution)
        {
            Console.WriteLine($"ESG Rating {kvp.Key}: {kvp.Value}");
        }*/
    }
    public class ESGMetricsCalculator
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

        public static double CalculateEnvironmentalPillarScoreDistribution(double[] weights, double[] environmentalPillarWeights, double[] environmentalPillarScores, int environmentalPillarScoreRange)
        {
            double numerator = 0;
            double denominator = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                if (environmentalPillarScores[i] >= environmentalPillarScoreRange && environmentalPillarScores[i] < environmentalPillarScoreRange + 1)
                {
                    numerator += weights[i] * environmentalPillarWeights[i];
                    denominator += weights[i] * environmentalPillarWeights[i];
                }
            }

            return numerator / denominator;
        }

        public static double CalculatePhysicalRiskClimateVaRPercentage(double[] weights, double[] physicalRiskClimateVaRs)
        {
            double numerator = 0;
            double denominator = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                numerator += weights[i] * physicalRiskClimateVaRs[i];
                denominator += weights[i];
            }

            return numerator / denominator;
        }

        public static double CalculateBrownSectorExposurePercentage(double[] weights, int[] brownSectorFactors)
        {
            double numerator = 0;
            double denominator = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                numerator += weights[i] * brownSectorFactors[i];
                denominator += weights[i];
            }

            return numerator / denominator;
        }

        public static double CalculateCarbonIntensity(double[] weights, double[] carbonEmissionsScope12s, double[] evics)
        {
            double numerator = 0;
            double denominator = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                numerator += weights[i] * carbonEmissionsScope12s[i] / evics[i];
                denominator += weights[i];
            }

            return numerator / denominator;
        }

        public static double CalculateReportedEmissionsPercentage(double[] weights, int[] reportedEmissionsFactors)
        {
            double numerator = 0;
            double denominator = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                numerator += weights[i] * reportedEmissionsFactors[i];
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