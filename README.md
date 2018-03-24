# XAMARIN-APP-MultiLanguage
Aplicativo(App) utilizando Xamarin e o Plugin.Multilingual para traduzir automaticamente conforme a lingua do Device

Nuget Plugin.Multilingual
https://www.nuget.org/packages/Plugin.Multilingual/

Passo a passo para a construção de um aplicativo multilingual 
https://xamgirl.com/multilingual-localization-plugin-for-xamarin/

Passo a passo: 
1º Adicione o Plugin.Multilingual via Nuget

2º Adicione um arquivo resx para cada idioma que você deseja suportar.

![alt text](https://github.com/ChristopherLambert/XAMARIN-APP-MultiLanguage/blob/master/MultiLanguage/MultiLanguage/Imagens/appresources.png)

3º Defina a cultura de seu aplicativo pegando do device.

```c#
AppResources.Culture = CrossMultilingual.Current.DeviceCultureInfo;
```

4º Ao instalar o plugin, ele criará um   arquivo TranslateExtension.txt na pasta Helpers, renomeando a extensão desse arquivo para  TranslateExtension.cs.
  No   arquivo TranslateExtension.cs na constante  ResourceId  por padrão, ele assumirá que seu arquivo de recurso foi adicionado na raiz do projeto e o arquivo resx será nomeado como AppResources. Se você o adicionou a uma pasta ou nomeou o arquivo resx de maneira diferente, pode alterá-lo para lá.

5º Adicione a referência de sua extensão de tradução em seu XAML e use-a.

![alt text](
https://github.com/ChristopherLambert/XAMARIN-APP-MultiLanguage/blob/master/MultiLanguage/MultiLanguage/Imagens/xml.png)
