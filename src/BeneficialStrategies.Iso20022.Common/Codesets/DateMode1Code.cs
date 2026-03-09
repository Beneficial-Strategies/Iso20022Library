// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies, for a date, when the event or operation is to take place, for example at the beginning or end of the day.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_f_Z6kFuSEeSmO6RkXg92Lg")]
[Description(@"Specifies, for a date, when the event or operation is to take place, for example at the beginning or end of the day.")]
[DerivedFrom(typeof(DateModeCode))]
public enum DateMode1Code
{
    /// <summary>
    /// Beginning of day.
    /// Encoded/decoded by serializers as &quot;BODY&quot;.
    /// </summary>
    [EnumMember(Value = "BODY")]
    [IsoId("_jKunEVuSEeSmO6RkXg92Lg")]
    [Description(@"Beginning of day.")]
    BODY = DateModeCode.BODY, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// End of day.
    /// Encoded/decoded by serializers as &quot;EODY&quot;.
    /// </summary>
    [EnumMember(Value = "EODY")]
    [IsoId("_jT6_UVuSEeSmO6RkXg92Lg")]
    [Description(@"End of day.")]
    EODY = DateModeCode.EODY, // same ordinal as derivation source for type conversions
    
}
