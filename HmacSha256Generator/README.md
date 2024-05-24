# HMAC-SHA256 Key Generation and Hash Computation

This C# console application demonstrates how to generate a secure cryptographic key and compute the HMAC-SHA256 hash of a given data string. The program ensures the key size meets the requirements of the HMAC-SHA256 algorithm (greater than 256 bits) and securely handles cryptographic operations.

## Features
- **Secure Key Generation**: Generates a cryptographic key with a size greater than 256 bits using `RandomNumberGenerator`.
- **HMAC-SHA256 Hashing**: Computes the HMAC-SHA256 hash for any given input data.
- **Key Size Validation**: Ensures the key size is appropriate for HMAC-SHA256.
- **Base64 Output**: Outputs the computed HMAC-SHA256 hash in Base64 format.

## Usage
1. Clone the repository.
2. Modify the `data` string variable in the code to the data you want to hash.
3. Run the program to generate a secure key and compute the HMAC-SHA256 hash.
4. The computed hash will be displayed in the console output.

## Installation
1. Ensure you have .NET installed on your machine.
2. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/HMAC-SHA256-Key-Generation.git
    ```
3. Open the project in your preferred C# IDE (e.g., Visual Studio).
4. Build and run the project.
