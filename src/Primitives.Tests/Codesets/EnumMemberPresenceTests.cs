// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using BeneficialStrategies.Iso20022.Codesets;
using Xunit.Abstractions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Verifies that every enum in the library assembly has at least one member.
/// An empty enum cannot be assigned a value, making any required field that uses it
/// impossible to populate — a fatal defect.
/// </summary>
public class EnumMemberPresenceTests(ITestOutputHelper output)
{
    [Fact]
    public void AllEnums_HaveAtLeastOneMember()
    {
        var assembly = typeof(CreditDebitCode).Assembly;

        var emptyEnums = assembly
            .GetTypes()
            .Where(t => t.IsEnum && !Enum.GetNames(t).Any())
            .OrderBy(t => t.FullName)
            .ToList();

        foreach (var t in emptyEnums)
            output.WriteLine(t.FullName ?? t.Name);

        Assert.True(emptyEnums.Count == 0,
            $"{emptyEnums.Count} enum(s) have zero members (see test output for names). " +
            "Empty enums cannot be used as required fields — convert them to readonly structs.");
    }
}
