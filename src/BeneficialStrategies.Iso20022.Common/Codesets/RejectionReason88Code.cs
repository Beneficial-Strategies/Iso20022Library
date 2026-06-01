// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qoVJYd8PEe-NrtAAlrBEgQ")]
[Description(
    @"Specifies the reason why the instruction/cancellation request has a rejected status."
)]
[DerivedFrom(typeof(RejectionReasonV3Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<RejectionReason88Code>))]
public enum RejectionReason88Code
{
    /// <summary>
    /// Cancellation declined.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_qs0Ay98PEe-NrtAAlrBEgQ")]
    [Description(@"Cancellation request was rejected since the instruction has already been cancelled.")]
    RejectedSinceAlreadyCancelled = RejectionReasonV3Code.RejectedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_qs0Azd8PEe-NrtAAlrBEgQ")]
    [Description(@"Cancellation request has been rejected because the instruction process is in progress or has been processed.")]
    RejectedSinceInProgress = RejectionReasonV3Code.RejectedSinceInProgress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is a duplicate of another instruction.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_qs0A398PEe-NrtAAlrBEgQ")]
    [Description(@"Instruction is a duplicate of another instruction.")]
    DuplicateInstruction = RejectionReasonV3Code.DuplicateInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after the election to counterparty mandate market deadline.
    /// Encoded/decoded by serializers as &quot;ECMD&quot;.
    /// </summary>
    [EnumMember(Value = "ECMD")]
    [IsoId("_csW9ADPuEfCIZLORDJsr-g")]
    [Description(@"Received after the election to counterparty market deadline.")]
    ElectionToCounterpartyMarketDeadlineMissed = RejectionReasonV3Code.ElectionToCounterpartyMarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after the election to counterparty response market deadline.
    /// Encoded/decoded by serializers as &quot;ECRD&quot;.
    /// </summary>
    [EnumMember(Value = "ECRD")]
    [IsoId("_czPoITPuEfCIZLORDJsr-g")]
    [Description(@"Received after the election to counterparty response market deadline.")]
    ElectionToCounterpartyResponseDeadlineMissed = RejectionReasonV3Code.ElectionToCounterpartyResponseDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_qs0Ax98PEe-NrtAAlrBEgQ")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonV3Code.MarketDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_qs0Ayd8PEe-NrtAAlrBEgQ")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Linked reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_qs0Axd8PEe-NrtAAlrBEgQ")]
    [Description(@"Linked reference is unknown.")]
    InvalidReference = RejectionReasonV3Code.InvalidReference, // same ordinal as derivation source for type conversions
}
