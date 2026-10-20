// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Framework;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace BeneficialStrategies.Iso20022.Validation;

/// <summary>
/// The validators are written for the interfaces (#28), so a class of someone else's that implements an interface is
/// validated by the same rules as our record, and gets the same failures.
/// </summary>
public class ValidatorsOnInterfacesTests
{
    /// <summary>An implementer's own class: not one of our records.</summary>
    private sealed class OwnBirth(string country) : IDateAndPlaceOfBirth1
    {
        public ISODate BirthDate => new DateOnly(1990, 1, 1);
        public Max35Text? ProvinceOfBirth => null;
        public Max35Text CityOfBirth => "Springfield";
        public CountryCode CountryOfBirth => country;
    }

    /// <summary>An implementer's own variant of a choice.</summary>
    private sealed class OwnEquivalentAmount(string currency) : Choices.AmountType4Choice.IEquivalentAmount
    {
        public ActiveOrHistoricCurrencyAndAmount Amount => new() { Currency = "USD", Amount = 100m };
        public ActiveOrHistoricCurrencyCode CurrencyOfTransfer => currency;
    }

    private static InMemoryExternalCodeRegistry<T> RegistryOf<T>(string code)
        where T : struct, IIsoExternalCode
    {
        var registry = new InMemoryExternalCodeRegistry<T>();
        registry.Add(code);
        return registry;
    }

    private static string[] Describe(FluentValidation.Results.ValidationResult result) =>
        result.Errors.Select(e => $"{e.PropertyName}|{e.ErrorCode}|{e.ErrorMessage}").OrderBy(s => s).ToArray();

    [Fact]
    public void Component_OwnClass_GivesTheSameFailuresAsTheRecord()
    {
        var sut = new DateAndPlaceOfBirth1Validator(new CountryCodeValidator(RegistryOf<CountryCode>("US")));
        var record = new DateAndPlaceOfBirth1
        {
            BirthDate = new DateOnly(1990, 1, 1),
            CityOfBirth = "Springfield",
            CountryOfBirth = "ZZ",
        };

        var fromRecord = Describe(sut.Validate(record));
        var fromOwnClass = Describe(sut.Validate(new OwnBirth("ZZ")));

        Assert.NotEmpty(fromRecord);
        Assert.Equal(fromRecord, fromOwnClass);
        Assert.True(sut.Validate(new OwnBirth("US")).IsValid);
    }

    [Fact]
    public void Choice_OwnVariantClass_GivesTheSameFailuresAsTheRecord()
    {
        var sut = new AmountType4Choice_Validator(new ActiveOrHistoricCurrencyCodeValidator(RegistryOf<ActiveOrHistoricCurrencyCode>("EUR")));
        var record = new Choices.AmountType4Choice.EquivalentAmount
        {
            Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            CurrencyOfTransfer = "ZZZ",
        };

        var fromRecord = Describe(sut.Validate(record));
        var fromOwnClass = Describe(sut.Validate(new OwnEquivalentAmount("ZZZ")));

        Assert.NotEmpty(fromRecord);
        Assert.Equal(fromRecord, fromOwnClass);
        Assert.True(sut.Validate(new OwnEquivalentAmount("EUR")).IsValid);
    }

    [Fact]
    public void EveryValidator_IsForAnInterface_NotForARecord()
    {
        var recordNamespaces = new[]
        {
            "BeneficialStrategies.Iso20022.Components",
            "BeneficialStrategies.Iso20022.Choices",
            "BeneficialStrategies.Iso20022.camt",
            "BeneficialStrategies.Iso20022.pacs",
            "BeneficialStrategies.Iso20022.pain",
        };
        var onRecords = typeof(Iso20022ServiceCollectionExtensions)
            .Assembly.GetTypes()
            .Where(t => t is { IsClass: true, IsAbstract: false })
            .SelectMany(t => t.GetInterfaces().Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IValidator<>)))
            .Select(i => i.GetGenericArguments()[0])
            .Where(validated => validated.IsClass && recordNamespaces.Any(ns => validated.Namespace?.StartsWith(ns, StringComparison.Ordinal) == true))
            .Select(validated => validated.FullName)
            .Distinct()
            // the adapters in the same assembly forward a message record to the validator of its interface (generic, so not listed)
            .ToList();

        Assert.Empty(onRecords);
    }
}
