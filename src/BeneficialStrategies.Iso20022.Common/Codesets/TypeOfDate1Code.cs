// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether a date is actual or estimated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVs0sFfvEeOuDtoQo1qilA")]
[Description(@"Specifies whether a date is actual or estimated.")]
[DerivedFrom(typeof(TypeOfDateCode))]
public enum TypeOfDate1Code
{
    /// <summary>
    /// Date / date and time is the actual date / date and time.
    /// Encoded/decoded by serializers as &quot;ACTL&quot;.
    /// </summary>
    [EnumMember(Value = "ACTL")]
    [IsoId("_Ua4UEVfvEeOuDtoQo1qilA")]
    [Description(@"Date / date and time is the actual date / date and time.")]
    Actual = TypeOfDateCode.Actual, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Date/date and time is estimated.
    /// Encoded/decoded by serializers as &quot;ESTM&quot;.
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_UiUY0VfvEeOuDtoQo1qilA")]
    [Description(@"Date/date and time is estimated.")]
    Estimated = TypeOfDateCode.Estimated, // same ordinal as derivation source for type conversions
    
}
