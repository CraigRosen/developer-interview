
public class FizzBuzz {
	public String generate(Integer passedInt) throws Exception {
		
		if(passedInt <=0 ||passedInt > 100)
			throw new Exception("Invalid Passed Integer");
		
		String retVal = passedInt.toString();
		if(passedInt%3==0) {
			retVal =  "Fizz";
		}
		if(passedInt%5==0) {
			retVal= "Buzz";
		}
		return retVal;
	}

	public String generateAll() throws Exception{
		String result = "";
		// TODO Auto-generated constructor stub
		for (int i=1; i<=100; i++) {
			result += this.generate(i);
		}
		System.out.println(result);
		return result;
	}

	public FizzBuzz() throws Exception {
		super();
		// TODO Auto-generated constructor stub
		this.generateAll();
	}
	

}
