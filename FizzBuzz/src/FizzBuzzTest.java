import static org.junit.jupiter.api.Assertions.*;

import org.junit.Assert;
import org.junit.Rule;
import org.junit.jupiter.api.Test;
import org.junit.rules.ExpectedException;

class FizzBuzzTest {
	@Rule
	public final ExpectedException exception = ExpectedException.none();
	
	@Test
	void test() throws Exception {
		FizzBuzz fizzBuzz = new FizzBuzz();

		try {
			Assert.assertEquals("Buzz", fizzBuzz.generate(5));
			Assert.assertEquals("Fizz", fizzBuzz.generate(3));
			Assert.assertEquals("1", fizzBuzz.generate(1));
			Assert.assertEquals("Fizz", fizzBuzz.generate(99));
			Assert.assertEquals("Buzz", fizzBuzz.generate(100));
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	@Test
	void testEntireRun() throws Exception {
		FizzBuzz fizzBuzz = new FizzBuzz();
		Assert.assertEquals("12Fizz4BuzzFizz78FizzBuzz11Fizz1314Buzz1617Fizz19BuzzFizz2223FizzBuzz26Fizz2829Buzz3132Fizz34BuzzFizz3738FizzBuzz41Fizz4344Buzz4647Fizz49BuzzFizz5253FizzBuzz56Fizz5859Buzz6162Fizz64BuzzFizz6768FizzBuzz71Fizz7374Buzz7677Fizz79BuzzFizz8283FizzBuzz86Fizz8889Buzz9192Fizz94BuzzFizz9798FizzBuzz",fizzBuzz.generateAll());
	}
	
	@Test
	void testZeroException() throws Exception {
		FizzBuzz fizzBuzz = new FizzBuzz();
		//assertThrows(Exception.class,fizzBuzz.generate(0));
	}
}
