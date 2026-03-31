// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bpPSANp-Ed-ak6NoX_4Aeg_-1257492124")]
[Description(@"Specifies additional information about the processed instruction.")]
[DerivedFrom(typeof(AcknowledgementReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AcknowledgementReason4Code>))]
#endif
public enum AcknowledgementReason4Code
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_bpPSAdp-Ed-ak6NoX_4Aeg_-966580559")]
    [Description(
        @"Received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = AcknowledgementReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_bpPSAtp-Ed-ak6NoX_4Aeg_-925024563")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed = AcknowledgementReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction was not straight through processing and had to be processed manually.
    /// Encoded/decoded by serializers as &quot;NSTP&quot;.
    /// </summary>
    [EnumMember(Value = "NSTP")]
    [IsoId("_bpPSA9p-Ed-ak6NoX_4Aeg_-856682877")]
    [Description(
        @"Instruction was not straight through processing and had to be processed manually."
    )]
    NotStraightThroughProcessing = AcknowledgementReasonCode.NotStraightThroughProcessing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bpPSBNp-Ed-ak6NoX_4Aeg_1167272842")]
    [Description(@"Other. See Narrative.")]
    Other = AcknowledgementReasonCode.Other, // same ordinal as derivation source for type conversions
}
