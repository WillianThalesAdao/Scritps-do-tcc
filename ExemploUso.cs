using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExemploUso : MonoBehaviour 
{
public ScriptTeste obj;
public int valorEx;
public string txtEx;
public float valorExf;
void Start() 
{
    valorEx = obj.valor1Int;
    valorExf = obj.valor2Float;
    txtEx = obj.txt;
}
}