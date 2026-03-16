// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the delivery or custody arrangement for the underlying foreign exchange.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DeliveryType4Code")]
[Description(@"Describes the delivery or custody arrangement for the underlying foreign exchange.")]
[DerivedFrom(typeof(DeliveryTypeCode))]
public enum DeliveryType4Code
{
    /// <summary>
    /// Indicates that the delivery is against payment.
    /// Encoded/decoded by serializers as &quot;AGPM&quot;.
    /// </summary>
    [EnumMember(Value = "AGPM")]
    [IsoId("_DeliveryType4Code_AgainstPayment")]
    [Description(@"Indicates that the delivery is against payment.")]
    AgainstPayment = DeliveryTypeCode.AgainstPayment,

    /// <summary>
    /// Indicates the delivery is free of payment.
    /// Encoded/decoded by serializers as &quot;FREE&quot;.
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_DeliveryType4Code_Free")]
    [Description(@"Indicates the delivery is free of payment.")]
    Free = DeliveryTypeCode.Free,

    /// <summary>
    /// Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender.
    /// Encoded/decoded by serializers as &quot;HOIC&quot;.
    /// </summary>
    [EnumMember(Value = "HOIC")]
    [IsoId("_DeliveryType4Code_HoldInCustody")]
    [Description(
        @"Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender."
    )]
    HoldInCustody = DeliveryTypeCode.HoldInCustody,

    /// <summary>
    /// Indicates that the delivery is a Payment versus Payment.
    /// Encoded/decoded by serializers as &quot;PVSP&quot;.
    /// </summary>
    [EnumMember(Value = "PVSP")]
    [IsoId("_DeliveryType4Code_PaymentVsPayment")]
    [Description(@"Indicates that the delivery is a Payment versus Payment.")]
    PaymentVsPayment,

    /// <summary>
    /// Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo.
    /// Encoded/decoded by serializers as &quot;TRIP&quot;.
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("_DeliveryType4Code_Triparty")]
    [Description(
        @"Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo."
    )]
    Triparty = DeliveryTypeCode.Triparty,
}
