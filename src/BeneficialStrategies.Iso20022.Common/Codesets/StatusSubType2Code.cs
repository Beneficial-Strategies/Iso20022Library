// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the sub status of the trade notification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EcL4QZU-EeaYkf5FCqYMeA")]
[Description(@"Indicates the sub status of the trade notification.")]
[DerivedFrom(typeof(StatusSubTypeCode))]
public enum StatusSubType2Code
{
    /// <summary>
    /// Same day flag has been set to true for the sub status of the trade notification.
    /// Encoded/decoded by serializers as &quot;SMDY&quot;.
    /// </summary>
    [EnumMember(Value = "SMDY")]
    [IsoId("_EmxXpZU-EeaYkf5FCqYMeA")]
    [Description(
        @"Same day flag has been set to true for the sub status of the trade notification."
    )]
    OnlySameDayFlagTrue = StatusSubTypeCode.OnlySameDayFlagTrue, // same ordinal as derivation source for type conversions
}
