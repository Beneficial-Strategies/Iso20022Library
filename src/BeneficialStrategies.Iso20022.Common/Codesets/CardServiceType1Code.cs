// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of reconciliation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0GHcoHu8EeSLmfFG0DG7zQ")]
[Description(@"Type of reconciliation.")]
[DerivedFrom(typeof(CardServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardServiceType1Code>))]
#endif
public enum CardServiceType1Code
{
    /// <summary>
    /// Partial reconciliation of the day.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_AFicAXu9EeSLmfFG0DG7zQ")]
    [Description(@"Partial reconciliation of the day.")]
    CheckPoint = CardServiceTypeCode.CheckPoint, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final reconciliation.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_AK5dIXu9EeSLmfFG0DG7zQ")]
    [Description(@"Final reconciliation.")]
    Final = CardServiceTypeCode.Final, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Request for totals of a previous reconciliation.
    /// Encoded/decoded by serializers as &quot;PRVS&quot;.
    /// </summary>
    [EnumMember(Value = "PRVS")]
    [IsoId("_AUbzo3u9EeSLmfFG0DG7zQ")]
    [Description(@"Request for totals of a previous reconciliation.")]
    TotalInquiry = CardServiceTypeCode.TotalInquiry, // same ordinal as derivation source for type conversions
}
