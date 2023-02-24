// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DateTimeExtensionsTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.DateTime.Recipes.Test
{
    using System;

    using OBeautifulCode.Assertion.Recipes;

    using Xunit;

    public static class DateTimeExtensionsTest
    {
        [Fact]
        public static void Next___Should_return_next_occurrence_of_specified_day_of_week___When_called()
        {
            var referenceDate1 = new DateTime(2010, 11, 21);
            Assert.Equal(new DateTime(2010, 11, 28), referenceDate1.Next(DayOfWeek.Sunday));
            Assert.Equal(new DateTime(2010, 11, 22), referenceDate1.Next(DayOfWeek.Monday));
            Assert.Equal(new DateTime(2010, 11, 23), referenceDate1.Next(DayOfWeek.Tuesday));
            Assert.Equal(new DateTime(2010, 11, 24), referenceDate1.Next(DayOfWeek.Wednesday));
            Assert.Equal(new DateTime(2010, 11, 25), referenceDate1.Next(DayOfWeek.Thursday));
            Assert.Equal(new DateTime(2010, 11, 26), referenceDate1.Next(DayOfWeek.Friday));
            Assert.Equal(new DateTime(2010, 11, 27), referenceDate1.Next(DayOfWeek.Saturday));

            var referenceDate2 = new DateTime(2010, 11, 22);
            Assert.Equal(new DateTime(2010, 11, 28), referenceDate2.Next(DayOfWeek.Sunday));
            Assert.Equal(new DateTime(2010, 11, 29), referenceDate2.Next(DayOfWeek.Monday));
            Assert.Equal(new DateTime(2010, 11, 23), referenceDate2.Next(DayOfWeek.Tuesday));
            Assert.Equal(new DateTime(2010, 11, 24), referenceDate2.Next(DayOfWeek.Wednesday));
            Assert.Equal(new DateTime(2010, 11, 25), referenceDate2.Next(DayOfWeek.Thursday));
            Assert.Equal(new DateTime(2010, 11, 26), referenceDate2.Next(DayOfWeek.Friday));
            Assert.Equal(new DateTime(2010, 11, 27), referenceDate2.Next(DayOfWeek.Saturday));

            var referenceDate3 = new DateTime(2010, 11, 23);
            Assert.Equal(new DateTime(2010, 11, 28), referenceDate3.Next(DayOfWeek.Sunday));
            Assert.Equal(new DateTime(2010, 11, 29), referenceDate3.Next(DayOfWeek.Monday));
            Assert.Equal(new DateTime(2010, 11, 30), referenceDate3.Next(DayOfWeek.Tuesday));
            Assert.Equal(new DateTime(2010, 11, 24), referenceDate3.Next(DayOfWeek.Wednesday));
            Assert.Equal(new DateTime(2010, 11, 25), referenceDate3.Next(DayOfWeek.Thursday));
            Assert.Equal(new DateTime(2010, 11, 26), referenceDate3.Next(DayOfWeek.Friday));
            Assert.Equal(new DateTime(2010, 11, 27), referenceDate3.Next(DayOfWeek.Saturday));

            var referenceDate4 = new DateTime(2010, 11, 24);
            Assert.Equal(new DateTime(2010, 11, 28), referenceDate4.Next(DayOfWeek.Sunday));
            Assert.Equal(new DateTime(2010, 11, 29), referenceDate4.Next(DayOfWeek.Monday));
            Assert.Equal(new DateTime(2010, 11, 30), referenceDate4.Next(DayOfWeek.Tuesday));
            Assert.Equal(new DateTime(2010, 12, 1), referenceDate4.Next(DayOfWeek.Wednesday));
            Assert.Equal(new DateTime(2010, 11, 25), referenceDate4.Next(DayOfWeek.Thursday));
            Assert.Equal(new DateTime(2010, 11, 26), referenceDate4.Next(DayOfWeek.Friday));
            Assert.Equal(new DateTime(2010, 11, 27), referenceDate4.Next(DayOfWeek.Saturday));

            var referenceDate5 = new DateTime(2010, 11, 25);
            Assert.Equal(new DateTime(2010, 11, 28), referenceDate5.Next(DayOfWeek.Sunday));
            Assert.Equal(new DateTime(2010, 11, 29), referenceDate5.Next(DayOfWeek.Monday));
            Assert.Equal(new DateTime(2010, 11, 30), referenceDate5.Next(DayOfWeek.Tuesday));
            Assert.Equal(new DateTime(2010, 12, 1), referenceDate5.Next(DayOfWeek.Wednesday));
            Assert.Equal(new DateTime(2010, 12, 2), referenceDate5.Next(DayOfWeek.Thursday));
            Assert.Equal(new DateTime(2010, 11, 26), referenceDate5.Next(DayOfWeek.Friday));
            Assert.Equal(new DateTime(2010, 11, 27), referenceDate5.Next(DayOfWeek.Saturday));

            var referenceDate6 = new DateTime(2010, 11, 26);
            Assert.Equal(new DateTime(2010, 11, 28), referenceDate6.Next(DayOfWeek.Sunday));
            Assert.Equal(new DateTime(2010, 11, 29), referenceDate6.Next(DayOfWeek.Monday));
            Assert.Equal(new DateTime(2010, 11, 30), referenceDate6.Next(DayOfWeek.Tuesday));
            Assert.Equal(new DateTime(2010, 12, 1), referenceDate6.Next(DayOfWeek.Wednesday));
            Assert.Equal(new DateTime(2010, 12, 2), referenceDate6.Next(DayOfWeek.Thursday));
            Assert.Equal(new DateTime(2010, 12, 3), referenceDate6.Next(DayOfWeek.Friday));
            Assert.Equal(new DateTime(2010, 11, 27), referenceDate6.Next(DayOfWeek.Saturday));

            var referenceDate7 = new DateTime(2010, 11, 27);
            Assert.Equal(new DateTime(2010, 11, 28), referenceDate7.Next(DayOfWeek.Sunday));
            Assert.Equal(new DateTime(2010, 11, 29), referenceDate7.Next(DayOfWeek.Monday));
            Assert.Equal(new DateTime(2010, 11, 30), referenceDate7.Next(DayOfWeek.Tuesday));
            Assert.Equal(new DateTime(2010, 12, 1), referenceDate7.Next(DayOfWeek.Wednesday));
            Assert.Equal(new DateTime(2010, 12, 2), referenceDate7.Next(DayOfWeek.Thursday));
            Assert.Equal(new DateTime(2010, 12, 3), referenceDate7.Next(DayOfWeek.Friday));
            Assert.Equal(new DateTime(2010, 12, 4), referenceDate7.Next(DayOfWeek.Saturday));
        }

        [Fact]
        public static void Previous___Should_return_occurrence_of_specified_day_of_week___When_called()
        {
            var referenceDate1 = new DateTime(2010, 11, 7);
            Assert.Equal(new DateTime(2010, 10, 31), referenceDate1.Previous(DayOfWeek.Sunday));
            Assert.Equal(new DateTime(2010, 11, 1), referenceDate1.Previous(DayOfWeek.Monday));
            Assert.Equal(new DateTime(2010, 11, 2), referenceDate1.Previous(DayOfWeek.Tuesday));
            Assert.Equal(new DateTime(2010, 11, 3), referenceDate1.Previous(DayOfWeek.Wednesday));
            Assert.Equal(new DateTime(2010, 11, 4), referenceDate1.Previous(DayOfWeek.Thursday));
            Assert.Equal(new DateTime(2010, 11, 5), referenceDate1.Previous(DayOfWeek.Friday));
            Assert.Equal(new DateTime(2010, 11, 6), referenceDate1.Previous(DayOfWeek.Saturday));

            var referenceDate2 = new DateTime(2010, 11, 8);
            Assert.Equal(new DateTime(2010, 11, 7), referenceDate2.Previous(DayOfWeek.Sunday));
            Assert.Equal(new DateTime(2010, 11, 1), referenceDate2.Previous(DayOfWeek.Monday));
            Assert.Equal(new DateTime(2010, 11, 2), referenceDate2.Previous(DayOfWeek.Tuesday));
            Assert.Equal(new DateTime(2010, 11, 3), referenceDate2.Previous(DayOfWeek.Wednesday));
            Assert.Equal(new DateTime(2010, 11, 4), referenceDate2.Previous(DayOfWeek.Thursday));
            Assert.Equal(new DateTime(2010, 11, 5), referenceDate2.Previous(DayOfWeek.Friday));
            Assert.Equal(new DateTime(2010, 11, 6), referenceDate2.Previous(DayOfWeek.Saturday));

            var referenceDate3 = new DateTime(2010, 11, 9);
            Assert.Equal(new DateTime(2010, 11, 7), referenceDate3.Previous(DayOfWeek.Sunday));
            Assert.Equal(new DateTime(2010, 11, 8), referenceDate3.Previous(DayOfWeek.Monday));
            Assert.Equal(new DateTime(2010, 11, 2), referenceDate3.Previous(DayOfWeek.Tuesday));
            Assert.Equal(new DateTime(2010, 11, 3), referenceDate3.Previous(DayOfWeek.Wednesday));
            Assert.Equal(new DateTime(2010, 11, 4), referenceDate3.Previous(DayOfWeek.Thursday));
            Assert.Equal(new DateTime(2010, 11, 5), referenceDate3.Previous(DayOfWeek.Friday));
            Assert.Equal(new DateTime(2010, 11, 6), referenceDate3.Previous(DayOfWeek.Saturday));

            var referenceDate4 = new DateTime(2010, 11, 10);
            Assert.Equal(new DateTime(2010, 11, 7), referenceDate4.Previous(DayOfWeek.Sunday));
            Assert.Equal(new DateTime(2010, 11, 8), referenceDate4.Previous(DayOfWeek.Monday));
            Assert.Equal(new DateTime(2010, 11, 9), referenceDate4.Previous(DayOfWeek.Tuesday));
            Assert.Equal(new DateTime(2010, 11, 3), referenceDate4.Previous(DayOfWeek.Wednesday));
            Assert.Equal(new DateTime(2010, 11, 4), referenceDate4.Previous(DayOfWeek.Thursday));
            Assert.Equal(new DateTime(2010, 11, 5), referenceDate4.Previous(DayOfWeek.Friday));
            Assert.Equal(new DateTime(2010, 11, 6), referenceDate4.Previous(DayOfWeek.Saturday));

            var referenceDate5 = new DateTime(2010, 11, 11);
            Assert.Equal(new DateTime(2010, 11, 7), referenceDate5.Previous(DayOfWeek.Sunday));
            Assert.Equal(new DateTime(2010, 11, 8), referenceDate5.Previous(DayOfWeek.Monday));
            Assert.Equal(new DateTime(2010, 11, 9), referenceDate5.Previous(DayOfWeek.Tuesday));
            Assert.Equal(new DateTime(2010, 11, 10), referenceDate5.Previous(DayOfWeek.Wednesday));
            Assert.Equal(new DateTime(2010, 11, 4), referenceDate5.Previous(DayOfWeek.Thursday));
            Assert.Equal(new DateTime(2010, 11, 5), referenceDate5.Previous(DayOfWeek.Friday));
            Assert.Equal(new DateTime(2010, 11, 6), referenceDate5.Previous(DayOfWeek.Saturday));

            var referenceDate6 = new DateTime(2010, 11, 12);
            Assert.Equal(new DateTime(2010, 11, 7), referenceDate6.Previous(DayOfWeek.Sunday));
            Assert.Equal(new DateTime(2010, 11, 8), referenceDate6.Previous(DayOfWeek.Monday));
            Assert.Equal(new DateTime(2010, 11, 9), referenceDate6.Previous(DayOfWeek.Tuesday));
            Assert.Equal(new DateTime(2010, 11, 10), referenceDate6.Previous(DayOfWeek.Wednesday));
            Assert.Equal(new DateTime(2010, 11, 11), referenceDate6.Previous(DayOfWeek.Thursday));
            Assert.Equal(new DateTime(2010, 11, 5), referenceDate6.Previous(DayOfWeek.Friday));
            Assert.Equal(new DateTime(2010, 11, 6), referenceDate6.Previous(DayOfWeek.Saturday));

            var referenceDate7 = new DateTime(2010, 11, 13);
            Assert.Equal(new DateTime(2010, 11, 7), referenceDate7.Previous(DayOfWeek.Sunday));
            Assert.Equal(new DateTime(2010, 11, 8), referenceDate7.Previous(DayOfWeek.Monday));
            Assert.Equal(new DateTime(2010, 11, 9), referenceDate7.Previous(DayOfWeek.Tuesday));
            Assert.Equal(new DateTime(2010, 11, 10), referenceDate7.Previous(DayOfWeek.Wednesday));
            Assert.Equal(new DateTime(2010, 11, 11), referenceDate7.Previous(DayOfWeek.Thursday));
            Assert.Equal(new DateTime(2010, 11, 12), referenceDate7.Previous(DayOfWeek.Friday));
            Assert.Equal(new DateTime(2010, 11, 6), referenceDate7.Previous(DayOfWeek.Saturday));
        }

        [Fact]
        public static void ToUtc_DateTime___Should_return_value___When_value_is_already_in_Utc()
        {
            // Arrange
            var expected = DateTime.UtcNow;

            // Act
            var actual = expected.ToUtc();

            // Assert
            actual.AsTest().Must().BeEqualTo(expected);
        }

        [Fact]
        public static void ToUtc_DateTime___Should_return_value_with_Kind_changed_to_Utc___When_value_is_an_Unspecified_time()
        {
            // Arrange
            var value = new DateTime(2021, 10, 20, 21, 29, 16, DateTimeKind.Unspecified);
            var expected = new DateTime(2021, 10, 20, 21, 29, 16, DateTimeKind.Utc);

            // Act
            var actual = value.ToUtc();

            // Assert
            actual.AsTest().Must().BeEqualTo(expected);
        }

        [Fact(Skip = "Local time depends on where this test is running.")]
        public static void ToUtc_DateTime___Should_return_value_converted_into_Utc___When_value_is_a_local_time()
        {
        }

        [Fact]
        public static void ToUtc_Nullable_DateTime___Should_throw_ArgumentNullException___When_value_is_null()
        {
            // Arrange
            DateTime? value = null;

            // Act
            var actual = Record.Exception(() => value.ToUtc());

            // Assert
            actual.AsTest().Must().BeOfType<ArgumentNullException>();
        }

        [Fact]
        public static void ToUtc_Nullable_DateTime___Should_return_value___When_value_is_already_in_Utc()
        {
            // Arrange
            DateTime? expected = DateTime.UtcNow;

            // Act
            var actual = expected.ToUtc();

            // Assert
            actual.AsTest().Must().BeEqualTo((DateTime)expected);
        }

        [Fact]
        public static void ToUtc_Nullable_DateTime___Should_return_value_with_Kind_changed_to_Utc___When_value_is_an_Unspecified_time()
        {
            // Arrange
            DateTime? value = new DateTime(2021, 10, 20, 21, 29, 16, DateTimeKind.Unspecified);
            var expected = new DateTime(2021, 10, 20, 21, 29, 16, DateTimeKind.Utc);

            // Act
            var actual = value.ToUtc();

            // Assert
            actual.AsTest().Must().BeEqualTo(expected);
        }

        [Fact(Skip = "Local time depends on where this test is running.")]
        public static void ToUtc_Nullable_DateTime___Should_return_value_converted_into_Utc___When_value_is_a_local_time()
        {
        }

        [Fact]
        public static void ToUnspecified_Nullable_DateTime___Should_throw_ArgumentNullException___When_value_is_null()
        {
            // Arrange
            DateTime? value = null;

            // Act
            var actual = Record.Exception(() => value.ToUnspecified());

            // Assert
            actual.AsTest().Must().BeOfType<ArgumentNullException>();
        }

        [Fact]
        public static void ToUnspecified_DateTime___Should_return_value___When_value_is_already_Unspecified()
        {
            // Arrange
            var expected = new DateTime(2021, 10, 20, 21, 29, 16, DateTimeKind.Unspecified);

            // Act
            var actual = expected.ToUnspecified();

            // Assert
            actual.AsTest().Must().BeEqualTo(expected);
        }

        [Fact]
        public static void ToUnspecified_DateTime___Should_return_value_with_Kind_changed_to_Unspecified___When_value_is_an_Utc_time()
        {
            // Arrange
            var value = new DateTime(2021, 10, 20, 21, 29, 16, DateTimeKind.Utc);
            var expected = new DateTime(2021, 10, 20, 21, 29, 16, DateTimeKind.Unspecified);

            // Act
            var actual = value.ToUnspecified();

            // Assert
            actual.AsTest().Must().BeEqualTo(expected);
        }

        [Fact]
        public static void ToUnspecified_DateTime___Should_return_value_with_Kind_changed_to_Unspecified___When_value_is_a_Local_time()
        {
            // Arrange
            var value = new DateTime(2021, 10, 20, 21, 29, 16, DateTimeKind.Local);
            var expected = new DateTime(2021, 10, 20, 21, 29, 16, DateTimeKind.Unspecified);

            // Act
            var actual = value.ToUnspecified();

            // Assert
            actual.AsTest().Must().BeEqualTo(expected);
        }

        [Fact]
        public static void ToUnspecified_Nullable_DateTime___Should_return_value___When_value_is_already_Unspecified()
        {
            // Arrange
            DateTime? expected = new DateTime(2021, 10, 20, 21, 29, 16, DateTimeKind.Unspecified);

            // Act
            var actual = expected.ToUnspecified();

            // Assert
            actual.AsTest().Must().BeEqualTo((DateTime)expected);
        }

        [Fact]
        public static void ToUnspecified_Nullable_DateTime___Should_return_value_with_Kind_changed_to_Unspecified___When_value_is_an_Utc_time()
        {
            // Arrange
            DateTime? value = new DateTime(2021, 10, 20, 21, 29, 16, DateTimeKind.Utc);
            var expected = new DateTime(2021, 10, 20, 21, 29, 16, DateTimeKind.Unspecified);

            // Act
            var actual = value.ToUnspecified();

            // Assert
            actual.AsTest().Must().BeEqualTo(expected);
        }

        [Fact]
        public static void ToUnspecified_Nullable_DateTime___Should_return_value_with_Kind_changed_to_Unspecified___When_value_is_a_Local_time()
        {
            // Arrange
            DateTime? value = new DateTime(2021, 10, 20, 21, 29, 16, DateTimeKind.Local);
            var expected = new DateTime(2021, 10, 20, 21, 29, 16, DateTimeKind.Unspecified);

            // Act
            var actual = value.ToUnspecified();

            // Assert
            actual.AsTest().Must().BeEqualTo(expected);
        }

        [Fact]
        public static void RewindToEvenMinute___Should_remove_partial_minutes___When_value_has_partial_minutes()
        {
            // Arrange
            var input1 = new DateTime(2020, 10, 10, 16, 20, 13, DateTimeKind.Unspecified);
            var input2 = new DateTime(2020, 10, 10, 16, 20, 13, DateTimeKind.Local);
            var input3 = new DateTime(2020, 10, 10, 16, 20, 13, DateTimeKind.Utc);

            var expected1 = new DateTime(2020, 10, 10, 16, 20, 0, DateTimeKind.Unspecified);
            var expected2 = new DateTime(2020, 10, 10, 16, 20, 0, DateTimeKind.Local);
            var expected3 = new DateTime(2020, 10, 10, 16, 20, 0, DateTimeKind.Utc);

            // Act
            var actual1 = input1.RewindToEvenMinute();
            var actual2 = input2.RewindToEvenMinute();
            var actual3 = input3.RewindToEvenMinute();

            // Assert
            actual1.MustForTest().BeEqualTo(expected1);
            actual2.MustForTest().BeEqualTo(expected2);
            actual3.MustForTest().BeEqualTo(expected3);
        }

        [Fact]
        public static void RewindToNextMatchingHourAndMinute___Should_fail___With_invalid_inputs()
        {
            var exception1 = Record.Exception(() => DateTime.UtcNow.RewindToNextMatchingHourAndMinute(-1, 10));
            exception1.MustForTest().BeOfType<ArgumentException>();
            exception1?.Message.MustForTest().ContainString("The hour of the day cannot be less than 0.  It was -1");

            var exception2 = Record.Exception(() => DateTime.UtcNow.RewindToNextMatchingHourAndMinute(24, 10));
            exception2.MustForTest().BeOfType<ArgumentException>();
            exception2?.Message.MustForTest().ContainString("The hour of the day cannot be more than 23.  It was 24");

            var exception3 = Record.Exception(() => DateTime.UtcNow.RewindToNextMatchingHourAndMinute(10, -1));
            exception3.MustForTest().BeOfType<ArgumentException>();
            exception3?.Message.MustForTest().ContainString("The minute of the hour cannot be less than 0.  It was -1");

            var exception4 = Record.Exception(() => DateTime.UtcNow.RewindToNextMatchingHourAndMinute(10, 60));
            exception4.MustForTest().BeOfType<ArgumentException>();
            exception4?.Message.MustForTest().ContainString("The minute of the hour cannot be more than 59.  It was 60");
        }

        [Fact]
        public static void RewindToNextMatchingHourAndMinute___Should_rollback_to_next_DateTime_matching_inputs___Based_on_input()
        {
            // Arrange
            var expectedHour = 16;
            var input1 = new DateTime(2020, 10, 10, expectedHour, 20, 13, DateTimeKind.Unspecified);
            var input2 = new DateTime(2020, 10, 10, expectedHour, 10, 13, DateTimeKind.Local);
            var input3 = new DateTime(2020, 10, 10, expectedHour, 15, 13, DateTimeKind.Utc);

            var expectedMinute = 15;
            var expected1 = new DateTime(2020, 10, 10, expectedHour, expectedMinute, 13, DateTimeKind.Unspecified);
            var expected2 = new DateTime(2020, 10, 9, expectedHour, expectedMinute, 13, DateTimeKind.Local);
            var expected3 = new DateTime(2020, 10, 9, expectedHour, expectedMinute, 13, DateTimeKind.Utc);

            // Act
            var actual1 = input1.RewindToNextMatchingHourAndMinute(expectedHour, expectedMinute);
            var actual2 = input2.RewindToNextMatchingHourAndMinute(expectedHour, expectedMinute);
            var actual3 = input3.RewindToNextMatchingHourAndMinute(expectedHour, expectedMinute);

            // Assert
            actual1.MustForTest().BeEqualTo(expected1);
            actual2.MustForTest().BeEqualTo(expected2);
            actual3.MustForTest().BeEqualTo(expected3);
        }

        [Fact]
        public static void RewindToNextMatchingMinute___Should_fail___With_invalid_inputs()
        {
            var exception1 = Record.Exception(() => DateTime.UtcNow.RewindToNextMatchingMinute(-1));
            exception1.MustForTest().BeOfType<ArgumentException>();
            exception1?.Message.MustForTest().ContainString("The minute of the hour cannot be less than 0.  It was -1");

            var exception2 = Record.Exception(() => DateTime.UtcNow.RewindToNextMatchingMinute(60));
            exception2.MustForTest().BeOfType<ArgumentException>();
            exception2?.Message.MustForTest().ContainString("The minute of the hour cannot be more than 59.  It was 60");
        }

        [Fact]
        public static void RewindToNextMatchingMinute___Should_rollback_to_next_DateTime_matching_inputs___Based_on_input()
        {
            // Arrange
            var input1 = new DateTime(2020, 10, 10, 16, 20, 13, DateTimeKind.Unspecified);
            var input2 = new DateTime(2020, 10, 10, 16, 10, 13, DateTimeKind.Local);
            var input3 = new DateTime(2020, 10, 10, 16, 15, 13, DateTimeKind.Utc);

            var expectedMinute = 15;
            var expected1 = new DateTime(2020, 10, 10, 16, expectedMinute, 13, DateTimeKind.Unspecified);
            var expected2 = new DateTime(2020, 10, 10, 15, expectedMinute, 13, DateTimeKind.Local);
            var expected3 = new DateTime(2020, 10, 10, 15, expectedMinute, 13, DateTimeKind.Utc);

            // Act
            var actual1 = input1.RewindToNextMatchingMinute(expectedMinute);
            var actual2 = input2.RewindToNextMatchingMinute(expectedMinute);
            var actual3 = input3.RewindToNextMatchingMinute(expectedMinute);

            // Assert
            actual1.MustForTest().BeEqualTo(expected1);
            actual2.MustForTest().BeEqualTo(expected2);
            actual3.MustForTest().BeEqualTo(expected3);
        }

        [Fact]
        public static void AdvanceToNextMatchingHourAndMinute___Should_fail___With_invalid_inputs()
        {
            var exception1 = Record.Exception(() => DateTime.UtcNow.AdvanceToNextMatchingHourAndMinute(-1, 10));
            exception1.MustForTest().BeOfType<ArgumentException>();
            exception1?.Message.MustForTest().ContainString("The hour of the day cannot be less than 0.  It was -1");

            var exception2 = Record.Exception(() => DateTime.UtcNow.AdvanceToNextMatchingHourAndMinute(24, 10));
            exception2.MustForTest().BeOfType<ArgumentException>();
            exception2?.Message.MustForTest().ContainString("The hour of the day cannot be more than 23.  It was 24");

            var exception3 = Record.Exception(() => DateTime.UtcNow.AdvanceToNextMatchingHourAndMinute(10, -1));
            exception3.MustForTest().BeOfType<ArgumentException>();
            exception3?.Message.MustForTest().ContainString("The minute of the hour cannot be less than 0.  It was -1");

            var exception4 = Record.Exception(() => DateTime.UtcNow.AdvanceToNextMatchingHourAndMinute(10, 60));
            exception4.MustForTest().BeOfType<ArgumentException>();
            exception4?.Message.MustForTest().ContainString("The minute of the hour cannot be more than 59.  It was 60");
        }

        [Fact]
        public static void AdvanceToNextMatchingHourAndMinute___Should_advance_to_next_DateTime_matching_inputs___Based_on_input()
        {
            // Arrange
            var expectedHour = 16;
            var input1 = new DateTime(2020, 10, 10, expectedHour, 20, 13, DateTimeKind.Unspecified);
            var input2 = new DateTime(2020, 10, 10, expectedHour, 10, 13, DateTimeKind.Local);
            var input3 = new DateTime(2020, 10, 10, expectedHour, 15, 13, DateTimeKind.Utc);

            var expectedMinute = 15;
            var expected1 = new DateTime(2020, 10, 11, expectedHour, expectedMinute, 13, DateTimeKind.Unspecified);
            var expected2 = new DateTime(2020, 10, 10, expectedHour, expectedMinute, 13, DateTimeKind.Local);
            var expected3 = new DateTime(2020, 10, 11, expectedHour, expectedMinute, 13, DateTimeKind.Utc);

            // Act
            var actual1 = input1.AdvanceToNextMatchingHourAndMinute(expectedHour, expectedMinute);
            var actual2 = input2.AdvanceToNextMatchingHourAndMinute(expectedHour, expectedMinute);
            var actual3 = input3.AdvanceToNextMatchingHourAndMinute(expectedHour, expectedMinute);

            // Assert
            actual1.MustForTest().BeEqualTo(expected1);
            actual2.MustForTest().BeEqualTo(expected2);
            actual3.MustForTest().BeEqualTo(expected3);
        }

        [Fact]
        public static void AdvanceToNextMatchingMinute___Should_fail___With_invalid_inputs()
        {
            var exception1 = Record.Exception(() => DateTime.UtcNow.AdvanceToNextMatchingMinute(-1));
            exception1.MustForTest().BeOfType<ArgumentException>();
            exception1?.Message.MustForTest().ContainString("The minute of the hour cannot be less than 0.  It was -1");

            var exception2 = Record.Exception(() => DateTime.UtcNow.AdvanceToNextMatchingMinute(60));
            exception2.MustForTest().BeOfType<ArgumentException>();
            exception2?.Message.MustForTest().ContainString("The minute of the hour cannot be more than 59.  It was 60");
        }

        [Fact]
        public static void AdvanceToNextMatchingMinute___Should_advance_to_next_DateTime_matching_inputs___Based_on_input()
        {
            // Arrange
            var input1 = new DateTime(2020, 10, 10, 16, 20, 13, DateTimeKind.Unspecified);
            var input2 = new DateTime(2020, 10, 10, 16, 10, 13, DateTimeKind.Local);
            var input3 = new DateTime(2020, 10, 10, 16, 15, 13, DateTimeKind.Utc);

            var expectedMinute = 15;
            var expected1 = new DateTime(2020, 10, 10, 17, expectedMinute, 13, DateTimeKind.Unspecified);
            var expected2 = new DateTime(2020, 10, 10, 16, expectedMinute, 13, DateTimeKind.Local);
            var expected3 = new DateTime(2020, 10, 10, 17, expectedMinute, 13, DateTimeKind.Utc);

            // Act
            var actual1 = input1.AdvanceToNextMatchingMinute(expectedMinute);
            var actual2 = input2.AdvanceToNextMatchingMinute(expectedMinute);
            var actual3 = input3.AdvanceToNextMatchingMinute(expectedMinute);

            // Assert
            actual1.MustForTest().BeEqualTo(expected1);
            actual2.MustForTest().BeEqualTo(expected2);
            actual3.MustForTest().BeEqualTo(expected3);
        }
    }
}
