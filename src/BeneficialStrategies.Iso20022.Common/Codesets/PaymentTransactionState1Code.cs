// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the different states which a payment transaction can be in.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Wlue0KHnEeagRbKvRt3LnA")]
[Description(@"Contains the different states which a payment transaction can be in.")]
[DerivedFrom(typeof(PaymentTransactionStateCode))]
public enum PaymentTransactionState1Code
{
    /// <summary>
    /// Transaction is credited.
    /// Encoded/decoded by serializers as &quot;CRED&quot;.
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_YEuMYaHnEeagRbKvRt3LnA")]
    [Description(@"Transaction is credited.")]
    Credited = PaymentTransactionStateCode.Credited, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial institution to financial institution customer credit transfer is received at the creditor agent or the financial institution credit transfer with cover is received at the creditor.
    /// Encoded/decoded by serializers as &quot;RCCC&quot;.
    /// </summary>
    [EnumMember(Value = "RCCC")]
    [IsoId("_YZBBYqHnEeagRbKvRt3LnA")]
    [Description(@"Financial institution to financial institution customer credit transfer is received at the creditor agent or the financial institution credit transfer with cover is received at the creditor.")]
    ReceivedAtCreditorAgentOrCreditor = PaymentTransactionStateCode.ReceivedAtCreditorAgentOrCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is received by my institution.
    /// Encoded/decoded by serializers as &quot;RCMY&quot;.
    /// </summary>
    [EnumMember(Value = "RCMY")]
    [IsoId("_YsRUkqHnEeagRbKvRt3LnA")]
    [Description(@"Transaction is received by my institution.")]
    ReceivedByMyInstitution = PaymentTransactionStateCode.ReceivedByMyInstitution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is sent by my institution.
    /// Encoded/decoded by serializers as &quot;STMY&quot;.
    /// </summary>
    [EnumMember(Value = "STMY")]
    [IsoId("_Yw8ZMaHnEeagRbKvRt3LnA")]
    [Description(@"Transaction is sent by my institution.")]
    SentByMyInstitution = PaymentTransactionStateCode.SentByMyInstitution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial institution to financial institution customer credit transfer is sent by the debtor agent or the financial institution credit transfer with cover is sent by the debtor.
    /// Encoded/decoded by serializers as &quot;STDD&quot;.
    /// </summary>
    [EnumMember(Value = "STDD")]
    [IsoId("_ZKEq4aHnEeagRbKvRt3LnA")]
    [Description(@"Financial institution to financial institution customer credit transfer is sent by the debtor agent or the financial institution credit transfer with cover is sent by the debtor.")]
    SentByDebtorAgentOrDebtor = PaymentTransactionStateCode.SentByDebtorAgentOrDebtor, // same ordinal as derivation source for type conversions
    
}
