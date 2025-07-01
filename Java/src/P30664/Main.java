package P30664;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.math.BigInteger;
import java.util.Objects;

public class Main {

    public static void main(String[] args) throws IOException {
        BigInteger remainderN = new BigInteger("42");
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        String input;
        while (!(input = br.readLine()).equals("0")) {
            System.out.println(Objects.equals(new BigInteger(input).remainder(remainderN), BigInteger.ZERO) ? "PREMIADO" : "TENTE NOVAMENTE");
        }
        br.close();
    }
}