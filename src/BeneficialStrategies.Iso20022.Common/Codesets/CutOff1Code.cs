// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cut-off type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1pktkTL3EeKU9IrkkToqcw_-1547713338")]
[Description(@"Specifies the cut-off type.")]
[DerivedFrom(typeof(CutOffCode))]
public enum CutOff1Code
{
    /// <summary>
    /// Cut-off may change to early.
    /// Encoded/decoded by serializers as &quot;AERL&quot;.
    /// </summary>
    [EnumMember(Value = "AERL")]
    [IsoId("_1pktkjL3EeKU9IrkkToqcw_1676180925")]
    [Description(@"Cut-off may change to early.")]
    AnticipatedEarlyCutoff = CutOffCode.AnticipatedEarlyCutoff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cut-off occurs before the DTCC (The Depository Trust and Clearing Corporation) standard settlement cut-off. Early cut-off usually 1: 30 Eastern Standard Time.
    /// Encoded/decoded by serializers as &quot;EARL&quot;.
    /// </summary>
    [EnumMember(Value = "EARL")]
    [IsoId("_1pktkzL3EeKU9IrkkToqcw_1562341859")]
    [Description(@"Cut-off occurs before the DTCC (The Depository Trust and Clearing Corporation) standard settlement cut-off. Early cut-off usually 1: 30 Eastern Standard Time.")]
    Early = CutOffCode.Early, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cut-off is after settlement at DTCC (The Depository Trust and Clearing Corporation).
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_1pktlDL3EeKU9IrkkToqcw_2001298432")]
    [Description(@"Cut-off is after settlement at DTCC (The Depository Trust and Clearing Corporation).")]
    Late = CutOffCode.Late, // same ordinal as derivation source for type conversions
    
}
