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
[IsoId("_KTAyqtA4EeeCAfThR1cp_Q")]
[Description(
    @"Specifies further instructions for the agent concerning the processing of an instruction.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalAgentInstruction1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalAgentInstructionCode>))]
#endif
public enum ExternalAgentInstructionCode
{
    /// <summary>
    /// (Ultimate) creditor must be paid by cheque.
    /// Encoded/decoded by serializers as &quot;CHQB&quot;.
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_KTBZsNA4EeeCAfThR1cp_Q")]
    [Description(@"(Ultimate) creditor must be paid by cheque. ")]
    PayCreditorByCheque,

    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_KTBZstA4EeeCAfThR1cp_Q")]
    [Description(
        @"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification. "
    )]
    HoldCashForCreditor,

    /// <summary>
    /// Additional Information to an inquiry reason must be provided.
    /// Encoded/decoded by serializers as &quot;INQR&quot;.
    /// </summary>
    [EnumMember(Value = "INQR")]
    [IsoId("_etQCMNA4EeeCAfThR1cp_Q")]
    [Description(@"Additional Information to an inquiry reason must be provided. ")]
    InquiryReason,

    /// <summary>
    /// (Ultimate) creditor to be paid only after verification of identity.
    /// Encoded/decoded by serializers as &quot;PBEN&quot;.
    /// </summary>
    [EnumMember(Value = "PBEN")]
    [IsoId("_KTBZttA4EeeCAfThR1cp_Q")]
    [Description(@"(Ultimate) creditor to be paid only after verification of identity. ")]
    PayTheBeneficiary,

    /// <summary>
    /// Please advise/contact next agent by phone.
    /// Encoded/decoded by serializers as &quot;PHOA&quot;.
    /// </summary>
    [EnumMember(Value = "PHOA")]
    [IsoId("_KTBZt9A4EeeCAfThR1cp_Q")]
    [Description(@"Please advise/contact next agent by phone. ")]
    PhoneNextAgent,

    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone.
    /// Encoded/decoded by serializers as &quot;PHOB&quot;.
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_KTBZuNA4EeeCAfThR1cp_Q")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone. ")]
    PhoneBeneficiary,

    /// <summary>
    /// Please advise/contact next agent by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as &quot;TELA&quot;.
    /// </summary>
    [EnumMember(Value = "TELA")]
    [IsoId("_KTBZtNA4EeeCAfThR1cp_Q")]
    [Description(
        @"Please advise/contact next agent by the most efficient means of telecommunication. "
    )]
    TelecomNextAgent,

    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as &quot;TELB&quot;.
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_KTBZsdA4EeeCAfThR1cp_Q")]
    [Description(
        @"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication. "
    )]
    Telecom,

    /// <summary>
    /// Payment instruction will be valid and eligible for execution from the date and time stipulated.
    /// Encoded/decoded by serializers as &quot;TFRO&quot;.
    /// </summary>
    [EnumMember(Value = "TFRO")]
    [IsoId("_KTBZs9A4EeeCAfThR1cp_Q")]
    [Description(
        @"Payment instruction will be valid and eligible for execution from the date and time stipulated. "
    )]
    TimeFrom,

    /// <summary>
    /// Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected.
    /// Encoded/decoded by serializers as &quot;TTIL&quot;.
    /// </summary>
    [EnumMember(Value = "TTIL")]
    [IsoId("_KTBZtdA4EeeCAfThR1cp_Q")]
    [Description(
        @"Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected. "
    )]
    TimeTill,
}
