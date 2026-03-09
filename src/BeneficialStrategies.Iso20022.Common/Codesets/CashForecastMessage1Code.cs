// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the fund cash forecast message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a65lUNp-Ed-ak6NoX_4Aeg_986167915")]
[Description(@"Specifies the fund cash forecast message.")]
[DerivedFrom(typeof(MessageTypeCode))]
public enum CashForecastMessage1Code
{
    /// <summary>
    /// Fund estimated cash forecast report (camt.040).
    /// Encoded/decoded by serializers as &quot;CF40&quot;.
    /// </summary>
    [EnumMember(Value = "CF40")]
    [IsoId("_a65lUdp-Ed-ak6NoX_4Aeg_1040652616")]
    [Description(@"Fund estimated cash forecast report (camt.040).")]
    Estimated = MessageTypeCode.Estimated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fund detailed estimated cash forecast Report (042).
    /// Encoded/decoded by serializers as &quot;CF42&quot;.
    /// </summary>
    [EnumMember(Value = "CF42")]
    [IsoId("_a65lUtp-Ed-ak6NoX_4Aeg_-1588280260")]
    [Description(@"Fund detailed estimated cash forecast Report (042).")]
    EstimatedDetailed = MessageTypeCode.EstimatedDetailed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fund confirmed cash forecast report (camt.041).
    /// Encoded/decoded by serializers as &quot;CF41&quot;.
    /// </summary>
    [EnumMember(Value = "CF41")]
    [IsoId("_a65lU9p-Ed-ak6NoX_4Aeg_-1557804493")]
    [Description(@"Fund confirmed cash forecast report (camt.041).")]
    Confirmed = MessageTypeCode.Confirmed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fund detailed confirmed cash forecast report (camt.043).
    /// Encoded/decoded by serializers as &quot;CF43&quot;.
    /// </summary>
    [EnumMember(Value = "CF43")]
    [IsoId("_a65lVNp-Ed-ak6NoX_4Aeg_-1535641166")]
    [Description(@"Fund detailed confirmed cash forecast report (camt.043).")]
    CornfirmedDetailed = MessageTypeCode.CornfirmedDetailed, // same ordinal as derivation source for type conversions
    
}
