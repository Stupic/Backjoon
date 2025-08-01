package P26489;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int cnt = 0;
        String input;
        while ((input = br.readLine()) != null && !input.trim().isEmpty()) {
            cnt++;
        }
        System.out.println(cnt);

        br.close();
    }
}