// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the delivery or custody arrangement for the underlying securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_azmDdNp-Ed-ak6NoX_4Aeg_-797084822")]
[Description(@"Describes the delivery or custody arrangement for the underlying securities.")]
[DerivedFrom(typeof(DeliveryTypeCode))]
public enum DeliveryType1Code
{
    /// <summary>
    /// Indicates that the delivery is against payment.
    /// Encoded/decoded by serializers as &quot;AGPM&quot;.
    /// </summary>
    [EnumMember(Value = "AGPM")]
    [IsoId("_azmDddp-Ed-ak6NoX_4Aeg_202824033")]
    [Description(@"Indicates that the delivery is against payment.")]
    AgainstPayment = DeliveryTypeCode.AgainstPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates the delivery is free of payment.
    /// Encoded/decoded by serializers as &quot;FREE&quot;.
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_azv0cNp-Ed-ak6NoX_4Aeg_202824093")]
    [Description(@"Indicates the delivery is free of payment.")]
    Free = DeliveryTypeCode.Free, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo.
    /// Encoded/decoded by serializers as &quot;TRIP&quot;.
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("_azv0cdp-Ed-ak6NoX_4Aeg_203744107")]
    [Description(@"Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo.")]
    Triparty = DeliveryTypeCode.Triparty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender. Rather, it is placed in an internal account (&quot;held in custody&quot;) by the borrower, for the lender, throughout the duration of the trade.
    /// Encoded/decoded by serializers as &quot;HOIC&quot;.
    /// </summary>
    [EnumMember(Value = "HOIC")]
    [IsoId("_azv0ctp-Ed-ak6NoX_4Aeg_203744124")]
    [Description(@"Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender. Rather, it is placed in an internal account (""held in custody"") by the borrower, for the lender, throughout the duration of the trade.")]
    HoldInCustody = DeliveryTypeCode.HoldInCustody, // same ordinal as derivation source for type conversions
    
}
