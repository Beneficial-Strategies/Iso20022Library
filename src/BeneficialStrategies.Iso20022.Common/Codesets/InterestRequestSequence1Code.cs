// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the interest request is new or updated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YbKMd9p-Ed-ak6NoX_4Aeg_2101487215")]
[Description(@"Indicates whether the interest request is new or updated.")]
[DerivedFrom(typeof(InterestRequestSequenceCode))]
public enum InterestRequestSequence1Code
{
    /// <summary>
    /// Indicates this is a new interest payment request.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_YbKMeNp-Ed-ak6NoX_4Aeg_-654514650")]
    [Description(@"Indicates this is a new interest payment request.")]
    Initial = InterestRequestSequenceCode.Initial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates this is an updated interest payement request.
    /// Encoded/decoded by serializers as &quot;UPDA&quot;.
    /// </summary>
    [EnumMember(Value = "UPDA")]
    [IsoId("_YbT9cNp-Ed-ak6NoX_4Aeg_-200427381")]
    [Description(@"Indicates this is an updated interest payement request.")]
    Updated = InterestRequestSequenceCode.Updated, // same ordinal as derivation source for type conversions
}
