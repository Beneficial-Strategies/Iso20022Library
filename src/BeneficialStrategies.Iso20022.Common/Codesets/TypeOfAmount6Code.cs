// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type or class of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WQhuYHs3EeSTS7uHCe8FPQ")]
[Description(@"Type or class of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount6Code
{
    /// <summary>
    /// Commission that the issuer will charge to the cardholder, which should be shown and accepted by the cardholder before the money is disbursed.
    /// Encoded/decoded by serializers as &quot;ATMF&quot;.
    /// </summary>
    [EnumMember(Value = "ATMF")]
    [IsoId("_ch5l0Xs3EeSTS7uHCe8FPQ")]
    [Description(
        @"Commission that the issuer will charge to the cardholder, which should be shown and accepted by the cardholder before the money is disbursed."
    )]
    ATMCommissionFee = TypeOfAmountCode.ATMCommissionFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction amount that has been authorised.
    /// Encoded/decoded by serializers as &quot;AMTH&quot;.
    /// </summary>
    [EnumMember(Value = "AMTH")]
    [IsoId("_crbVQ3s3EeSTS7uHCe8FPQ")]
    [Description(@"Transaction amount that has been authorised.")]
    AuthorisedAmount = TypeOfAmountCode.AuthorisedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Remaining allowed amount for this type of transaction with this card, after the transaction, until the end of the card limit period.
    /// Encoded/decoded by serializers as &quot;CRDB&quot;.
    /// </summary>
    [EnumMember(Value = "CRDB")]
    [IsoId("_dpya83s3EeSTS7uHCe8FPQ")]
    [Description(
        @"Remaining allowed amount for this type of transaction with this card, after the transaction, until the end of the card limit period."
    )]
    CardRemainingBalance = TypeOfAmountCode.CardRemainingBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Discount, rebate or voucher, related to loyalty programs. This amount is counted as a negative amount.
    /// Encoded/decoded by serializers as &quot;DCNT&quot;.
    /// </summary>
    [EnumMember(Value = "DCNT")]
    [IsoId("_euupw3s3EeSTS7uHCe8FPQ")]
    [Description(
        @"Discount, rebate or voucher, related to loyalty programs. This amount is counted as a negative amount."
    )]
    Discount = TypeOfAmountCode.Discount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fees.
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_e8LP43s3EeSTS7uHCe8FPQ")]
    [Description(@"Fees.")]
    Fees = TypeOfAmountCode.Fees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum amount allowed for the transaction in the transaction amount currency if the transaction amount of the request was declined.
    /// Encoded/decoded by serializers as &quot;AMTX&quot;.
    /// </summary>
    [EnumMember(Value = "AMTX")]
    [IsoId("_fJJ783s3EeSTS7uHCe8FPQ")]
    [Description(
        @"Maximum amount allowed for the transaction in the transaction amount currency if the transaction amount of the request was declined."
    )]
    MaximumAllowedAmount = TypeOfAmountCode.MaximumAllowedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Minimum amount allowed in the TransactionAmount currency if the transaction amount of the request was declined.
    /// Encoded/decoded by serializers as &quot;AMTN&quot;.
    /// </summary>
    [EnumMember(Value = "AMTN")]
    [IsoId("_fP3n83s3EeSTS7uHCe8FPQ")]
    [Description(
        @"Minimum amount allowed in the TransactionAmount currency if the transaction amount of the request was declined."
    )]
    MinimumAllowedAmount = TypeOfAmountCode.MinimumAllowedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction amount that has been requested to be authorised.
    /// Encoded/decoded by serializers as &quot;AMTQ&quot;.
    /// </summary>
    [EnumMember(Value = "AMTQ")]
    [IsoId("_greqU3s3EeSTS7uHCe8FPQ")]
    [Description(@"Transaction amount that has been requested to be authorised.")]
    RequestedAmount = TypeOfAmountCode.RequestedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Extra fee for a purchase or a withdrawal.
    /// Encoded/decoded by serializers as &quot;SRCH&quot;.
    /// </summary>
    [EnumMember(Value = "SRCH")]
    [IsoId("_g34Hk3s3EeSTS7uHCe8FPQ")]
    [Description(@"Extra fee for a purchase or a withdrawal.")]
    Surcharge = TypeOfAmountCode.Surcharge, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value added tax amount.
    /// Encoded/decoded by serializers as &quot;VATX&quot;.
    /// </summary>
    [EnumMember(Value = "VATX")]
    [IsoId("_hFQcQ3s3EeSTS7uHCe8FPQ")]
    [Description(@"Value added tax amount.")]
    ValueAddedTax = TypeOfAmountCode.ValueAddedTax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission from the card issuer.
    /// Encoded/decoded by serializers as &quot;COMI&quot;.
    /// </summary>
    [EnumMember(Value = "COMI")]
    [IsoId("_UJEOkYN6EeSNofOeou9G3A")]
    [Description(@"Commission from the card issuer.")]
    IssuerCommission = TypeOfAmountCode.IssuerCommission, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fees amount from the card issuer.
    /// Encoded/decoded by serializers as &quot;FEEI&quot;.
    /// </summary>
    [EnumMember(Value = "FEEI")]
    [IsoId("_UUHA8YN6EeSNofOeou9G3A")]
    [Description(@"Fees amount from the card issuer.")]
    IssuerFees = TypeOfAmountCode.IssuerFees, // same ordinal as derivation source for type conversions
}
