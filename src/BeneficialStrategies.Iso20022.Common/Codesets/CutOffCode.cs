// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cut-off type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1oYawzL3EeKU9IrkkToqcw_1347831784")]
[Description(@"Specifies the cut-off type.")]
[Derivations(typeof(CutOff1Code))]
public enum CutOffCode
{
    /// <summary>
    /// Cut-off may change to early.
    /// Encoded/decoded by serializers as &quot;AERL&quot;.
    /// </summary>
    [EnumMember(Value = "AERL")]
    [IsoId("_1oYaxDL3EeKU9IrkkToqcw_-1262434567")]
    [Description(@"Cut-off may change to early.")]
    AnticipatedEarlyCutoff,
    
    /// <summary>
    /// Cut-off occurs before the DTCC (The Depository Trust and Clearing Corporation) standard settlement cut-off. Early cut-off usually 1: 30 Eastern Standard Time.
    /// Encoded/decoded by serializers as &quot;EARL&quot;.
    /// </summary>
    [EnumMember(Value = "EARL")]
    [IsoId("_1oYaxTL3EeKU9IrkkToqcw_-874706012")]
    [Description(@"Cut-off occurs before the DTCC (The Depository Trust and Clearing Corporation) standard settlement cut-off. Early cut-off usually 1: 30 Eastern Standard Time.")]
    Early,
    
    /// <summary>
    /// Cut-off is after settlement at DTCC (The Depository Trust and Clearing Corporation).
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_1oYaxjL3EeKU9IrkkToqcw_804786511")]
    [Description(@"Cut-off is after settlement at DTCC (The Depository Trust and Clearing Corporation).")]
    Late,
    
}
