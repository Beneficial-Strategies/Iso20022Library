// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// A choice variant named like its primitive type (<c>Choices.RateTypeChoice.PercentageRate</c>) declares
/// <c>Value</c> of the primitive. Written with the short name, the compiler resolves it to the variant itself and says nothing;
/// the member then has its own record as its type. The type is written in full in those files, and this test fails for a
/// model type with a property of its own type.
/// </summary>
public class NoSelfTypedMembersTests
{
    [Fact]
    public void NoModelTypeHasAPropertyOfItsOwnType()
    {
        var offenders = typeof(Iso20022XmlSerializer)
            .Assembly.GetExportedTypes()
            .Where(t => t.IsClass && Iso.KindOf(t) is not null || t.Namespace?.StartsWith("BeneficialStrategies.Iso20022.Choices") == true)
            .SelectMany(t =>
                t.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                    .Where(p => (Nullable.GetUnderlyingType(p.PropertyType) ?? p.PropertyType) == t)
                    .Select(p => $"{t.FullName}.{p.Name}")
            )
            .ToList();
        Assert.True(offenders.Count == 0, "Properties typed as their own declaring type:" + Environment.NewLine + string.Join(Environment.NewLine, offenders));
    }
}
