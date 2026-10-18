// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a returned status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Bq1lIIZPEe-4Qrkp6i5eWQ")]
[Description(@"Specifies the reason why the instruction/cancellation request has a returned status.")]
[DerivedFrom(typeof(ReturnedStatusCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ReturnedStatus1Code>))]
public enum ReturnedStatus1Code
{
    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_CqcA8YZPEe-4Qrkp6i5eWQ")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason = ReturnedStatusCode.NarrativeReason, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Shares returned due to prorated acceptance.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_CvQPgoZPEe-4Qrkp6i5eWQ")]
    [Description(@"Shares returned due to prorated acceptance.")]
    Prorated = ReturnedStatusCode.Prorated, // same ordinal as derivation source for type conversions
}
