require_relative '../lib/fizz_buzz.rb'

describe 'FizzBuzz' do
  it 'returns 1 when given 1' do
    expect(FizzBuzz.new.get_nth_member(1)).to eq(1)
  end
  it 'returns 2 when given 2' do
    expect(FizzBuzz.new.get_nth_member(2)).to eq(2)
  end
  it 'returns Fizz when given 3' do
    expect(FizzBuzz.new.get_nth_member(3)).to eq('Fizz')
  end
  it 'returns Fizz when given 6' do
    expect(FizzBuzz.new.get_nth_member(6)).to eq('Fizz')
  end
  it 'returns Buzz when given 5' do
    expect(FizzBuzz.new.get_nth_member(5)).to eq('Buzz')
  end
  it 'returns Buzz when given 10' do
    expect(FizzBuzz.new.get_nth_member(10)).to eq('Buzz')
  end
  it 'returns FizzBuzz when given 15' do
    expect(FizzBuzz.new.get_nth_member(15)).to eq('FizzBuzz')
  end
end 
