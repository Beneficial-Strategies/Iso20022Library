// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mn2q4MP9Eemsic1bQcEtLA")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent.")]
[Derivations(typeof(ExternalCreditorAgentInstruction1Code))]
public enum ExternalCreditorAgentInstructionCode
{
    /// <summary>
    /// (Ultimate) creditor must be paid by cheque.
    /// Encoded/decoded by serializers as &quot;CHQB&quot;.
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_mn2q4cP9Eemsic1bQcEtLA")]
    [Description(@"(Ultimate) creditor must be paid by cheque.")]
    PayCreditorByCheque,
    
    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_mn3R8cP9Eemsic1bQcEtLA")]
    [Description(@"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.")]
    HoldCashForCreditor,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone.
    /// Encoded/decoded by serializers as &quot;PHOB&quot;.
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_mn3R98P9Eemsic1bQcEtLA")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone.")]
    PhoneBeneficiary,
    
    /// <summary>
    /// Indicates that a payer token is requested/used.
    /// Encoded/decoded by serializers as &quot;PRTK&quot;.
    /// </summary>
    [EnumMember(Value = "PRTK")]
    [IsoId("_EGLpwMQBEemsic1bQcEtLA")]
    [Description(@"Indicates that a payer token is requested/used.")]
    PayerTokenRequested,
    
    /// <summary>
    /// Further information regarding the intended recipient. 
    /// Encoded/decoded by serializers as &quot;RECI&quot;.
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_uwN_A_RYEeuLhpyIdtJzwg")]
    [Description(@"Further information regarding the intended recipient. ")]
    ReceiverCustomerInformation,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as &quot;TELB&quot;.
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_mn3R9sP9Eemsic1bQcEtLA")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.")]
    Telecom,
    
    /// <summary>
    /// Token found with counterparty mismatch. 
    /// Encoded/decoded by serializers as &quot;TKCM&quot;.
    /// </summary>
    [EnumMember(Value = "TKCM")]
    [IsoId("_uwN_CfRYEeuLhpyIdtJzwg")]
    [Description(@"Token found with counterparty mismatch. ")]
    TokenCounterpartyMismatch,
    
    /// <summary>
    /// Single Use Token already used. 
    /// Encoded/decoded by serializers as &quot;TKSG&quot;.
    /// </summary>
    [EnumMember(Value = "TKSG")]
    [IsoId("_uwXwAPRYEeuLhpyIdtJzwg")]
    [Description(@"Single Use Token already used. ")]
    TokenSingleUse,
    
    /// <summary>
    /// Token found with suspended status.
    /// Encoded/decoded by serializers as &quot;TKSP&quot;.
    /// </summary>
    [EnumMember(Value = "TKSP")]
    [IsoId("_uwXwA_RYEeuLhpyIdtJzwg")]
    [Description(@"Token found with suspended status.")]
    TokenSuspended,
    
    /// <summary>
    /// Token found with value limit rule violation. 
    /// Encoded/decoded by serializers as &quot;TKVE&quot;.
    /// </summary>
    [EnumMember(Value = "TKVE")]
    [IsoId("_uwXwBvRYEeuLhpyIdtJzwg")]
    [Description(@"Token found with value limit rule violation. ")]
    TokenValueLimitExceeded,
    
    /// <summary>
    /// Token expired. 
    /// Encoded/decoded by serializers as &quot;TKXP&quot;.
    /// </summary>
    [EnumMember(Value = "TKXP")]
    [IsoId("_uwXwCfRYEeuLhpyIdtJzwg")]
    [Description(@"Token expired. ")]
    TokenExpired,
    
    /// <summary>
    /// Token information.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_Dz9RUMQBEemsic1bQcEtLA")]
    [Description(@"Token information.")]
    Token,
    
    /// <summary>
    /// Additional validation information to be used in conjunction with the token.
    /// Encoded/decoded by serializers as &quot;VLTK&quot;.
    /// </summary>
    [EnumMember(Value = "VLTK")]
    [IsoId("_D8MAQMQBEemsic1bQcEtLA")]
    [Description(@"Additional validation information to be used in conjunction with the token.")]
    TokenValidation,
    
}
