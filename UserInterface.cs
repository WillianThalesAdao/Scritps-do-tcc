using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterface : MonoBehaviour {
    public string meuNome;
    public string Idade;
    void OnGUI() {
        
        meuNome = GUI.TextField(new Rect(Screen.width/2 - 50, Screen.height/2, 100, 20), meuNome);
        Idade = GUI.TextField(new Rect(Screen.width/2 - 50, Screen.height/2 + 20, 100, 20), Idade);

        bool salvarJogo = GUI.Button(new Rect(Screen.width/2 - 50, Screen.height/2 + 50, 100, 20), "Salvar Jogo");
        bool carregarJogo = GUI.Button(new Rect(Screen.width/2 - 50, Screen.height/2 + 70, 100, 20), "Carregar Jogo");
        bool deletarSalvos = GUI.Button(new Rect(Screen.width/2 - 50, Screen.height/2 + 90, 100, 20), "Deletar Salvos");

        if (salvarJogo) {
            bancoDeDados.salvarDados(meuNome, Idade);
        }

        if (carregarJogo) {
            string[] valoreRetornados = bancoDeDados.carregarDados();
            meuNome = valoreRetornados[0];
            Idade = valoreRetornados[1]; 

        }
        if (deletarSalvos) {
            bancoDeDados.deletarJogosSalvos();
        }
    }
}
