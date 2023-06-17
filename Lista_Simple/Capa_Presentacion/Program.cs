using Capa_Logica.Lista_Simple;
using Capa_Modelo.Nodo;

Orquestador orquestador = new Orquestador();
orquestador.Agregar_NodoInt(12);
orquestador.Agregar_NodoInt(21);
orquestador.Agregar_NodoInt(21);
orquestador.Agregar_NodoInt(33);
orquestador.Agregar_NodoInt(21);
orquestador.Mostrar_Lista_Simple();

orquestador.Borrar_N_Nodos(21,3);
orquestador.Mostrar_Lista_Simple();