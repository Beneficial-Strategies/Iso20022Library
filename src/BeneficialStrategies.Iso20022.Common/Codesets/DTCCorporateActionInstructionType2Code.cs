// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the corporate action instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_12r8gTL3EeKU9IrkkToqcw_1999140726")]
[Description(@"Specifies the type of the corporate action instruction.")]
[DerivedFrom(typeof(DTCCorporateActionInstructionTypeCode))]
public enum DTCCorporateActionInstructionType2Code
{
    /// <summary>
    /// Withdrawal of previously submitted instruction.
    /// Encoded/decoded by serializers as &quot;WIIN&quot;.
    /// </summary>
    [EnumMember(Value = "WIIN")]
    [IsoId("_12r8gjL3EeKU9IrkkToqcw_776378901")]
    [Description(@"Withdrawal of previously submitted instruction.")]
    InstructionWithdrawal = DTCCorporateActionInstructionTypeCode.InstructionWithdrawal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal of a previously submitted protect instruction.
    /// Encoded/decoded by serializers as &quot;WIPR&quot;.
    /// </summary>
    [EnumMember(Value = "WIPR")]
    [IsoId("_12r8gzL3EeKU9IrkkToqcw_-2051439632")]
    [Description(@"Withdrawal of a previously submitted protect instruction.")]
    ProtectWithdrawal = DTCCorporateActionInstructionTypeCode.ProtectWithdrawal, // same ordinal as derivation source for type conversions
    
}
