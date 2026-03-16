// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the precise type of reservation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8KDc86MgEeCJ6YNENx4h-w_-1329725720")]
[Description(@"Specifies the precise type of reservation.")]
[DerivedFrom(typeof(ReservationTypeCode))]
public enum ReservationType2Code
{
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing cash withdrawals.
    /// Encoded/decoded by serializers as &quot;CARE&quot;.
    /// </summary>
    [EnumMember(Value = "CARE")]
    [IsoId("_8KDc9KMgEeCJ6YNENx4h-w_-2072444791")]
    [Description(
        @"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing cash withdrawals."
    )]
    CashReservation = ReservationTypeCode.CashReservation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments.
    /// Encoded/decoded by serializers as &quot;UPAR&quot;.
    /// </summary>
    [EnumMember(Value = "UPAR")]
    [IsoId("_8KDc9aMgEeCJ6YNENx4h-w_-2083543568")]
    [Description(
        @"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments."
    )]
    UrgentPaymentReservation = ReservationTypeCode.UrgentPaymentReservation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System.
    /// Encoded/decoded by serializers as &quot;NSSR&quot;.
    /// </summary>
    [EnumMember(Value = "NSSR")]
    [IsoId("_8KDc9qMgEeCJ6YNENx4h-w_58010523")]
    [Description(
        @"Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System."
    )]
    NetSSSReservation = ReservationTypeCode.NetSSSReservation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing highly urgent payments.
    /// Encoded/decoded by serializers as &quot;HPAR&quot;.
    /// </summary>
    [EnumMember(Value = "HPAR")]
    [IsoId("_8KDc96MgEeCJ6YNENx4h-w_643957549")]
    [Description(
        @"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing highly urgent payments."
    )]
    HighlyUrgentPaymentReservation = ReservationTypeCode.HighlyUrgentPaymentReservation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount above which funds will be destined for investment.
    /// Encoded/decoded by serializers as &quot;THRE&quot;.
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_8KMm4KMgEeCJ6YNENx4h-w_-428047510")]
    [Description(@"Amount above which funds will be destined for investment.")]
    ThresholdForInvestment = ReservationTypeCode.ThresholdForInvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.
    /// Encoded/decoded by serializers as &quot;BLKD&quot;.
    /// </summary>
    [EnumMember(Value = "BLKD")]
    [IsoId("_8KMm4aMgEeCJ6YNENx4h-w_-745824171")]
    [Description(
        @"Amount blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy."
    )]
    Blocked = ReservationTypeCode.Blocked, // same ordinal as derivation source for type conversions
}
