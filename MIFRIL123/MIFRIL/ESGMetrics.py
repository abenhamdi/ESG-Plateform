import os
from docx import Document
from reportlab.lib.pagesizes import letter
from reportlab.pdfgen import canvas
from serializer import Serializer
import json

# Constantes pour les chemins des fichiers de sortie
PDF_PATH = "metrics.pdf"
DOCX_PATH = "metrics.docx"

class IESGMetric:
    def calculate(self, *args, **kwargs):
        pass

    def to_string(self):
        pass

class BaseESGMetric(IESGMetric):
    def __init__(self, code, topic, metric_desc, isQuantitative, units):
        self._code = code
        self._topic = topic
        self._metric_desc = metric_desc
        self._units = units
        self._isQuantitative = isQuantitative

    def to_string(self):
        return f"Code: {self._code}\nTopic: {', '.join(self._topic)}\nDescription: {', '.join(self._metric_desc)}\nQuantitative: {self._isQuantitative}\nUnits: {', '.join(self._units)}\n"

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
        return all(v is not None for v in [self._code, self._topic, self._metric_desc, self._category_set, self._units_of_measure])
    
class ESGSectorMetric(IESGMetric):
    def __init__(self, sector_name, metrics=None):
        self._sector_name = sector_name
        self._metrics = metrics if metrics else []

    def add_metric(self, metric):
        self._metrics.append(metric)

    def calculate(self, *args, **kwargs):
        # Implémentez la logique pour calculer les métriques spécifiques au secteur
        pass

    def to_string(self):
        return f"Sector: {self._sector_name}\nMetrics:\n{', '.join(metric.to_string() for metric in self._metrics)}\n"

# Exemple de classe dérivée pour un secteur spécifique
class ESGMetricApparelAccessoriesAndFootwear(BaseESGMetric):
    def __init__(self):
        super().__init__("Apparel Accessories And Footwear",
                         ["Management of Chemicals in Products", "topic2"],
                         ["[CG-AA-250a.1;CG-AA-250a.2]", "code2"],
                         ["metric_description1", "metric_description2"],
                         ["unit1", "unit2"])

class ESGMetricApplianceManufacturing(BaseESGMetric):
    def __init__(self):
        super().__init__("Appliance Manufacturing")
        
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
        
# Création d'une instance de la super classe pour le secteur "Consumers Goods"
consumer_goods_sector = ESGSectorMetric("Consumers Goods", [
    ESGMetricApparelAccessoriesAndFootwear(),
    ESGMetricApplianceManufacturing()
])

# Générer le document PDF
pdf_path = PDF_PATH
pdf_canvas = canvas.Canvas(pdf_path, pagesize=letter)
pdf_canvas.drawString(72, 800, consumer_goods_sector.to_string())
pdf_canvas.save()

# Générer le document Word
docx_path = DOCX_PATH
doc = Document()
doc.add_paragraph(consumer_goods_sector.to_string())
doc.save(docx_path)

# Sérialiser l'instance et sauvegarder dans un fichier
serializer = Serializer()
serializer.serialize(consumer_goods_sector, 'serialized_sector.pkl')

# Désérialiser l'instance à partir du fichier
#deserialized_sector = serializer.deserialize('serialized_sector.pkl')

print(f"Les documents ont été générés : {pdf_path}, {docx_path}")