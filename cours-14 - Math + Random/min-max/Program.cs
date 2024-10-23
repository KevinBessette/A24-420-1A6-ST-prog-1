double RandomDouble(double min, double max) {
    Random random = new Random();
    return random.NextDouble() * (max - min) + min;
}