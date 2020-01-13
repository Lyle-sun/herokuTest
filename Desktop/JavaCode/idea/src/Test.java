import java.util.Arrays;

public class Test {
    public static void main(String[] args) {
       int[] arr={1,6,9,5,4,2,77,3};
       Arrays.sort(arr);
        System.out.println(Arrays.toString(arr));
        System.out.println(sort(arr,6));
    }

    public static int sort(int[] arr,int num){
        int low=0;
        int high=arr.length-1;
        while (low<=high){
            int mid=(low+high)/2;
            if(num==arr[mid]){
                return mid;
            }
            if(num>mid){
                low=mid+1;
            }
            if(num<mid){
                high=mid-1;
            }
        }
        return -1;
    }
}
