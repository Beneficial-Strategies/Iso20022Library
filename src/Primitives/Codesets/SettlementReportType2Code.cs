// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of settlement report
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WVWFAXSDEfC68Y4jZPNEug")]
[Description(@"Type of settlement report")]
[DerivedFrom(typeof(SettlementReportTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<SettlementReportType2Code>))]
public enum SettlementReportType2Code
{
    /// <summary>
    /// Final settlement position.
    /// Encoded/decoded by serializers as &quot;FIPO&quot;.
    /// </summary>
    [EnumMember(Value = "FIPO")]
    [IsoId("_WX7e8XSDEfC68Y4jZPNEug")]
    [Description(@"Final settlement position.")]
    FinalPosition = SettlementReportTypeCode.FinalPosition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interim settlement position.
    /// Encoded/decoded by serializers as &quot;INPO&quot;.
    /// </summary>
    [EnumMember(Value = "INPO")]
    [IsoId("_WX7e93SDEfC68Y4jZPNEug")]
    [Description(@"Interim settlement position.")]
    InterimPosition = SettlementReportTypeCode.InterimPosition, // same ordinal as derivation source for type conversions
}
