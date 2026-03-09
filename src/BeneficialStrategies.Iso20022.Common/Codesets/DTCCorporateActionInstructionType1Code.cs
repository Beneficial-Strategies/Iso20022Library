// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the corporate action instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_12iLgzL3EeKU9IrkkToqcw_1355863049")]
[Description(@"Specifies the type of the corporate action instruction.")]
[DerivedFrom(typeof(DTCCorporateActionInstructionTypeCode))]
public enum DTCCorporateActionInstructionType1Code
{
    /// <summary>
    /// Instruction on a option in corporate action.
    /// Encoded/decoded by serializers as &quot;ELCT&quot;.
    /// </summary>
    [EnumMember(Value = "ELCT")]
    [IsoId("_12iLhDL3EeKU9IrkkToqcw_2002789136")]
    [Description(@"Instruction on a option in corporate action.")]
    ElectionInstruction = DTCCorporateActionInstructionTypeCode.ElectionInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction for a protect on a corporate action.
    /// Encoded/decoded by serializers as &quot;PRTC&quot;.
    /// </summary>
    [EnumMember(Value = "PRTC")]
    [IsoId("_12iLhTL3EeKU9IrkkToqcw_1976970213")]
    [Description(@"Instruction for a protect on a corporate action.")]
    ProtectInstruction = DTCCorporateActionInstructionTypeCode.ProtectInstruction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction on covering a protect at the service provider.
    /// Encoded/decoded by serializers as &quot;CPSY&quot;.
    /// </summary>
    [EnumMember(Value = "CPSY")]
    [IsoId("_12iLhjL3EeKU9IrkkToqcw_738877285")]
    [Description(@"Instruction on covering a protect at the service provider.")]
    CoverProtectSystem = DTCCorporateActionInstructionTypeCode.CoverProtectSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction on covering a protect at the agent.
    /// Encoded/decoded by serializers as &quot;CPAG&quot;.
    /// </summary>
    [EnumMember(Value = "CPAG")]
    [IsoId("_12r8gDL3EeKU9IrkkToqcw_727778508")]
    [Description(@"Instruction on covering a protect at the agent.")]
    CoverProtectAgent = DTCCorporateActionInstructionTypeCode.CoverProtectAgent, // same ordinal as derivation source for type conversions
    
}
