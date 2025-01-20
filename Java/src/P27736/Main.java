package P27736;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.math.BigInteger;

public class Main {

    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        long n = Long.parseLong(br.readLine());

        String[] inputs = br.readLine().split(" ");
        BigInteger agree = BigInteger.ZERO;
        BigInteger disagree = BigInteger.ZERO;
        BigInteger abstention = BigInteger.ZERO;

        for (String input : inputs) {
            int value = Integer.parseInt(input); // 문자열을 정수로 변환
            if (value == 1) {
                agree = agree.add(BigInteger.ONE);
            } else if (value == -1) {
                disagree = disagree.add(BigInteger.ONE);
            } else {
                abstention = abstention.add(BigInteger.ONE);
            }
        }

        if (agree.compareTo(disagree) < 0) {
            System.out.println("REJECTED");
        } else if (agree.compareTo(disagree) > 0) {
            System.out.println("APPROVED");
        } else if (abstention.compareTo(new BigInteger(n + "")) >= 0) {
            System.out.println("INVALID");
        }
    }
}