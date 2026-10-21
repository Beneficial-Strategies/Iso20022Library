// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Text.RegularExpressions;
using BeneficialStrategies.Iso20022.Samples;

namespace BeneficialStrategies.Iso20022.SamplesTests;

public class PatternSamplerTests
{
    [Theory]
    [InlineData("^[A-Z]{2,2}$", "AA")]
    [InlineData("^[A-Z0-9]{4}[A-Z]{2}[A-Z0-9]{2}([A-Z0-9]{3}){0,1}$", "AAAAAAAA")]
    [InlineData("^(\\+|-)?[\\d]{1,3}(\\.[\\d]{1,8})?/(\\+|-)?[\\d]{1,3}(\\.[\\d]{1,8})?$", "1/1")]
    [InlineData("^[a-z]{4}\\.[0-9]{3}\\.[0-9]{3}\\.[0-9]{2}$", "aaaa.000.000.00")]
    [InlineData("^UNLIMITED$", "UNLIMITED")]
    [InlineData("^\\d{4}-\\d{2}-\\d{2}\\z", "1111-11-11")]
    [InlineData("^[^\\t\\n\\r]*$", "")]
    [InlineData("^.+$", "A")]
    public void AnExampleIsTheSmallestStringThatMatches(string pattern, string expected)
    {
        Assert.Equal(expected, PatternSampler.Sample(pattern));
        Assert.Matches(pattern, expected);
    }

    [Fact]
    public void ExtraRepeatsLengthenWhatThePatternAllows()
    {
        Assert.Equal("AAA", PatternSampler.Sample("^[A-Z]{1,6}$", 2));
        Assert.Equal("AAAAAA", PatternSampler.Sample("^[A-Z]{1,6}$", 9));
    }

    [Theory]
    [InlineData("^(?=a)b$")]
    [InlineData("^\\p{L}+$")]
    [InlineData("^(a$")]
    public void WhatItDoesNotUnderstand_IsNull(string pattern)
    {
        Assert.Null(PatternSampler.Sample(pattern));
    }

    [Fact]
    public void EveryPatternOfTheModel_GivesAStringThatMatchesIt()
    {
        var failures = new List<string>();
        var checkedCount = 0;
        foreach (var type in typeof(Max35Text).Assembly.GetTypes().Where(t => t.IsPublic))
            foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Static).Where(f => f.IsLiteral && f.Name is "Pattern" or "CorePattern"))
            {
                var pattern = (string)field.GetRawConstantValue()!;
                var sample = PatternSampler.Sample(pattern);
                checkedCount++;
                if (sample is null || !Regex.IsMatch(sample, pattern))
                    failures.Add($"{type.Name}: {pattern} -> {sample ?? "null"}");
            }

        Assert.True(checkedCount > 50);
        Assert.True(failures.Count == 0, $"{failures.Count} of {checkedCount}:\n" + string.Join("\n", failures));
    }
}
