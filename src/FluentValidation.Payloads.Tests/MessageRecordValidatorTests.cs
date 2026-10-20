// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Framework;

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

public class MessageRecordValidatorTests
{
    [Fact]
    public void EveryMessageValidator_IsAlsoResolvableForTheMessageRecord_OncePayloadValidatorsAreAdded()
    {
        var services = new ServiceCollection();
        services.AddIso20022Validators();
        services.AddIso20022PayloadValidators(messageAssemblies: [typeof(MultilateralSettlementRequestV02).Assembly]);

        var messageInterfaces = services
            .Select(d => d.ServiceType)
            .Where(t => t.IsGenericType && !t.ContainsGenericParameters && t.GetGenericTypeDefinition() == typeof(IValidator<>))
            .Select(t => t.GetGenericArguments()[0])
            .Where(t => t.IsInterface && typeof(IOuterRecord).IsAssignableFrom(t))
            .ToList();
        Assert.NotEmpty(messageInterfaces);

        using var provider = services.BuildServiceProvider();
        foreach (var iface in messageInterfaces)
        {
            var record = Iso20022MessageTypeRegistry.ByIsoIdentifier.Values.Single(r => r.Name == iface.Name[1..] && iface.IsAssignableFrom(r));
            Assert.NotNull(provider.GetService(typeof(IValidator<>).MakeGenericType(record)));
        }
    }

    [Fact]
    public void RegistryAssembly_AddedExplicitly_FindsTheMessageRecords()
    {
        Iso20022MessageTypeRegistry.AddAssembly(typeof(MultilateralSettlementRequestV02).Assembly);

        Assert.True(Iso20022MessageTypeRegistry.TryGetByIsoIdentifier("pacs.008.001.14", out var type));
        Assert.Equal(typeof(FIToFICustomerCreditTransferV14), type);
    }

    [Fact]
    public void PayloadsPackage_DoesNotReferenceTheMessageRecords()
    {
        var references = typeof(IIso20022PayloadValidationDispatcher).Assembly.GetReferencedAssemblies().Select(a => a.Name).ToList();

        Assert.DoesNotContain("BeneficialStrategies.Iso20022.Common", references);
        Assert.Contains("BeneficialStrategies.Iso20022.Primitives", references);
    }
}
