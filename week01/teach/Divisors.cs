private static List<int> FindDivisors(int number) {
    List<int> results = new(); // dynamic array to store divisors

    // loop from 1 up to number-1
    for (int i = 1; i < number; i++) {
        if (number % i == 0) { // check if i divides number
            results.Add(i);    // add divisor to the list
        }
    }

    return results; // return the list of divisors
}
