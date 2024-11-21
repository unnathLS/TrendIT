public class Ex03 {
    public static void main(String[] args) {
        double i = 10;
        System.out.println("i = " + i);
        System.out.println("i= " + i + " + 5     | i = " + (i = i + 5));
        System.out.println("i= " + i + " - 5     | i = " + (i = i - 5));
        System.out.println("i= " + i + " * 5     | i = " + (i = i * 5));
        System.out.println("i= " + i + " / 5     | i = " + (i = i / 5));
        System.out.println("i= " + i + " % 5     | i = " + (i = i % 5));
        System.out.println("i= += 5         | i = " + (i = i += 5));
        System.out.println("i= -= 5         | i = " + (i = i -= 5));
        System.out.println("i= *= 5         | i = " + (i = i *= 5));
        System.out.println("i= /= 5         | i = " + (i = i /= 5));
        i++;        
        System.err.println("i++             | i = " + (+ i));
        i--;        
        System.err.println("i--             | i = " + (+ i));
    }
}
