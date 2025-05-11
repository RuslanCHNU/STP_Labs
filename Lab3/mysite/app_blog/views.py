from django.shortcuts import render
from .models import Article

def home(request):
    articles = Article.objects.filter(main_page=True).order_by('-pub_date')  # Фільтр для статей на головній
    return render(request, 'app_blog/index.html', {'articles': articles})