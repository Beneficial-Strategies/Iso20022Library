// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the delivery or custody arrangement for the underlying securities.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__1ywktojEeC60axPepSq7g_-1223322819")]
[Description(@"Describes the delivery or custody arrangement for the underlying securities.")]
[DerivedFrom(typeof(DeliveryTypeV2Code))]
public enum DeliveryType2Code
{
    /// <summary>
    /// Indicates that the delivery is against payment.
    /// Encoded/decoded by serializers as &quot;APMT&quot;.
    /// </summary>
    [EnumMember(Value = "APMT")]
    [IsoId("__1ywk9ojEeC60axPepSq7g_-1012044378")]
    [Description(@"Indicates that the delivery is against payment.")]
    AgainstPayment = DeliveryTypeV2Code.AgainstPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates the delivery is free of payment.
    /// Encoded/decoded by serializers as &quot;FREE&quot;.
    /// </summary>
    [EnumMember(Value = "FREE")]
    [IsoId("__1ywlNojEeC60axPepSq7g_-5169852")]
    [Description(@"Indicates the delivery is free of payment.")]
    Free = DeliveryTypeV2Code.Free, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo.
    /// Encoded/decoded by serializers as &quot;TRIP&quot;.
    /// </summary>
    [EnumMember(Value = "TRIP")]
    [IsoId("__1ywldojEeC60axPepSq7g_-423703442")]
    [Description(
        @"Indicates that a custodian bank or international clearing organization acts as an intermediary between the two parties to the repo."
    )]
    Triparty = DeliveryTypeV2Code.Triparty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender. Rather, it is placed in an internal account (&quot;held in custody&quot;) by the borrower, for the lender, throughout the duration of the trade.
    /// Encoded/decoded by serializers as &quot;HOIC&quot;.
    /// </summary>
    [EnumMember(Value = "HOIC")]
    [IsoId("__18hkNojEeC60axPepSq7g_1043445321")]
    [Description(
        @"Indicates that the collateral pledged by the (cash) borrower is not actually delivered to the cash lender. Rather, it is placed in an internal account (""held in custody"") by the borrower, for the lender, throughout the duration of the trade."
    )]
    HoldInCustody = DeliveryTypeV2Code.HoldInCustody, // same ordinal as derivation source for type conversions
}
