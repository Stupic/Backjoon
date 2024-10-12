package P10797;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int target = Integer.parseInt(br.readLine());
        String[] carNums = br.readLine().split(" ");

        int cnt = 0;
        for (String carNum : carNums) {
            if (carNum.equals(String.valueOf(target))) cnt++;
        }
        System.out.println(cnt);
        br.close();
    }
}