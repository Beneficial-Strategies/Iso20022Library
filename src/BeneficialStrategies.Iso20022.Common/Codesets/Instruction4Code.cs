// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aW-_8tp-Ed-ak6NoX_4Aeg_-1362532082")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).")]
[DerivedFrom(typeof(InstructionCode))]
public enum Instruction4Code
{
    /// <summary>
    /// Please advise/contact next agent by phone.
    /// Encoded/decoded by serializers as &quot;PHOA&quot;.
    /// </summary>
    [EnumMember(Value = "PHOA")]
    [IsoId("_aW-_89p-Ed-ak6NoX_4Aeg_-1285879464")]
    [Description(@"Please advise/contact next agent by phone.")]
    PhoneNextAgent = InstructionCode.PhoneNextAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Please advise/contact next agent by the most efficient means of telecommunication.
    /// Encoded/decoded by serializers as &quot;TELA&quot;.
    /// </summary>
    [EnumMember(Value = "TELA")]
    [IsoId("_aW-_9Np-Ed-ak6NoX_4Aeg_-1285879404")]
    [Description(@"Please advise/contact next agent by the most efficient means of telecommunication.")]
    TelecomNextAgent = InstructionCode.TelecomNextAgent, // same ordinal as derivation source for type conversions
    
}
