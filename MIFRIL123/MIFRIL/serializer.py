from ESGMetrics import ESGMetric
import json 

class Serializer:
    @staticmethod
    def serialize(obj, file_path):
        if not isinstance(obj, ESGMetric):
            raise ValueError("L'objet doit être une instance de la classe ESGMetric.")

        data = {
            'type': type(obj).__name__,
            'data': {
                'code': obj.code,
                'topic': obj.topic,
                'metric_desc': obj.metric_desc,
                'isQuantitative': obj.isQuantitative,
                'units': obj.units
            }
        }

        with open(file_path, 'w') as file:
            json.dump(data, file)

        print(f"Objet ESGMetric sérialisé avec succès dans le fichier : {file_path}")

    @staticmethod
    def deserialize(file_path):
        with open(file_path, 'r') as file:
            data = json.load(file)

        if data['type'] != 'ESGMetric':
            raise ValueError("Type d'objet non pris en charge pour la désérialisation.")

        obj = ESGMetric(
            code=data['data']['code'],
            topic=data['data']['topic'],
            metric_desc=data['data']['metric_desc'],
            isQuantitative=data['data']['isQuantitative'],
            units=data['data']['units']
        )

        print(f"Objet ESGMetric désérialisé avec succès du fichier : {file_path}")
        return obj