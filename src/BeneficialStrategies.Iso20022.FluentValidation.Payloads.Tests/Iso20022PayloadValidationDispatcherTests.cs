// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

public class Iso20022PayloadValidationDispatcherTests
{
    private static MultilateralSettlementRequestV02 ValidMessage() =>
        new()
        {
            GroupHeader = new GroupHeader104
            {
                MessageIdentification = "MSG-001",
                CreationDateTime = new DateTime(2026, 1, 1),
                NumberOfSettlementRequests = "1",
            },
            SettlementRequest =
            [
                new MultilateralSettlementRequest3
                {
                    InstructionIdentification = "INSTR-001",
                    MovementRecord =
                    [
                        new MovementRecord2
                        {
                            Amount = new AmountAndDirection5 { Amount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m } },
                            Identification = "MOV-001",
                        },
                        new MovementRecord2
                        {
                            Amount = new AmountAndDirection5 { Amount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 200m } },
                            Identification = "MOV-002",
                        },
                    ],
                },
            ],
        };

    private static IIso20022PayloadValidationDispatcher BuildDispatcher(Func<Type, bool>? filter = null)
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators(filter: filter);
        services.AddIso20022PayloadValidationDispatcher();
        var provider = services.BuildServiceProvider();
        return provider.GetRequiredService<IIso20022PayloadValidationDispatcher>();
    }

    // ── XML: type resolved from the payload's own root document namespace ────────

    [Fact]
    public void ValidateXml_ValidPayload_RoutesToCorrectValidator_ReturnsValidResult()
    {
        var dispatcher = BuildDispatcher();
        var xml = Iso20022XmlSerializer.SerializeToString(ValidMessage());

        var result = dispatcher.ValidateXml(xml);

        Assert.True(result.IsValid, string.Join("; ", result.ValidationResult.Errors.Select(e => e.ErrorMessage)));
        Assert.Equal(typeof(MultilateralSettlementRequestV02), result.MessageType);
        var message = Assert.IsType<MultilateralSettlementRequestV02>(result.Message);
        Assert.Equal("MSG-001", (string)message.GroupHeader.MessageIdentification);
    }

    [Fact]
    public void ValidateXml_BusinessRuleViolation_RoutesToCorrectValidator_ReturnsSameFailureAsDirectValidation()
    {
        var dispatcher = BuildDispatcher();
        var invalidMessage = new MultilateralSettlementRequestV02
        {
            GroupHeader = new GroupHeader104
            {
                MessageIdentification = "MSG-001",
                CreationDateTime = new DateTime(2026, 1, 1),
                NumberOfSettlementRequests = "0",
            },
        };
        var xml = Iso20022XmlSerializer.SerializeToString(invalidMessage);

        var result = dispatcher.ValidateXml(xml);

        Assert.False(result.IsValid);
        Assert.Contains(result.ValidationResult.Errors, e => e.PropertyName == "SettlementRequest");
        // The type was still resolved and the message still deserialized — only the business
        // rule failed. Both remain available to the caller alongside the failure.
        Assert.Equal(typeof(MultilateralSettlementRequestV02), result.MessageType);
        Assert.NotNull(result.Message);
    }

    [Fact]
    public void ValidateXml_MalformedXml_SingleFailure_WithXmlParseErrorCode()
    {
        var dispatcher = BuildDispatcher();

        var result = dispatcher.ValidateXml("<Document><Unclosed>");

        Assert.False(result.IsValid);
        var failure = Assert.Single(result.ValidationResult.Errors);
        Assert.Equal("XmlParseError", failure.ErrorCode);
    }

    [Fact]
    public void ValidateXml_UnrecognizedNamespace_SingleFailure_WithUnknownMessageTypeErrorCode()
    {
        var dispatcher = BuildDispatcher();

        var result = dispatcher.ValidateXml("<Document xmlns=\"urn:not-iso20022\"><Foo/></Document>");

        Assert.False(result.IsValid);
        var failure = Assert.Single(result.ValidationResult.Errors);
        Assert.Equal("UnknownMessageType", failure.ErrorCode);
        Assert.Null(result.MessageType);
        Assert.Null(result.Message);
    }

    [Fact]
    public void ValidateXml_NoValidatorRegisteredForResolvedType_SingleFailure_WithNoValidatorRegisteredErrorCode()
    {
        // Exclude MultilateralSettlementRequestV02Validator specifically — the message type is
        // still discoverable via Iso20022MessageTypeRegistry (that scan doesn't depend on DI
        // registration at all), but no IValidator<MultilateralSettlementRequestV02> exists.
        var dispatcher = BuildDispatcher(filter: t => t != typeof(MultilateralSettlementRequestV02Validator));
        var xml = Iso20022XmlSerializer.SerializeToString(ValidMessage());

        var result = dispatcher.ValidateXml(xml);

        Assert.False(result.IsValid);
        var failure = Assert.Single(result.ValidationResult.Errors);
        Assert.Equal("NoValidatorRegistered", failure.ErrorCode);
        // The type resolved and the message deserialized fine — DI just has no validator for it.
        Assert.Equal(typeof(MultilateralSettlementRequestV02), result.MessageType);
        Assert.NotNull(result.Message);
    }

    // ── JSON: type supplied out of band (no self-describing discriminator) ───────

    [Fact]
    public void ValidateJson_ValidPayload_CorrectIdentifier_RoutesToCorrectValidator_ReturnsValidResult()
    {
        var dispatcher = BuildDispatcher();
        var json = Iso20022JsonSerializer.SerializeToString(ValidMessage());

        var result = dispatcher.ValidateJson(json, "pacs.029.001.02");

        Assert.True(result.IsValid, string.Join("; ", result.ValidationResult.Errors.Select(e => e.ErrorMessage)));
    }

    [Fact]
    public void ValidateJson_UnrecognizedIdentifier_SingleFailure_WithUnknownMessageTypeErrorCode()
    {
        var dispatcher = BuildDispatcher();
        var json = Iso20022JsonSerializer.SerializeToString(ValidMessage());

        var result = dispatcher.ValidateJson(json, "xxxx.999.999.99");

        Assert.False(result.IsValid);
        var failure = Assert.Single(result.ValidationResult.Errors);
        Assert.Equal("UnknownMessageType", failure.ErrorCode);
    }

    [Fact]
    public void ValidateJson_MalformedJson_SingleFailure_WithPayloadParseErrorCode()
    {
        var dispatcher = BuildDispatcher();

        var result = dispatcher.ValidateJson("{ this is not valid json", "pacs.029.001.02");

        Assert.False(result.IsValid);
        var failure = Assert.Single(result.ValidationResult.Errors);
        Assert.Equal("PayloadParseError", failure.ErrorCode);
    }
}
