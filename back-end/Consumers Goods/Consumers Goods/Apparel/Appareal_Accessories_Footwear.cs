using System;

namespace Apparel_Accessories_Footwear
{
    public interface IESGMetric
    {
        string Topic { get; }
        string MetricDescription { get; set; }
        ESGCategory Category { get; set; }
        string UnitOfMeasure { get; set; }
        float? Measure { get; set; }
        string Code { get; set; }

        bool ValidateMetric();
    }

    public abstract class BaseESGMetric : IESGMetric
    {
        public string Topic { get; protected set; }
        public string MetricDescription { get; set; }
        public ESGCategory Category { get; set; }
        public string UnitOfMeasure { get; set; }
        public float? Measure { get; set; }
        public string Code { get; set; }

        public bool ValidateMetric()
        {
            if (string.IsNullOrEmpty(Topic) || string.IsNullOrEmpty(Code))
            {
                LogError("Error: Topic or code not found.");
                return false;
            }

            return ValidateESGMetric();
        }

        protected abstract bool ValidateESGMetric();

        protected void LogError(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ESGMetricApparelAccessoriesAndFootwear : BaseESGMetric
    {
        public ESGMetricApparelAccessoriesAndFootwear()
        {
            Topic = "Apparel Accessories and Footwear";
        }

        protected override bool ValidateESGMetric()
        {
            return ValidateChemicalsInProducts()
                && ValidateEnvironmentalImpactsInSupplyChain()
                && ValidateLabourConditionsInSupplyChain()
                && ValidateRawMaterialsSourcing();
        }

        private bool ValidateChemicalsInProducts()
        {
            return !string.IsNullOrEmpty(this.MetricDescription);
        }

        private bool ValidateEnvironmentalImpactsInSupplyChain()
        {
            return this.Measure.HasValue;
        }

        private bool ValidateLabourConditionsInSupplyChain()
        {
            return !string.IsNullOrEmpty(this.MetricDescription);
        }

        private bool ValidateRawMaterialsSourcing()
        {
            return !string.IsNullOrEmpty(this.MetricDescription);
        }
    }

    // Les autres classes de métriques suivent le même modèle...

    public class ESGMetricEcommerce : BaseESGMetric
    {
        public ESGMetricEcommerce()
        {
            Topic = "Ecommerce";
        }

        protected override bool ValidateESGMetric()
        {
            // Logique de validation spécifique pour Ecommerce
            return true; // Placeholder pour la logique réelle
        }
    }

    // ... Autres classes ici ...

    public class ESGMetricsSet
    {
        public bool ValidateMetrics(IESGMetric metric)
        {
            return metric.ValidateMetric();
        }
    }

    public enum CategoryType
    {
        DiscussionAndAnalysis,
        Quantitative
    }

    public class ESGCategory
    {
        public CategoryType Type { get; set; }
    }
}
