/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programa6;
import java.util.Scanner;
/**
 *
 * @author Alexander Gonzalez
 */
public class Programa6 {


    public static void main(String[] args) {
        Scanner it = new Scanner(System.in);
        int base, altura , total;
        System.out.println("Programa para calcular el area de un triangulo");
        System.out.print("Ingresa la base: ");
        base = it.nextInt();
        System.out.print("Ingresa la altura: ");
        altura = it.nextInt();
        
        total = (base*altura)/2;
        
        System.out.println("El valor de x es: "+total);

    }
    
}
