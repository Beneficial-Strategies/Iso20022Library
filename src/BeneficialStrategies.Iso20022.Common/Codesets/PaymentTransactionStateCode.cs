// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Contains the different states which a payment transaction can be in.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fEf3YKHmEeagRbKvRt3LnA")]
[Description(@"Contains the different states which a payment transaction can be in.")]
[Derivations(typeof(PaymentTransactionState1Code))]
public enum PaymentTransactionStateCode
{
    /// <summary>
    /// Transaction is received by my institution.
    /// Encoded/decoded by serializers as &quot;RCMY&quot;.
    /// </summary>
    [EnumMember(Value = "RCMY")]
    [IsoId("_nmQdEKHmEeagRbKvRt3LnA")]
    [Description(@"Transaction is received by my institution.")]
    ReceivedByMyInstitution,
    
    /// <summary>
    /// Transaction is sent by my institution.
    /// Encoded/decoded by serializers as &quot;STMY&quot;.
    /// </summary>
    [EnumMember(Value = "STMY")]
    [IsoId("_v4WPEKHmEeagRbKvRt3LnA")]
    [Description(@"Transaction is sent by my institution.")]
    SentByMyInstitution,
    
    /// <summary>
    /// Financial institution to financial institution customer credit transfer is sent by the debtor agent or the financial institution credit transfer with cover is sent by the debtor.
    /// Encoded/decoded by serializers as &quot;STDD&quot;.
    /// </summary>
    [EnumMember(Value = "STDD")]
    [IsoId("_52ZMkKHmEeagRbKvRt3LnA")]
    [Description(@"Financial institution to financial institution customer credit transfer is sent by the debtor agent or the financial institution credit transfer with cover is sent by the debtor.")]
    SentByDebtorAgentOrDebtor,
    
    /// <summary>
    /// Financial institution to financial institution customer credit transfer is received at the creditor agent or the financial institution credit transfer with cover is received at the creditor.
    /// Encoded/decoded by serializers as &quot;RCCC&quot;.
    /// </summary>
    [EnumMember(Value = "RCCC")]
    [IsoId("_AmsbsKHnEeagRbKvRt3LnA")]
    [Description(@"Financial institution to financial institution customer credit transfer is received at the creditor agent or the financial institution credit transfer with cover is received at the creditor.")]
    ReceivedAtCreditorAgentOrCreditor,
    
    /// <summary>
    /// Transaction is credited.
    /// Encoded/decoded by serializers as &quot;CRED&quot;.
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_J8DokKHnEeagRbKvRt3LnA")]
    [Description(@"Transaction is credited.")]
    Credited,
    
}
