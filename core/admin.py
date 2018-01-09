from django.contrib import admin

from .models import Country, IndicatorA, IndicatorB


class CountryAdmin(admin.ModelAdmin):
    list_display = ['code', 'name']


admin.site.register(Country, CountryAdmin)


class IndicatorAAdmin(admin.ModelAdmin):
    list_display = ['year', 'country', 'value']


admin.site.register(IndicatorA, IndicatorAAdmin)


class IndicatorBAdmin(admin.ModelAdmin):
    list_display = ['year', 'country', 'value']


admin.site.register(IndicatorB, IndicatorBAdmin)
