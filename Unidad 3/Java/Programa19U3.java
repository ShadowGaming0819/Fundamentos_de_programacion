/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa19u3;

import java.util.Scanner;
public class Programa19U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Ingrese la cantidad de numeros (N): ");
        int n = sc.nextInt();
        int igualCero = 0,menorCero = 0,mayorCero = 0;

        for (int i = 0; i < n; i++) {
            System.out.print("Ingrese el numero " + (i + 1) + ": ");
            double numero = sc.nextDouble();

            if (numero == 0) {
                igualCero++;
            } else if (numero > 0) {
                mayorCero++;
            } else {
                menorCero++;
            }
        }

        System.out.println("Numeros iguales a cero: " + igualCero);
        System.out.println("Numeros mayores a cero: " + mayorCero);
        System.out.println("Numeros menores a cero: " + menorCero);

    }
}




