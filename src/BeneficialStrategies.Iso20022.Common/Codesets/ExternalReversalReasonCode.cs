// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reversal reason, as published in an external reversal reason code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UBzAwLf9Eee9KIDjEHK7ZQ")]
[Description(@"Specifies the reversal reason, as published in an external reversal reason code list.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalReversalReason1Code))]
public enum ExternalReversalReasonCode
{
    /// <summary>
    /// Wrong IBAN in  SCT
    /// Encoded/decoded by serializers as &quot;AC03&quot;.
    /// </summary>
    [EnumMember(Value = "AC03")]
    [IsoId("_t8gqIPRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong IBAN in  SCT")]
    InvalidCreditorAccountNumber,
    
    /// <summary>
    /// Account number specified has been closed on the Receiver&apos;s books
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_t8gqI_RYEeuLhpyIdtJzwg")]
    [Description(@"Account number specified has been closed on the Receiver's books")]
    ClosedAccountNumber,
    
    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver
    /// Encoded/decoded by serializers as &quot;AG02&quot;.
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_t8gqJvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver")]
    InvalidBankOperationCode,
    
    /// <summary>
    /// Duplication
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_t8gqKfRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication")]
    Duplication,
    
    /// <summary>
    /// Wrong amount in SCT
    /// Encoded/decoded by serializers as &quot;AM09&quot;.
    /// </summary>
    [EnumMember(Value = "AM09")]
    [IsoId("_t8qbIPRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong amount in SCT")]
    WrongAmount,
    
    /// <summary>
    /// No Mandate
    /// Encoded/decoded by serializers as &quot;MD01&quot;.
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_t8qbI_RYEeuLhpyIdtJzwg")]
    [Description(@"No Mandate")]
    NoMandate,
    
    /// <summary>
    /// Creditor or creditor&apos;s agent should not have collected the direct debit
    /// Encoded/decoded by serializers as &quot;MD05&quot;.
    /// </summary>
    [EnumMember(Value = "MD05")]
    [IsoId("_t8qbJvRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor or creditor's agent should not have collected the direct debit")]
    CollectionNotDue,
    
    /// <summary>
    /// Reason has not been specified by end customer
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_t8qbKfRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by end customer")]
    NotSpecifiedReasonCustomerGenerated,
    
    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_t8qbLPRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated,
    
    /// <summary>
    /// Wrong BIC in SCT
    /// Encoded/decoded by serializers as &quot;RC07&quot;.
    /// </summary>
    [EnumMember(Value = "RC07")]
    [IsoId("_t8zlEPRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong BIC in SCT")]
    InvalidCreditorBICIdentifier,
    
    /// <summary>
    /// Associated message was received after agreed processing cut-off time.
    /// Encoded/decoded by serializers as &quot;TM01&quot;.
    /// </summary>
    [EnumMember(Value = "TM01")]
    [IsoId("_t8zlE_RYEeuLhpyIdtJzwg")]
    [Description(@"Associated message was received after agreed processing cut-off time.")]
    CutOffTime,
    
}
