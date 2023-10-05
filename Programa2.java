/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.p_2;
import java.util.Scanner;

/**
 *
 * @author LaboratorioLTI2
 */
public class P_2 {

    public static void main(String[] args) {//PASO 1
        Scanner sc= new Scanner(System.in);
        int a= 5, b=8, suma; //PASO 2
        System.out.print("Escribe un numero A: ");//PASO 3
        a  = sc.nextInt();
        System.out.print("Escribe un numero B: ");//PASO 3   
        b  = sc.nextInt();
        suma= a + b;
        System.out.println("Resultado : " + suma);
    }
}
