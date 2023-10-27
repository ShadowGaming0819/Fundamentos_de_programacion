/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa16u3;

import java.util.Scanner;
public class Programa16U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int  c= 1, horas,pago,sueldo;
        System.out.println("Determinar el sueldo semanal de horas trabajadas");
        while(c <= 20){
            System.out.println("Introduce las horas trabajadas ");
            horas= sc.nextInt();
            System.out.println("Introduce el sueldo por hora ");
            pago= sc.nextInt();
            sueldo = horas * pago;
            System.out.println("El sueldo del trabajador es "+sueldo);
            c++;
        }
    }
}
