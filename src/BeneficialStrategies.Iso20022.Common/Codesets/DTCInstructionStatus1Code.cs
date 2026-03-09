// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// DTC (The Depository Trust Company) system status code of instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_121thDL3EeKU9IrkkToqcw_1866676652")]
[Description(@"DTC (The Depository Trust Company) system status code of instruction.")]
[DerivedFrom(typeof(DTCInstructionStatusCode))]
public enum DTCInstructionStatus1Code
{
    /// <summary>
    /// Instruction waiting for position. Instruction will subsequently either become “Made” or “Dropped” by end of day.
    /// Encoded/decoded by serializers as &quot;RECY&quot;.
    /// </summary>
    [EnumMember(Value = "RECY")]
    [IsoId("_121thTL3EeKU9IrkkToqcw_1047722971")]
    [Description(@"Instruction waiting for position. Instruction will subsequently either become “Made” or “Dropped” by end of day.")]
    Recycle = DTCInstructionStatusCode.Recycle, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fully processed instruction.
    /// Encoded/decoded by serializers as &quot;MADE&quot;.
    /// </summary>
    [EnumMember(Value = "MADE")]
    [IsoId("_121thjL3EeKU9IrkkToqcw_-1664224946")]
    [Description(@"Fully processed instruction.")]
    Made = DTCInstructionStatusCode.Made, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction dropped due to insufficient position.
    /// Encoded/decoded by serializers as &quot;DROP&quot;.
    /// </summary>
    [EnumMember(Value = "DROP")]
    [IsoId("_12-3cDL3EeKU9IrkkToqcw_1558737291")]
    [Description(@"Instruction dropped due to insufficient position.")]
    Dropped = DTCInstructionStatusCode.Dropped, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction rejected.
    /// Encoded/decoded by serializers as &quot;EDRJ&quot;.
    /// </summary>
    [EnumMember(Value = "EDRJ")]
    [IsoId("_12-3cTL3EeKU9IrkkToqcw_-1269081242")]
    [Description(@"Transaction rejected.")]
    EditReject = DTCInstructionStatusCode.EditReject, // same ordinal as derivation source for type conversions
    
}
