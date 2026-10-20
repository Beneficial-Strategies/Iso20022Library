// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using PartyId127 = BeneficialStrategies.Iso20022.Choices.PartyIdentification127Choice;
using SfkpgPlace28 = BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat28Choice;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Tests for <see cref="AccountAndBalance47Validator"/>.
/// Rules sourced from ISO 20022 MCP server on 2026-03-13 (ISO ID: _945XHRukEeyhRdHRjakS2w).
/// </summary>
public class AccountAndBalance47ValidatorTests
{
    private readonly AccountAndBalance47Validator _sut = new();

    // ── Helpers ─────────────────────────────────────────────────────────────────

    /// <summary>
    /// Minimal valid instance: SafekeepingAccountOrBlockChainAddress1Rule requires exactly
    /// one of SafekeepingAccount or BlockChainAddressOrWallet to be present.
    /// </summary>
    private static IAccountAndBalance47 ValidMessage() => IsoDataFactory.Make<IAccountAndBalance47>(b => b
        .Set(x => x.SafekeepingAccount).To("ACC-001"));

    private static PartyId127.IAnyBIC OwnerAnyBic(string bic) => IsoDataFactory.Make<PartyId127.IAnyBIC>(b => b
        .Set(x => x.Value).To(bic));

    private static PartyId127.IProprietaryIdentification OwnerPropId(
        string id = "PROP-ID-001",
        string issuer = "ACME",
        string? schemeName = null
    ) =>
        IsoDataFactory.Make<PartyId127.IProprietaryIdentification>(b => b
            .Set(x => x.Identification).To(id)
            .Set(x => x.Issuer).To(issuer)
            .Set(x => x.SchemeName).To(schemeName is null ? null : (Max35Text?)new Max35Text(schemeName)));

    private static SfkpgPlace28.ICountry PlaceCountry(string code) => IsoDataFactory.Make<SfkpgPlace28.ICountry>(b => b
        .Set(x => x.Value).To(code));

    private static SfkpgPlace28.ITypeAndIdentification PlaceTypeAndId(string bic) =>
        IsoDataFactory.Make<SfkpgPlace28.ITypeAndIdentification>(b => b
            .Set(x => x.SafekeepingPlaceType).To(Codesets.SafekeepingPlace1Code.SharesHeldAtLocalCustodian)
            .Set(x => x.Identification).To(bic));

    // ── Happy path ───────────────────────────────────────────────────────────────

