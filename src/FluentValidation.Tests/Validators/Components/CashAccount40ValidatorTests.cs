// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CashAccount40ValidatorTests
{
    private readonly CashAccount40Validator _sut = new();

    private static ICashAccount40 ValidMessageWithIdentification() =>
        IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b2 => b2
                .Set(x2 => x2.Value).To("DE89370400440532013000"))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessageWithIdentification()).ShouldNotHaveAnyValidationErrors();
    }

    // ── IdentificationOrProxyPresenceRule ──────────────────────────────────────

    [Fact]
    public void NeitherIdentificationNorProxy_HasValidationError()
    {
        var msg = IsoDataFactory.Make<ICashAccount40>();
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "IdentificationOrProxyPresenceRule");
    }

    [Fact]
    public void IdentificationOnly_NoValidationError()
    {
        var result = _sut.Validate(ValidMessageWithIdentification());
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "IdentificationOrProxyPresenceRule");
    }

    [Fact]
    public void ProxyOnly_NoValidationError()
    {
        var msg = IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Proxy).To(IsoDataFactory.Make<IProxyAccountIdentification1>(b2 => b2
                .Set(x2 => x2.Identification).To("alias@example.com"))));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "IdentificationOrProxyPresenceRule");
    }

    [Fact]
    public void BothIdentificationAndProxy_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessageWithIdentification(), b => b
            .Set(x => x.Proxy).To(IsoDataFactory.Make<IProxyAccountIdentification1>(b2 => b2
                .Set(x2 => x2.Identification).To("alias@example.com"))));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "IdentificationOrProxyPresenceRule");
    }

    [Fact]
    public void TypeAndCurrencyAndName_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessageWithIdentification(), b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<Choices.CashAccountType2Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYTYPE")))
            .Set(x => x.Currency).To("USD")
            .Set(x => x.Name).To("My Account"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
