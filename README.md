# Conversor de imagem em "Imagem Elipse"

## Descrição

Este é um projeto de estudo desenvolvido que pode ser executado via linha de comando (CLI) ou pela IDE de desenvolvimento. 
O objetivo é carregar uma imagem, processar seus pixels e gerar uma nova imagem formada pela forma geometrica "Elipse".
Para ficar mais claro a compreenção, será utilizado o termo "PixelElipse".


## Requisitos

- .NET 6 ou superior
- Biblioteca:
  - SixLabors.ImageSharp (para manipulação de imagens)

## Instalação

```bash
dotnet add package SixLabors.ImageSharp
```

## Funcionalidades

- Carregamento de imagens em formatos comuns: JPEG, PNG, BMP, GIF, TIFF.
- Leitura dos pixels da imagem e criação de uma matriz de dados.
- Conversão da luminosidade em "PixelElipse" para formar a nova imagem.
- Geração de um arquivo `.jpg`.
- Possibilidade de configurar diferentes métodos de cálculo de luminosidade.
- Configuração de resolução em percentual, isso indica o quão nitida será a imagem final.
- Saturação irá aumentar ou diminuir o "PixelElipse"
- Tamanho do pixel define qual é o tamanho ocupado pelo "PixelElipse". Esse valor influencia diretamente no tamanho final da imagem e em sua qualidade, pois determina a granularidade e a resolução da conversão.


## Como funciona

1. A imagem é carregada e criada uma matriz com as informações da imagem
2. Cada pixel, ou conjunto de pixel tem sua luminosidade calculada e convertido em uma coordenada.
3. A matriz é lida e para cada coordenada teremos um "PixelElipse" desenhado na nova imagem
4. O resultado é salvo em um arquivo `.jpg`, onde os .


## Classe `Matriz.cs`
A classe Matriz é responsável por armazenar as coordenadas dos pixels da imagem. Ela contém uma coleção de coordenadas representadas pelos valores:
X: Posição horizontal do pixel.
Y: Posição vertical do pixel.
Luminosidade: Intensidade da luz do pixel, que influencia na geração da nova imagem.

## Classe `Controlador.cs`
A classe Controlador é responsável por redimensionar a imagem conforme a resolução desejada para a geração da nova imagem. Ela ajusta os parâmetros de escala e proporção, garantindo que a imagem final esteja de acordo com as especificações definidas pelo usuário.
Também é possível definir a resolução da conversão em percentual:
- **100%**: Cada pixel da imagem será convertido em um "PixelElipse". Essa resolução tente a gerar imagens extremamente grandes. Visto que se for configurado o tamanho do pixel como 20 por exemplo, uma imagem de 200x200 resultará em uma imagem de 4000x4000.
- **50%**: O "PixelElipse" será baseado em um bloco de 2x2 pixels.
- **25%**: O "PixelElipse" será baseado em um bloco de 4x4 pixels.
Outros valores podem ser configurados conforme necessidade para ajustar a resolução e nível de detalhe.


## Classe `ImageConverter.cs`
Responsavel por receber a imagem e converter em uma Matriz


## Classe `PixelConverter`
Responsável extrair a luminosidade em um valor numérico.


## Classes de Luminosidade

O cálculo da luminosidade pode ser ajustado por diferentes classes, permitindo um ajuste fino conforme as cores da imagem original. Normalmente, utiliza-se a classe `Luminosidade_R21_G71_B01`, que representa melhor a percepção de luminosidade do olho humano, considerando os pesos:

- **21%** Vermelho (R * 0.21)
- **71%** Verde (G * 0.71)
- **07%** Azul (B * 0.07)

Essa distribuição reflete melhor a forma como o olho humano percebe diferentes cores e seus brilhos relativos. A nomenclatura da classe `Luminosidade_R21_G71_B01` segue esse padrão para deixar claro as proporções utilizadas no cálculo de cada componente RGB.

## Uso

Para usar o conversor, abra o projeto na IDE e defina o caminho da imagem e a resolução desejada. O arquivo será gerado na pasta raiz do projeto.


## Considerações

- Para melhor resultado, escolha inicialmente uma resolução baixa por exemplo 10, e vá aumentando até que a imagem gerada esteja em um tamanho e resolução adequados.
- A resolução e o tamanho do pixel deverão ser ajustados para equilibrar detalhes e tamanho da saída.

## Exemplo de Saída

![Uma imagem simples poderia ser convertida em algo como](ImagemGerada.jpg)







