// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aW12Bdp-Ed-ak6NoX_4Aeg_68416834")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).")]
[DerivedFrom(typeof(InstructionCode))]
public enum Instruction3Code
{
    /// <summary>
    /// (Ultimate) creditor must be paid by cheque.
    /// Encoded/decoded by serializers as &quot;CHQB&quot;.
    /// </summary>
    [EnumMember(Value = "CHQB")]
    [IsoId("_aW12Btp-Ed-ak6NoX_4Aeg_156152754")]
    [Description(@"(Ultimate) creditor must be paid by cheque.")]
    PayCreditorByCheque = InstructionCode.PayCreditorByCheque, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.
    /// Encoded/decoded by serializers as &quot;HOLD&quot;.
    /// </summary>
    [EnumMember(Value = "HOLD")]
    [IsoId("_aW12B9p-Ed-ak6NoX_4Aeg_157072838")]
    [Description(@"Amount of money must be held for the (ultimate) creditor, who will call. Pay on identification.")]
    HoldCashForCreditor = InstructionCode.HoldCashForCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone.
    /// Encoded/decoded by serializers as &quot;PHOB&quot;.
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_aW-_8Np-Ed-ak6NoX_4Aeg_157072976")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone.")]
    PhoneBeneficiary = InstructionCode.PhoneBeneficiary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as &quot;TELB&quot;.
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_aW-_8dp-Ed-ak6NoX_4Aeg_157073330")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.")]
    Telecom = InstructionCode.Telecom, // same ordinal as derivation source for type conversions
    
}
