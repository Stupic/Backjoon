package P31306;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        String str = br.readLine();
        int notContainY = str.replaceAll("[^aeiou]","").length();
        int containY = str.replaceAll("[^aeiouy]","").length();
        System.out.println(notContainY + " " + containY);

        br.close();
    }
}