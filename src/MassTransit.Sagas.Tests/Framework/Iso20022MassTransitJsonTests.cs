// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas;

public class Iso20022MassTransitJsonTests
{
    private sealed class SomeFactory : IIsoDataFactory
    {
        public object Create(Type type) => throw new NotSupportedException();
    }

    private sealed class AnotherKindOfFactory : IIsoDataFactory
    {
        public object Create(Type type) => throw new NotSupportedException();
    }

    [Fact]
    public void Register_AddsTheConvertersOfTheLibrary_OnlyOnce()
    {
        var options = new JsonSerializerOptions();

        Iso20022MassTransitJson.Register(options);
        var once = options.Converters.Count;
        Iso20022MassTransitJson.Register(options);

        Assert.True(once > 0);
        Assert.Equal(once, options.Converters.Count);
        Assert.Empty(options.Converters.OfType<Iso20022InterfaceJsonConverterFactory>());
    }

    [Fact]
    public void Register_WithAFactory_AddsTheInterfaceConverterFirst_Once_AndRefusesAnotherKindOfFactory()
    {
        var options = new JsonSerializerOptions();
        var factory = new SomeFactory();

        Iso20022MassTransitJson.Register(options, factory);
        Iso20022MassTransitJson.Register(options, factory);

        var converter = Assert.Single(options.Converters.OfType<Iso20022InterfaceJsonConverterFactory>());
        Assert.Same(factory, converter.Factory);
        Assert.Same(converter, options.Converters[0]);
        Iso20022MassTransitJson.Register(options, new SomeFactory());   // the same kind: interchangeable, the first stays
        Assert.Same(factory, Assert.Single(options.Converters.OfType<Iso20022InterfaceJsonConverterFactory>()).Factory);
        Assert.Throws<InvalidOperationException>(() => Iso20022MassTransitJson.Register(options, new AnotherKindOfFactory()));
    }

    [Fact]
    public void SagaPackage_DoesNotReferenceTheMessageRecords()
    {
        var references = typeof(Iso20022MassTransitJson).Assembly.GetReferencedAssemblies().Select(a => a.Name).ToList();

        Assert.DoesNotContain("BeneficialStrategies.Iso20022.Common", references);
        Assert.Contains("BeneficialStrategies.Iso20022.Messages", references);
    }
}
