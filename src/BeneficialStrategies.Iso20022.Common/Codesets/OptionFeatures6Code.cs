// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the feature of an option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_v3kM0WOQEeW4z96Yfj3Wng")]
[Description(@"Specifies the feature of an option.")]
[DerivedFrom(typeof(OptionFeaturesCode))]
public enum OptionFeatures6Code
{
    /// <summary>
    /// Feature whereby the holder can elect to place a condition on the acceptance of the option.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_wLywYWOQEeW4z96Yfj3Wng")]
    [Description(@"Feature whereby the holder can elect to place a condition on the acceptance of the option.")]
    Conditional = OptionFeaturesCode.Conditional, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.
    /// Encoded/decoded by serializers as &quot;MAXC&quot;.
    /// </summary>
    [EnumMember(Value = "MAXC")]
    [IsoId("_wLywY2OQEeW4z96Yfj3Wng")]
    [Description(@"Maximum cash option, may be subject to scaling, as such you may receive a combination of cash and securities outturn.")]
    MaximumCash = OptionFeaturesCode.MaximumCash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.
    /// Encoded/decoded by serializers as &quot;MAXS&quot;.
    /// </summary>
    [EnumMember(Value = "MAXS")]
    [IsoId("_wLywZWOQEeW4z96Yfj3Wng")]
    [Description(@"Maximum stock option, may be subject to scaling, as such you may receive a combination of securities and cash outturn.")]
    MaximumSecurities = OptionFeaturesCode.MaximumSecurities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tender or exchange with the odd lot preference.
    /// Encoded/decoded by serializers as &quot;OPLF&quot;.
    /// </summary>
    [EnumMember(Value = "OPLF")]
    [IsoId("_wLywZ2OQEeW4z96Yfj3Wng")]
    [Description(@"Tender or exchange with the odd lot preference.")]
    OddLotPreference = OptionFeaturesCode.OddLotPreference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_wLywaWOQEeW4z96Yfj3Wng")]
    [Description(@"Feature whereby the option can be subject to pro ration in case, for example, of over-subscription.")]
    Proration = OptionFeaturesCode.Proration, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reduced withholding tax rate applies to the option.
    /// Encoded/decoded by serializers as &quot;VVPR&quot;.
    /// </summary>
    [EnumMember(Value = "VVPR")]
    [IsoId("_wLywb2OQEeW4z96Yfj3Wng")]
    [Description(@"Reduced withholding tax rate applies to the option.")]
    ReducedWithholdingTax = OptionFeaturesCode.ReducedWithholdingTax, // same ordinal as derivation source for type conversions
    
}
