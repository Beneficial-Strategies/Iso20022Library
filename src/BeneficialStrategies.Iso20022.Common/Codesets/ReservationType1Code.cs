// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the precise type of reservation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZUiEdNp-Ed-ak6NoX_4Aeg_865240256")]
[Description(@"Specifies the precise type of reservation.")]
[DerivedFrom(typeof(ReservationTypeCode))]
public enum ReservationType1Code
{
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing cash withdrawals.
    /// Encoded/decoded by serializers as &quot;CARE&quot;.
    /// </summary>
    [EnumMember(Value = "CARE")]
    [IsoId("_ZUiEddp-Ed-ak6NoX_4Aeg_937272384")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing cash withdrawals.")]
    CashReservation = ReservationTypeCode.CashReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments.
    /// Encoded/decoded by serializers as &quot;UPAR&quot;.
    /// </summary>
    [EnumMember(Value = "UPAR")]
    [IsoId("_ZUiEdtp-Ed-ak6NoX_4Aeg_952974761")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments.")]
    UrgentPaymentReservation = ReservationTypeCode.UrgentPaymentReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System.
    /// Encoded/decoded by serializers as &quot;NSSR&quot;.
    /// </summary>
    [EnumMember(Value = "NSSR")]
    [IsoId("_ZUiEd9p-Ed-ak6NoX_4Aeg_998225402")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System.")]
    NetSSSReservation = ReservationTypeCode.NetSSSReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing highly urgent payments.
    /// Encoded/decoded by serializers as &quot;HPAR&quot;.
    /// </summary>
    [EnumMember(Value = "HPAR")]
    [IsoId("_ZUiEeNp-Ed-ak6NoX_4Aeg_1227258206")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing highly urgent payments.")]
    HighlyUrgentPaymentReservation = ReservationTypeCode.HighlyUrgentPaymentReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount above which funds will be destined for investment.
    /// Encoded/decoded by serializers as &quot;THRE&quot;.
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_ZUiEedp-Ed-ak6NoX_4Aeg_1253119695")]
    [Description(@"Amount above which funds will be destined for investment.")]
    ThresholdForInvestment = ReservationTypeCode.ThresholdForInvestment, // same ordinal as derivation source for type conversions
    
}
