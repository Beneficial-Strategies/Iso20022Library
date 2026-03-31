// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bpZDBtp-Ed-ak6NoX_4Aeg_423330067")]
[Description(@"Specifies additional information about the processed instruction.")]
[Derivations(
    typeof(AcknowledgementReason5Code),
    typeof(AcknowledgementReason6Code),
    typeof(AcknowledgementReason2Code),
    typeof(AcknowledgementReason4Code),
    typeof(AcknowledgementReason3Code),
    typeof(AcknowledgementReason8Code),
    typeof(AcknowledgementReason10Code),
    typeof(AcknowledgementReason7Code),
    typeof(AcknowledgementReason9Code),
    typeof(AcknowledgementReason1Code)
)]
public enum AcknowledgementReasonCode
{
    /// <summary>
    /// Received after the account servicer&apos;s deadline. Processed on best effort basis.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_bpZDB9p-Ed-ak6NoX_4Aeg_309491001")]
    [Description(
        @"Received after the account servicer's deadline. Processed on best effort basis."
    )]
    AccountServicerDeadlineMissed,

    /// <summary>
    /// Instruction is accepted but does not comply with the market practice rule published for the concerned market or process.
    /// Encoded/decoded by serializers as &quot;SMPG&quot;.
    /// </summary>
    [EnumMember(Value = "SMPG")]
    [IsoId("_bpZDCNp-Ed-ak6NoX_4Aeg_-865700024")]
    [Description(
        @"Instruction is accepted but does not comply with the market practice rule published for the concerned market or process."
    )]
    MarketPracticeRuleDiscrepency,

    /// <summary>
    /// Instruction was received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_bpi0ANp-Ed-ak6NoX_4Aeg_-1570814639")]
    [Description(@"Instruction was received after market deadline.")]
    MarketDeadlineMissed,

    /// <summary>
    /// Instruction was not straight through processing and had to be processed manually.
    /// Encoded/decoded by serializers as &quot;NSTP&quot;.
    /// </summary>
    [EnumMember(Value = "NSTP")]
    [IsoId("_bpi0Adp-Ed-ak6NoX_4Aeg_74452796")]
    [Description(
        @"Instruction was not straight through processing and had to be processed manually."
    )]
    NotStraightThroughProcessing,

    /// <summary>
    /// Instruction registration is accepted but the registration is not in full, that is, not with voting rights.
    /// Encoded/decoded by serializers as &quot;RQWV&quot;.
    /// </summary>
    [EnumMember(Value = "RQWV")]
    [IsoId("_bpi0Atp-Ed-ak6NoX_4Aeg_1613241238")]
    [Description(
        @"Instruction registration is accepted but the registration is not in full, that is, not with voting rights."
    )]
    AcceptedWithoutVotingRights,

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bpi0A9p-Ed-ak6NoX_4Aeg_-39849136")]
    [Description(@"Other. See Narrative.")]
    Other,

    /// <summary>
    /// Execution is conditional to the execution of a process linked to the currency of the transaction.
    /// Encoded/decoded by serializers as &quot;CDCY&quot;.
    /// </summary>
    [EnumMember(Value = "CDCY")]
    [IsoId("_bpi0BNp-Ed-ak6NoX_4Aeg_277271")]
    [Description(
        @"Execution is conditional to the execution of a process linked to the currency of the transaction."
    )]
    ConditionalCurrency,

    /// <summary>
    /// Execution is conditional to the execution of a process at the registrar.
    /// Encoded/decoded by serializers as &quot;CDRG&quot;.
    /// </summary>
    [EnumMember(Value = "CDRG")]
    [IsoId("_bpi0Bdp-Ed-ak6NoX_4Aeg_-732594298")]
    [Description(@"Execution is conditional to the execution of a process at the registrar.")]
    ConditionalRegistrar,

    /// <summary>
    /// Execution is conditional to the execution of a process of realignment at the issuer CSD.
    /// Encoded/decoded by serializers as &quot;CDRE&quot;.
    /// </summary>
    [EnumMember(Value = "CDRE")]
    [IsoId("_bpi0Btp-Ed-ak6NoX_4Aeg_1822773303")]
    [Description(
        @"Execution is conditional to the execution of a process of realignment at the issuer CSD."
    )]
    ConditionalRealignement,

    /// <summary>
    /// See narrative field for reason.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_-23l4Cz1EeOsiuMH68so7Q")]
    [Description(@"See narrative field for reason.")]
    NarrativeReason,
}
