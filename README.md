# MoneyInC#

For study purposes. This repo contains some samples on how C# interacts with currency and strings.

<hr>

## Features

- Samples of money and currency to string in C#


## Samples

```
value = 10;

value.ToString("G") -> 10
value.ToString("C") -> R$ 10,00
value.ToString("E04") -> 1,0000E+001
value.ToString("F") -> 10,00
value.ToString("P") -> 1.000,00%

for all samples the culture CultureInfo.CreateSpecificCulture("pt-BR") was specified
```


## Running

clone the repo and just ``` dotnet build ``` in your console. (Required ASP.NET 6 or higher)
