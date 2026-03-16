// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// TSE/JASDEC codes for unknown number of shares to be purchased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZBS2UDFxEeGKkIZzgd38VA")]
[Description(@"TSE/JASDEC codes for unknown number of shares to be purchased.")]
[DerivedFrom(typeof(SecuritiesQuantityTypeCode))]
public enum SecuritiesQuantity2Code
{
    /// <summary>
    /// Maximum / Minimum number is unknown or not decided.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_bLRaljFxEeGKkIZzgd38VA")]
    [Description(@"Maximum / Minimum number is unknown or not decided.")]
    Unknown = SecuritiesQuantityTypeCode.Unknown, // same ordinal as derivation source for type conversions
}
