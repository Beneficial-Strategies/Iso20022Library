// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZxSR49p-Ed-ak6NoX_4Aeg_528226726")]
[Description(
    @"Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s)."
)]
[DerivedFrom(typeof(InstructionCode))]
public enum PartialInstruction3Code
{
    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_ZxSR5Np-Ed-ak6NoX_4Aeg_528226787")]
    [Description(
        @"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification."
    )]
    HoldCashForCreditor = InstructionCode.HoldCashForCreditor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone.
    /// Encoded/decoded by serializers as &quot;PHOB&quot;.
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_ZxSR5dp-Ed-ak6NoX_4Aeg_528226788")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone.")]
    PhoneBeneficiary = InstructionCode.PhoneBeneficiary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as &quot;TELB&quot;.
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_ZxSR5tp-Ed-ak6NoX_4Aeg_528226818")]
    [Description(
        @"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication."
    )]
    Telecom = InstructionCode.Telecom, // same ordinal as derivation source for type conversions
}
