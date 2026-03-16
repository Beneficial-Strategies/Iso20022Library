// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aXbr6Np-Ed-ak6NoX_4Aeg_86377106")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction.")]
[Derivations(
    typeof(Instruction4Code),
    typeof(Instruction3Code),
    typeof(Instruction5Code),
    typeof(Instruction1Code),
    typeof(PartialInstruction3Code)
)]
public enum InstructionCode
{
    /// <summary>
    /// (Ultimate) creditor to be paid only after verification of identity.
    /// Encoded/decoded by serializers as &quot;PBEN&quot;.
    /// </summary>
    [EnumMember(Value = "PBEN")]
    [IsoId("_aXlc4Np-Ed-ak6NoX_4Aeg_170415723")]
    [Description(@"(Ultimate) creditor to be paid only after verification of identity.")]
    PayTheBeneficiary,

    /// <summary>
    /// Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected.
    /// Encoded/decoded by serializers as &quot;TTIL&quot;.
    /// </summary>
    [EnumMember(Value = "TTIL")]
    [IsoId("_aXlc4dp-Ed-ak6NoX_4Aeg_171341881")]
    [Description(
        @"Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected."
    )]
    TimeTill,

    /// <summary>
    /// Payment instruction will be valid and eligible for execution from the date and time stipulated.
    /// Encoded/decoded by serializers as &quot;TFRO&quot;.
    /// </summary>
    [EnumMember(Value = "TFRO")]
    [IsoId("_aXlc4tp-Ed-ak6NoX_4Aeg_171341923")]
    [Description(
        @"Payment instruction will be valid and eligible for execution from the date and time stipulated."
    )]
    TimeFrom,

    /// <summary>
    /// (Ultimate) creditor must be paid by cheque.
    /// Encoded/decoded by serializers as &quot;CHQB&quot;.
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_aXlc49p-Ed-ak6NoX_4Aeg_-849133974")]
    [Description(@"(Ultimate) creditor must be paid by cheque.")]
    PayCreditorByCheque,

    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_aXlc5Np-Ed-ak6NoX_4Aeg_-849133957")]
    [Description(
        @"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification."
    )]
    HoldCashForCreditor,

    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone.
    /// Encoded/decoded by serializers as &quot;PHOB&quot;.
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_aXlc5dp-Ed-ak6NoX_4Aeg_715895574")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone.")]
    PhoneBeneficiary,

    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as &quot;TELB&quot;.
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_aXlc5tp-Ed-ak6NoX_4Aeg_927383559")]
    [Description(
        @"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication."
    )]
    Telecom,

    /// <summary>
    /// Please advise/contact next agent by phone.
    /// Encoded/decoded by serializers as &quot;PHOA&quot;.
    /// </summary>
    [EnumMember(Value = "PHOA")]
    [IsoId("_aXlc59p-Ed-ak6NoX_4Aeg_1747493253")]
    [Description(@"Please advise/contact next agent by phone.")]
    PhoneNextAgent,

    /// <summary>
    /// Please advise/contact next agent by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as &quot;TELA&quot;.
    /// </summary>
    [EnumMember(Value = "TELA")]
    [IsoId("_aXlc6Np-Ed-ak6NoX_4Aeg_1750263880")]
    [Description(
        @"Please advise/contact next agent by the most efficient means of telecommunication."
    )]
    TelecomNextAgent,
}
