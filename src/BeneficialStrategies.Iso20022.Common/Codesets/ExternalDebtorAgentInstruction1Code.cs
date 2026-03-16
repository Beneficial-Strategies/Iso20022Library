// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hokV-csaEemxFbEZK-FMzw")]
[Description(
    @"Specifies further instructions concerning the processing of a payment instruction, as provided to the creditor agent."
)]
[DerivedFrom(typeof(ExternalDebtorAgentInstructionCode))]
public enum ExternalDebtorAgentInstruction1Code
{
    /// <summary>
    /// (Ultimate) creditor must be paid by cheque.
    /// Encoded/decoded by serializers as &quot;CHQB&quot;.
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("")]
    [Description(@"(Ultimate) creditor must be paid by cheque.")]
    PayCreditorByCheque = ExternalDebtorAgentInstructionCode.PayCreditorByCheque, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("")]
    [Description(
        @"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification."
    )]
    HoldCashForCreditor = ExternalDebtorAgentInstructionCode.HoldCashForCreditor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone.
    /// Encoded/decoded by serializers as &quot;PHOB&quot;.
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone.")]
    PhoneBeneficiary = ExternalDebtorAgentInstructionCode.PhoneBeneficiary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that a payer token is requested/used.
    /// Encoded/decoded by serializers as &quot;PRTK&quot;.
    /// </summary>
    [EnumMember(Value = "PRTK")]
    [IsoId("")]
    [Description(@"Indicates that a payer token is requested/used.")]
    PayerTokenRequested = ExternalDebtorAgentInstructionCode.PayerTokenRequested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as &quot;TELB&quot;.
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("")]
    [Description(
        @"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication."
    )]
    Telecom = ExternalDebtorAgentInstructionCode.Telecom, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Token information.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("")]
    [Description(@"Token information.")]
    Token = ExternalDebtorAgentInstructionCode.Token, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional validation information to be used in conjunction with the token.
    /// Encoded/decoded by serializers as &quot;VLTK&quot;.
    /// </summary>
    [EnumMember(Value = "VLTK")]
    [IsoId("")]
    [Description(@"Additional validation information to be used in conjunction with the token.")]
    TokenValidation = ExternalDebtorAgentInstructionCode.TokenValidation, // same ordinal as derivation source for type conversions
}
