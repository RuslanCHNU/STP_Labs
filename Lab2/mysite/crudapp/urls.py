from django.urls import path
from . import views

urlpatterns = [
    path('', views.order_list, name='order_list'),
    path('new/', views.create_order, name='create_order'),
    path('edit/<int:pk>/', views.update_order, name='update_order'),
    path('delete/<int:pk>/', views.delete_order, name='delete_order'),
]