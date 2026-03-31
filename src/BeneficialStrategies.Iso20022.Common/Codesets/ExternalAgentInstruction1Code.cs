// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions for the agent concerning the processing of an instruction.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rLbaINA4EeeCAfThR1cp_Q")]
[Description(
    @"Specifies further instructions for the agent concerning the processing of an instruction.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalAgentInstructionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalAgentInstruction1Code>))]
#endif
public enum ExternalAgentInstruction1Code
{
    /// <summary>
    /// (Ultimate) creditor must be paid by cheque.
    /// Encoded/decoded by serializers as &quot;CHQB&quot;.
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_uaUAe_RYEeuLhpyIdtJzwg")]
    [Description(@"(Ultimate) creditor must be paid by cheque. ")]
    PayCreditorByCheque = ExternalAgentInstructionCode.PayCreditorByCheque, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_uaUAfvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification. "
    )]
    HoldCashForCreditor = ExternalAgentInstructionCode.HoldCashForCreditor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional Information to an inquiry reason must be provided.
    /// Encoded/decoded by serializers as &quot;INQR&quot;.
    /// </summary>
    [EnumMember(Value = "INQR")]
    [IsoId("_uadxcvRYEeuLhpyIdtJzwg")]
    [Description(@"Additional Information to an inquiry reason must be provided. ")]
    InquiryReason = ExternalAgentInstructionCode.InquiryReason, // same ordinal as derivation source for type conversions

    /// <summary>
    /// (Ultimate) creditor to be paid only after verification of identity.
    /// Encoded/decoded by serializers as &quot;PBEN&quot;.
    /// </summary>
    [EnumMember(Value = "PBEN")]
    [IsoId("_uadxdfRYEeuLhpyIdtJzwg")]
    [Description(@"(Ultimate) creditor to be paid only after verification of identity. ")]
    PayTheBeneficiary = ExternalAgentInstructionCode.PayTheBeneficiary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Please advise/contact next agent by phone.
    /// Encoded/decoded by serializers as &quot;PHOA&quot;.
    /// </summary>
    [EnumMember(Value = "PHOA")]
    [IsoId("_uam7YvRYEeuLhpyIdtJzwg")]
    [Description(@"Please advise/contact next agent by phone. ")]
    PhoneNextAgent = ExternalAgentInstructionCode.PhoneNextAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone.
    /// Encoded/decoded by serializers as &quot;PHOB&quot;.
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_uam7ZfRYEeuLhpyIdtJzwg")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone. ")]
    PhoneBeneficiary = ExternalAgentInstructionCode.PhoneBeneficiary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Please advise/contact next agent by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as &quot;TELA&quot;.
    /// </summary>
    [EnumMember(Value = "TELA")]
    [IsoId("_uawsYvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Please advise/contact next agent by the most efficient means of telecommunication. "
    )]
    TelecomNextAgent = ExternalAgentInstructionCode.TelecomNextAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as &quot;TELB&quot;.
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_uawsZfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication. "
    )]
    Telecom = ExternalAgentInstructionCode.Telecom, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment instruction will be valid and eligible for execution from the date and time stipulated.
    /// Encoded/decoded by serializers as &quot;TFRO&quot;.
    /// </summary>
    [EnumMember(Value = "TFRO")]
    [IsoId("_uawsaPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Payment instruction will be valid and eligible for execution from the date and time stipulated. "
    )]
    TimeFrom = ExternalAgentInstructionCode.TimeFrom, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected.
    /// Encoded/decoded by serializers as &quot;TTIL&quot;.
    /// </summary>
    [EnumMember(Value = "TTIL")]
    [IsoId("_ua6dYvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected. "
    )]
    TimeTill = ExternalAgentInstructionCode.TimeTill, // same ordinal as derivation source for type conversions
}
