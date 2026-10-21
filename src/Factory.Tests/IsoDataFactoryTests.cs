// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Factory;

public class IsoDataFactoryTests
{
    private static readonly IsoDataFactory Factory = new();

    /// <summary>The message of <see cref="Golden"/>, built from the samples; the second movement has the given identification.</summary>
    internal static IMultilateralSettlementRequestV02 Message(string movementId = "MOV-002") =>
        IsoDataFactory.With(Samples.MultilateralSettlementRequestV02.Valid.Standard.Minimal, b => b
            .Set(x => x.SettlementRequest).To([
                IsoDataFactory.With(Samples.MultilateralSettlementRequest3.Valid.Standard.Minimal, r => r
                    .Set(x => x.MovementRecord).To([Movement("MOV-001", 100m), Movement(movementId, 200m)])),
            ]));

    private static IMovementRecord2 Movement(string identification, decimal amount) =>
        IsoDataFactory.With(Samples.MovementRecord2.Valid.Standard.Minimal, m => m
            .Set(x => x.Identification).To(identification)
            .Set(x => x.Amount).To(IsoDataFactory.With(Samples.AmountAndDirection5.Valid.Standard.Minimal, a => a
                .Set(x => x.Amount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = amount }))));

    private static IMultilateralSettlementRequestV02 Read(string xml)
    {
        var result = Iso20022XmlSerializer.TryRead<IMultilateralSettlementRequestV02>(xml, Factory);
        Assert.True(result.Succeeded, string.Join("; ", result.Issues));
        return result.Message!;
    }

    [Fact]
    public void AMessage_IsReadIntoGeneratedClasses_NotRecords()
    {
        var message = Read(Golden.Xml);

        Assert.True(message.GetType().Assembly.IsDynamic);
        Assert.Equal("MSG-001", message.GroupHeader.MessageIdentification.Value);
        var movements = message.SettlementRequest.Single().MovementRecord.ToList();
        Assert.Equal(["MOV-001", "MOV-002"], movements.Select(m => m.Identification.Value));
        Assert.Equal(200m, movements[1].Amount.Amount.Amount);
    }

    [Fact]
    public void TheGeneratedClasses_HaveValueEquality()
    {
        var xml = Golden.Xml;

        var a = Read(xml);
        var b = Read(xml);
        var c = Read(Iso20022XmlSerializer.SerializeToString(Message("MOV-999")));

        Assert.Equal(a, b);
        Assert.Equal(a.GetHashCode(), b.GetHashCode());
        Assert.NotEqual(a, c);
        Assert.False(a.Equals(null));
        Assert.Contains("MSG-001", a.ToString());
    }

    [Fact]
    public void TheExistingValidators_RunOnTheGeneratedObjects()
    {
        var valid = new MultilateralSettlementRequestV02Validator().Validate(
            Read(Golden.Xml)
        );
        Assert.True(valid.IsValid, string.Join("; ", valid.Errors.Select(e => e.ErrorMessage)));

        var invalidMessage = IsoDataFactory.With(Samples.MultilateralSettlementRequestV02.Valid.Standard.Minimal, m => m
            .Set(x => x.GroupHeader).To(IsoDataFactory.With(Samples.GroupHeader104.Valid.Standard.Minimal, g => g
                .Set(x => x.NumberOfSettlementRequests).To("0")))
            .Set(x => x.SettlementRequest).To([]));
        var invalid = new MultilateralSettlementRequestV02Validator().Validate(
            Read(Iso20022XmlSerializer.SerializeToString(invalidMessage))
        );
        Assert.False(invalid.IsValid);
    }

    [Fact]
    public void WhatWasRead_IsWrittenBackAsTheSameXml()
    {
        var xml = Golden.Xml;

        var written = Iso20022XmlSerializer.SerializeToString(Read(xml));

        Assert.True(
            XNode.DeepEquals(XDocument.Parse(xml).Root, XDocument.Parse(written).Root),
            written
        );
    }

    [Fact]
    public void AChoice_IsReadIntoTheVariantOfTheElementPresent()
    {
        var element = XElement.Parse(
            "<Id xmlns=\"urn:test\"><IBAN>DE89370400440532013000</IBAN></Id>"
        );

        var result = Iso20022XmlSerializer.Read<IAccountIdentification4Choice>(
            element,
            factory: Factory
        );

        Assert.True(result.Succeeded, string.Join("; ", result.Issues));
        Assert.Equal(
            "DE89370400440532013000",
            Assert
                .IsAssignableFrom<Choices.AccountIdentification4Choice.IIBAN>(result.Message)
                .Value.Value
        );
    }

    [Fact]
    public void AVariantWithSeveralMembers_IsReadByItsWrapperTag()
    {
        var element = XElement.Parse(
            "<Id xmlns=\"urn:test\"><Othr><Id>ABC-1</Id><Issr>BANK</Issr></Othr></Id>"
        );

        var result = Iso20022XmlSerializer.Read<IAccountIdentification4Choice>(
            element,
            factory: Factory
        );

        Assert.True(result.Succeeded, string.Join("; ", result.Issues));
        var other = Assert.IsAssignableFrom<Choices.AccountIdentification4Choice.IOther>(
            result.Message
        );
        Assert.Equal("ABC-1", other.Identification.Value);
        Assert.Equal("BANK", other.Issuer!.Value.Value);
    }

    [Fact]
    public void AListOfAnObjectMadeByTheFactory_StartsEmpty()
    {
        var request = (IMultilateralSettlementRequest3)
            Factory.Create(typeof(IMultilateralSettlementRequest3));

        Assert.NotNull(request.MovementRecord);
        Assert.Empty(request.MovementRecord);
    }

    [Fact]
    public void AClassIsBuiltOncePerInterface_AndSharedByEveryFactory()
    {
        var one = new IsoDataFactory().ImplementationOf(typeof(IGroupHeader104));
        var two = new IsoDataFactory().ImplementationOf(typeof(IGroupHeader104));

        Assert.Same(one, two);
    }

    [Fact]
    public void ManyThreadsAskingForTheSameInterface_GetTheSameClass()
    {
        var types = Enumerable
            .Range(0, 64)
            .AsParallel()
            .Select(_ => new IsoDataFactory().Create(typeof(IGroupHeader131)).GetType())
            .Distinct()
            .ToList();

        Assert.Single(types);
    }

    [Fact]
    public void WarmingAMessage_BuildsEverythingItReaches()
    {
        var factory = new IsoDataFactory();

        factory.Warm(typeof(IFIToFICustomerCreditTransferV14), typeof(IBankToCustomerStatementV08));

        Assert.NotNull(factory.Create(typeof(IFIToFICustomerCreditTransferV14)));
        Assert.NotNull(factory.Create(typeof(IBankToCustomerStatementV08)));
    }

    [Fact]
    public void AnythingButAnInterface_IsRefused()
    {
        Assert.Throws<ArgumentException>(() => Factory.Create(typeof(string)));
    }

    [Fact]
    public void ThePackage_DoesNotNeedTheMessageRecords()
    {
        var references = typeof(IsoDataFactory)
            .Assembly.GetReferencedAssemblies()
            .Select(a => a.Name)
            .ToList();

        Assert.DoesNotContain("BeneficialStrategies.Iso20022.Common", references);
        Assert.DoesNotContain("BeneficialStrategies.Iso20022.Interfaces", references);
    }

    [Fact]
    public void TheDependencyInjectionExtension_RegistersOneFactoryForBothServices()
    {
        var services = new ServiceCollection();
        services.AddIso20022Factory(typeof(IMultilateralSettlementRequestV02));
        using var provider = services.BuildServiceProvider();

        Assert.Same(
            provider.GetRequiredService<IsoDataFactory>(),
            provider.GetRequiredService<IIsoDataFactory>()
        );
        var warm = provider.GetServices<Microsoft.Extensions.Hosting.IHostedService>().Single();
        warm.StartAsync(CancellationToken.None).GetAwaiter().GetResult();
    }
}
