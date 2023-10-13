/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa2u3;
import java.util.Scanner;

public class Programa2U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int c1,c2,c3,c4,c5,c6, sum, res;
        System.out.println("Programa para saber si un alumno esta aprobado o reprobado");
        System.out.println("Introduce calificacion 1: ");
        c1=sc.nextInt();
                System.out.println("Introduce calificacion 2: ");
        c2=sc.nextInt();
                System.out.println("Introduce calificacion 3: ");
        c3=sc.nextInt();
                System.out.println("Introduce calificacion 4: ");
        c4=sc.nextInt();
                System.out.println("Introduce calificacion 5: ");
        c5=sc.nextInt();
                System.out.println("Introduce calificacion 6: ");
        c6=sc.nextInt();      
        
        sum = c1+c2+c3+c4+c5+c6;
        res= sum / 6;
        
        if(res >= 70 ){
            System.out.println("Usted esta aprobado su calificacion es: "+res);
        
        }else{
            System.out.println("Usted esta reprobado su calificacion es: "+res);
        }
        
      
    }
}
