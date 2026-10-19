// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation;

/// <summary>
/// The netstandard2.0 builds of the validators and the payload validators, run on .NET Framework 4.8 as well as on .NET 8 and 10, with
/// classes of the tests' own and no message record.
/// </summary>
public class NetStandardBuildTests
{
    private sealed class OwnBirth(string country) : IDateAndPlaceOfBirth1
    {
        public ISODate BirthDate => new DateOnly(1990, 1, 1);
        public Max35Text? ProvinceOfBirth => null;
        public Max35Text CityOfBirth => "Springfield";
        public CountryCode CountryOfBirth => country;
    }

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

    [Fact]
    public void Component_OwnClass_IsValidatedByTheRules()
    {
        var sut = new DateAndPlaceOfBirth1Validator(new CountryCodeValidator(RegistryOf<CountryCode>("US")));

        Assert.True(sut.Validate(new OwnBirth("US")).IsValid);
        Assert.False(sut.Validate(new OwnBirth("ZZ")).IsValid);
    }

    [Fact]
    public void Choice_OwnVariantClass_IsValidatedByTheVariantValidator()
    {
        var sut = new AmountType4Choice_Validator(new ActiveOrHistoricCurrencyCodeValidator(RegistryOf<ActiveOrHistoricCurrencyCode>("EUR")));

        Assert.True(sut.Validate(new OwnEquivalentAmount("EUR")).IsValid);
        Assert.False(sut.Validate(new OwnEquivalentAmount("ZZZ")).IsValid);
    }

    [Fact]
    public void ValidatorsAreRegisteredAndResolvedFromTheContainer()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators(filter: t => t == typeof(DateAndPlaceOfBirth1Validator) || t == typeof(CountryCodeValidator));
        using var provider = services.BuildServiceProvider();

        var sut = provider.GetRequiredService<IValidator<IDateAndPlaceOfBirth1>>();

        Assert.True(sut.Validate(new OwnBirth("US")).IsValid);
    }

    // ── a message of the tests' own, read from XML and JSON ────────────────────

    public interface ITinyMessage : IOuterRecord
    {
        Max35Text Identification { get; }
    }

    public sealed record TinyMessage : ITinyMessage
    {
        public const string IsoIdentifier = "tiny.001.001.01";
        public const string XmlTag = "Tiny";
        public const string DocumentNamespace = "urn:test:tiny";
        public const string DocumentElementName = "Document";

        [IsoXmlTag("Id")]
        public Max35Text Identification { get; init; }
    }

    private static InlineValidator<ITinyMessage> TinyRules()
    {
        var rules = new InlineValidator<ITinyMessage>();
        rules.RuleFor(x => x.Identification).Must(id => id.Value != "BAD").WithMessage("BAD is not allowed.");
        return rules;
    }

    private static ServiceProvider TinyServices()
    {
        var services = new ServiceCollection();
        services.AddSingleton<IValidator<ITinyMessage>>(TinyRules());
        services.AddIso20022PayloadValidators(messageAssemblies: [typeof(TinyMessage).Assembly]);
        services.AddIso20022PayloadValidationDispatcher();
        return services.BuildServiceProvider();
    }

    private static string TinyXml(string id) => $"<Document xmlns=\"urn:test:tiny\"><Tiny><Id>{id}</Id></Tiny></Document>";

    [Fact]
    public void XmlPayload_OfAKnownType_IsReadAndValidated()
    {
        using var provider = TinyServices();
        var sut = provider.GetRequiredService<IValidator<XmlEnvelope<TinyMessage>>>();

        Assert.True(sut.Validate(new XmlEnvelope<TinyMessage>(TinyXml("OK"))).IsValid);
        Assert.False(sut.Validate(new XmlEnvelope<TinyMessage>(TinyXml("BAD"))).IsValid);
        Assert.False(sut.Validate(new XmlEnvelope<TinyMessage>("<not-xml")).IsValid);
    }

    [Fact]
    public void XmlPayload_OfAnUnknownType_IsDispatchedByItsNamespace()
    {
        using var provider = TinyServices();
        var dispatcher = provider.GetRequiredService<IIso20022PayloadValidationDispatcher>();

        var good = dispatcher.ValidateXml(TinyXml("OK"));
        var bad = dispatcher.ValidateXml(TinyXml("BAD"));

        Assert.True(good.IsValid);
        Assert.Equal(typeof(TinyMessage), good.MessageType);
        Assert.False(bad.IsValid);
    }

    [Fact]
    public void JsonPayload_IsReadAndValidated()
    {
        using var provider = TinyServices();
        var sut = provider.GetRequiredService<IValidator<JsonEnvelope<TinyMessage>>>();

        string Json(string id) => Iso20022JsonSerializer.SerializeToString(new TinyMessage { Identification = id });

        Assert.True(sut.Validate(new JsonEnvelope<TinyMessage>(Json("OK"))).IsValid);
        Assert.False(sut.Validate(new JsonEnvelope<TinyMessage>(Json("BAD"))).IsValid);
        Assert.False(sut.Validate(new JsonEnvelope<TinyMessage>("{not json")).IsValid);
    }
}
