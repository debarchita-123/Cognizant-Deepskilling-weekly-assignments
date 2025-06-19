import java.util.Scanner;

public class financialForecast {

    public static double futureValueRecursive(double initialValue, double growthRate, int periods) {
        if (periods == 0) {
            return initialValue;
        }
        return futureValueRecursive(initialValue, growthRate, periods - 1) * (1 + growthRate);
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter the Initial value");
        double initialValue = sc.nextDouble(); 
        System.out.println("Enter the growth rate in decimal form");
        double growthRate = sc.nextDouble();     // 5% growth rate
        System.out.println("Enter the period in years");
        int periods = sc.nextInt();             // Forecast for 10 periods

        double futureValue = futureValueRecursive(initialValue, growthRate, periods);
        System.out.println("Future Value after " + periods + " periods: " + futureValue);
    }
}
