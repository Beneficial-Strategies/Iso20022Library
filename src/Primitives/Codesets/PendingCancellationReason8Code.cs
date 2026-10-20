// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the cancellation request has a pending status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_f26Ywd8QEe-NrtAAlrBEgQ")]
[Description(@"Specifies the reason why the cancellation request has a pending status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PendingCancellationReason8Code>))]
public enum PendingCancellationReason8Code
{
    /// <summary>
    /// Received after the election to counterparty response market deadline.
    /// Encoded/decoded by serializers as &quot;ECRD&quot;.
    /// </summary>
    [EnumMember(Value = "ECRD")]
    [IsoId("_mYhgUTPuEfCIZLORDJsr-g")]
    [Description(@"Received after the election to counterparty response market deadline.")]
    ElectionToCounterpartyResponseDeadlineMissed = RejectionReasonV3Code.ElectionToCounterpartyResponseDeadlineMissed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other. See Narrative.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_f7NC6d8QEe-NrtAAlrBEgQ")]
    [Description(@"Other. See Narrative.")]
    Other = RejectionReasonV3Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending acceptance from the counterparty.
    /// Encoded/decoded by serializers as &quot;PCAT&quot;.
    /// </summary>
    [EnumMember(Value = "PCAT")]
    [IsoId("_0rs4gd8fEe-NrtAAlrBEgQ")]
    [Description(@"Pending acceptance from the counterparty.")]
    PendingCounterpartyAcceptance = RejectionReasonV3Code.PendingCounterpartyAcceptance, // same ordinal as derivation source for type conversions
}
