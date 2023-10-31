/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa20u3;

/**
 *
 * @author Alexander Gonzalez
 */
public class Programa20U3 {

    public static void main(String[] args) {
        int dia = 1,ahorroDiario = 3,ahorroAnual = 0;

        while (dia <= 365) {
            ahorroAnual += ahorroDiario;
            System.out.println("Día " + dia + ": Ahorro diario= " + ahorroDiario);
            ahorroDiario *= 3;

            dia++;
        }

        System.out.println("Ahorro anual: " + ahorroAnual+" pesos ");
    }
}



