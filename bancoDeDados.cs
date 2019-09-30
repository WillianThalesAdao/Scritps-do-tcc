using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class bancoDeDados{
    public static void salvarDados(string meuNome, string Idade) {
        string mn = meuNome;
        string i = Idade;

        PlayerPrefs.SetString("meuNome", mn);
        PlayerPrefs.SetString("minhaIdade", i);
        Debug.Log(mn +", seus dados foram salvos!");
    }

    public static string[] carregarDados() {
        string valor1 = PlayerPrefs.GetString("meuNome", "");
        string valor2 = PlayerPrefs.GetString("minhaIdade", "");

        return new string[] {valor1, valor2};
    }

    public static void deletarJogosSalvos() {
        PlayerPrefs.DeleteAll();
    }
} 