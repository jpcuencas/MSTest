Feature: ImageManagement
	In order to corregir errores
	As a corrector de desarrolo
	I want to comprobar image management

@mytag
Scenario: ImageManagement1
	Given con un ImageManagement Mock
	And establecer el valor resituya método GetHour a 12
	When obtener la imagen de la hora del día
	Then la imagen resultante debe ser "sun.jpg"

Scenario: ImageManagement2
	Given con un ImageManagement Mock
	And establecer el valor resituya método GetHour a 10
	When obtener la imagen de la hora del día
	Then la imagen resultante debe ser "sun.jpg"

	Scenario: ImageManagement3
	Given con un ImageManagement Mock
	And establecer el valor resituya método GetHour a 22
	When obtener la imagen de la hora del día
	Then la imagen resultante debe ser "moon.jpg"

	Scenario: ImageManagement4
	Given con un ImageManagement Mock
	And establecer el valor resituya método GetHour a 6
	When obtener la imagen de la hora del día
	Then la imagen resultante debe ser "moon.jpg"

	Scenario: ImageManagement5
	Given con un ImageManagement Mock
	And establecer el valor resituya método GetHour a 21
	When obtener la imagen de la hora del día
	Then la imagen resultante debe ser "moon.jpg"

	Scenario: ImageManagement6
	Given con un ImageManagement Mock
	And establecer el valor resituya método GetHour a -3
	When obtener la imagen de la hora del día
	Then la imagen resultante debe ser "moon.jpg"

	Scenario: ImageManagement7
	Given con un ImageManagement Mock
	And establecer el valor resituya método GetHour a 30
	When obtener la imagen de la hora del día
	Then la imagen resultante debe ser "moon.jpg"
