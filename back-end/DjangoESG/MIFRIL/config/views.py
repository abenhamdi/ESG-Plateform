from django.contrib.auth.models import User, Group
from rest_framework import viewsets
from rest_framework import permissions
from serializers import UserSerializer, GroupSerializer


class UserViewSet(viewsets.ModelViewSet):
    """
    API endpoint that allows users to be viewed or edited.
    """
    queryset = User.objects.all().order_by('-date_joined')
    # This is the serializer class that will be used for validating and
    # deserializing input, and for serializing output. The default value is
    # automatically determined by examining the Model that is used.
    serializer_class = UserSerializer
    # This is the list of permissions that the user must have in order to
    # access this viewset. This setting is used by the DefaultRouter class
    # to determine the viewset permissions.
    permission_classes = [permissions.IsAuthenticated]

class GroupViewSet(viewsets.ModelViewSet):
    """
    API endpoint that allows groups to be viewed or edited.
    """
    queryset = Group.objects.all()
    # This is the serializer class that will be used for validating and
    # deserializing input, and for serializing output. The default value is
    # automatically determined by examining the Model that is used.
    serializer_class = GroupSerializer
    # This is the list of permissions that the user must have in order to
    # access this viewset. This setting is used by the DefaultRouter class
    # to determine the viewset permissions.
    permission_classes = [permissions.IsAuthenticated]