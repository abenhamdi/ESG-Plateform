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
        return (
            f"URI: {self._uri}\n"
            f"Name: {self._name}\n"
            f"User: {self._user}\n"
            f"Timezone: {self._timezone}\n"
            f"Rules: {self._rules}\n"
        )
    
class CalendlyAvailabilitySchedule(BaseESGMetric):
    def __init__(self, calendars=None):
        self._calendars = calendars if calendars else []

    def add_calendar(self, calendar):
        self._calendars.append(calendar)

    def to_string1(self):
        return f"Calendars: {', '.join(calendar.to_string() for calendar in self._calendars)}"

# Exemple d'utilisation de la classe CalendlyAvailabilitySchedule avec deux calendriers
calendly_schedule = CalendlyAvailabilitySchedule()
calendly_schedule.add_calendar(
    CalendlyAvailabilityCalendar(
        uri='https://api.calendly.com/user_availability_schedule/abc123',
        name='Working Hours',
        user='https://api.calendly.com/users/abc123',
        timezone='America/New_York',
        rules=[
            {"type": "wday", "intervals": [{"from": "08:30", "to": "17:00"}], "wday": "monday"},
            {"type": "wday", "intervals": [{"from": "08:30", "to": "17:00"}], "wday": "tuesday"},
            {"type": "wday", "intervals": [], "wday": "wednesday"},
            {"type": "wday", "intervals": [{"from": "08:30", "to": "17:00"}], "wday": "thursday"},
            {"type": "wday", "intervals": [{"from": "08:30", "to": "17:00"}], "wday": "friday"},
            {"type": "wday", "intervals": [], "wday": "saturday"},
            {"type": "date", "intervals": [{"from": "08:30", "to": "09:30"}], "date": "2028-12-31"}
        ]
    )
)

calendly_schedule.add_calendar(
    CalendlyAvailabilityCalendar(
        uri='https://api.calendly.com/user_availability_schedule/xyz456',
        name='Weekend Hours',
        user='https://api.calendly.com/users/xyz456',
        timezone='America/New_York',
        rules=[
            {"type": "wday", "intervals": [{"from": "10:00", "to": "16:00"}], "wday": "saturday"},
            {"type": "wday", "intervals": [{"from": "12:00", "to": "18:00"}], "wday": "sunday"}
        ]
    )
)

class BaseESGMetric(IESGMetric):
    def __init__(self,name_doc, topic, code, metric_desc, isQuantitative, units):
        self.name_doc= name_doc
        self._topic = topic
        self._code = code
        self._metric_desc = metric_desc
        self._isQuantitative = isQuantitative
        self._units = units
        

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

#Implementer fonction isQuantitative quand active activefctTakeappoinment() à connecter avec Calendly

def activeTakeAppointement():
    pass

def isQuantitative(self, *args, **kwargs):
    isQuantitative= True
    for arg in args:
        if arg == False:
            isQuantitative = False
            set.unit_of_measure = ValueError

# A Paramtrer tard plus
    def calculate(self, args, **kwargs):
        result = ""
        for arg in kwargs.values():
            result += arg
        pass

    def to_string(self):
        return f"Sector: {self._sector_name}\nMetrics:\n{', '.join(metric.to_string() for metric in self._metrics)}\n"

