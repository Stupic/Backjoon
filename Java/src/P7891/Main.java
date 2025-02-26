package P7891;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.math.BigInteger;

public class Main {

    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        int n = Integer.parseInt(br.readLine());

        while (n-- > 0){
            String[] inputs = br.readLine().split(" ");
            BigInteger a = new BigInteger(inputs[0]);
            BigInteger b = new BigInteger(inputs[1]);
            System.out.println(a.add(b));
        }
        br.close();
    }
}