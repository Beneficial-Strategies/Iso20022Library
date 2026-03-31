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
[IsoId("_h8dHUQFJEeGwysJa71YlYA")]
[Description(@"Specifies the features that may apply to a corporate action option.")]
[DerivedFrom(typeof(OptionFeaturesCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OptionFeatures4Code>))]
#endif
public enum OptionFeatures4Code
{
    /// <summary>
    /// Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.
    /// Encoded/decoded by serializers as &quot;CAOS&quot;.
    /// </summary>
    [EnumMember(Value = "CAOS")]
    [IsoId("_h8m4VQFJEeGwysJa71YlYA")]
    [Description(
        @"Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants."
    )]
    OptionApplicability = OptionFeaturesCode.OptionApplicability, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder can elect to place a condition on the acceptance of the option.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_h8m4WQFJEeGwysJa71YlYA")]
    [Description(
        @"Feature whereby the holder can elect to place a condition on the acceptance of the option."
    )]
    Conditional = OptionFeaturesCode.Conditional, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.
    /// Encoded/decoded by serializers as &quot;MAXC&quot;.
    /// </summary>
    [EnumMember(Value = "MAXC")]
    [IsoId("_h8m4XQFJEeGwysJa71YlYA")]
    [Description(
        @"Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn."
    )]
    MaximumCash = OptionFeaturesCode.MaximumCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.
    /// Encoded/decoded by serializers as &quot;MAXS&quot;.
    /// </summary>
    [EnumMember(Value = "MAXS")]
    [IsoId("_h8m4YQFJEeGwysJa71YlYA")]
    [Description(
        @"Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn."
    )]
    MaximumSecurities = OptionFeaturesCode.MaximumSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tender or exchange with the odd lot preference.
    /// Encoded/decoded by serializers as &quot;OPLF&quot;.
    /// </summary>
    [EnumMember(Value = "OPLF")]
    [IsoId("_h8m4ZQFJEeGwysJa71YlYA")]
    [Description(@"Tender or exchange with the odd lot preference.")]
    OddLotPreference = OptionFeaturesCode.OddLotPreference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_h8m4aQFJEeGwysJa71YlYA")]
    [Description(
        @"Feature whereby the option can be subject to pro ration in case, for example, of over-subscription."
    )]
    Proration = OptionFeaturesCode.Proration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder can elect a quantity to receive over and above normal ensured entitlement.
    /// Encoded/decoded by serializers as &quot;QOVE&quot;.
    /// </summary>
    [EnumMember(Value = "QOVE")]
    [IsoId("_h8m4bQFJEeGwysJa71YlYA")]
    [Description(
        @"Feature whereby the holder can elect a quantity to receive over and above normal ensured entitlement."
    )]
    OverAndAbove = OptionFeaturesCode.OverAndAbove, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder can elect a quantity to receive.
    /// Encoded/decoded by serializers as &quot;QREC&quot;.
    /// </summary>
    [EnumMember(Value = "QREC")]
    [IsoId("_h8m4cQFJEeGwysJa71YlYA")]
    [Description(@"Feature whereby the holder can elect a quantity to receive.")]
    QuantityToReceive = OptionFeaturesCode.QuantityToReceive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reduced withholding tax rate applies to the option.
    /// Encoded/decoded by serializers as &quot;VVPR&quot;.
    /// </summary>
    [EnumMember(Value = "VVPR")]
    [IsoId("_h8m4dQFJEeGwysJa71YlYA")]
    [Description(@"Reduced withholding tax rate applies to the option.")]
    ReducedWithholdingTax = OptionFeaturesCode.ReducedWithholdingTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder must elect directly to the issuer&apos;s agent (issuer only supported option).
    /// Encoded/decoded by serializers as &quot;NOSE&quot;.
    /// </summary>
    [EnumMember(Value = "NOSE")]
    [IsoId("_h8m4eQFJEeGwysJa71YlYA")]
    [Description(
        @"Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option)."
    )]
    NoServiceOffered = OptionFeaturesCode.NoServiceOffered, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension.
    /// Encoded/decoded by serializers as &quot;PINS&quot;.
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_h8m4fQFJEeGwysJa71YlYA")]
    [Description(
        @"Indicates the previously sent instructions becomes invalid. This is only applicable after a market deadline extension."
    )]
    PreviousInstructionInvalidity = OptionFeaturesCode.PreviousInstructionInvalidity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Option is offered by the account servicer only.
    /// Encoded/decoded by serializers as &quot;ASVO&quot;.
    /// </summary>
    [EnumMember(Value = "ASVO")]
    [IsoId("_i-6p5gFJEeGwysJa71YlYA")]
    [Description(@"Option is offered by the account servicer only.")]
    AccountServicerOption = OptionFeaturesCode.AccountServicerOption, // same ordinal as derivation source for type conversions
}
