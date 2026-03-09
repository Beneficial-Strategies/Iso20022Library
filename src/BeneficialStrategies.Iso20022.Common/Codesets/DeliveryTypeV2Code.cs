// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the delivery or custody arrangement for the underlying securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ltUEcNomEeCWg-hsBVGrDA_-989246574")]
[Description(@"Describes the delivery or custody arrangement for the underlying securities.")]
[Derivations(typeof(DeliveryType2Code))]
public enum DeliveryTypeV2Code
{
    /// <summary>
    /// Indicates that the delivery is against payment.
    /// Encoded/decoded by serializers as &quot;APMT&quot;.
    /// </summary>
    [EnumMember(Value = "APMT")]
    [IsoId("_ltUEcdomEeCWg-hsBVGrDA_-1103085640")]
    [Description(@"Indicates that the delivery is against payment.")]
    AgainstPayment,
    
    /// <summary>
    /// Indicates the delivery is free of payment.
    /// Encoded/decoded by serializers as &quot;FREE&quot;.
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("_ltUEctomEeCWg-hsBVGrDA_-1808200255")]
    [Description(@"Indicates the delivery is free of payment.")]
    Free,
    
    /// <summary>
    /// Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo.
    /// Encoded/decoded by serializers as &quot;TRIP&quot;.
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("_ltUEc9omEeCWg-hsBVGrDA_1311576016")]
    [Description(@"Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo.")]
    Triparty,
    
    /// <summary>
    /// Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender. Rather, it is placed in an internal account (&quot;held in custody&quot;) by the borrower, for the lender, throughout the duration of the trade.
    /// Encoded/decoded by serializers as &quot;HOIC&quot;.
    /// </summary>
    [EnumMember(Value = "HOIC")]
    [IsoId("_ltd1cNomEeCWg-hsBVGrDA_-1338123845")]
    [Description(@"Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender. Rather, it is placed in an internal account (""held in custody"") by the borrower, for the lender, throughout the duration of the trade.")]
    HoldInCustody,
    
}
