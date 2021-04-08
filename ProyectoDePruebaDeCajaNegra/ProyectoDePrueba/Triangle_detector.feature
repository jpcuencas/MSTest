Feature: Triangle_detector
	In order to TriangleValidator
	As a equipo desarrollo en pruebas
	I want to comprobar un triangulo segun sus lados

@mytag
Scenario: si los lados son iguales
	Given tengo validador de triangulos
	When Compruebo el tipo de triangulo de lado:1, 1, 1 
	Then me devuelve el tipo equilatero

Scenario: si los lados son diferentes
	Given tengo validador de triangulos  
	When Compruebo el tipo de triangulo de lado:1, 2, 3 
	Then me devuelve el tipo escaleno

Scenario: si dos de sus lados son diferentes
	Given tengo validador de triangulos
	When Compruebo el tipo de triangulo de lado:1, 2, 2
	Then me devuelve el tipo isorceles

Scenario: si los lados son negativos
	Given tengo validador de triangulos  
	When Compruebo el tipo de triangulo de lado:-1, -1, -1
	Then me devuelve una excepcion de argumento
	
Scenario: si solo dos lados son negativos
	Given tengo validador de triangulos
	When Compruebo el tipo de triangulo de lado:-1, 1, -1
	Then me devuelve una excepcion de argumento


Scenario: si dos lados son negativos
	Given tengo validador de triangulos 
	When Compruebo el tipo de triangulo de lado:1, -1, -1
	Then me devuelve una excepcion de argumento

Scenario: si tenemos dos lados son negativos
	Given tengo validador de triangulos  
	When Compruebo el tipo de triangulo de lado:-1, -1, 1
	Then me devuelve una excepcion de argumento


Scenario: si los lados son cero
	Given tengo validador de triangulos
	When Compruebo el tipo de triangulo de lado:0, 0, 0
	Then me devuelve una excepcion de argumento

Scenario: si primer lados son cero
	Given tengo validador de triangulos   
	When Compruebo el tipo de triangulo de lado:0, 1, 1
	Then me devuelve una excepcion de argumento

Scenario: si segundo lados son cero
	Given tengo validador de triangulos   
	When Compruebo el tipo de triangulo de lado:1, 0, 1
	Then me devuelve una excepcion de argumento

Scenario: si tercero lados son cero
	Given tengo validador de triangulos 
	When Compruebo el tipo de triangulo de lado:1, 1, 0
	Then me devuelve una excepcion de argumento

Scenario: Lados inconclusos
	Given tengo validador de triangulos  
	When Compruebo el tipo de triangulo de lado:7, 1, 2
	Then me devuelve una excepcion de argumento

Scenario: Lados inconclusos 2 letras
	Given tengo validador de triangulos  
	When Compruebo el tipo de triangulo de lado letra:a, a, 2
	Then me devuelve una excepcion de argumento

Scenario: Lados inconclusos otras 2 letras
	Given tengo validador de triangulos  
	When Compruebo el tipo de triangulo de lado letra:b, a, 2
	Then me devuelve una excepcion de argumento

Scenario: Lados inconclusos tres letras
	Given tengo validador de triangulos  
	When Compruebo el tipo de triangulo de lado letra:a, b, c
	Then me devuelve una excepcion de argumento

Scenario: Lados inconclusos otras 3 letras
	Given tengo validador de triangulos  
	When Compruebo el tipo de triangulo de lado letra:a, a, b
	Then me devuelve una excepcion de argumento

Scenario: Lados inconclusos 3 letras iguales
	Given tengo validador de triangulos  
	When Compruebo el tipo de triangulo de lado letra:a, a, a
	Then me devuelve una excepcion de argumento
