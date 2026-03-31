// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the denied reason.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a0CvaNp-Ed-ak6NoX_4Aeg_255961944")]
[Description(@"Specifies the denied reason.")]
[DerivedFrom(typeof(DeniedReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DeniedReason3Code>))]
#endif
public enum DeniedReason3Code
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_a0MgYNp-Ed-ak6NoX_4Aeg_255961976")]
    [Description(@"Received after the account servicer's deadline.")]
    AccountServicerDeadlineMissed = DeniedReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repo call request was denied since another call already applies.
    /// Encoded/decoded by serializers as &quot;DCAL&quot;.
    /// </summary>
    [EnumMember(Value = "DCAL")]
    [IsoId("_a0MgYdp-Ed-ak6NoX_4Aeg_255961977")]
    [Description(@"Repo call request was denied since another call already applies.")]
    CallDeniedSinceAlreadyApplied = DeniedReasonCode.CallDeniedSinceAlreadyApplied, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay.
    /// Encoded/decoded by serializers as &quot;DFOR&quot;.
    /// </summary>
    [EnumMember(Value = "DFOR")]
    [IsoId("_a0MgYtp-Ed-ak6NoX_4Aeg_255962253")]
    [Description(
        @"Repo call request was denied. Call not allowed on the concerned repo, for example, out of delay."
    )]
    DeniedSinceNotAllowed = DeniedReasonCode.DeniedSinceNotAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_a0MgY9p-Ed-ak6NoX_4Aeg_255962345")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = DeniedReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_a0MgZNp-Ed-ak6NoX_4Aeg_59995441")]
    [Description(@"Other. See Narrative.")]
    Other = DeniedReasonCode.Other, // same ordinal as derivation source for type conversions
}
