// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the value of a rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZaMAhdp-Ed-ak6NoX_4Aeg_-1008646416")]
[Description(@"Specifies the value of a rate.")]
[DerivedFrom(typeof(RateTypeCode))]
public enum RateValueType2Code
{
    /// <summary>
    /// Rate is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ZaMAhtp-Ed-ak6NoX_4Aeg_-1008646189")]
    [Description(@"Rate is unknown by the sender or has not been established.")]
    Unknown = RateTypeCode.Unknown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_ZaMAh9p-Ed-ak6NoX_4Aeg_-1008646188")]
    [Description(@"Rate has not been established.")]
    Open = RateTypeCode.Open, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate will not be paid.
    /// Encoded/decoded by serializers as &quot;NILP&quot;.
    /// </summary>
    [EnumMember(Value = "NILP")]
    [IsoId("_ZaMAiNp-Ed-ak6NoX_4Aeg_-1008646168")]
    [Description(@"Rate will not be paid.")]
    NilPayment = RateTypeCode.NilPayment, // same ordinal as derivation source for type conversions
}
