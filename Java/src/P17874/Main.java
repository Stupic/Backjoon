package P17874;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String[] input = br.readLine().split(" ");
        int n = Integer.parseInt(input[0]);
        int w = Integer.parseInt(input[1]);
        int h = Integer.parseInt(input[2]);
        int max = w * h;
        max = Math.max(max, (n - w) * h);
        max = Math.max(max, w * (n - h));
        max = Math.max(max, (n - w) * (n - h));
        System.out.println(max * 4);
        br.close();
    }

}