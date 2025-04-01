package P20254;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String[] input = br.readLine().split(" ");
        int ur = Integer.parseInt(input[0]);
        int tr = Integer.parseInt(input[1]);
        int uo = Integer.parseInt(input[2]);
        int to = Integer.parseInt(input[3]);
        System.out.println(56*ur + 24*tr + 14*uo + 6*to);
    }

}