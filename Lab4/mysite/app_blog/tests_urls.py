from django.test import TestCase
from django.urls import resolve, reverse
from .views import HomePageView, ArticleList

class UrlsTest(TestCase):
    def test_home_url_resolves(self):
        view = resolve('/')
        self.assertEqual(view.func.__name__, HomePageView.as_view().__name__)

    def test_articles_list_url_resolves(self):
        view = resolve('/articles/')
        self.assertEqual(view.func.__name__, ArticleList.as_view().__name__)