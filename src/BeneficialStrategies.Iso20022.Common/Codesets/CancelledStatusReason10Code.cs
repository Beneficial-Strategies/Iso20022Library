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
[IsoId("_a0fbUdp-Ed-ak6NoX_4Aeg_-1834917145")]
[Description(
    @"Specifies the underlying reason for the cancellation of the associated transaction."
)]
[DerivedFrom(typeof(CancelledStatusReasonV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CancelledStatusReason10Code>))]
#endif
public enum CancelledStatusReason10Code
{
    /// <summary>
    /// Transaction is cancelled by yourself.
    /// Encoded/decoded by serializers as &quot;CANI&quot;.
    /// </summary>
    [EnumMember(Value = "CANI")]
    [IsoId("_a0fbUtp-Ed-ak6NoX_4Aeg_-189649710")]
    [Description(@"Transaction is cancelled by yourself.")]
    CancelledByYourself = CancelledStatusReasonV2Code.CancelledByYourself, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is cancelled by the system.
    /// Encoded/decoded by serializers as &quot;CANS&quot;.
    /// </summary>
    [EnumMember(Value = "CANS")]
    [IsoId("_a0fbU9p-Ed-ak6NoX_4Aeg_1462977798")]
    [Description(@"Transaction is cancelled by the system.")]
    CancelledBySystem = CancelledStatusReasonV2Code.CancelledBySystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been cancelled by the agent due to an event deadline extension.
    /// Encoded/decoded by serializers as &quot;CSUB&quot;.
    /// </summary>
    [EnumMember(Value = "CSUB")]
    [IsoId("_a0fbVNp-Ed-ak6NoX_4Aeg_1171020060")]
    [Description(
        @"Instruction has been cancelled by the agent due to an event deadline extension."
    )]
    CancelledByAgent = CancelledStatusReasonV2Code.CancelledByAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is rejected by the executing party, the rejection is final therefore the order is cancelled in the system.
    /// Encoded/decoded by serializers as &quot;CXLR&quot;.
    /// </summary>
    [EnumMember(Value = "CXLR")]
    [IsoId("_a0fbVdp-Ed-ak6NoX_4Aeg_1349138732")]
    [Description(
        @"Transaction is rejected by the executing party, the rejection is final therefore the order is cancelled in the system."
    )]
    EndOfLife = CancelledStatusReasonV2Code.EndOfLife, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original transaction has been cancelled and replaced due to a corporate action.
    /// Encoded/decoded by serializers as &quot;CANT&quot;.
    /// </summary>
    [EnumMember(Value = "CANT")]
    [IsoId("_a0fbVtp-Ed-ak6NoX_4Aeg_-1186722063")]
    [Description(
        @"Original transaction has been cancelled and replaced due to a corporate action."
    )]
    CancelledDueToTransformation = CancelledStatusReasonV2Code.CancelledDueToTransformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original transaction has been cancelled and replaced to allow a partial or split settlement.
    /// Encoded/decoded by serializers as &quot;CANZ&quot;.
    /// </summary>
    [EnumMember(Value = "CANZ")]
    [IsoId("_a0fbV9p-Ed-ak6NoX_4Aeg_465905445")]
    [Description(
        @"Original transaction has been cancelled and replaced to allow a partial or split settlement."
    )]
    CancelledSplitPartialSettlement = CancelledStatusReasonV2Code.CancelledSplitPartialSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been cancelled due to a corporate action.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_a0fbWNp-Ed-ak6NoX_4Aeg_173947707")]
    [Description(@"Transaction has been cancelled due to a corporate action.")]
    CancelledDueToCorporateAction = CancelledStatusReasonV2Code.CancelledDueToCorporateAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been cancelled; the security no longer exists or is no longer eligible on the market instructed. For corporate action related cancellation, CORP should be used.
    /// Encoded/decoded by serializers as &quot;SCEX&quot;.
    /// </summary>
    [EnumMember(Value = "SCEX")]
    [IsoId("_a0fbWdp-Ed-ak6NoX_4Aeg_352066379")]
    [Description(
        @"Transaction has been cancelled; the security no longer exists or is no longer eligible on the market instructed. For corporate action related cancellation, CORP should be used."
    )]
    SecuritiesNoLongerEligible = CancelledStatusReasonV2Code.SecuritiesNoLongerEligible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_a0pMUNp-Ed-ak6NoX_4Aeg_2111172880")]
    [Description(@"Other. See Narrative.")]
    Other = CancelledStatusReasonV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is cancelled by a party other than the instructing party, for example, a market infrastructure such as a stock exchange.
    /// Encoded/decoded by serializers as &quot;CANO&quot;.
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_a0pMUdp-Ed-ak6NoX_4Aeg_329434618")]
    [Description(
        @"Transaction is cancelled by a party other than the instructing party, for example, a market infrastructure such as a stock exchange."
    )]
    CancelledByOther = CancelledStatusReasonV2Code.CancelledByOther, // same ordinal as derivation source for type conversions
}
