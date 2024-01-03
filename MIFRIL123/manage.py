#!/usr/bin/env python
"""Django's command-line utility for administrative tasks."""
import os
import sys
from django.core.management import execute_from_command_line
from django.http import JsonResponse
from serializer import Serializer

def main():
    """Run administrative tasks."""
    os.environ.setdefault('DJANGO_SETTINGS_MODULE', 'config.settings')

    try:
        from django.core.management import execute_from_command_line
        if len(sys.argv) > 1 and sys.argv[1] == 'render_data':
            # Si la commande est "render_data", exécute la fonction correspondante
            render_data()
        else:
            execute_from_command_line(sys.argv)
    except ImportError as exc:
        raise ImportError(
            "Couldn't import Django. Are you sure it's installed and ",
            "available on your PYTHONPATH environment variable? Did you ",
            "forget to activate a virtual environment?"
        ) from exc

def render_data():
    # Chemin vers le fichier sérialisé par serializer.py
    serialized_file_path = 'path/to/serialized_data.json'

    # Désérialiser les données
    serializer = Serializer()
    deserialized_data = serializer.deserialize(serialized_file_path)

    # Renvoyer les données sous forme de JsonResponse à l'application React
    return JsonResponse(deserialized_data.__dict__)

if __name__ == '__main__':
    main()
