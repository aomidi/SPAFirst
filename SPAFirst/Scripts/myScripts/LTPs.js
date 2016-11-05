function Compute(number) {
	var sum = 0;

	while (number !=0)  {
		sum += number % 10;

		number = Math.floor(number / 10);

		if (number<10) {
			sum += number;
			number = 0;
		}
	}
	return sum;
}

function LTP(number) {
	var total = 0;

	for (var i = 0; i < number; i++) {
		total += Compute(i);
	}
	return total;
}

this.onmessage = function (e) {
	var number = e.data.number;

	var result = LTP(number);

	var message = { result: result };
	postMessage(message);
}