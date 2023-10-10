/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programa7;
import java.util.Scanner;

public class Programa7 {


    public static void main(String[] args) {
        Scanner it = new Scanner(System.in);
        double cel, far;
        System.out.println("Programa para convertir grados celsius a farenheit");
        System.out.print("Ingresa los grados celsius: ");
        cel = it.nextInt();
        
        far=(cel*1.8)+32;
        

        
        System.out.println("El valor de x es: "+far);

    }
    
}
