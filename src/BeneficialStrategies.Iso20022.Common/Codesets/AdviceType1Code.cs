// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of advice to provide back in the report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_U8Z8ANomEembTrt_WixjyQ")]
[Description(@"Specifies the type of advice to provide back in the report.")]
[DerivedFrom(typeof(AdviceTypeCode))]
public enum AdviceType1Code
{
    /// <summary>
    /// Advice with transaction details is requested.
    /// Encoded/decoded by serializers as &quot;ADWD&quot;.
    /// </summary>
    [EnumMember(Value = "ADWD")]
    [IsoId("_XiPt0e8XEemSR6j6KWQzCg")]
    [Description(@"Advice with transaction details is requested.")]
    AdviceWithDetails = AdviceTypeCode.AdviceWithDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Advice without  transaction details is requested.
    /// Encoded/decoded by serializers as &quot;ADND&quot;.
    /// </summary>
    [EnumMember(Value = "ADND")]
    [IsoId("_Xz3CQe8XEemSR6j6KWQzCg")]
    [Description(@"Advice without  transaction details is requested.")]
    AdviceWithoutDetails = AdviceTypeCode.AdviceWithoutDetails, // same ordinal as derivation source for type conversions
    
}
