// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of additional service
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vnuScBZZEeiwvuY-sPnsNg")]
[Description(@"Type of additional service")]
[Derivations(typeof(AdditionalServiceType1Code),typeof(AdditionalServiceType2Code))]
public enum AdditionalServiceTypeCode
{
    /// <summary>
    /// Card activation
    /// Encoded/decoded by serializers as &quot;CACT&quot;.
    /// </summary>
    [EnumMember(Value = "CACT")]
    [IsoId("_3fUg0BZZEeiwvuY-sPnsNg")]
    [Description(@"Card activation")]
    CardActivation,
    
    /// <summary>
    /// Purchase of goods or services with cashback
    /// Encoded/decoded by serializers as &quot;CSHB&quot;.
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_3fUg0RZZEeiwvuY-sPnsNg")]
    [Description(@"Purchase of goods or services with cashback")]
    CashBack,
    
    /// <summary>
    /// Amount and notes values are chosen by the customer
    /// Encoded/decoded by serializers as &quot;CSWD&quot;.
    /// </summary>
    [EnumMember(Value = "CSWD")]
    [IsoId("_3fUg0xZZEeiwvuY-sPnsNg")]
    [Description(@"Amount and notes values are chosen by the customer")]
    ChosenWithdrawal,
    
    /// <summary>
    /// Dynamic Currency Conversion (DCC)
    /// Encoded/decoded by serializers as &quot;DCCV&quot;.
    /// </summary>
    [EnumMember(Value = "DCCV")]
    [IsoId("_3fUg1BZZEeiwvuY-sPnsNg")]
    [Description(@"Dynamic Currency Conversion (DCC)")]
    DCC,
    
    /// <summary>
    /// Instant payment from a cardholder&apos;s account to an acceptor&apos;s account
    /// Encoded/decoded by serializers as &quot;INTP&quot;.
    /// </summary>
    [EnumMember(Value = "INTP")]
    [IsoId("_3fUg2BZZEeiwvuY-sPnsNg")]
    [Description(@"Instant payment from a cardholder's account to an acceptor's account")]
    InstantPayment,
    
    /// <summary>
    /// Instant transfer of funds from a payer&apos;s account to a payee&apos;s account.
    /// Encoded/decoded by serializers as &quot;INTT&quot;.
    /// </summary>
    [EnumMember(Value = "INTT")]
    [IsoId("_3fUg2RZZEeiwvuY-sPnsNg")]
    [Description(@"Instant transfer of funds from a payer's account to a payee's account.")]
    InstantTransfer,
    
    /// <summary>
    /// Loyalty services
    /// Encoded/decoded by serializers as &quot;LOYT&quot;.
    /// </summary>
    [EnumMember(Value = "LOYT")]
    [IsoId("_3fUg2xZZEeiwvuY-sPnsNg")]
    [Description(@"Loyalty services")]
    Loyalty,
    
    /// <summary>
    /// Other type of additional service at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_3fUg3hZZEeiwvuY-sPnsNg")]
    [Description(@"Other type of additional service at national level")]
    OtherNational,
    
    /// <summary>
    /// Other type of additional service at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_3fUg3xZZEeiwvuY-sPnsNg")]
    [Description(@"Other type of additional service at private level")]
    OtherPrivate,
    
    /// <summary>
    /// Withdrawal transaction was pre-authorised by another channel (amount could be absent).
    /// Encoded/decoded by serializers as &quot;PRST&quot;.
    /// </summary>
    [EnumMember(Value = "PRST")]
    [IsoId("_3fUg4RZZEeiwvuY-sPnsNg")]
    [Description(@"Withdrawal transaction was pre-authorised by another channel (amount could be absent).")]
    PreStagedTransaction,
    
    /// <summary>
    /// Return the account balance with the transaction.
    /// Encoded/decoded by serializers as &quot;BALC&quot;.
    /// </summary>
    [EnumMember(Value = "BALC")]
    [IsoId("_mxsHgJ1LEeublrfU-wN95w")]
    [Description(@"Return the account balance with the transaction.")]
    AccountBalance,
    
}
