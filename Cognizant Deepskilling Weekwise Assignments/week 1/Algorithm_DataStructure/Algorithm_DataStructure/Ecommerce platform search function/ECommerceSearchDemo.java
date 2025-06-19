import java.util.Arrays;
import java.util.Comparator;
import java.util.Scanner;

// Product class
class Product {
    private int productId;
    private String productName;
    private String category;

    public Product(int productId, String productName, String category) {
        this.productId = productId;
        this.productName = productName;
        this.category = category;
    }

    public int getProductId() {
        return productId;
    }

    public String getProductName() {
        return productName;
    }

    public String getCategory() {
        return category;
    }

    @Override
    public String toString() {
        return "Product [ID=" + productId + ", Name=" + productName + ", Category=" + category + "]";
    }
}

// Search algorithms
class ProductSearch {
    // Linear Search
    public static Product linearSearch(Product[] products, int targetId) {
        for (Product product : products) {
            if (product.getProductId() == targetId) {
                return product;
            }
        }
        return null;
    }

    // Binary Search (array must be sorted by productId)
    public static Product binarySearch(Product[] products, int targetId) {
        int left = 0, right = products.length - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (products[mid].getProductId() == targetId) {
                return products[mid];
            } else if (products[mid].getProductId() < targetId) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }
        return null;
    }
}

// Main class
public class ECommerceSearchDemo {
    public static void main(String[] args) {
        Product[] products = {
            new Product(101, "Laptop", "Electronics"),
            new Product(205, "Sneakers", "Footwear"),
            new Product(150, "Smartphone", "Electronics"),
            new Product(120, "Backpack", "Accessories"),
            new Product(180, "Watch", "Accessories")
        };

        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter Product ID to search: ");
        int searchId = scanner.nextInt();

        // Linear Search
        Product foundLinear = ProductSearch.linearSearch(products, searchId);
        if (foundLinear != null) {
            System.out.println("Linear Search: " + foundLinear);
        } else {
            System.out.println("Linear Search: Product not found.");
        }

        // Sort array by productId for binary search
        Arrays.sort(products, Comparator.comparingInt(Product::getProductId));

        // Binary Search
        Product foundBinary = ProductSearch.binarySearch(products, searchId);
        if (foundBinary != null) {
            System.out.println("Binary Search: " + foundBinary);
        } else {
            System.out.println("Binary Search: Product not found.");
        }

        scanner.close();
    }
}