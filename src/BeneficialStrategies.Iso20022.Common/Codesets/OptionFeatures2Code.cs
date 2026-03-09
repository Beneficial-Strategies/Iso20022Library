// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the features that may apply to a corporate action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aPiUJdp-Ed-ak6NoX_4Aeg_646365217")]
[Description(@"Specifies the features that may apply to a corporate action option.")]
[DerivedFrom(typeof(OptionFeaturesCode))]
public enum OptionFeatures2Code
{
    /// <summary>
    /// Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.
    /// Encoded/decoded by serializers as &quot;CAOS&quot;.
    /// </summary>
    [EnumMember(Value = "CAOS")]
    [IsoId("_aPiUJtp-Ed-ak6NoX_4Aeg_760881963")]
    [Description(@"Option applicability is not subject to the account owner decision but depends on the terms defined by the issuer, for example in the case of equity linked notes or warrants.")]
    OptionApplicability = OptionFeaturesCode.OptionApplicability, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the holder can elect to place a condition on the acceptance of the option.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_aPiUJ9p-Ed-ak6NoX_4Aeg_646365219")]
    [Description(@"Feature whereby the holder can elect to place a condition on the acceptance of the option.")]
    Conditional = OptionFeaturesCode.Conditional, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.
    /// Encoded/decoded by serializers as &quot;MAXC&quot;.
    /// </summary>
    [EnumMember(Value = "MAXC")]
    [IsoId("_aPiUKNp-Ed-ak6NoX_4Aeg_646365234")]
    [Description(@"Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.")]
    MaximumCash = OptionFeaturesCode.MaximumCash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.
    /// Encoded/decoded by serializers as &quot;MAXS&quot;.
    /// </summary>
    [EnumMember(Value = "MAXS")]
    [IsoId("_aPiUKdp-Ed-ak6NoX_4Aeg_646365235")]
    [Description(@"Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.")]
    MaximumSecurities = OptionFeaturesCode.MaximumSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tender or exchange with the odd lot preference.
    /// Encoded/decoded by serializers as &quot;OPLF&quot;.
    /// </summary>
    [EnumMember(Value = "OPLF")]
    [IsoId("_aPsFINp-Ed-ak6NoX_4Aeg_646365252")]
    [Description(@"Tender or exchange with the odd lot preference.")]
    OddLotPreference = OptionFeaturesCode.OddLotPreference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_aPsFIdp-Ed-ak6NoX_4Aeg_646365269")]
    [Description(@"Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.")]
    Proration = OptionFeaturesCode.Proration, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the holder can elect a quantity to receive over and above normal ensured entitlement.
    /// Encoded/decoded by serializers as &quot;QOVE&quot;.
    /// </summary>
    [EnumMember(Value = "QOVE")]
    [IsoId("_aPsFItp-Ed-ak6NoX_4Aeg_646365295")]
    [Description(@"Feature whereby the holder can elect a quantity to receive over and above normal ensured entitlement.")]
    OverAndAbove = OptionFeaturesCode.OverAndAbove, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the holder can elect a quantity to receive.
    /// Encoded/decoded by serializers as &quot;QREC&quot;.
    /// </summary>
    [EnumMember(Value = "QREC")]
    [IsoId("_aPsFI9p-Ed-ak6NoX_4Aeg_646365296")]
    [Description(@"Feature whereby the holder can elect a quantity to receive.")]
    QuantityToReceive = OptionFeaturesCode.QuantityToReceive, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reduced withholding tax rate applies to the option.
    /// Encoded/decoded by serializers as &quot;VVPR&quot;.
    /// </summary>
    [EnumMember(Value = "VVPR")]
    [IsoId("_aPsFJNp-Ed-ak6NoX_4Aeg_646365313")]
    [Description(@"Reduced withholding tax rate applies to the option.")]
    ReducedWithholdingTax = OptionFeaturesCode.ReducedWithholdingTax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the holder must elect directly to the issuer&apos;s agent (issuer only supported option).
    /// Encoded/decoded by serializers as &quot;NOSE&quot;.
    /// </summary>
    [EnumMember(Value = "NOSE")]
    [IsoId("_aPsFJdp-Ed-ak6NoX_4Aeg_539775341")]
    [Description(@"Feature whereby the holder must elect directly to the issuer's agent (issuer only supported option).")]
    NoServiceOffered = OptionFeaturesCode.NoServiceOffered, // same ordinal as derivation source for type conversions
    
}
