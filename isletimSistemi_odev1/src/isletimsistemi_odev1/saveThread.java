/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package isletimsistemi_odev1;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import javax.swing.JOptionPane;
import javax.swing.JProgressBar;

/**
 *
 * @author Lenovo
 */
public class saveThread extends Thread {
    String[] content;
    int time = 100;
    File dosya;
    
    public saveThread( int Time, File dosya) {
        this.time = Time;
        this.dosya = dosya;
    }

    public void run() {
       
        while(true)
        {
            this.content = DosyaIslemi.jTextArea1.getText().split("\n");
            try {
                
                
                    BufferedWriter bw;
                try {
                    FileWriter fw = new FileWriter(this.dosya.getAbsoluteFile());
                    bw = new BufferedWriter(fw);

                    for (    String i : this.content) {
                        bw.write(i.toString());
                        bw.newLine();
                      }
                    bw.flush();
                    bw.close();
                    System.out.println("kaydedildi");
                } catch (IOException e) {
                        e.printStackTrace();
                        System.out.println("hata");
                }
                
                
                this.sleep(time);
            } catch (Exception e) {
            }
        }

    }

}
