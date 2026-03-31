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
[IsoId("_bpGIFdp-Ed-ak6NoX_4Aeg_-1663512836")]
[Description(@"Specifies additional information about the processed instruction.")]
[DerivedFrom(typeof(AcknowledgementReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AcknowledgementReason3Code>))]
#endif
public enum AcknowledgementReason3Code
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_bpGIFtp-Ed-ak6NoX_4Aeg_-1512482082")]
    [Description(
        @"Received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed = AcknowledgementReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is accepted but does not comply with the market practice rule published for the concerned market or process.
    /// Encoded/decoded by serializers as &quot;SMPG&quot;.
    /// </summary>
    [EnumMember(Value = "SMPG")]
    [IsoId("_bpGIF9p-Ed-ak6NoX_4Aeg_318441087")]
    [Description(
        @"Instruction is accepted but does not comply with the market practice rule published for the concerned market or process."
    )]
    MarketPracticeRuleDiscrepency = AcknowledgementReasonCode.MarketPracticeRuleDiscrepency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bpGIGNp-Ed-ak6NoX_4Aeg_-1522255292")]
    [Description(@"Other. See Narrative.")]
    Other = AcknowledgementReasonCode.Other, // same ordinal as derivation source for type conversions
}
