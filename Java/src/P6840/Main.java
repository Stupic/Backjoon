package P6840;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class Main {

    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        Integer[] list = new Integer[3];
        list[0] = Integer.parseInt(br.readLine());
        list[1] = Integer.parseInt(br.readLine());
        list[2] = Integer.parseInt(br.readLine());
        System.out.println(Arrays.stream(list).sorted().toArray()[1]);
        br.close();
    }
}