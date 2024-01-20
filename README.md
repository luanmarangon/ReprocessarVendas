# Aplicativo de Reprocessamento de Vendas

## Visão Geral

Este aplicativo foi desenvolvido em C# com Windows Forms e tem como objetivo facilitar o reprocessamento de vendas de um sistema de frente de caixa. As vendas são armazenadas em uma estrutura de pastas organizadas por mês e dia.

## Estrutura do Diretório de Vendas

As vendas são organizadas da seguinte maneira:

├── Vendas
│   ├── 01
│   │   ├── 01
│   │   │   ├── Venda01.txt
│   │   │   ├── Venda02.txt
│   │   │   └── Venda03.txt
│   │   ├── 02
│   │   │   ├── Venda01.txt
│   │   │   └── Venda02.txt
├── 02
│   ├── 01
│   │   ├── Venda01.txt
│   │   ├── Venda02.txt
│   │   └── Venda03.txt
│   ├── 02
│   │   ├── Venda01.txt
│   │   └── Venda04.txt


Cada pasta do mês (01 a 12) contém subpastas para cada dia (01 a 31), e dentro de cada subpasta do dia, há arquivos contendo as vendas daquele dia.

## Funcionalidades do Aplicativo

### 1. Seleção de Mês e Dia

O aplicativo permite a seleção do mês e do dia para reprocessar as vendas. Uma interface intuitiva facilita a navegação pelos dias e meses disponíveis.

### 2. Reprocessamento de Vendas

Ao informar o periodo desejado, será necessário informar o caminho de origem das vendas e destinos para realizar o Reprocessamento.

## Como Usar

1. Clone o repositório para o seu ambiente local.
2. Abra o projeto no Visual Studio ou sua IDE preferida.
3. Execute o aplicativo.
4. Selecione o mês e o dia desejados.
5. Reprocesse ou visualize as vendas conforme necessário.

## Pré-requisitos

- [Visual Studio](https://visualstudio.microsoft.com/)

## Contribuição

Contribuições são bem-vindas! Se você tiver sugestões de melhorias, novas funcionalidades ou correções, fique à vontade para abrir uma issue ou enviar um pull request.
