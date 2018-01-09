from django.db import models


class Country(models.Model):
    code = models.CharField(max_length=3)
    name = models.CharField(max_length=200)

    def __str__(self):
        return self.code


class IndicatorA(models.Model):
    year = models.IntegerField(default=2018)
    country = models.ForeignKey(Country, on_delete=models.DO_NOTHING)
    value = models.FloatField(default=0.0)


class IndicatorB(models.Model):
    year = models.IntegerField(default=2018)
    country = models.ForeignKey(Country, on_delete=models.DO_NOTHING)
    value = models.CharField(max_length=200)

