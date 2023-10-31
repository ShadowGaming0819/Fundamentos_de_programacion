/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa18u3;

public class Programa18U3 {

    public static void main(String[] args) {
        int año;
        double salarioInicial = 1500.0,incrementoAnual = 0.10, salarioActual = salarioInicial;
        
        System.out.println("Programa para calcular el salario de un profesor");
        System.out.println("Año 1: " + salarioActual);

        for (año = 2; año <= 6; año++) {
            salarioActual += salarioActual * incrementoAnual;
            System.out.println("Año " + año + ": Salario = " + salarioActual);
        }

        System.out.println("Salario al cabo de 6 años: " + salarioActual);
    }
}