    [Fact]
    public void SafekeepingAccountOnly_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IAccountAndBalance47>(b => b
            .Set(x => x.SafekeepingAccount).To("ACC-001")))
            .ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void BlockChainAddressOnly_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IAccountAndBalance47>(b => b
            .Set(x => x.BlockChainAddressOrWallet).To("0xABCDEF")))
            .ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SafekeepingAccountWithOptionalFields_NoValidationErrors()
    {
        var msg = IsoDataFactory.Make<IAccountAndBalance47>(b => b
            .Set(x => x.SafekeepingAccount).To("ACC-001")
            .Set(x => x.AccountOwner).To(OwnerAnyBic("DEUTDEFFXXX"))
            .Set(x => x.SafekeepingPlace).To(PlaceCountry("DE"))
            .Set(x => x.Balance).To(IsoDataFactory.Make<ICorporateActionBalanceDetails43>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── Constraint: SafekeepingAccountOrBlockChainAddress1Rule ───────────────────
    // "Either SafekeepingAccount or BlockChainAddressOrWallet must be present but not both."

    [Fact]
    public void NeitherAccountField_Violates1Rule()
    {
        var result = _sut.Validate(IsoDataFactory.Make<IAccountAndBalance47>());
        Assert.Contains(
            result.Errors,
            e => e.PropertyName == "SafekeepingAccountOrBlockChainAddress1Rule"
        );
    }

    [Fact]
    public void BothAccountFields_DoesNotViolate1Rule()
    {
        // Rule 1 fires when NEITHER is present; when both are present, rules 2 and 3 fire instead.
        var result = _sut.Validate(
            IsoDataFactory.Make<IAccountAndBalance47>(b => b
                .Set(x => x.SafekeepingAccount).To("ACC-001")
                .Set(x => x.BlockChainAddressOrWallet).To("0xABCDEF"))
        );
        Assert.DoesNotContain(
            result.Errors,
            e => e.PropertyName == "SafekeepingAccountOrBlockChainAddress1Rule"
        );
    }

    // ── Constraint: SafekeepingAccountOrBlockChainAddress2Rule ───────────────────
    // "If BlockChainAddressOrWallet is present then SafekeepingAccount must be absent."

    [Fact]
    public void BothPresent_Violates2Rule()
    {
        var result = _sut.Validate(
            IsoDataFactory.Make<IAccountAndBalance47>(b => b
                .Set(x => x.SafekeepingAccount).To("ACC-001")
                .Set(x => x.BlockChainAddressOrWallet).To("0xABCDEF"))
        );
        Assert.Contains(
            result.Errors,
            e => e.PropertyName == "SafekeepingAccountOrBlockChainAddress2Rule"
        );
    }

    [Fact]
    public void BlockChainOnly_DoesNotViolate2Rule()
    {
        var result = _sut.Validate(
            IsoDataFactory.Make<IAccountAndBalance47>(b => b
                .Set(x => x.BlockChainAddressOrWallet).To("0xABCDEF"))
        );
        Assert.DoesNotContain(
            result.Errors,
            e => e.PropertyName == "SafekeepingAccountOrBlockChainAddress2Rule"
        );
    }

    // ── Constraint: SafekeepingAccountOrBlockChainAddress3Rule ───────────────────
    // "If SafekeepingAccount is present then BlockChainAddressOrWallet must be absent."

    [Fact]
    public void BothPresent_Violates3Rule()
    {
        var result = _sut.Validate(
            IsoDataFactory.Make<IAccountAndBalance47>(b => b
                .Set(x => x.SafekeepingAccount).To("ACC-001")
                .Set(x => x.BlockChainAddressOrWallet).To("0xABCDEF"))
        );
        Assert.Contains(
            result.Errors,
            e => e.PropertyName == "SafekeepingAccountOrBlockChainAddress3Rule"
        );
    }

    [Fact]
    public void SafekeepingAccountOnly_DoesNotViolate3Rule()
    {
        var result = _sut.Validate(IsoDataFactory.Make<IAccountAndBalance47>(b => b
            .Set(x => x.SafekeepingAccount).To("ACC-001")));
        Assert.DoesNotContain(
            result.Errors,
            e => e.PropertyName == "SafekeepingAccountOrBlockChainAddress3Rule"
        );
    }

    // ── SafekeepingAccount: Max35Text (0..1) ─────────────────────────────────────

    [Fact]
    public void SafekeepingAccount_TooLong_ThrowsAtConstruction()
    {
        // Max35Text constructor rejects invalid values — they never reach the validator.
        Assert.Throws<Iso20022FormatException>(() =>
            _ = IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.SafekeepingAccount).To(new string('X', 36))));
    }

    [Fact]
    public void SafekeepingAccount_MaxLength35_NoError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SafekeepingAccount).To(new string('X', 35)));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.SafekeepingAccount);
    }

    [Fact]
    public void SafekeepingAccount_EmptyString_ThrowsAtConstruction()
    {
        Assert.Throws<Iso20022FormatException>(() =>
            _ = IsoDataFactory.With(ValidMessage(), b => b
                .Set(x => x.SafekeepingAccount).To("")));
    }

    // ── BlockChainAddressOrWallet: Max140Text (0..1) ──────────────────────────────

    [Fact]
    public void BlockChainAddress_TooLong_ThrowsAtConstruction()
    {
        Assert.Throws<Iso20022FormatException>(() =>
            _ = IsoDataFactory.Make<IAccountAndBalance47>(b => b
                .Set(x => x.BlockChainAddressOrWallet).To(new string('a', 141))));
    }

    [Fact]
    public void BlockChainAddress_MaxLength140_NoError()
    {
        var msg = IsoDataFactory.Make<IAccountAndBalance47>(b => b
            .Set(x => x.BlockChainAddressOrWallet).To(new string('a', 140)));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.BlockChainAddressOrWallet);
    }

    // ── AccountOwner: AnyBIC variant ─────────────────────────────────────────────

    [Fact]
    public void AccountOwner_AnyBic_ValidBic8_NoError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AccountOwner).To(OwnerAnyBic("DEUTDEFF")));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AccountOwner_AnyBic_ValidBic11_NoError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AccountOwner).To(OwnerAnyBic("DEUTDEFFXXX")));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AccountOwner_AnyBic_LowercaseLetters_ThrowsAtConstruction()
    {
        // AnyBICDec2014Identifier enforces uppercase — invalid values cannot reach the validator.
        Assert.Throws<Iso20022FormatException>(() => OwnerAnyBic("deutdeffxxx"));
    }

    [Fact]
    public void AccountOwner_AnyBic_TooShort_ThrowsAtConstruction()
    {
        Assert.Throws<Iso20022FormatException>(() => OwnerAnyBic("DEUT"));
    }

    [Fact]
    public void AccountOwner_AnyBic_TooLong_ThrowsAtConstruction()
    {
        Assert.Throws<Iso20022FormatException>(() => OwnerAnyBic("DEUTDEFFXXXQ")); // 12 chars
    }

    // ── AccountOwner: ProprietaryIdentification variant ──────────────────────────

    [Fact]
    public void AccountOwner_ProprietaryId_Valid_NoError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AccountOwner).To(OwnerPropId()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AccountOwner_ProprietaryId_EmptyIdentification_ThrowsAtConstruction()
    {
        Assert.Throws<Iso20022FormatException>(() => OwnerPropId(id: ""));
    }

    [Fact]
    public void AccountOwner_ProprietaryId_IdentificationTooLong_ThrowsAtConstruction()
    {
        Assert.Throws<Iso20022FormatException>(() => OwnerPropId(id: new string('X', 36)));
    }

    [Fact]
    public void AccountOwner_ProprietaryId_IssuerTooLong_ThrowsAtConstruction()
    {
        Assert.Throws<Iso20022FormatException>(() => OwnerPropId(issuer: new string('X', 36)));
    }

    [Fact]
    public void AccountOwner_ProprietaryId_SchemeNameTooLong_ThrowsAtConstruction()
    {
        Assert.Throws<Iso20022FormatException>(() => OwnerPropId(schemeName: new string('X', 36)));
    }

    [Fact]
    public void AccountOwner_ProprietaryId_SchemeNameMaxLength35_NoError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AccountOwner).To(OwnerPropId(schemeName: new string('X', 35))));
        _sut.TestValidate(msg)
            .ShouldNotHaveValidationErrorFor(x =>
                ((PartyId127.IProprietaryIdentification)x.AccountOwner!).SchemeName
            );
    }

    // ── SafekeepingPlace: Country variant ────────────────────────────────────────

    [Fact]
    public void SafekeepingPlace_Country_ValidCode_NoError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SafekeepingPlace).To(PlaceCountry("DE")));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SafekeepingPlace_Country_LowercaseCode_ThrowsAtConstruction()
    {
        // CountryCode enforces ^[A-Z]{2}$ at construction — invalid values never reach the validator.
        Assert.Throws<Iso20022FormatException>(() => PlaceCountry("de"));
    }

    [Fact]
    public void SafekeepingPlace_Country_ThreeLetters_ThrowsAtConstruction()
    {
        // CountryCode enforces ^[A-Z]{2}$ at construction — invalid values never reach the validator.
        Assert.Throws<Iso20022FormatException>(() => PlaceCountry("DEU"));
    }

    // ── SafekeepingPlace: TypeAndIdentification variant ───────────────────────────

    [Fact]
    public void SafekeepingPlace_TypeAndId_ValidBic_NoError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SafekeepingPlace).To(PlaceTypeAndId("DEUTDEFFXXX")));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SafekeepingPlace_TypeAndId_InvalidBic_ThrowsAtConstruction()
    {
        // AnyBICDec2014Identifier enforces the BIC pattern — invalid values cannot reach the validator.
        Assert.Throws<Iso20022FormatException>(() => PlaceTypeAndId("not-a-bic"));
    }

    // ── Balance: CorporateActionBalanceDetails43 ─────────────────────────────────

    [Fact]
    public void Balance_EmptyDetails_NoError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Balance).To(IsoDataFactory.Make<ICorporateActionBalanceDetails43>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
