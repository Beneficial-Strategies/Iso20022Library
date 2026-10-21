// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice;
using BeneficialStrategies.Iso20022.Samples;

namespace BeneficialStrategies.Iso20022.SamplesTests;

public class IsoSampleTests
{
    private static readonly Assembly InterfacesAssembly = typeof(IGroupHeader104).Assembly;

    private static IEnumerable<Type> ModelInterfaces(IsoKind kind) =>
        InterfacesAssembly.GetTypes().Where(t => t.IsInterface && t.IsPublic && Iso.KindOf(t) == kind);

    [Fact]
    public void AComponent_HasItsRequiredMembersAndNotTheOptionalOnes()
    {
        var header = IsoSample.Minimal<IGroupHeader104>();

        Assert.False(string.IsNullOrEmpty(header.MessageIdentification.Value));
        Assert.Equal("1", header.NumberOfSettlementRequests.Value);
        Assert.Null(header.ControlSum);
        Assert.Null(header.SettlementInformation);
    }

    [Fact]
    public void AChoice_IsItsFirstVariant_ByName()
    {
        var account = IsoSample.Minimal<IAccountIdentification4Choice>();

        Assert.IsAssignableFrom<IIBAN>(account);
    }

    [Fact]
    public void ANamedSample_WinsOverTheGeneratedOne()
    {
        Assert.Equal(Samples.CashAccount40.Valid.Standard.Minimal, IsoSample.Minimal<ICashAccount40>());
        Assert.Equal(Samples.AccountIdentification4Choice.Valid.IBAN.Minimal, IsoSample.Minimal<IIBAN>());
    }

    [Fact]
    public void TheSameAnswerEveryTime_InANewObject()
    {
        var a = IsoSample.Minimal<IMovementRecord2>();
        var b = IsoSample.Minimal<IMovementRecord2>();

        Assert.NotSame(a, b);
        Assert.Equal(a, b);
    }

    [Fact]
    public void AListHasOneItem()
    {
        var request = IsoSample.Minimal<IMultilateralSettlementRequestV02>();

        Assert.Single(request.SettlementRequest);
    }

    [Fact]
    public void AnythingButAnInterfaceOfTheModel_IsRefused()
    {
        Assert.Throws<InvalidOperationException>(() => IsoSample.Minimal(typeof(string)));
        Assert.Throws<InvalidOperationException>(() => IsoSample.Minimal(typeof(Max35Text)));
        Assert.Throws<ArgumentNullException>(() => IsoSample.Minimal(null!));
    }

    /// <summary>
    /// A message out of every 25, in order of name. The first call for a type makes its class (the factory emits it), which takes a few milliseconds and
    /// more as the number grows: all 34,000 interfaces of the model take most of an hour, so the whole model is checked by hand, not here.
    /// The interfaces that have a validator are all checked in <see cref="GeneratedSamplesAreValidTests"/>.
    /// </summary>
    [Fact]
    public void EveryTwentyFifthMessageOfTheModel_CanBeMade()
    {
        var failures = new List<string>();
        foreach (var message in ModelInterfaces(IsoKind.Message).OrderBy(t => t.Name, StringComparer.Ordinal).Where((_, i) => i % 25 == 0))
        {
            try
            {
                Assert.NotNull(IsoSample.Minimal(message));
            }
            catch (InvalidOperationException e)
            {
                failures.Add($"{message.Name}: {e.Message}");
            }
        }

        Assert.True(failures.Count == 0, $"{failures.Count} could not be made:\n" + string.Join("\n", failures.Take(20)));
    }

    [Fact]
    public void ARequiredNumber_GetsAValue()
    {
        Assert.NotEmpty(IsoSample.Minimal<IPreviousYear1>().SpecificPreviousYears);
        Assert.Equal(9, IsoSample.Minimal<Choices.SecurityIdentification3Choice.ICUSIP>().Value.Value.Length);
    }

    [Fact]
    public void WhatTheGeneratorCallsOptional_IsWhatTheCompilerSays()
    {
        var context = new NullabilityInfoContext();
        var differing = new List<string>();
        foreach (var type in Enum.GetValues<IsoKind>().SelectMany(ModelInterfaces))
            foreach (var property in type.GetProperties())
            {
                var viaCompiler = context.Create(property).ReadState == NullabilityState.Nullable;
                if (viaCompiler != Nullability.IsOptional(property))
                    differing.Add($"{type.Name}.{property.Name}");
            }

        Assert.True(differing.Count == 0, $"{differing.Count} differ, e.g. {string.Join(", ", differing.Take(5))}");
    }
}
