// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies when an transaction/instruction is to be executed relative to a linked transaction/instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aLED0tp-Ed-ak6NoX_4Aeg_1278061835")]
[Description(@"Specifies when an transaction/instruction is to be executed relative to a linked transaction/instruction.")]
[Derivations(typeof(ProcessingPosition3Code),typeof(ProcessingPosition4Code),typeof(ProcessingPosition2Code),typeof(ProcessingPosition5Code))]
public enum ProcessingPositionCode
{
    /// <summary>
    /// Specifies that the transaction/instruction is to be executed after the linked transaction/instruction.
    /// Encoded/decoded by serializers as &quot;AFTE&quot;.
    /// </summary>
    [EnumMember(Value = "AFTE")]
    [IsoId("_aLED09p-Ed-ak6NoX_4Aeg_1278061854")]
    [Description(@"Specifies that the transaction/instruction is to be executed after the linked transaction/instruction.")]
    After,
    
    /// <summary>
    /// Specifies that the transaction/instruction is to be executed with the linked transaction/instruction.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_aLED1Np-Ed-ak6NoX_4Aeg_1278061870")]
    [Description(@"Specifies that the transaction/instruction is to be executed with the linked transaction/instruction.")]
    With,
    
    /// <summary>
    /// Specifies that the transaction/instruction is to be executed before the linked transaction/instruction.
    /// Encoded/decoded by serializers as &quot;BEFO&quot;.
    /// </summary>
    [EnumMember(Value = "BEFO")]
    [IsoId("_aLED1dp-Ed-ak6NoX_4Aeg_1278061871")]
    [Description(@"Specifies that the transaction/instruction is to be executed before the linked transaction/instruction.")]
    Before,
    
    /// <summary>
    /// Specifies that the transactions/instructions are linked for information purposes only.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_aLED1tp-Ed-ak6NoX_4Aeg_1278061880")]
    [Description(@"Specifies that the transactions/instructions are linked for information purposes only.")]
    Information,
    
}
