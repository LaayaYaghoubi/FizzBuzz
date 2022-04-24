using System;
using Xunit;
using FizzBuzz;
using FizzBuzz.Logics;
using FluentAssertions;

namespace FizzBuzz.Logic.Tests
{
    public class FizzBuzzTests
    {
        private readonly FizzBuzzGame _sut;

        public FizzBuzzTests()
        {
            _sut = new FizzBuzzGame();
        }

        [Fact]
        public void FizzBuzzGame_Should_print_Fizz_if_current_number_is_divisible_by_3()
        {
            var number = 3;

            var expected = _sut.DivisibleTest(number);

            expected.Should().Be("Fizz");

        }
        [Fact]
        public void FizzBuzzGame_should_print_Buzz_if_current_number_is_divisible_by_5()
        {
            var number = 5;

            var expected = _sut.DivisibleTest(number);

            expected.Should().Be("Buzz");
        }
        [Fact]

        public void FizzBuzzGame_should_print_Buzz_if_current_number_is_divisible_by_3_and_5()
        {
            var number = 15;

            var expected = _sut.DivisibleTest(number);

            expected.Should().Be("FizzBuzz");

        }
    }
}
