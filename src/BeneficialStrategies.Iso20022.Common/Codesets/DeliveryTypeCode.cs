// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the delivery or custody arrangement for the underlying securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_azv0c9p-Ed-ak6NoX_4Aeg_-799855242")]
[Description(@"Describes the delivery or custody arrangement for the underlying securities.")]
[Derivations(typeof(DeliveryType1Code))]
public enum DeliveryTypeCode
{
    /// <summary>
    /// Indicates that the delivery is against payment.
    /// Encoded/decoded by serializers as &quot;AGPM&quot;.
    /// </summary>
    [EnumMember(Value = "AGPM")]
    [IsoId("_azv0dNp-Ed-ak6NoX_4Aeg_-422136688")]
    [Description(@"Indicates that the delivery is against payment.")]
    AgainstPayment,
    
    /// <summary>
    /// Indicates the delivery is free of payment.
    /// Encoded/decoded by serializers as &quot;FREE&quot;.
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_azv0ddp-Ed-ak6NoX_4Aeg_-170014204")]
    [Description(@"Indicates the delivery is free of payment.")]
    Free,
    
    /// <summary>
    /// Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo.
    /// Encoded/decoded by serializers as &quot;TRIP&quot;.
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("_azv0dtp-Ed-ak6NoX_4Aeg_-140462836")]
    [Description(@"Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo.")]
    Triparty,
    
    /// <summary>
    /// Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender. Rather, it is placed in an internal account (&quot;held in custody&quot;) by the borrower, for the lender, throughout the duration of the trade.
    /// Encoded/decoded by serializers as &quot;HOIC&quot;.
    /// </summary>
    [EnumMember(Value = "HOIC")]
    [IsoId("_azv0d9p-Ed-ak6NoX_4Aeg_-134919815")]
    [Description(@"Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender. Rather, it is placed in an internal account (""held in custody"") by the borrower, for the lender, throughout the duration of the trade.")]
    HoldInCustody,
    
}
