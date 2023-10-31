/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa21u3;

import java.util.Scanner;
public class Programa21U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Ingrese la cantidad de números a procesar: ");
        int cantidadNumeros = sc.nextInt();

        int contador = 1, cubo;
        while (contador <= cantidadNumeros) {
            System.out.print("Ingrese un número natural positivo: ");
            int numero = sc.nextInt();
            
            if (numero > 0) {
                cubo = numero * numero * numero;
                System.out.println("El cubo de " + numero + " es " + cubo);
            } else {
                System.out.println("Por favor, ingrese un número natural positivo.");
            }
            
            contador++;
        }
    }
}


