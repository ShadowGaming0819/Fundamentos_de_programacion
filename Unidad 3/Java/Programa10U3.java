/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa10u3;

import java.util.Scanner;
public class Programa10U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int horas, pago, total;
        System.out.println("Programa para determinar el sueldo semanal de un trabajador");
        System.out.println("Introdusca las horas trabajadas");
        horas = sc.nextInt();
        System.out.println("Introdusca el pago por horas");
        pago = sc.nextInt();
        
        if(horas > 40){
            total=(horas*pago)*2;
            System.out.println("Su salario total es de "+total); 
            
        }else{
            total=horas*pago;
            System.out.println("Su salario total es de "+total);  
        }
    }
}
