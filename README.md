# 🌱 ESG Platform

Une plateforme web permettant de gérer des données liées à la notation ESG (Environnementale, Sociale et de Gouvernance). Cette application offre une interface d’administration pour saisir, consulter et filtrer des données ESG par entreprise.

## 🧩 Fonctionnalités principales

* Authentification utilisateur (interface admin Django)
* Ajout, modification et suppression de données ESG
* Visualisation structurée des données ESG
* Filtres par entreprise et catégories ESG
* Gestion via le panneau d’administration Django

## ⚙️ Technologies utilisées

* **Backend** : Django (framework Python)
* **Frontend** : HTML, CSS (via Django admin)
* **Base de données** : SQLite (par défaut)
* **Environnement virtuel** : `venv`

## 📁 Structure du projet

```
ESG-Plateform/
│
├── ESG/                     # Projet Django principal
│   ├── settings.py
│   ├── urls.py
│   └── ...
│
├── platform/                # Application Django dédiée aux données ESG
│   ├── models.py            # Modèles des entités ESG
│   ├── admin.py             # Personnalisation de l’admin Django
│   ├── views.py             # (non utilisé ici)
│   └── ...
│
├── db.sqlite3               # Base de données SQLite
├── manage.py                # Script principal Django
└── requirements.txt         # Dépendances du projet
```

## 🚀 Installation et lancement

1. **Cloner le dépôt :**

```bash
git clone https://github.com/abenhamdi/ESG-Plateform.git
cd ESG-Plateform
```

2. **Créer un environnement virtuel :**

```bash
python -m venv venv
source venv/bin/activate  # Linux/macOS
venv\Scripts\activate     # Windows
```

3. **Installer les dépendances :**

```bash
pip install -r requirements.txt
```

4. **Appliquer les migrations :**

```bash
python manage.py migrate
```

5. **Créer un superutilisateur :**

```bash
python manage.py createsuperuser
```

6. **Lancer le serveur de développement :**

```bash
python manage.py runserver
```

7. Accédez à l’interface admin via :
   [http://127.0.0.1:8000/admin](http://127.0.0.1:8000/admin)

## 🧾 Exemple de modèles ESG

Les modèles incluent :

* **Entreprise** : nom, secteur
* **Critère ESG** : nom, description, catégorie (E/S/G)
* **Score ESG** : score par critère, par entreprise et par année

## ✅ TODO / pistes d'amélioration

* Ajouter des graphiques et visualisations (via Plotly ou Chart.js)
* Ajouter une API REST (Django REST Framework)
* Intégration d’un système de notation automatique
* Interface utilisateur personnalisée (frontend indépendant)

## 👤 Auteur

* **abenhamdi** – [@abenhamdi](https://github.com/abenhamdi)

---
