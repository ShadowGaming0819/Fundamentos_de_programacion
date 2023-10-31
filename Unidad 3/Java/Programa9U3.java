/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa9u3;

import java.util.Scanner;
public class Programa9U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int horas, total;
        System.out.println("Programa para cobrar el uso de estacionamiento");
        System.out.println("Introdusca las horas de uso");
        horas = sc.nextInt();
        
        if(horas <= 2){
        total=horas*5;
        System.out.println("Tu total a pagar es"+total);
        }else if(horas>2&&horas<=5){
            total=2*5+(horas-3)*4;
            System.out.println("Tu total a pagar es"+total);
        }else if(horas>5&&horas<=10){
            total=2*5+3*4+(horas-5)*3;
            System.out.println("Tu total a pagar es"+total);     
        }else if(horas>10){
            total=2*5+3*4+3*5+(horas-10)*2;
            System.out.println("Tu total a pagar es"+total);
        }
        
        
    }
}
