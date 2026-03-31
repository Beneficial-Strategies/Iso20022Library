// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the features that may apply to a corporate action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aPsFJtp-Ed-ak6NoX_4Aeg_322763675")]
[Description(@"Specifies the features that may apply to a corporate action option.")]
[Derivations(
    typeof(OptionFeatures7Code),
    typeof(OptionFeatures3Code),
    typeof(OptionFeatures2Code),
    typeof(OptionFeatures8Code),
    typeof(OptionFeatures5Code),
    typeof(OptionFeatures6Code),
    typeof(OptionFeatures12Code),
    typeof(OptionFeatures4Code),
    typeof(OptionFeatures11Code),
    typeof(OptionFeatures1Code),
    typeof(OptionFeatures10Code)
)]
public enum OptionFeaturesCode
{
    /// <summary>
    /// Feature whereby the holder must elect directly to the issuer&apos;s agent (issuer only supported option).
    /// Encoded/decoded by serializers as &quot;NOSE&quot;.
    /// </summary>
    [EnumMember(Value = "NOSE")]
    [IsoId("_aPsFJ9p-Ed-ak6NoX_4Aeg_-903313345")]
    [Description(
        @"Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option)."
    )]
    NoServiceOffered,

    /// <summary>
    /// Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.
    /// Encoded/decoded by serializers as &quot;CAOS&quot;.
    /// </summary>
    [EnumMember(Value = "CAOS")]
    [IsoId("_aPsFKNp-Ed-ak6NoX_4Aeg_818140160")]
    [Description(
        @"Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants."
    )]
    OptionApplicability,

    /// <summary>
    /// Feature whereby the holder can elect to place a condition on the acceptance of the option.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_aP1PENp-Ed-ak6NoX_4Aeg_566570893")]
    [Description(
        @"Feature whereby the holder can elect to place a condition on the acceptance of the option."
    )]
    Conditional,

    /// <summary>
    /// Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.
    /// Encoded/decoded by serializers as &quot;MAXC&quot;.
    /// </summary>
    [EnumMember(Value = "MAXC")]
    [IsoId("_aP1PEdp-Ed-ak6NoX_4Aeg_-1407302614")]
    [Description(
        @"Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn."
    )]
    MaximumCash,

    /// <summary>
    /// Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.
    /// Encoded/decoded by serializers as &quot;MAXS&quot;.
    /// </summary>
    [EnumMember(Value = "MAXS")]
    [IsoId("_aP1PEtp-Ed-ak6NoX_4Aeg_-1300176639")]
    [Description(
        @"Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn."
    )]
    MaximumSecurities,

    /// <summary>
    /// Tender or exchange with the odd lot preference.
    /// Encoded/decoded by serializers as &quot;OPLF&quot;.
    /// </summary>
    [EnumMember(Value = "OPLF")]
    [IsoId("_aP1PE9p-Ed-ak6NoX_4Aeg_566570894")]
    [Description(@"Tender or exchange with the odd lot preference.")]
    OddLotPreference,

    /// <summary>
    /// Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_aP1PFNp-Ed-ak6NoX_4Aeg_566570923")]
    [Description(
        @"Feature whereby the option can be subject to pro ration in case, for example, of over-subscription."
    )]
    Proration,

    /// <summary>
    /// Feature whereby the holder can elect a quantity to receive over and above normal ensured entitlement.
    /// Encoded/decoded by serializers as &quot;QOVE&quot;.
    /// </summary>
    [EnumMember(Value = "QOVE")]
    [IsoId("_aP1PFdp-Ed-ak6NoX_4Aeg_566570924")]
    [Description(
        @"Feature whereby the holder can elect a quantity to receive over and above normal ensured entitlement."
    )]
    OverAndAbove,

    /// <summary>
    /// Feature whereby the holder can elect a quantity to receive.
    /// Encoded/decoded by serializers as &quot;QREC&quot;.
    /// </summary>
    [EnumMember(Value = "QREC")]
    [IsoId("_aP1PFtp-Ed-ak6NoX_4Aeg_566570954")]
    [Description(@"Feature whereby the holder can elect a quantity to receive.")]
    QuantityToReceive,

    /// <summary>
    /// Reduced withholding tax rate applies to the option.
    /// Encoded/decoded by serializers as &quot;VVPR&quot;.
    /// </summary>
    [EnumMember(Value = "VVPR")]
    [IsoId("_aP1PF9p-Ed-ak6NoX_4Aeg_566570955")]
    [Description(@"Reduced withholding tax rate applies to the option.")]
    ReducedWithholdingTax,

    /// <summary>
    /// Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension.
    /// Encoded/decoded by serializers as &quot;PINS&quot;.
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_M5t68N3eEd-KAqAOGQOnnw")]
    [Description(
        @"Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension."
    )]
    PreviousInstructionInvalidity,

    /// <summary>
    /// Option is offered by the account servicer only.
    /// Encoded/decoded by serializers as &quot;ASVO&quot;.
    /// </summary>
    [EnumMember(Value = "ASVO")]
    [IsoId("_icnX0_onEeCM181g5EbUXw")]
    [Description(@"Option is offered by the account servicer only.")]
    AccountServicerOption,

    /// <summary>
    /// Indicates that the holder needs to instruct at beneficiary owner level only.
    /// Encoded/decoded by serializers as &quot;BOIS&quot;.
    /// </summary>
    [EnumMember(Value = "BOIS")]
    [IsoId("_B2l64CdaEeOXAt_43VmZGw")]
    [Description(@"Indicates that the holder needs to instruct at beneficiary owner level only.")]
    BeneficiaryOwnerInstruction,

    /// <summary>
    /// Feature whereby the holder should only instruct a cash amount.
    /// Encoded/decoded by serializers as &quot;QCAS&quot;.
    /// </summary>
    [EnumMember(Value = "QCAS")]
    [IsoId("_kgtpoIclEeavwKddCbm3hg")]
    [Description(@"Feature whereby the holder should only instruct a cash amount.")]
    InstructCashAmount,

    /// <summary>
    /// Indicates usage of a reference number to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code).
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_F_hDcLaCEeiN--kDwanlkA")]
    [Description(
        @"Indicates usage of a reference number to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code)."
    )]
    ShareholderNumber,

    /// <summary>
    /// Gross dividend is reinvested.
    /// Encoded/decoded by serializers as &quot;RGRS&quot;.
    /// </summary>
    [EnumMember(Value = "RGRS")]
    [IsoId("")]
    [Description(@"Gross dividend is reinvested.")]
    GrossDividendReinvestment,

    /// <summary>
    /// Dividend reinvestment is processed net of withholding tax.
    /// Encoded/decoded by serializers as &quot;RNET&quot;.
    /// </summary>
    [EnumMember(Value = "RNET")]
    [IsoId("")]
    [Description(@"Dividend reinvestment is processed net of withholding tax.")]
    NetDividendReinvestment,
}
