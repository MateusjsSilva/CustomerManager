# CustomerManagementSystem

The `CustomerManagementSystem` is a C# console application for managing basic customer information and calculating taxes based on the type of customer. The system supports two types of customers: Individual and Corporate.

## Features

- **Customer Registration**: Users can input the customer's name and address.
- **Individual**:
  - Register CPF and RG.
  - Calculate tax based on the purchase amount.
- **Corporate**:
  - Register CNPJ and IE.
  - Calculate tax based on the purchase amount.
- **Information Display**: The system shows the customer's information, including the purchase amount, calculated tax, and total amount due.

## How to Use

1. **Compile and Run the Program**:
   - Ensure that the .NET SDK is installed on your system.
   - Navigate to the project directory and run:

    ```bash
    dotnet run
    ```

2. **Interact with the Program**:
   - Enter the customer's name and address.
   - Choose the type of customer (`f` for Individual or `j` for Corporate).
   - Provide additional required information (CPF, RG, CNPJ, IE).
   - Enter the purchase amount.
   - The program will calculate the tax and display all relevant information.

## Contribution

Feel free to open issues or submit pull requests. All contributions are welcome!

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.