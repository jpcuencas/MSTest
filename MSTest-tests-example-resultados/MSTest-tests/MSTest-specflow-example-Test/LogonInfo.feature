Feature: LogonInfo
	In order to corregir errores
	As a corrector de desarrolo
	I want to comprobar LogonInfo

@mytag
Scenario: LogonInfo1
	Given una funcion privada LogonInfo
	When comprobar la validez de "1235Aa_4"
	Then el resultado deberia ser true

Scenario: LogonInfo2
	Given una funcion privada LogonInfo
	When comprobar la validez de "1235AA_4"
	Then el resultado deberia ser false
	
Scenario: LogonInfo3
	Given una funcion privada LogonInfo
	When comprobar la validez de "1235aa_4"
	Then el resultado deberia ser false

Scenario: LogonInfo4
	Given una funcion privada LogonInfo
	When comprobar la validez de "HHKKAA_a"
	Then el resultado deberia ser false

Scenario: LogonInfo5
	Given una funcion privada LogonInfo
	When comprobar la validez de "1235aAAB4"
	Then el resultado deberia ser false

Scenario: LogonInfo6
	Given una funcion privada LogonInfo
	When comprobar la validez de "12355_4"
	Then el resultado deberia ser false

Scenario: LogonInfo7
	Given una funcion privada LogonInfo
	When comprobar la validez de "DDDDA_B"
	Then el resultado deberia ser false

Scenario: LogonInfo8
	Given una funcion privada LogonInfo
	When comprobar la validez de "dddda_f"
	Then el resultado deberia ser false

Scenario: LogonInfo9
	Given una funcion privada LogonInfo
	When comprobar la validez de "1235ASS4"
	Then el resultado deberia ser false

Scenario: LogonInfo10
	Given una funcion privada LogonInfo
	When comprobar la validez de "gg123aa4"
	Then el resultado deberia ser false

Scenario: LogonInfo11
	Given una funcion privada LogonInfo
	When comprobar la validez de "AAAAAAAA"
	Then el resultado deberia ser false

Scenario: LogonInfo12
	Given una funcion privada LogonInfo
	When comprobar la validez de "aaaaaaaa"
	Then el resultado deberia ser false

Scenario: LogonInfo13
	Given una funcion privada LogonInfo
	When comprobar la validez de "12"
	Then el resultado deberia ser false

Scenario: LogonInfo14
	Given una funcion privada LogonInfo
	When comprobar la validez de "1235Aa _4"
	Then el resultado deberia ser false