// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of margin.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aUJuZNp-Ed-ak6NoX_4Aeg_797163955")]
[Description(@"Specifies the type of margin.")]
[DerivedFrom(typeof(RemarketingMarginTypeCode))]
public enum RemarketingMarginType1Code
{
    /// <summary>
    /// Agreed margin.
    /// Encoded/decoded by serializers as &quot;AGRE&quot;.
    /// </summary>
    [EnumMember(Value = "AGRE")]
    [IsoId("_aUJuZdp-Ed-ak6NoX_4Aeg_818404999")]
    [Description(@"Agreed margin.")]
    Agreed = RemarketingMarginTypeCode.Agreed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Alternative margin.
    /// Encoded/decoded by serializers as &quot;ALTE&quot;.
    /// </summary>
    [EnumMember(Value = "ALTE")]
    [IsoId("_aUJuZtp-Ed-ak6NoX_4Aeg_1072371865")]
    [Description(@"Alternative margin.")]
    Alternative = RemarketingMarginTypeCode.Alternative, // same ordinal as derivation source for type conversions
    
}
