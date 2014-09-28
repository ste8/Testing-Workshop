Testing-Workshop
================

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