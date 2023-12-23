# Importing necessary libraries
from abc import ABC, abstractmethod
from collections import namedtuple

class IESGMetric(ABC):
    @abstractmethod
    def calculate(self, *args, **kwargs):
        pass
# Base class to handle common functionalities
class BaseESGMetric(IESGMetric):
    def __init__(self, code, topic, metric_desc,isQuantitative, units):
        self._code = code
        self._topic = topic
        self._metric_desc = metric_desc
        self._units = units
        self._isQuantitative = isQuantitative

    @property
    def name_doc(self): 
        self._name_doc
    
    @property
    def topics(self):
        return self._topics

    @property
    def metric_descriptions(self):
        return self._metric_descriptions

    @metric_descriptions.setter
    def metric_description(self, value):
        self._metric_descriptions = value

    @property
    def category(self):
        return self._category_set

    @category.setter
    def category(self, value):
        self._category_set = value
  
    @property
    def units_of_measure(self):
        return self._units_of_measure

    @units_of_measure.setter
    def unit_of_measure(self, value):
        self._unit_of_measure = value

    @property
    def measures(self):
        return self._measures

    @measures.setter
    def measure(self, value):
        self._measure = value

    @property
    def codes(self):
        return self._codes

    @codes.setter
    def code(self, value):
        self._code = value

    def validate_metric(self):
        return all(v is not None for v in [self._codes, self.topics, self.metric_descriptions, self._category_set, self._units_of_measure])

# Implementing classes with specific topics
class Metric(self, BaseESGMetric[]){
    self._topics= _topics
    self._codes= _codes
    self._metric_descs= _metric_descs
    self._units= _units
    
}
class ESGMetricApparelAccessoriesAndFootwear(BaseESGMetric):
    def __init__(self):
        super().__init__("Apparel Accessories And Footwear",
                         ["Management of Chemicals in Products", "topic2"],
                         ["[CG-AA-250a.1;CG-AA-250a.2] ", "code2"], 
                         ["[""]", "metric_description2"], 
                         ["unit1", "unit2"] )
        
class ESGMetricApplianceManufacturing(BaseESGMetric):
    def __init__(self):
        super().__init__("Appliance Manufacturing")

# Similar implementations for other classes...
class ESGMetricApplianceManufacturing(BaseESGMetric):
    def __init__(self):
        super().__init__("Appliance Manufacturing")
        self.category ={"Quantitative": True}
# Implementing the ESGMetricBuildingProductsAndFurnishings class
class ESGMetricBuildingProductsAndFurnishings(BaseESGMetric):
    def __init__(self):
        super().__init__("Building Products And Furnishings")

# Implementing the ESGMetricEcommerce class
class ESGMetricEcommerce(BaseESGMetric):
    def __init__(self):
        super().__init__("E-commerce")

# Implementing the ESGMetricHouseholdAndPersonalProducts class
class ESGMetricHouseholdAndPersonalProducts(BaseESGMetric):
    def __init__(self):
      super().__init__("Household And Personal Products")

# Implementing the ESGMetricMultilineAndSpecialtyRetailersAndDistributors class
class ESGMetricMultilineAndSpecialtyRetailersAndDistributors(BaseESGMetric):
    def __init__(self):
        super().__init__("Multiline And Specialty Retailers And Distributors")

# Implementing the ESGMetrictoysAndSportingGoods class
class ESGMetrictoysAndSportingGoods(BaseESGMetric):
    def __init__(self):
        super().__init__("Toys And Sporting Goods")