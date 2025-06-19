import java.util.Scanner;
public class Test {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Logger logger = Logger.getInstance();  // Singleton instance
        System.out.println("Enter log messages (type 'exit' to quit):");
        while (true) {
            System.out.print(">> ");
            String input = scanner.nextLine();
            if (input.equalsIgnoreCase("exit")) {
                System.out.println("Exiting logger...");
                break;
            }
            logger.log(input);
        }
        scanner.close();
    }
}
