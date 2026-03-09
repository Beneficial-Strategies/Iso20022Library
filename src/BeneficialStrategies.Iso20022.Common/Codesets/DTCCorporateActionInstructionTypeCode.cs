// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the corporate action instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_12ZBkjL3EeKU9IrkkToqcw_1778386754")]
[Description(@"Specifies the type of the corporate action instruction.")]
[Derivations(typeof(DTCCorporateActionInstructionType1Code),typeof(DTCCorporateActionInstructionType2Code))]
public enum DTCCorporateActionInstructionTypeCode
{
    /// <summary>
    /// Instruction on a option in corporate action.
    /// Encoded/decoded by serializers as &quot;ELCT&quot;.
    /// </summary>
    [EnumMember(Value = "ELCT")]
    [IsoId("_12ZBkzL3EeKU9IrkkToqcw_-1001370478")]
    [Description(@"Instruction on a option in corporate action.")]
    ElectionInstruction,
    
    /// <summary>
    /// Instruction for a protect on a corporate action.
    /// Encoded/decoded by serializers as &quot;PRTC&quot;.
    /// </summary>
    [EnumMember(Value = "PRTC")]
    [IsoId("_12ZBlDL3EeKU9IrkkToqcw_2076946910")]
    [Description(@"Instruction for a protect on a corporate action.")]
    ProtectInstruction,
    
    /// <summary>
    /// Withdrawal of previously submitted instruction.
    /// Encoded/decoded by serializers as &quot;WIIN&quot;.
    /// </summary>
    [EnumMember(Value = "WIIN")]
    [IsoId("_12ZBlTL3EeKU9IrkkToqcw_1368059689")]
    [Description(@"Withdrawal of previously submitted instruction.")]
    InstructionWithdrawal,
    
    /// <summary>
    /// Withdrawal of a previously submitted protect instruction.
    /// Encoded/decoded by serializers as &quot;WIPR&quot;.
    /// </summary>
    [EnumMember(Value = "WIPR")]
    [IsoId("_12iLgDL3EeKU9IrkkToqcw_-305979129")]
    [Description(@"Withdrawal of a previously submitted protect instruction.")]
    ProtectWithdrawal,
    
    /// <summary>
    /// Instruction on covering a protect at the service provider.
    /// Encoded/decoded by serializers as &quot;CPSY&quot;.
    /// </summary>
    [EnumMember(Value = "CPSY")]
    [IsoId("_12iLgTL3EeKU9IrkkToqcw_-628200838")]
    [Description(@"Instruction on covering a protect at the service provider.")]
    CoverProtectSystem,
    
    /// <summary>
    /// Instruction on covering a protect at the agent.
    /// Encoded/decoded by serializers as &quot;CPAG&quot;.
    /// </summary>
    [EnumMember(Value = "CPAG")]
    [IsoId("_12iLgjL3EeKU9IrkkToqcw_-2135919619")]
    [Description(@"Instruction on covering a protect at the agent.")]
    CoverProtectAgent,
    
}
