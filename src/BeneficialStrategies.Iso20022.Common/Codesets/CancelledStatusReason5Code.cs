// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for the cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a08HRtp-Ed-ak6NoX_4Aeg_566867564")]
[Description(
    @"Specifies the underlying reason for the cancellation of the associated transaction."
)]
[DerivedFrom(typeof(CancelledStatusReasonV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CancelledStatusReason5Code>))]
#endif
public enum CancelledStatusReason5Code
{
    /// <summary>
    /// Transaction is cancelled by yourself.
    /// Encoded/decoded by serializers as &quot;CANI&quot;.
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_a08HR9p-Ed-ak6NoX_4Aeg_-2082832297")]
    [Description(@"Transaction is cancelled by yourself.")]
    CancelledByYourself = CancelledStatusReasonV2Code.CancelledByYourself, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_a08HSNp-Ed-ak6NoX_4Aeg_1266449994")]
    [Description(@"Other. See Narrative.")]
    Other = CancelledStatusReasonV2Code.Other, // same ordinal as derivation source for type conversions
}
