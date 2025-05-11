from django.shortcuts import render
from django.views.generic import ListView, DetailView
from .models import Article, Category

class HomePageView(ListView):
    model = Category
    template_name = 'app_blog/index.html'
    context_object_name = 'categories'

    def get_context_data(self, **kwargs):
        context = super().get_context_data(**kwargs)
        context['articles'] = Article.objects.filter(main_page=True)[:5]
        return context

class ArticleDetail(DetailView):
    model = Article
    template_name = 'app_blog/article_detail.html'
    context_object_name = 'item'

class ArticleList(ListView):
    model = Article
    template_name = 'app_blog/articles_list.html'
    context_object_name = 'items'

class ArticleCategoryList(ArticleList):
    def get_queryset(self):
        return Article.objects.filter(category__slug=self.kwargs['slug'])