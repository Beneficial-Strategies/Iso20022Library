// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the source of a price quotation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aI_AONp-Ed-ak6NoX_4Aeg_-1214303822")]
[Description(@"Indicates the source of a price quotation.")]
[DerivedFrom(typeof(PriceSourceCode))]
public enum PriceSource1Code
{
    /// <summary>
    /// Source of price quotation is a fund, eg, transfer agent, fund itself.
    /// Encoded/decoded by serializers as &quot;FUND&quot;.
    /// </summary>
    [EnumMember(Value = "FUND")]
    [IsoId("_aJIKINp-Ed-ak6NoX_4Aeg_-1087782704")]
    [Description(@"Source of price quotation is a fund, eg, transfer agent, fund itself.")]
    Fund = PriceSourceCode.Fund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Source of price quotation is a theoretical value based on the market yield.
    /// Encoded/decoded by serializers as &quot;THEO&quot;.
    /// </summary>
    [EnumMember(Value = "THEO")]
    [IsoId("_aJIKIdp-Ed-ak6NoX_4Aeg_-1073007545")]
    [Description(@"Source of price quotation is a theoretical value based on the market yield.")]
    Theoretical = PriceSourceCode.Theoretical, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Source of price quotation is an external vendor.
    /// Encoded/decoded by serializers as &quot;VEND&quot;.
    /// </summary>
    [EnumMember(Value = "VEND")]
    [IsoId("_aJIKItp-Ed-ak6NoX_4Aeg_-1060076665")]
    [Description(@"Source of price quotation is an external vendor.")]
    Vendor = PriceSourceCode.Vendor, // same ordinal as derivation source for type conversions
    
}
