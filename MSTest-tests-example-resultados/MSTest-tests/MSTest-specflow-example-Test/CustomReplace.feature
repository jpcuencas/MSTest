Feature: Custom Replace
	In order to corregir errores
	As a corrector de desarrolo
	I want to comprobar custom replace

@mytag
Scenario: Replace single sentence1
	Given remplazar una letra por el numero de ocurrencias
	When  reemplace la letra "b" en el texto "hola"
	Then el resultado deberia ser "0"

Scenario: Replace single sentence2
	Given remplazar una letra por el numero de ocurrencias
	When  reemplace la letra "a" en el texto "null"
	Then el resultado deberia ser excepcion

Scenario: Replace single sentence3
	Given remplazar una letra por el numero de ocurrencias
	When  reemplace la letra "null" en el texto "null"
	Then el resultado deberia ser excepcion

Scenario: Replace single sentence4
	Given remplazar una letra por el numero de ocurrencias
	When  reemplace la letra "null" en el texto "hola"
	Then el resultado deberia ser excepcion

Scenario: Replace single sentence5
	Given remplazar una letra por el numero de ocurrencias
	When  reemplace la letra "aa" en el texto "hola"
	Then el resultado deberia ser 2

Scenario: Replace single sentence6
	Given remplazar una letra por el numero de ocurrencias
	When  reemplace la letra "aa" en el texto "null"
	Then el resultado deberia ser excepcion