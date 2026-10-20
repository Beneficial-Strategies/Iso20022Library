// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JBI74d8FEe-NrtAAlrBEgQ")]
[Description(@"Specifies the reason why the instruction has a pending status.")]
[DerivedFrom(typeof(PendingFailingReasonV2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PendingReason30Code>))]
public enum PendingReason30Code
{
    /// <summary>
    /// Counterparty disagreement on the chosen corporate action outturn.
    /// Encoded/decoded by serializers as &quot;BUMM&quot;.
    /// </summary>
    [EnumMember(Value = "BUMM")]
    [IsoId("_csN7Md8MEe-NrtAAlrBEgQ")]
    [Description(@"Counterparty disagreement on the chosen corporate action outturn.")]
    BuyerProtectionMismatch = PendingFailingReasonV2Code.BuyerProtectionMismatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Received after the election to counterparty response market deadline.
    /// Encoded/decoded by serializers as &quot;ECRD&quot;.
    /// </summary>
    [EnumMember(Value = "ECRD")]
    [IsoId("_hoJ-ETPtEfCIZLORDJsr-g")]
    [Description(@"Received after the election to counterparty response market deadline.")]
    ElectionToCounterpartyResponseDeadlineMissed = PendingFailingReasonV2Code.ElectionToCounterpartyResponseDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_JFt5498FEe-NrtAAlrBEgQ")]
    [Description(@"Other. See Narrative.")]
    Other = PendingFailingReasonV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Allegement has been sent out to counterparty. Waiting for the response.
    /// Encoded/decoded by serializers as &quot;WCTF&quot;.
    /// </summary>
    [EnumMember(Value = "WCTF")]
    [IsoId("_m3aRMTPtEfCIZLORDJsr-g")]
    [Description(@"Allegement has been sent out to counterparty. Waiting for the response.")]
    AwaitingCounterpartyResponse = PendingFailingReasonV2Code.AwaitingCounterpartyResponse, // same ordinal as derivation source for type conversions
}
