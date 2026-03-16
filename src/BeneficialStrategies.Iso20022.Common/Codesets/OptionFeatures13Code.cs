// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the features that may apply to a corporate action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bQETcWHGEe6yt_d72zQZeQ")]
[Description(@"Specifies the features that may apply to a corporate action option.")]
[DerivedFrom(typeof(OptionFeaturesCode))]
public enum OptionFeatures13Code
{
    /// <summary>
    /// Option is offered by the account servicer only.
    /// Encoded/decoded by serializers as &quot;ASVO&quot;.
    /// </summary>
    [EnumMember(Value = "ASVO")]
    [IsoId("")]
    [Description(@"Option is offered by the account servicer only.")]
    AccountServicerOption = OptionFeaturesCode.AccountServicerOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the holder needs to instruct at beneficiary owner level only.
    /// Encoded/decoded by serializers as &quot;BOIS&quot;.
    /// </summary>
    [EnumMember(Value = "BOIS")]
    [IsoId("")]
    [Description(@"Indicates that the holder needs to instruct at beneficiary owner level only.")]
    BeneficiaryOwnerInstruction = OptionFeaturesCode.BeneficiaryOwnerInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.
    /// Encoded/decoded by serializers as &quot;CAOS&quot;.
    /// </summary>
    [EnumMember(Value = "CAOS")]
    [IsoId("")]
    [Description(
        @"Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants."
    )]
    OptionApplicability = OptionFeaturesCode.OptionApplicability, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder can elect to place a condition on the acceptance of the option.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("")]
    [Description(
        @"Feature whereby the holder can elect to place a condition on the acceptance of the option."
    )]
    Conditional = OptionFeaturesCode.Conditional, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.
    /// Encoded/decoded by serializers as &quot;MAXC&quot;.
    /// </summary>
    [EnumMember(Value = "MAXC")]
    [IsoId("")]
    [Description(
        @"Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn."
    )]
    MaximumCash = OptionFeaturesCode.MaximumCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.
    /// Encoded/decoded by serializers as &quot;MAXS&quot;.
    /// </summary>
    [EnumMember(Value = "MAXS")]
    [IsoId("")]
    [Description(
        @"Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn."
    )]
    MaximumSecurities = OptionFeaturesCode.MaximumSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option).
    /// Encoded/decoded by serializers as &quot;NOSE&quot;.
    /// </summary>
    [EnumMember(Value = "NOSE")]
    [IsoId("")]
    [Description(
        @"Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option)."
    )]
    NoServiceOffered = OptionFeaturesCode.NoServiceOffered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tender or exchange with the odd lot preference.
    /// Encoded/decoded by serializers as &quot;OPLF&quot;.
    /// </summary>
    [EnumMember(Value = "OPLF")]
    [IsoId("")]
    [Description(@"Tender or exchange with the odd lot preference.")]
    OddLotPreference = OptionFeaturesCode.OddLotPreference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension.
    /// Encoded/decoded by serializers as &quot;PINS&quot;.
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("")]
    [Description(
        @"Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension."
    )]
    PreviousInstructionInvalidity = OptionFeaturesCode.PreviousInstructionInvalidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("")]
    [Description(
        @"Feature whereby the option can be subject to pro ration in case, for example, of over-subscription."
    )]
    Proration = OptionFeaturesCode.Proration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder should only instruct a cash amount.
    /// Encoded/decoded by serializers as &quot;QCAS&quot;.
    /// </summary>
    [EnumMember(Value = "QCAS")]
    [IsoId("")]
    [Description(@"Feature whereby the holder should only instruct a cash amount.")]
    InstructCashAmount = OptionFeaturesCode.InstructCashAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gross dividend is reinvested.
    /// Encoded/decoded by serializers as &quot;RGRS&quot;.
    /// </summary>
    [EnumMember(Value = "RGRS")]
    [IsoId("")]
    [Description(@"Gross dividend is reinvested.")]
    GrossDividendReinvestment = OptionFeaturesCode.GrossDividendReinvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend reinvestment is processed net of withholding tax.
    /// Encoded/decoded by serializers as &quot;RNET&quot;.
    /// </summary>
    [EnumMember(Value = "RNET")]
    [IsoId("")]
    [Description(@"Dividend reinvestment is processed net of withholding tax.")]
    NetDividendReinvestment = OptionFeaturesCode.NetDividendReinvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates usage of a reference number to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code).
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("")]
    [Description(
        @"Indicates usage of a reference number to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code)."
    )]
    ShareholderNumber = OptionFeaturesCode.ShareholderNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reduced withholding tax rate applies to the option.
    /// Encoded/decoded by serializers as &quot;VVPR&quot;.
    /// </summary>
    [EnumMember(Value = "VVPR")]
    [IsoId("")]
    [Description(@"Reduced withholding tax rate applies to the option.")]
    ReducedWithholdingTax = OptionFeaturesCode.ReducedWithholdingTax, // same ordinal as derivation source for type conversions
}