# Exemple de classe dérivée pour un secteur spécifique
class ESGMetricApparelAccessoriesAndFootwear(BaseESGMetric):
    def __init__(self):
        super().__init__("Apparel Accessories And Footwear",
                         ["Management of Chemicals in Products", "Environmental Impacts in the Supply Chain", "Labour Conditions in the Supply Chain", "Raw Materials Sourcing"],
                         ["[CG-AA-250a.1;CG-AA-250a.2]", "[CG-AA-250a.1;CG-AA-250a.2]"],
                         ["[Discussion of processes to maintain compliance with restricted substances regulations; Discussion of processes to assess and manage risks and/or hazards associated with chemicals in products] ", "[Percentage of (1) Tier 1 supplier facilities and(2) supplier facilities beyond Tier 1 in compliance with waste water discharge permits and/or contractual agreement1 ; "" Percentage of (1) Tier 1 supplier facilities and 2 supplier facilities beyond Tier 1 that havecompleted the Sustainable Apparel Coalition’sHigg Facility Environmental Module Higg FEM assessment or an equivalent environmentaldata assessment"]","[ "Percentage of (1) Tier 1 supplier facilities and (2) supplier facilities beyond Tier 1 that havebeen audited to a labour code of conduct, (3)percentage of total audits conducted by athird-party audito"; "Priority non-conformance rate and associated corrective action rate for suppliers’ labourcode of conduct audits2 "; " Description of the greatest (1) labour and (2) environmental, health, and safety risks in thesupply chain"]","[ " (1) List of priority raw materials; for each priority raw material: (2) environmental or social factor(s) most likely to threaten sourcing, (3) discussion on business risks or opportunities associated with environmentalor social factors and (4) management strategyfor addressing business risks and opportunities" ; " (1) Amount of priority raw materials purchased, by material, and (2) amount ofeach priority raw material that is certified to athird-party environmental or social standard, by standard"],
                         [ [isQuantitative ;   , ],
                         [ , "unit2"])

class ESGMetricApplianceManufacturing(BaseESGMetric):
    def __init__(self):
        super().__init__("Appliance Manufacturing",
                         ["Management of Chemicals in Products", "topic2"],
                         ["[CG-AA-250a.1;CG-AA-250a.2]", "code2"],
                         ["metric_description1", "metric_description2"],
                         ["unit1", "unit2"])
        
class ESGMetricBuildingProductsAndFurnishings(BaseESGMetric):
    def __init__(self):
        super().__init__("Building Products And Furnishings",
                         ["Management of Chemicals in Products", "topic2"],
                         ["[CG-AA-250a.1;CG-AA-250a.2]", "code2"],
                         ["metric_description1", "metric_description2"],
                         ["unit1", "unit2"])

# Implementing the ESGMetricEcommerce class
class ESGMetricEcommerce(BaseESGMetric):
    def __init__(self):
        super().__init__("E-commerce",
                         ["Management of Chemicals in Products", "topic2"],
                         ["[CG-AA-250a.1;CG-AA-250a.2]", "code2"],
                         ["metric_description1", "metric_description2"],
                         ["unit1", "unit2"])

# Implementing the ESGMetricHouseholdAndPersonalProducts class
class ESGMetricHouseholdAndPersonalProducts(BaseESGMetric):
    def __init__(self):
      super().__init__("Household And Personal Products",
                       ["Management of Chemicals in Products", "topic2"],
                         ["[CG-AA-250a.1;CG-AA-250a.2]", "code2"],
                         ["metric_description1", "metric_description2"],
                         ["unit1", "unit2"])

# Implementing the ESGMetricMultilineAndSpecialtyRetailersAndDistributors class
class ESGMetricMultilineAndSpecialtyRetailersAndDistributors(BaseESGMetric):
    def __init__(self):
        super().__init__("Multiline And Specialty Retailers And Distributors",
                         ["Management of Chemicals in Products", "topic2"],
                         ["[CG-AA-250a.1;CG-AA-250a.2]", "code2"],
                         ["metric_description1", "metric_description2"],
                         ["unit1", "unit2"])

# Implementing the ESGMetrictoysAndSportingGoods class
class ESGMetrictoysAndSportingGoods(BaseESGMetric):
    def __init__(self):
        super().__init__("Toys And Sporting Goods",
                         ["Management of Chemicals in Products", "topic2"],
                         ["[CG-AA-250a.1;CG-AA-250a.2]", "code2"],
                         ["metric_description1", "metric_description2"],
                         ["unit1", "unit2"])
        
# Création d'une instance de la super classe pour le secteur "Consumers Goods"
consumer_goods_sector = ESGSectorMetric("Consumers Goods", [
    ESGMetricApparelAccessoriesAndFootwear(),
    ESGMetricApplianceManufacturing(), 
    ESGMetricBuildingProductsAndFurnishings(),
    ESGMetricEcommerce(),
    ESGMetricHouseholdAndPersonalProducts(),
    ESGMetricMultilineAndSpecialtyRetailersAndDistributors(),
    ESGMetrictoysAndSportingGoods()
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
serializer.serialize(calendly_schedule, 'serialized_calendly_schedule.pkl')

# Désérialiser l'instance à partir du fichier
#deserialized_sector = serializer.deserialize('serialized_sector.pkl')

print(f"Les documents ont été générés : {pdf_path}, {docx_path}")