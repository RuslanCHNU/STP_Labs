from django.test import TestCase
from django.urls import reverse
from .models import Category, Article

class CategoryModelTest(TestCase):
    @classmethod
    def setUpTestData(cls):
        # Створення тестової категорії
        Category.objects.create(category="Технології", slug="tech")

    def test_category_creation(self):
        category = Category.objects.get(slug="tech")
        self.assertEqual(category.category, "Технології")

    def test_get_absolute_url(self):
        category = Category.objects.get(slug="tech")
        self.assertEqual(
            category.get_absolute_url(),
            reverse('articles-category-list', kwargs={'slug': 'tech'})
        )

class ArticleModelTest(TestCase):
    @classmethod
    def setUpTestData(cls):
        # Створення тестової статті
        category = Category.objects.create(category="Наука", slug="science")
        Article.objects.create(
            title="Тестова стаття",
            description="Опис статті",
            slug="test-article",
            category=category
        )

    def test_article_creation(self):
        article = Article.objects.get(slug="test-article")
        self.assertEqual(article.title, "Тестова стаття")