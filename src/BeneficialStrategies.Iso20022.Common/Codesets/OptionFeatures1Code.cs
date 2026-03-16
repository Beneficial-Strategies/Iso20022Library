// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the feature of an option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aPYjI9p-Ed-ak6NoX_4Aeg_-906093897")]
[Description(@"Specifies the feature of an option.")]
[DerivedFrom(typeof(OptionFeaturesCode))]
public enum OptionFeatures1Code
{
    /// <summary>
    /// Feature whereby the holder can elect to place a condition on the acceptance of the option.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_aPYjJNp-Ed-ak6NoX_4Aeg_-906093895")]
    [Description(
        @"Feature whereby the holder can elect to place a condition on the acceptance of the option."
    )]
    Conditional = OptionFeaturesCode.Conditional, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.
    /// Encoded/decoded by serializers as &quot;MAXC&quot;.
    /// </summary>
    [EnumMember(Value = "MAXC")]
    [IsoId("_aPYjJdp-Ed-ak6NoX_4Aeg_-906093886")]
    [Description(
        @"Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn."
    )]
    MaximumCash = OptionFeaturesCode.MaximumCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.
    /// Encoded/decoded by serializers as &quot;MAXS&quot;.
    /// </summary>
    [EnumMember(Value = "MAXS")]
    [IsoId("_aPYjJtp-Ed-ak6NoX_4Aeg_-906093866")]
    [Description(
        @"Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn."
    )]
    MaximumSecurities = OptionFeaturesCode.MaximumSecurities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tender or exchange with the odd lot preference.
    /// Encoded/decoded by serializers as &quot;OPLF&quot;.
    /// </summary>
    [EnumMember(Value = "OPLF")]
    [IsoId("_aPiUINp-Ed-ak6NoX_4Aeg_-906093865")]
    [Description(@"Tender or exchange with the odd lot preference.")]
    OddLotPreference = OptionFeaturesCode.OddLotPreference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_aPiUIdp-Ed-ak6NoX_4Aeg_-906093835")]
    [Description(
        @"Feature whereby the option can be subject to pro ration in case, for example, of over-subscription."
    )]
    Proration = OptionFeaturesCode.Proration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder can elect a quantity to receive over and above normal ensured entitlement.
    /// Encoded/decoded by serializers as &quot;QOVE&quot;.
    /// </summary>
    [EnumMember(Value = "QOVE")]
    [IsoId("_aPiUItp-Ed-ak6NoX_4Aeg_-906093834")]
    [Description(
        @"Feature whereby the holder can elect a quantity to receive over and above normal ensured entitlement."
    )]
    OverAndAbove = OptionFeaturesCode.OverAndAbove, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Feature whereby the holder can elect a quantity to receive.
    /// Encoded/decoded by serializers as &quot;QREC&quot;.
    /// </summary>
    [EnumMember(Value = "QREC")]
    [IsoId("_aPiUI9p-Ed-ak6NoX_4Aeg_-906093833")]
    [Description(@"Feature whereby the holder can elect a quantity to receive.")]
    QuantityToReceive = OptionFeaturesCode.QuantityToReceive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reduced withholding tax rate applies to the option.
    /// Encoded/decoded by serializers as &quot;VVPR&quot;.
    /// </summary>
    [EnumMember(Value = "VVPR")]
    [IsoId("_aPiUJNp-Ed-ak6NoX_4Aeg_-906093805")]
    [Description(@"Reduced withholding tax rate applies to the option.")]
    ReducedWithholdingTax = OptionFeaturesCode.ReducedWithholdingTax, // same ordinal as derivation source for type conversions
}
