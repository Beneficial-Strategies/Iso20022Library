// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Local time offset to UTC (Coordinated Universal Time).
/// </summary>
[IsoId("_4KU98GpuEeSMqvBfBY1c9A")]
[DisplayName("Local Date Time")]
public partial record LocalDateTime1
{
    #nullable enable
    
    /// <summary>
    /// Date time of the beginning of the period (inclusive).
    /// </summary>
    [IsoId("_-wojkGpuEeSMqvBfBY1c9A")]
    [DisplayName("From Date Time")]
    [IsoXmlTag("FrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? FromDateTime { get; init; } 
    
    /// <summary>
    /// Date time of the end of the period (exclusive).
    /// </summary>
    [IsoId("_GdqgsGpvEeSMqvBfBY1c9A")]
    [DisplayName("To Date Time")]
    [IsoXmlTag("ToDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ToDateTime { get; init; } 
    
    /// <summary>
    /// UTC offset in minutes, of the local time during the period. For instance, 120 for Central European Time, -720 for Central Standard Time (North America).
    /// </summary>
    [IsoId("_LJO38GpvEeSMqvBfBY1c9A")]
    [DisplayName("UTC Offset")]
    [IsoXmlTag("UTCOffset")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber UTCOffset { get; init; } 
    
    
    #nullable disable
    
}
