class FizzBuzz
  def get_nth_member(n)
    nth_member = n 
    if ((n % 3 == 0) && (n % 5 == 0))
      nth_member = 'FizzBuzz'
    elsif (n % 3  == 0)
      nth_member = 'Fizz'
    elsif (n % 5 == 0)
      nth_member = 'Buzz'
    end

    nth_member
  end
end
