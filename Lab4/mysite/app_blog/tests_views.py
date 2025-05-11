from django.test import TestCase
from django.urls import reverse
from .models import Category, Article

class HomePageViewTest(TestCase):
    def test_home_page_status_code(self):
        response = self.client.get(reverse('home'))
        self.assertEqual(response.status_code, 200)

    def test_home_page_template(self):
        response = self.client.get(reverse('home'))
        self.assertTemplateUsed(response, 'app_blog/index.html')

class ArticleListViewTest(TestCase):
    @classmethod
    def setUpTestData(cls):
        # Створення тестових даних
        category = Category.objects.create(category="Подорожі", slug="travel")
        Article.objects.create(
            title="Стаття про подорожі",
            slug="travel-article",
            category=category
        )

    def test_article_list_status_code(self):
        response = self.client.get(reverse('articles-list'))
        self.assertEqual(response.status_code, 200)