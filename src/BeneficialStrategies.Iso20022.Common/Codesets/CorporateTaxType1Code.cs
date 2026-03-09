// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the corporate tax identification type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZOAkC7REemIy6A-26wnAg")]
[Description(@"Indicates the corporate tax identification type.")]
[DerivedFrom(typeof(CorporateTaxTypeCode))]
public enum CorporateTaxType1Code
{
    /// <summary>
    /// Small Business
    /// Encoded/decoded by serializers as &quot;SMBS&quot;.
    /// </summary>
    [EnumMember(Value = "SMBS")]
    [IsoId("_aEAucS7REemIy6A-26wnAg")]
    [Description(@"Small Business")]
    SmallBusiness = CorporateTaxTypeCode.SmallBusiness, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aIZfMS7REemIy6A-26wnAg")]
    [Description(@"Other")]
    Other = CorporateTaxTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Corporate
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_aMSgsS7REemIy6A-26wnAg")]
    [Description(@"Corporate")]
    Corporate = CorporateTaxTypeCode.Corporate, // same ordinal as derivation source for type conversions
    
}
