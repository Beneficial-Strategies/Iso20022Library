// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hokV-ssaEemxFbEZK-FMzw")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent.")]
[Derivations(typeof(ExternalDebtorAgentInstruction1Code))]
public enum ExternalDebtorAgentInstructionCode
{
    /// <summary>
    /// (Ultimate) creditor must be paid by cheque.
    /// Encoded/decoded by serializers as &quot;CHQB&quot;.
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_hokV_ssaEemxFbEZK-FMzw")]
    [Description(@"(Ultimate) creditor must be paid by cheque.")]
    PayCreditorByCheque,
    
    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_hokV-8saEemxFbEZK-FMzw")]
    [Description(@"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.")]
    HoldCashForCreditor,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone.
    /// Encoded/decoded by serializers as &quot;PHOB&quot;.
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_hokWAcsaEemxFbEZK-FMzw")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone.")]
    PhoneBeneficiary,
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as &quot;TELB&quot;.
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_hokWAMsaEemxFbEZK-FMzw")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.")]
    Telecom,
    
    /// <summary>
    /// Token information.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_hokV_MsaEemxFbEZK-FMzw")]
    [Description(@"Token information.")]
    Token,
    
    /// <summary>
    /// Additional validation information to be used in conjunction with the token.
    /// Encoded/decoded by serializers as &quot;VLTK&quot;.
    /// </summary>
    [EnumMember(Value = "VLTK")]
    [IsoId("_hokV_8saEemxFbEZK-FMzw")]
    [Description(@"Additional validation information to be used in conjunction with the token.")]
    TokenValidation,
    
    /// <summary>
    /// Indicates that a payer token is requested/used.
    /// Encoded/decoded by serializers as &quot;PRTK&quot;.
    /// </summary>
    [EnumMember(Value = "PRTK")]
    [IsoId("_hokV_csaEemxFbEZK-FMzw")]
    [Description(@"Indicates that a payer token is requested/used.")]
    PayerTokenRequested,
    
}
