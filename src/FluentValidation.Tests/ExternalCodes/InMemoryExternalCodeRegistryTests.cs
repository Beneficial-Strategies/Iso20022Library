// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation;

public class InMemoryExternalCodeRegistryTests
{
    // ── Permissive when the type declares no known members ────────────────────

    [Fact]
    public void NoKnownMembers_EmptyByDefault_IsAcceptableForAnything()
    {
        var sut = new InMemoryExternalCodeRegistry<CountryCode>();

        Assert.True(sut.IsAcceptable("US"));
        Assert.True(sut.IsAcceptable("ZZ")); // not a real country, still accepted: permissive
    }

    // ── Auto-seeds from known static members, where the type declares them ────

    [Fact]
    public void KnownMembers_AutoSeedsFromType_BecomesRestrictive()
    {
        var sut = new InMemoryExternalCodeRegistry<ExternalAuthenticationMethod1Code>();

        Assert.True(sut.IsAcceptable(ExternalAuthenticationMethod1Code.AcceptorCertificateSerialNumber));
        Assert.False(sut.IsAcceptable(new ExternalAuthenticationMethod1Code("ZZZZ")));
    }

    [Fact]
    public void KnownMembers_SeedFromKnownMembersFalse_StaysPermissive()
    {
        var sut = new InMemoryExternalCodeRegistry<ExternalAuthenticationMethod1Code>(
            seedFromKnownMembers: false
        );

        Assert.True(sut.IsAcceptable(new ExternalAuthenticationMethod1Code("ZZZZ")));
    }

    // ── Add/Remove tweak the seeded set ─────────────────────────────────────────

    [Fact]
    public void Add_MakesANewValueAcceptable()
    {
        var sut = new InMemoryExternalCodeRegistry<ExternalAuthenticationMethod1Code>();
        sut.Add("ZZZZ");

        Assert.True(sut.IsAcceptable(new ExternalAuthenticationMethod1Code("ZZZZ")));
    }

    [Fact]
    public void Remove_MakesAKnownValueNoLongerAcceptable()
    {
        var sut = new InMemoryExternalCodeRegistry<ExternalAuthenticationMethod1Code>();
        sut.Remove("ACSN");

        Assert.False(sut.IsAcceptable(ExternalAuthenticationMethod1Code.AcceptorCertificateSerialNumber));
        // Everything else seeded remains acceptable — Remove is targeted, not a reset.
        Assert.True(sut.IsAcceptable(ExternalAuthenticationMethod1Code.BillingAddress));
    }

    [Fact]
    public void AddRange_RemoveRange_ApplyToEveryValue()
    {
        var sut = new InMemoryExternalCodeRegistry<CountryCode>();
        sut.AddRange(["US", "GB", "DE"]);

        Assert.True(sut.IsAcceptable("US"));
        Assert.True(sut.IsAcceptable("GB"));
        Assert.False(sut.IsAcceptable("ZZ")); // no longer permissive once populated at all

        sut.RemoveRange(["US", "GB"]);
        Assert.False(sut.IsAcceptable("US"));
        Assert.True(sut.IsAcceptable("DE"));
    }

    // ── Subclassing to add an extra requirement — proven through DI, not just direct calls ────

    private sealed class EmbargoedCountryRegistry : InMemoryExternalCodeRegistry<CountryCode>
    {
        public override bool IsAcceptable(CountryCode value) =>
            base.IsAcceptable(value) && value.Value != "KP";
    }

    [Fact]
    public void Subclass_CalledDirectly_AppliesExtraRequirement()
    {
        var sut = new EmbargoedCountryRegistry();

        Assert.True(sut.IsAcceptable("US"));  // base is permissive (no known members)
        Assert.False(sut.IsAcceptable("KP")); // extra requirement rejects it anyway
    }

    [Fact]
    public void Subclass_ResolvedThroughInterfaceViaDI_StillAppliesExtraRequirement()
    {
        // The whole point of `virtual`: DI always resolves this through IExternalCodeRegistry<T>,
        // never the concrete type, so the override has to take effect through that interface
        // reference for subclassing to be a real, usable extension point — not just something
        // that happens to work when called directly on the concrete class in a unit test.
        var services = new ServiceCollection();
        services.AddSingleton<IExternalCodeRegistry<CountryCode>, EmbargoedCountryRegistry>();
        using var provider = services.BuildServiceProvider();

        var sut = provider.GetRequiredService<IExternalCodeRegistry<CountryCode>>();

        Assert.True(sut.IsAcceptable("US"));
        Assert.False(sut.IsAcceptable("KP"));
    }
}
