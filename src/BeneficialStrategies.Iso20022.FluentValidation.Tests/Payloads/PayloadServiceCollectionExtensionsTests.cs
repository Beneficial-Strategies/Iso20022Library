// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

public class PayloadServiceCollectionExtensionsTests
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

    [Fact]
    public void AddIso20022PayloadValidators_RegistersXmlAndJsonEnvelopeValidators_ForEveryRegisteredMessageType()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators();
        services.AddIso20022PayloadValidators();
        using var provider = services.BuildServiceProvider();

        Assert.NotNull(provider.GetRequiredService<IValidator<XmlEnvelope<MultilateralSettlementRequestV02>>>());
        Assert.NotNull(provider.GetRequiredService<IValidator<JsonEnvelope<MultilateralSettlementRequestV02>>>());
    }

    [Fact]
    public void ResolvedXmlEnvelopeValidator_ValidatesEndToEnd_ViaDI()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators();
        services.AddIso20022PayloadValidators();
        using var provider = services.BuildServiceProvider();

        var sut = provider.GetRequiredService<IValidator<XmlEnvelope<MultilateralSettlementRequestV02>>>();
        var xml = Iso20022XmlSerializer.SerializeToString(ValidMessage());

        var result = sut.Validate(new XmlEnvelope<MultilateralSettlementRequestV02>(xml));

        Assert.True(result.IsValid, string.Join("; ", result.Errors.Select(e => e.ErrorMessage)));
    }

    [Fact]
    public void ResolvedJsonEnvelopeValidator_ValidatesEndToEnd_ViaDI()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators();
        services.AddIso20022PayloadValidators();
        using var provider = services.BuildServiceProvider();

        var sut = provider.GetRequiredService<IValidator<JsonEnvelope<MultilateralSettlementRequestV02>>>();
        var json = Iso20022JsonSerializer.SerializeToString(ValidMessage());

        var result = sut.Validate(new JsonEnvelope<MultilateralSettlementRequestV02>(json));

        Assert.True(result.IsValid, string.Join("; ", result.Errors.Select(e => e.ErrorMessage)));
    }

    [Fact]
    public void AddIso20022PayloadValidators_CalledWithNoMessageValidatorsRegistered_IsANoOp()
    {
        var services = new ServiceCollection();
        services.AddIso20022PayloadValidators();
        using var provider = services.BuildServiceProvider();

        Assert.Null(provider.GetService<IValidator<XmlEnvelope<MultilateralSettlementRequestV02>>>());
    }

    [Fact]
    public void AddIso20022PayloadValidationDispatcher_RegistersDispatcher()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators();
        services.AddIso20022PayloadValidationDispatcher();
        using var provider = services.BuildServiceProvider();

        Assert.NotNull(provider.GetRequiredService<IIso20022PayloadValidationDispatcher>());
    }
}
