// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CashAccount40ValidatorTests
{
    private readonly CashAccount40Validator _sut = new();

    private static CashAccount40 ValidMessageWithIdentification() =>
        new()
        {
            Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
            {
                Value = "DE89370400440532013000",
            },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessageWithIdentification()).ShouldNotHaveAnyValidationErrors();
    }

    // ── IdentificationOrProxyPresenceRule ──────────────────────────────────────

    [Fact]
    public void NeitherIdentificationNorProxy_HasValidationError()
    {
        var msg = new CashAccount40();
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
        var msg = new CashAccount40
        {
            Proxy = new ProxyAccountIdentification1 { Identification = "alias@example.com" },
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "IdentificationOrProxyPresenceRule");
    }

    [Fact]
    public void BothIdentificationAndProxy_NoValidationError()
    {
        var msg = ValidMessageWithIdentification() with
        {
            Proxy = new ProxyAccountIdentification1 { Identification = "alias@example.com" },
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "IdentificationOrProxyPresenceRule");
    }

    [Fact]
    public void TypeAndCurrencyAndName_Present_NoValidationError()
    {
        var msg = ValidMessageWithIdentification() with
        {
            Type = new BeneficialStrategies.Iso20022.Choices.CashAccountType2Choice.Proprietary
            {
                Value = "MYTYPE",
            },
            Currency = "USD",
            Name = "My Account",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
