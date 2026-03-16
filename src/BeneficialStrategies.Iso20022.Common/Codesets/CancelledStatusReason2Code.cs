// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying reason for cancellation of the associated transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a0pMVtp-Ed-ak6NoX_4Aeg_-1194630284")]
[Description(@"Specifies the underlying reason for cancellation of the associated transaction.")]
[DerivedFrom(typeof(CancelledStatusReasonCode))]
public enum CancelledStatusReason2Code
{
    /// <summary>
    /// Transaction is cancelled by the hub.
    /// Encoded/decoded by serializers as &quot;CANH&quot;.
    /// </summary>
    [EnumMember(Value = "CANH")]
    [IsoId("_a0pMV9p-Ed-ak6NoX_4Aeg_-839075780")]
    [Description(@"Transaction is cancelled by the hub.")]
    CancelledByHub = CancelledStatusReasonCode.CancelledByHub, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is cancelled by the instructing party.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_a0pMWNp-Ed-ak6NoX_4Aeg_-811371079")]
    [Description(@"Transaction is cancelled by the instructing party.")]
    CancelledByInstructingParty = CancelledStatusReasonCode.CancelledByInstructingParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is rejected by the executing party, the rejection is final therefore the order is cancelled in the system.
    /// Encoded/decoded by serializers as &quot;CXLR&quot;.
    /// </summary>
    [EnumMember(Value = "CXLR")]
    [IsoId("_a0yWQNp-Ed-ak6NoX_4Aeg_-781815077")]
    [Description(
        @"Transaction is rejected by the executing party, the rejection is final therefore the order is cancelled in the system."
    )]
    EndOfLife = CancelledStatusReasonCode.EndOfLife, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is cancelled by a party other than the instructing party, eg, a market infrastructure such as a stock exchange.
    /// Encoded/decoded by serializers as &quot;CANO&quot;.
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_a0yWQdp-Ed-ak6NoX_4Aeg_1087397542")]
    [Description(
        @"Transaction is cancelled by a party other than the instructing party, eg, a market infrastructure such as a stock exchange."
    )]
    CancelledByOther = CancelledStatusReasonCode.CancelledByOther, // same ordinal as derivation source for type conversions
}
