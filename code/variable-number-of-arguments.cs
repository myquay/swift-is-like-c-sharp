int SumOf(params int[] numbers){
    var sum = 0;
    foreach (int number in numbers) {
        sum += number;
    }
    return sum;
}

SumOf(42, 597, 12);

//can also be written
int SumOf(params int[] args)
    => args.Sum();

SumOf(42, 597, 12);
