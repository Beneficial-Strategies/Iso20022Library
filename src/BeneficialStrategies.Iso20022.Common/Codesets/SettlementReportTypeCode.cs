// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of settlement report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OiEAwFdJEeeIAMBcVOw01w")]
[Description(@"Type of settlement report.")]
[Derivations(typeof(SettlementReportType1Code))]
public enum SettlementReportTypeCode
{
    /// <summary>
    /// Final settlement position.
    /// Encoded/decoded by serializers as &quot;FIPO&quot;.
    /// </summary>
    [EnumMember(Value = "FIPO")]
    [IsoId("_cLDmAFdJEeeIAMBcVOw01w")]
    [Description(@"Final settlement position.")]
    FinalPosition,
    
    /// <summary>
    /// Interim settlement position.
    /// Encoded/decoded by serializers as &quot;INPO&quot;.
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_jiREIFdJEeeIAMBcVOw01w")]
    [Description(@"Interim settlement position.")]
    InterimPosition,
    
    /// <summary>
    /// Other type of settlement report defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("__VWJgFdJEeeIAMBcVOw01w")]
    [Description(@"Other type of settlement report defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other settlement report defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_DqAcoFdKEeeIAMBcVOw01w")]
    [Description(@"Other settlement report defined at private level.")]
    OtherPrivate,
    
}
