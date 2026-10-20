// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.Framework;
using FluentValidation.Results;

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

/// <summary>The XML envelope and the dispatcher read into the interfaces with the registered factory: no record is read.</summary>
public class PayloadsWithFactoryTests
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

    private static ServiceProvider Provider(bool withFactory = true)
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators(rootTypes: [typeof(IMultilateralSettlementRequestV02)]);
        if (withFactory)
            services.AddIso20022Factory();
        services.AddIso20022PayloadValidators();
        services.AddIso20022PayloadValidationDispatcher();
        return services.BuildServiceProvider();
    }

    private static string Describe(ValidationResult result) =>
        string.Join("; ", result.Errors.Select(e => $"{e.ErrorCode} {e.PropertyName}: {e.ErrorMessage}"));

    [Fact]
    public void AnEnvelopeOfTheInterface_ValidatesTheXml_WithNoRecord()
    {
        using var provider = Provider();
        var sut = provider.GetRequiredService<IValidator<XmlEnvelope<IMultilateralSettlementRequestV02>>>();

        var result = sut.Validate(new XmlEnvelope<IMultilateralSettlementRequestV02>(Iso20022XmlSerializer.SerializeToString(ValidMessage())));

        Assert.True(result.IsValid, Describe(result));
    }

    [Fact]
    public void AnEnvelopeOfTheInterface_ReportsABusinessRule_AsTheMessageValidatorDoes()
    {
        using var provider = Provider();
        var sut = provider.GetRequiredService<IValidator<XmlEnvelope<IMultilateralSettlementRequestV02>>>();
        var invalid = new MultilateralSettlementRequestV02
        {
            GroupHeader = new GroupHeader104
            {
                MessageIdentification = "MSG-001",
                CreationDateTime = new DateTime(2026, 1, 1),
                NumberOfSettlementRequests = "0",
            },
        };

        var result = sut.Validate(new XmlEnvelope<IMultilateralSettlementRequestV02>(Iso20022XmlSerializer.SerializeToString(invalid)));

        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "SettlementRequest");
    }

    [Fact]
    public void TheDispatcher_ReadsIntoTheInterface_WhenAFactoryIsRegistered()
    {
        using var provider = Provider();
        var dispatcher = provider.GetRequiredService<IIso20022PayloadValidationDispatcher>();

        var result = dispatcher.ValidateXml(Iso20022XmlSerializer.SerializeToString(ValidMessage()));

        Assert.True(result.IsValid, Describe(result.ValidationResult));
        Assert.Equal(typeof(IMultilateralSettlementRequestV02), result.MessageType);
        Assert.IsAssignableFrom<IMultilateralSettlementRequestV02>(result.Message);
        Assert.IsNotType<MultilateralSettlementRequestV02>(result.Message);
    }

    [Fact]
    public void TheDispatcher_StillReadsRecords_WhenNoFactoryIsRegistered()
    {
        using var provider = Provider(withFactory: false);
        var dispatcher = provider.GetRequiredService<IIso20022PayloadValidationDispatcher>();

        var result = dispatcher.ValidateXml(Iso20022XmlSerializer.SerializeToString(ValidMessage()));

        Assert.True(result.IsValid, Describe(result.ValidationResult));
        Assert.Equal(typeof(MultilateralSettlementRequestV02), result.MessageType);
    }

    [Fact]
    public void TheEnvelopeTheDispatcherAndTheExtension_ReportTheSameProblems()
    {
        using var provider = Provider();
        var xml = Iso20022XmlSerializer
            .SerializeToString(ValidMessage())
            .Replace("<NbOfSttlmReqs>1</NbOfSttlmReqs>", "")
            .Replace("MOV-001", new string('x', 40));
        var validator = provider.GetRequiredService<IValidator<IMultilateralSettlementRequestV02>>();
        var factory = provider.GetRequiredService<IIsoDataFactory>();

        var byExtension = validator.Validate(xml, factory, out IMultilateralSettlementRequestV02? _);
        var byEnvelope = provider.GetRequiredService<IValidator<XmlEnvelope<IMultilateralSettlementRequestV02>>>()
            .Validate(new XmlEnvelope<IMultilateralSettlementRequestV02>(xml));
        var byDispatcher = provider.GetRequiredService<IIso20022PayloadValidationDispatcher>().ValidateXml(xml).ValidationResult;

        static string[] Key(ValidationResult r) => r.Errors.Select(e => $"{e.ErrorCode}|{e.PropertyName}").OrderBy(x => x).ToArray();
        Assert.True(byExtension.Errors.Count >= 2, Describe(byExtension));
        Assert.Equal(Key(byExtension), Key(byEnvelope));
        Assert.Equal(Key(byExtension), Key(byDispatcher));
    }

    [Fact]
    public void TheRegistry_KnowsTheMessageInterfaceOfADocumentNamespace()
    {
        Assert.True(Iso20022MessageTypeRegistry.TryGetInterfaceByDocumentNamespace(MultilateralSettlementRequestV02.DocumentNamespace, out var found));
        Assert.Equal(typeof(IMultilateralSettlementRequestV02), found);
        Assert.True(Iso20022MessageTypeRegistry.TryGetInterfaceByIsoIdentifier(MultilateralSettlementRequestV02.IsoIdentifier, out var byId));
        Assert.Equal(typeof(IMultilateralSettlementRequestV02), byId);
    }
}
