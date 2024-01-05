# Create your views here.
from django.shortcuts import render
from django.http import HttpResponse
from serializer import Serializer
from .models import ESGSectorMetric  # Assurez-vous d'ajuster le chemin d'importation en fonction de votre structure de projet

def render_metrics(request):
    # Charger l'instance désérialisée à partir du fichier
    serializer = Serializer()
    deserialized_sector = serializer.deserialize('serialized_sector.pkl')

    # Rendre les données disponibles dans le template
    context = {'sector': deserialized_sector}
    return render(request, 'metrics_template.html', context)
