# Generated by Django 2.0.1 on 2018-01-09 20:46

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='Country',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('code', models.CharField(max_length=3)),
                ('name', models.CharField(max_length=200)),
            ],
        ),
        migrations.CreateModel(
            name='IndicatorA',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('year', models.IntegerField(default=2018)),
                ('value', models.FloatField(default=0.0)),
                ('country', models.ForeignKey(on_delete=django.db.models.deletion.DO_NOTHING, to='core.Country')),
            ],
        ),
        migrations.CreateModel(
            name='IndicatorB',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('year', models.IntegerField(default=2018)),
                ('value', models.CharField(max_length=200)),
                ('country', models.ForeignKey(on_delete=django.db.models.deletion.DO_NOTHING, to='core.Country')),
            ],
        ),
    ]
