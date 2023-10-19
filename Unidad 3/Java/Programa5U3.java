/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa5u3;

import java.util.Scanner;
public class Programa5U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double p1,p2,p3,total;
        System.out.println("Programa 5");
        System.out.println("Introduce el precio del producto 1");
        p1=sc.nextDouble();
        System.out.println("Introduce el precio del producto 2");
        p2=sc.nextDouble();
        System.out.println("Introduce el precio del producto 3");
        p3=sc.nextDouble();
        
        total = p1+p2+p3;
        
        if (total >= 1500){
            total=total-(total*0.3);
            System.out.println("Su total de 30% de descuento: "+total);
            
        }else if(total < 1500 && total >= 100){
            total=total-(total*0.2);
            System.out.println("Su total de 20% de descuento: "+total);
            
        }else if(total <1000 && total >= 700){
            total=total-(total*0.1);
            System.out.println("Su total de 10% de descuento: "+total);
        }else{
            System.out.println("Su total es "+total);
        }
    }
}
