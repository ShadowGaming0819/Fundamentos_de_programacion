/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.programa4u3;

import java.util.Scanner;
public class Programa4U3 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
                int mes;
        System.out.println("Programa para los meses del año");
        System.out.println("Introdusca un numero para saber que mes es: ");
        mes=sc.nextInt();
                switch(mes){
                    case 1:  
                        System.out.println("Es Enero ");
                        break;
                    case 2:  
                        System.out.println("Es Febrero ");
                        break;
                    case 3:  
                        System.out.println("Es Marzo ");
                        break;
                    case 4:  
                        System.out.println("Es Abril ");
                        break;
                    case 5:  
                        System.out.println("Es Mayo ");
                        break;
                    case 6:  
                        System.out.println("Es Junio ");
                        break;
                    case 7:  
                        System.out.println("Es Julio ");
                        break;
                    case 8:  
                        System.out.println("Es Agosto ");
                        break;
                    case 9:  
                        System.out.println("Es Septiembre ");
                        break;
                    case 10:  
                        System.out.println("Es Octubre ");
                        break;
                    case 11:  
                        System.out.println("Es Noviembre ");
                        break;
                    case 12:  
                        System.out.println("Es Diciembre ");
                        break;
                    default:
                        System.out.println("No existe el mes ingresado ");
                        
                }
    }
}
