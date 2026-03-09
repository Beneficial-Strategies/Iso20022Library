// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of reservation, as published in an external reservation type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BGpotRUOEeusI4XK3oQSyg")]
[Description(@"Specifies the type of reservation, as published in an external reservation type code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalReservationTypeCode))]
public enum ExternalReservationType1Code
{
    /// <summary>
    /// Amount blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.
    /// Encoded/decoded by serializers as &quot;BLKD&quot;.
    /// </summary>
    [EnumMember(Value = "BLKD")]
    [IsoId("_ut1ZYvRYEeuLhpyIdtJzwg")]
    [Description(@"Amount blocked or frozen due to external circumstances such as a court order, death of beneficiary or account owner, or bankruptcy.")]
    Blocked = ExternalReservationTypeCode.Blocked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively or executing cash withdrawals.
    /// Encoded/decoded by serializers as &quot;CARE&quot;.
    /// </summary>
    [EnumMember(Value = "CARE")]
    [IsoId("_ut1ZZfRYEeuLhpyIdtJzwg")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively or executing cash withdrawals.")]
    CashReservation = ExternalReservationTypeCode.CashReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing highly urgent payments.
    /// Encoded/decoded by serializers as &quot;HPAR&quot;.
    /// </summary>
    [EnumMember(Value = "HPAR")]
    [IsoId("_ut1ZaPRYEeuLhpyIdtJzwg")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing highly urgent payments.")]
    HighlyUrgentPaymentReservation = ExternalReservationTypeCode.HighlyUrgentPaymentReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System.
    /// Encoded/decoded by serializers as &quot;NSSR&quot;.
    /// </summary>
    [EnumMember(Value = "NSSR")]
    [IsoId("_ut_KYvRYEeuLhpyIdtJzwg")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for the settlement of the multilateral cash balance stemming from the Net Security Settlement System.")]
    NetSSSReservation = ExternalReservationTypeCode.NetSSSReservation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount above which funds will be destined for investment.
    /// Encoded/decoded by serializers as &quot;THRE&quot;.
    /// </summary>
    [EnumMember(Value = "THRE")]
    [IsoId("_uuIUUvRYEeuLhpyIdtJzwg")]
    [Description(@"Amount above which funds will be destined for investment.")]
    ThresholdForInvestment = ExternalReservationTypeCode.ThresholdForInvestment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments.
    /// Encoded/decoded by serializers as &quot;UPAR&quot;.
    /// </summary>
    [EnumMember(Value = "UPAR")]
    [IsoId("_uuIUVfRYEeuLhpyIdtJzwg")]
    [Description(@"Amount set aside by a participant to reserve liquidity from its own account, exclusively for executing critical payments called urgent payments.")]
    UrgentPaymentReservation = ExternalReservationTypeCode.UrgentPaymentReservation, // same ordinal as derivation source for type conversions
    
}
