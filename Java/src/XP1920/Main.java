package XP1920;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        BinaryTree binaryTree = null;

        int n = Integer.parseInt(br.readLine());
        String[] nInput = br.readLine().split(" ");
        for (int i = 0; i < n; i++) {
            int value = Integer.parseInt(nInput[i]);
            if (binaryTree == null) {
                binaryTree = new BinaryTree(value);
                continue;
            }
            BinaryTree parent = binaryTree;
            while (parent != null) {
                if (parent.getValue() == value){
                    break;
                }

                if (parent.getValue() > value) {
                    if (parent.getLeft() == null) {
                        parent.setLeft(value);
                        break;
                    }else{
                        parent = parent.getLeft();
                    }
                }else {
                    if (parent.getRight() == null) {
                        parent.setRight(value);
                        break;
                    }else{
                        parent = parent.getRight();
                    }
                }
            }
        }

        int m = Integer.parseInt(br.readLine());
        String[] mInput = br.readLine().split(" ");

        for (int i = 0; i < m; i++) {
            int value = Integer.parseInt(mInput[i]);
            BinaryTree parent = binaryTree;
            while (parent != null) {
                if (parent.getValue() == value) {
                    break;
                }
                if (parent.getValue() > value) {
                    parent = parent.getLeft();
                }else {
                    parent = parent.getRight();
                }
            }

            if (parent == null) {
                System.out.println(0);
            } else {
                System.out.println(1);
            }
        }
        br.close();
    }
}

class BinaryTree {
    int value ;
    BinaryTree left = null, right = null;

    public BinaryTree(int value) {
        this.value = value;
    }

    public int getValue() {
        return value;
    }
    public BinaryTree getLeft() {
        return left;
    }
    public void setLeft(int value) {
        this.left = new BinaryTree(value);
    }

    public BinaryTree getRight() {
        return right;
    }
    public void setRight(int value) {
        this.right = new BinaryTree(value);
    }
}