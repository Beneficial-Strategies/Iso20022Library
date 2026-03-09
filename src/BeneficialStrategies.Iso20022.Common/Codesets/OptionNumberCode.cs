// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code identifying special corporate action option numbers.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aP_AENp-Ed-ak6NoX_4Aeg_1603970622")]
[Description(@"Code identifying special corporate action option numbers.")]
[Derivations(typeof(OptionNumber1Code))]
public enum OptionNumberCode
{
    /// <summary>
    /// The corporate action instruction is unsolicited, that is, the instruction has not been preceded by a corporate action notification.
    /// Encoded/decoded by serializers as &quot;UNSO&quot;.
    /// </summary>
    [EnumMember(Value = "UNSO")]
    [IsoId("_aP_AEdp-Ed-ak6NoX_4Aeg_2061898890")]
    [Description(@"The corporate action instruction is unsolicited, that is, the instruction has not been preceded by a corporate action notification.")]
    Unsolicited,
    
}
