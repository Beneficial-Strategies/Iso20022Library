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
[IsoId("_a1F4QNp-Ed-ak6NoX_4Aeg_-1154713525")]
[Description(
    @"Specifies the underlying reason for the cancellation of the associated transaction."
)]
[DerivedFrom(typeof(CancelledStatusReasonV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CancelledStatusReason6Code>))]
#endif
public enum CancelledStatusReason6Code
{
    /// <summary>
    /// Transaction is cancelled by yourself.
    /// Encoded/decoded by serializers as &quot;CANI&quot;.
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_a1F4Qdp-Ed-ak6NoX_4Aeg_1095310605")]
    [Description(@"Transaction is cancelled by yourself.")]
    CancelledByYourself = CancelledStatusReasonV2Code.CancelledByYourself, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is cancelled by a party other than the instructing party, for example, a market infrastructure such as a stock exchange.
    /// Encoded/decoded by serializers as &quot;CANO&quot;.
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_a1F4Qtp-Ed-ak6NoX_4Aeg_1161803601")]
    [Description(
        @"Transaction is cancelled by a party other than the instructing party, for example, a market infrastructure such as a stock exchange."
    )]
    CancelledByOther = CancelledStatusReasonV2Code.CancelledByOther, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is cancelled by the system.
    /// Encoded/decoded by serializers as &quot;CANS&quot;.
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_a1F4Q9p-Ed-ak6NoX_4Aeg_1193205425")]
    [Description(@"Transaction is cancelled by the system.")]
    CancelledBySystem = CancelledStatusReasonV2Code.CancelledBySystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been cancelled by the agent due to an event deadline extension.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_a1F4RNp-Ed-ak6NoX_4Aeg_1225528362")]
    [Description(
        @"Instruction has been cancelled by the agent due to an event deadline extension."
    )]
    CancelledByAgent = CancelledStatusReasonV2Code.CancelledByAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_a1F4Rdp-Ed-ak6NoX_4Aeg_1272087253")]
    [Description(@"Other. See Narrative.")]
    Other = CancelledStatusReasonV2Code.Other, // same ordinal as derivation source for type conversions
}
