// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of settlement report
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RTGIgFdKEeeIAMBcVOw01w")]
[Description(@"Type of settlement report")]
[DerivedFrom(typeof(SettlementReportTypeCode))]
public enum SettlementReportType1Code
{
    /// <summary>
    /// Final settlement position.
    /// Encoded/decoded by serializers as &quot;FIPO&quot;.
    /// </summary>
    [EnumMember(Value = "FIPO")]
    [IsoId("_UfqLIVdKEeeIAMBcVOw01w")]
    [Description(@"Final settlement position.")]
    FinalPosition = SettlementReportTypeCode.FinalPosition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of settlement report defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_U01J4VdKEeeIAMBcVOw01w")]
    [Description(@"Other type of settlement report defined at national level.")]
    OtherNational = SettlementReportTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other settlement report defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_U_OcAVdKEeeIAMBcVOw01w")]
    [Description(@"Other settlement report defined at private level.")]
    OtherPrivate = SettlementReportTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interim settlement position.
    /// Encoded/decoded by serializers as &quot;INPO&quot;.
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_VY-YwVdKEeeIAMBcVOw01w")]
    [Description(@"Interim settlement position.")]
    InterimPosition = SettlementReportTypeCode.InterimPosition, // same ordinal as derivation source for type conversions
    
}
