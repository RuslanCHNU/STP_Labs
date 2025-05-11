from django.contrib import admin
from .models import Category, Article, ArticleImage

class CategoryAdmin(admin.ModelAdmin):
    prepopulated_fields = {'slug': ('category',)}
    list_display = ('category', 'slug')

class ArticleImageInline(admin.TabularInline):
    model = ArticleImage
    extra = 1

class ArticleAdmin(admin.ModelAdmin):
    prepopulated_fields = {'slug': ('title',)}
    list_display = ('title', 'pub_date', 'main_page')
    inlines = [ArticleImageInline]

admin.site.register(Category, CategoryAdmin)
admin.site.register(Article, ArticleAdmin)