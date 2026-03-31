// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gVopcMP-Eemsic1bQcEtLA")]
[Description(
    @"Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent."
)]
[DerivedFrom(typeof(ExternalCreditorAgentInstructionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalCreditorAgentInstruction1Code>))]
#endif
public enum ExternalCreditorAgentInstruction1Code
{
    /// <summary>
    /// (Ultimate) creditor must be paid by cheque.
    /// Encoded/decoded by serializers as &quot;CHQB&quot;.
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_uwEOAvRYEeuLhpyIdtJzwg")]
    [Description(@"(Ultimate) creditor must be paid by cheque.")]
    PayCreditorByCheque = ExternalCreditorAgentInstructionCode.PayCreditorByCheque, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_uwEOBfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification."
    )]
    HoldCashForCreditor = ExternalCreditorAgentInstructionCode.HoldCashForCreditor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone.
    /// Encoded/decoded by serializers as &quot;PHOB&quot;.
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_uwEOCPRYEeuLhpyIdtJzwg")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone.")]
    PhoneBeneficiary = ExternalCreditorAgentInstructionCode.PhoneBeneficiary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that a payer token is requested/used.
    /// Encoded/decoded by serializers as &quot;PRTK&quot;.
    /// </summary>
    [EnumMember(Value = "PRTK")]
    [IsoId("_uwN_AvRYEeuLhpyIdtJzwg")]
    [Description(@"Indicates that a payer token is requested/used.")]
    PayerTokenRequested = ExternalCreditorAgentInstructionCode.PayerTokenRequested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Further information regarding the intended recipient.
    /// Encoded/decoded by serializers as &quot;RECI&quot;.
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_uwN_BfRYEeuLhpyIdtJzwg")]
    [Description(@"Further information regarding the intended recipient. ")]
    ReceiverCustomerInformation = ExternalCreditorAgentInstructionCode.ReceiverCustomerInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as &quot;TELB&quot;.
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_uwN_CPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication."
    )]
    Telecom = ExternalCreditorAgentInstructionCode.Telecom, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Token found with counterparty mismatch.
    /// Encoded/decoded by serializers as &quot;TKCM&quot;.
    /// </summary>
    [EnumMember(Value = "TKCM")]
    [IsoId("_uwN_C_RYEeuLhpyIdtJzwg")]
    [Description(@"Token found with counterparty mismatch. ")]
    TokenCounterpartyMismatch = ExternalCreditorAgentInstructionCode.TokenCounterpartyMismatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Single Use Token already used.
    /// Encoded/decoded by serializers as &quot;TKSG&quot;.
    /// </summary>
    [EnumMember(Value = "TKSG")]
    [IsoId("_uwXwAvRYEeuLhpyIdtJzwg")]
    [Description(@"Single Use Token already used. ")]
    TokenSingleUse = ExternalCreditorAgentInstructionCode.TokenSingleUse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Token found with suspended status.
    /// Encoded/decoded by serializers as &quot;TKSP&quot;.
    /// </summary>
    [EnumMember(Value = "TKSP")]
    [IsoId("_uwXwBfRYEeuLhpyIdtJzwg")]
    [Description(@"Token found with suspended status.")]
    TokenSuspended = ExternalCreditorAgentInstructionCode.TokenSuspended, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Token found with value limit rule violation.
    /// Encoded/decoded by serializers as &quot;TKVE&quot;.
    /// </summary>
    [EnumMember(Value = "TKVE")]
    [IsoId("_uwXwCPRYEeuLhpyIdtJzwg")]
    [Description(@"Token found with value limit rule violation. ")]
    TokenValueLimitExceeded = ExternalCreditorAgentInstructionCode.TokenValueLimitExceeded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Token expired.
    /// Encoded/decoded by serializers as &quot;TKXP&quot;.
    /// </summary>
    [EnumMember(Value = "TKXP")]
    [IsoId("_uwXwC_RYEeuLhpyIdtJzwg")]
    [Description(@"Token expired. ")]
    TokenExpired = ExternalCreditorAgentInstructionCode.TokenExpired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Token information.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_uwg58vRYEeuLhpyIdtJzwg")]
    [Description(@"Token information.")]
    Token = ExternalCreditorAgentInstructionCode.Token, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional validation information to be used in conjunction with the token.
    /// Encoded/decoded by serializers as &quot;VLTK&quot;.
    /// </summary>
    [EnumMember(Value = "VLTK")]
    [IsoId("_uwg59fRYEeuLhpyIdtJzwg")]
    [Description(@"Additional validation information to be used in conjunction with the token.")]
    TokenValidation = ExternalCreditorAgentInstructionCode.TokenValidation, // same ordinal as derivation source for type conversions
}
