package XP1517;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;

public class Main {

    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        ArrayList<Integer> arr = new ArrayList<>();
        int size = Integer.parseInt(br.readLine());
        int changeCnt = 0;

        String[] input = br.readLine().split(" ");
        for (int i = 0; i < size ; i++) {
            arr.add(Integer.valueOf(input[i]));
        }

        br.close();
    }
}