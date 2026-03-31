// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the features that may apply to a corporate action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_L5yvAd3eEd-KAqAOGQOnnw")]
[Description(@"Specifies the features that may apply to a corporate action option.")]
[DerivedFrom(typeof(OptionFeaturesCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OptionFeatures3Code>))]
#endif
public enum OptionFeatures3Code
{
    /// <summary>
    /// Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.
    /// Encoded/decoded by serializers as &quot;CAOS&quot;.
    /// </summary>
    [EnumMember(Value = "CAOS")]
    [IsoId("_q5HiMWtdEeCY4-KZ9JEyUQ_-1152865500")]
    [Description(
        @"Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants."
    )]
    OptionApplicability = OptionFeaturesCode.OptionApplicability, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder can elect to place a condition on the acceptance of the option.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_q5HiMmtdEeCY4-KZ9JEyUQ_1881015850")]
    [Description(
        @"Feature whereby the holder can elect to place a condition on the acceptance of the option."
    )]
    Conditional = OptionFeaturesCode.Conditional, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.
    /// Encoded/decoded by serializers as &quot;MAXC&quot;.
    /// </summary>
    [EnumMember(Value = "MAXC")]
    [IsoId("_q5HiM2tdEeCY4-KZ9JEyUQ_1245984004")]
    [Description(
        @"Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn."
    )]
    MaximumCash = OptionFeaturesCode.MaximumCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.
    /// Encoded/decoded by serializers as &quot;MAXS&quot;.
    /// </summary>
    [EnumMember(Value = "MAXS")]
    [IsoId("_q5HiNGtdEeCY4-KZ9JEyUQ_-1970962954")]
    [Description(
        @"Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn."
    )]
    MaximumSecurities = OptionFeaturesCode.MaximumSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tender or exchange with the odd lot preference.
    /// Encoded/decoded by serializers as &quot;OPLF&quot;.
    /// </summary>
    [EnumMember(Value = "OPLF")]
    [IsoId("_q5HiNWtdEeCY4-KZ9JEyUQ_1326931989")]
    [Description(@"Tender or exchange with the odd lot preference.")]
    OddLotPreference = OptionFeaturesCode.OddLotPreference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_q5HiNmtdEeCY4-KZ9JEyUQ_-613151998")]
    [Description(
        @"Feature whereby the option can be subject to pro ration in case, for example, of over-subscription."
    )]
    Proration = OptionFeaturesCode.Proration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder can elect a quantity to receive over and above normal ensured entitlement.
    /// Encoded/decoded by serializers as &quot;QOVE&quot;.
    /// </summary>
    [EnumMember(Value = "QOVE")]
    [IsoId("_q5RTMGtdEeCY4-KZ9JEyUQ_1531268425")]
    [Description(
        @"Feature whereby the holder can elect a quantity to receive over and above normal ensured entitlement."
    )]
    OverAndAbove = OptionFeaturesCode.OverAndAbove, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder can elect a quantity to receive.
    /// Encoded/decoded by serializers as &quot;QREC&quot;.
    /// </summary>
    [EnumMember(Value = "QREC")]
    [IsoId("_q5RTMWtdEeCY4-KZ9JEyUQ_534196072")]
    [Description(@"Feature whereby the holder can elect a quantity to receive.")]
    QuantityToReceive = OptionFeaturesCode.QuantityToReceive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reduced withholding tax rate applies to the option.
    /// Encoded/decoded by serializers as &quot;VVPR&quot;.
    /// </summary>
    [EnumMember(Value = "VVPR")]
    [IsoId("_q5RTMmtdEeCY4-KZ9JEyUQ_-2002933718")]
    [Description(@"Reduced withholding tax rate applies to the option.")]
    ReducedWithholdingTax = OptionFeaturesCode.ReducedWithholdingTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder must elect directly to the issuer&apos;s agent (issuer only supported option).
    /// Encoded/decoded by serializers as &quot;NOSE&quot;.
    /// </summary>
    [EnumMember(Value = "NOSE")]
    [IsoId("_q5RTM2tdEeCY4-KZ9JEyUQ_-2014032495")]
    [Description(
        @"Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option)."
    )]
    NoServiceOffered = OptionFeaturesCode.NoServiceOffered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension.
    /// Encoded/decoded by serializers as &quot;PINS&quot;.
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_q5RTNGtdEeCY4-KZ9JEyUQ_1283862448")]
    [Description(
        @"Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension."
    )]
    PreviousInstructionInvalidity = OptionFeaturesCode.PreviousInstructionInvalidity, // same ordinal as derivation source for type conversions
}
