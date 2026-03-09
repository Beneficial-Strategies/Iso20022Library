// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of additional service.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6Pj1cZ1LEeublrfU-wN95w")]
[Description(@"Type of additional service.")]
[DerivedFrom(typeof(AdditionalServiceTypeCode))]
public enum AdditionalServiceType2Code
{
    /// <summary>
    /// Card activation
    /// Encoded/decoded by serializers as &quot;CACT&quot;.
    /// </summary>
    [EnumMember(Value = "CACT")]
    [IsoId("_6UOTAZ1LEeublrfU-wN95w")]
    [Description(@"Card activation")]
    CardActivation = AdditionalServiceTypeCode.CardActivation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Purchase of goods or services with cashback
    /// Encoded/decoded by serializers as &quot;CSHB&quot;.
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_6UOTA51LEeublrfU-wN95w")]
    [Description(@"Purchase of goods or services with cashback")]
    CashBack = AdditionalServiceTypeCode.CashBack, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dynamic Currency Conversion (DCC)
    /// Encoded/decoded by serializers as &quot;DCCV&quot;.
    /// </summary>
    [EnumMember(Value = "DCCV")]
    [IsoId("_6UOTBZ1LEeublrfU-wN95w")]
    [Description(@"Dynamic Currency Conversion (DCC)")]
    DCC = AdditionalServiceTypeCode.DCC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instant payment from a cardholder&apos;s account to an acceptor&apos;s account
    /// Encoded/decoded by serializers as &quot;INTP&quot;.
    /// </summary>
    [EnumMember(Value = "INTP")]
    [IsoId("_6UOTB51LEeublrfU-wN95w")]
    [Description(@"Instant payment from a cardholder's account to an acceptor's account")]
    InstantPayment = AdditionalServiceTypeCode.InstantPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instant transfer of funds from a payer&apos;s account to a payee&apos;s account.
    /// Encoded/decoded by serializers as &quot;INTT&quot;.
    /// </summary>
    [EnumMember(Value = "INTT")]
    [IsoId("_6UOTCZ1LEeublrfU-wN95w")]
    [Description(@"Instant transfer of funds from a payer's account to a payee's account.")]
    InstantTransfer = AdditionalServiceTypeCode.InstantTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Loyalty services
    /// Encoded/decoded by serializers as &quot;LOYT&quot;.
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_6UOTC51LEeublrfU-wN95w")]
    [Description(@"Loyalty services")]
    Loyalty = AdditionalServiceTypeCode.Loyalty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of additional service at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_6UOTDZ1LEeublrfU-wN95w")]
    [Description(@"Other type of additional service at national level")]
    OtherNational = AdditionalServiceTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of additional service at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_6UOTD51LEeublrfU-wN95w")]
    [Description(@"Other type of additional service at private level")]
    OtherPrivate = AdditionalServiceTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel (amount could be absent).
    /// Encoded/decoded by serializers as &quot;PRST&quot;.
    /// </summary>
    [EnumMember(Value = "PRST")]
    [IsoId("_6UOTEZ1LEeublrfU-wN95w")]
    [Description(@"Withdrawal transaction was pre-authorised by another channel (amount could be absent).")]
    PreStagedTransaction = AdditionalServiceTypeCode.PreStagedTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Return the account balance with the transaction.
    /// Encoded/decoded by serializers as &quot;BALC&quot;.
    /// </summary>
    [EnumMember(Value = "BALC")]
    [IsoId("_AzZV4Z1MEeublrfU-wN95w")]
    [Description(@"Return the account balance with the transaction.")]
    AccountBalance = AdditionalServiceTypeCode.AccountBalance, // same ordinal as derivation source for type conversions
    
}
