package P32314;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int a = Integer.parseInt(br.readLine());
        String[] inputs = br.readLine().split(" ");
        int w = Integer.parseInt(inputs[0]);
        int v = Integer.parseInt(inputs[1]);
        System.out.println(a > w/v ? 0 : 1);

        br.close();
    }
}


