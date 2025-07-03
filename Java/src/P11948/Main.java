package P11948;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;

public class Main {

    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        int total = 0;
        ArrayList<Integer> sciences = new ArrayList<>(4);
        sciences.add(Integer.parseInt(br.readLine()));
        sciences.add(Integer.parseInt(br.readLine()));
        sciences.add(Integer.parseInt(br.readLine()));
        sciences.add(Integer.parseInt(br.readLine()));
        sciences.sort((o1, o2) -> o2 - o1);

        total += sciences.get(0) + sciences.get(1) + sciences.get(2);
        total += Math.max(Integer.parseInt(br.readLine()),Integer.parseInt(br.readLine()));

        System.out.println(total);

        br.close();
    }
}
