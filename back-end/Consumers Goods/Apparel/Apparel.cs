public static ESGMetricsSet GetConsumersGoodsMetrics()
{
    var metricsSet = new ESGMetricsSet
    {
        Industry = "Consumers Goods",

        AapparelAccessoriesAndFootWearStandardMetrics = new List<ESGMetricAapparelAccessoriesAndFootWearStandardMetrics>,

        ApplicanceManufacturingStandarMetrics = new List<ESGMetricApplicanceManufacturingStandarMetrics>,

        BuildingProductsAndFurnishingsStandarMetrics = new List<ESGMetricBuildingProductsAndFurnishingsStandarMetrics>,

        EcommerceStandarMetrics = new Lsit<ESGMetricEcommerceStandarMetrics>,

        HouseHoldAndPersonalProductsStandardMetrics = new List<ESGMetricHouseHoldAndPersonalProductsStandardMetrics>,

        MultilineAndSpecialtyRetailerAndDistributorStandardMetrics = new List<ESGMetricMultilineAndSpecialtyRetailerAndDistributorStandardMetrics>,

        ToysandSportingGoodsStandardMetrics = new List<ESGMetricToysandSportingGoodsStandardMetrics>,

        {
            new ESGMetricAapparelAccessoriesAndFootWearStandardMetrics
            {
                Topic = "Management of Chemicals in Products",
                MetricDescription = "Discussion of processes to maintain compliance with restricted substances regulations",
                Category = "Discussion and Analysis",
                UnitOfMeasure = "n/a",
                Code = "CG-AA-250a.1"
            },
            new ESGMetricAapparelAccessoriesAndFootWearStandardMetrics
            {
                Topic = "Management of Chemicals in Products",
                MetricDescription = "Discussion of processes to assess and manage risks and/or hazards associated with chemicals in products",
                Category = "Discussion and Analysis",
                UnitOfMeasure = "n/a",
                Code = "CG-AA-250a.2"²
            },
            new ESGMetricAapparelAccessoriesAndFootWearStandardMetrics
            {
                Topic = "Environmental Impacts in the Supply Chain",
                MetricDescription = "Percentage of (1) Tier 1 supplier facilities and (2) supplier facilities beyond Tier 1 in compliance with wastewater discharge permits and/or contractual agreement1",
                Category = "Quantitative",
                UnitOfMeasure = "Percentage (%)",
                Code = "CG-AA-430a.1"
            },
            new ESGMetricAapparelAccessoriesAndFootWearStandardMetrics
            {
                Topic = "Environmental Impacts in the Supply Chain",
                MetricDescription = "Percentage of (1) Tier 1 supplier facilities and (2) supplier facilities beyond Tier 1 that have completed the Sustainable Apparel Coalition’s Higg Facility Environmental Module (Higg FEM) assessment or an equivalent environmental data assessment",
                Category = "Quantitative",
                UnitOfMeasure = "Percentage (%)",
                Code = "CG-AA-430a.2"
            },
            new ESGMetricAapparelAccessoriesAndFootWearStandardMetrics
             {
                Topic = "Labour Conditions in the Supply Chain",
                MetricDescription = "Percentage of (1) Tier 1 supplier facilities and (2) supplier facilities beyond Tier 1 that have completed the Sustainable Apparel Coalition’s Higg Facility Environmental Module (Higg FEM) assessment or an equivalent environmental data assessment",
                Category = "Quantitative",
                UnitOfMeasure = "Percentage (%)",
                Code = "CG-AA-430b.1"
            },
            new ESGMetricAapparelAccessoriesAndFootWearStandardMetrics
             {
                Topic = "Labour Conditions in the Supply Chain",
                MetricDescription = "Priority non-conformance rate and associated corrective action rate for suppliers’ labour code of conduct audits",
                Category = "Quantitative",
                UnitOfMeasure = "Rate ",
                Code = "CG-AA-430b.2"
            },
            new ESGMetricAapparelAccessoriesAndFootWearStandardMetrics
            {
                Topic = "Labour Conditions in the Supply Chain",
                MetricDescription = "Description of the greatest (1) labour and (2) environmental, health, and safety risks in the supply chain",
                Category = "Quantitative",
                UnitOfMeasure = "Discussion and Analysis ",
                Code = "CG-AA-430b.3"
            },
            new ESGMetricAapparelAccessoriesAndFootWearStandardMetrics
             {
                Topic = "Raw Materials Sourcing",
                MetricDescription =" (1) List of priority raw materials; for each priority raw material: (2) environmental or social factor(s) most likely to threaten sourcing, (3) discussion on business risks or opportunities associated with environmental or social factors and (4) management strategy for addressing business risks and opportunities",
                Category = "Discussion and Analysis",
                UnitOfMeasure = "n/a",
                Code = "CG-AA-440a.3"
            },
            new ESGMetricAapparelAccessoriesAndFootWearStandardMetrics
            {
                Topic = "Raw Materials Sourcing",
                MetricDescription =" (1) Amount of priority raw materials purchased, by material, and (2) amount of each priority raw material that is certified to a third-party environmental or social standard,by standard",
                Category = "Metrics ton(t)",
                UnitOfMeasure = "n/a",
                Code = "CG-AA-440a.4"
            },
            new ESGMetricApplicanceManufacturingStandarMetrics
            {
                Topic = "Product Safety",
                MetricDescription = "Number of (1) recalls issued and (2) total units recalled1",
                Category = "Quantitative",
                UnitOfMeasure = "Number",
                Code = "CG-AM-250a.1"
            },
            new ESGMetricApplicanceManufacturingStandarMetrics
            {
                Topic = "Product Safety",
                MetricDescription = "Discussion of process to identify and manage\r\nsafety risks associated with the use of its\r\nproducts",
                Category = "Discussion and Analysis",
                UnitOfMeasure = "n/a",
                Code = "CG-AM-250a.2"
            },
            new ESGMetricApplicanceManufacturingStandarMetrics
            {
                Topic = "Product Safety",
                MetricDescription = "Discussion of process to identify and manage safety risks associated with the use of its products",
                Category = "Discussion and Analysis",
                UnitOfMeasure = "n/a",
                Code = "CG-AM-250a.2"
            },
            new ESGMetricApplicanceManufacturingStandarMetrics
            {
                Topic = "Product Safety",
                MetricDescription = "Total amount of monetary losses as a result of\r\nlegal proceedings associated with product\r\nsafety",
                Category = "Quantitative",
                UnitOfMeasure = "Presentation currency",
                Code = "CG-AM-250a.3"
            },
            new ESGMetricApplicanceManufacturingStandarMetrics
            {
                Topic = "Environmental Impacts in the Supply Chain",
                MetricDescription = "Percentage of (1) Tier 1 supplier facilities and (2) supplier facilities beyond Tier 1 that have completed the Sustainable Apparel Coalition’s Higg Facility Environmental Module (Higg FEM) assessment or an equivalent environmental data assessment",
                Category = "Quantitative",
                UnitOfMeasure = "Percentage (%) by revenue",
                Code = "CG-AM-410a.1"
            },
            new ESGMetricApplicanceManufacturingStandarMetrics
            {
                Topic = "Labour Conditions in the Supply Chain",
                MetricDescription = " Percentage of (1) Tier 1 supplier facilities and (2) supplier facilities beyond Tier 1 that have\r\nbeen audited to a labour code of conduct, (3)percentage of total audits conducted by a third-party auditor",
                Category = "Quantitative",
                UnitOfMeasure = "Percentage (%) by revenue",
                Code = "CG-AM-410a.2"
            },
            new ESGMetricApplicanceManufacturingStandarMetrics
            {
                Topic = "Labour Conditions in the Supply Chain",
                MetricDescription = " Priority non-conformance rate and associated corrective action rate for suppliers’ labour code of conduct audits",
                Category = "Discussion and Analysis",
                UnitOfMeasure = "n/a",
                Code = "CG-AM-410a.3"
            },
            new ESGMetricBuildingProductsAndFurnishingsStandarMetrics
            {
                Topic = "Energy Management in Manufacturing",
                MetricDescription = " (1) Total energy consumed, (2) percentage grid electricity and (3) percentage renewable",
                Category = "Quantitative",
                UnitOfMeasure = "Gigajoules (GJ),Percentage (%)",
                Code = "CG-BF-130a.1"
            },
            new ESGMetricBuildingProductsAndFurnishingsStandarMetrics
            {
                Topic = "Management of Chemicals in Products",
                MetricDescription = " Discussion of processes to assess and manage\r\nrisks and/or hazards associated with chemicals in products",
                Category = "Discussion and Analysis",
                UnitOfMeasure = "n/a",
                Code = "CG-BF-250a.1"
            },
            new ESGMetricBuildingProductsAndFurnishingsStandarMetrics
            {
                Topic = "Management of Chemicals in Products",
                MetricDescription = "Percentage of eligible products meeting volatile organic compound (VOC) emissions and content standards",
                Category = "Quantitative",
                UnitOfMeasure = "Percentage (%) by revenue",
                Code = "CG-BF-250a.2"
            },
            new ESGMetricBuildingProductsAndFurnishingsStandarMetrics
            {
                Topic = "Product Lifecycle Environmental Impacts",
                MetricDescription = "Description of efforts to manage product lifecycle impacts and meet demand for sustainable products",
                Category = "Quantitative",
                UnitOfMeasure = "Percentage (%)",
                Code = "CG-BF-410a.1"
            },
            new ESGMetricBuildingProductsAndFurnishingsStandarMetrics
            {
                Topic = "Product Lifecycle Environmental Impacts",
                MetricDescription = "(1) Weight of end-of-life material recovered,(2) percentage of recovered materials recycled",
                Category = "Quantitative",
                UnitOfMeasure = "Percentage (%)",
                Code = "CG-BF-410a.2"
            },
            new ESGMetricBuildingProductsAndFurnishingsStandarMetrics
            {
                Topic = "Wood Supply Chain Management",
                MetricDescription = "(1) Total weight of wood fibre materials purchased, (2) percentage from third-party certified forestlands, (3) percentage by standard and (4) percentage certified to other wood fibre standards, (5) percentage by standard1",
                Category = "Quantitative",
                UnitOfMeasure = " Metric tons (t), Percentage (%) by weight",
                Code = "CG-BF-430a.1"
            },
            new ESGMetricBuildingProductsAndFurnishingsStandarMetrics
            {
                Topic = "Annual production",
                Category = "Quantitative",
                UnitOfMeasure = " See note",
                Code = "CG-AA-440a.3"
            },
            new ESGMetricBuildingProductsAndFurnishingsStandarMetrics
            {
                Topic = "Area of manufacturing facilities",
                Category = "Quantitative",
                UnitOfMeasure = "Square metres (m²)",
                Code = "CG-BF-000.B"
            },
            new ESGMetricBuildingProductsAndFurnishingsStandarMetrics
            {
                Topic = "Area of manufacturing facilities",
                Category = "Quantitative",
                UnitOfMeasure = "Square metres (m²)",
                Code = "CG-BF-000.B"
            },
            new ESGMetricEcommerceStandarMetrics
            {
                Topic = "Hardware Infrastructure Energy & Water Management",
                MetricDescription = "(1) Total energy consumed, (2) percentage grid electricity and (3) percentage renewable",
                Category = "Quantitative",
                UnitOfMeasure = " Gigajoules (GJ), Percentage (%)",
                Code = "CG-EC-130a.1"
            },
            new ESGMetricEcommerceStandarMetrics
            {
                Topic = "Hardware Infrastructure Energy & Water Management",
                MetricDescription = "(1) Total water withdrawn, (2) total water consumed; percentage of each in regions with High or Extremely High Baseline Water\r\nStress",
                Category = "Quantitative",
                UnitOfMeasure = "Thousand cubic metres (m³),Percentage (%)",
                Code = "CG-EC-130a.2"
            },
            new ESGMetricEcommerceStandarMetrics
            {
                Topic = " Hardware Infrastructure Energy & Water Management",
                MetricDescription = "Discussion of the integration of environmental considerations into strategic planning for data centre needs",
                Category = "Discussion and Analysis",
                UnitOfMeasure = "n/a",
                Code = "CG-EC-130a.3"
            },
            new ESGMetricEcommerceStandarMetrics
            {
                Topic = " Data Privacy & Advertising Standardst",
                MetricDescription = "Number of users whose information is used for secondary purposes",
                Category = "Quantitative",
                UnitOfMeasure = "Number",
                Code = "CG-EC-220a.1"
            },
            new ESGMetricEcommerceStandarMetrics
            {
                Topic = " Data Privacy & Advertising Standardst",
                MetricDescription = "Description of policies and practices relating to behavioural advertising and user privacy",
                Category = "Discussion and Analysis",
                UnitOfMeasure = "n/a",
                Code = "CG-EC-220a.2"
            },
            new ESGMetricEcommerceStandarMetrics
            {
                Topic = "Data Security",
                MetricDescription = "Priority non-conformance rate and associated corrective action rate for suppliers’ labour code of conduct audits",
                Category = "Quantitative",
                UnitOfMeasure = "n/a",
                Code = "CG-EC-230a.1"
            },
            new ESGMetricEcommerceStandarMetrics
            {
                Topic = "Data Security",
                MetricDescription = "Description of the greatest (1) labour and (2) environmental, health, and safety risks in the supply chain",
                Category = "Quantitative",
                UnitOfMeasure = "Number,Percentage (%)",
                Code = "CG-EC-230a.2"
            },
            new ESGMetricEcommerceStandarMetrics
            {
                Topic = "Employee Recruitment, Inclusion & Performance",
                MetricDescription = "Employee engagement as a percentage",
                Category = "Quantitative",
                UnitOfMeasure = "Percentage (%)",
                Code = "CG-EC-330a.1"
            },
            new ESGMetricEcommerceStandarMetrics
            {
                Topic = "Employee Recruitment, Inclusion & Performance",
                MetricDescription = "(1) Voluntary and (2) involuntary turnover rate for all employees",
                Category = "Quantitative ",
                UnitOfMeasure = "Rate",
                Code = "CG-EC-330a.2"
            },

        }
    }
         
    };

    return metricsSet;
}
