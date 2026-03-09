// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aW-_9dp-Ed-ak6NoX_4Aeg_1768251033")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).")]
[DerivedFrom(typeof(InstructionCode))]
public enum Instruction5Code
{
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by phone.
    /// Encoded/decoded by serializers as &quot;PHOB&quot;.
    /// </summary>
    [EnumMember(Value = "PHOB")]
    [IsoId("_aW-_9tp-Ed-ak6NoX_4Aeg_1896618964")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by phone.")]
    PhoneBeneficiary = InstructionCode.PhoneBeneficiary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as &quot;TELB&quot;.
    /// </summary>
    [EnumMember(Value = "TELB")]
    [IsoId("_aW-_99p-Ed-ak6NoX_4Aeg_1896618989")]
    [Description(@"Please advise/contact (ultimate) creditor/claimant by the most efficient means of telecommunication.")]
    Telecom = InstructionCode.Telecom, // same ordinal as derivation source for type conversions
    
}
