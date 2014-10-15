Testing-Workshop
================

.NET (C# e VB.NET)
----------

Per gli sviluppatori .NET che non hanno ancora usato una libreria di unit testing, consigliamo NUnit (http://www.nunit.org), in abbinamento a TestDriven.Net (http://testdriven.net), un software in grado di eseguire i test direttamente dall'interno di Visual Studio (è gratuito per uso personale, sufficiente per il nostro workshop).
In alternativa, sia Visual Studio dalla versione 2012 che Resharper sono in grado di eseguire test scritti con NUnit.

Java
----------

Per gli sviluppatori Java, Eclispe è già in grado di far girare test con JUnit. Nel caso usiate un IDE diverso, verificate che riuscite ad eseguire dei test con JUnit o librerie analoghe.

JavaScript
----------

PREREQUISITI:
Nodejs e npm installati http://nodejs.org/

ISTRUZIONI:
Spostarsi nella direcory /projects/JavaScript ed eseguire il comando:

	npm install

A questo punto verrà installato il test runner jasmine-node. Per far girare la suite di test basta dare il comando:

	node_modules/.bin/jasmine-node spec

Utilizzando come target la cartella il runner caricherà tutti i js che rispettano la convenzione:

	*Spec.js

Python
------

PREREQUISITI:
Python installato sulla propria macchina (su OSX e Linux è già installato installato) http://www.python.it/

ISTRUZIONI:
Spostarsi nella direcory /projects/Python e far girare i test con il comando:

	python TestFrameworkSpec.py

PHP
---

PREREQUISITI:
PHP installato sulla propria macchina (su osx e linux è facilmente installabile), su windows può essere scaricato da qui: http://windows.php.net/download/

ISTRUZIONI:
Spostarsi nella directory /projects/PHP e far girare i test con i phar di phpunit:

	./phpunit.phar TestFrameworkTest.php
