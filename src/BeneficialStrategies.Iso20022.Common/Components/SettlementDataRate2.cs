// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the volume and value percentage rates of settlement instructions.
/// </summary>
[IsoId("_vW5JAY0SEemUAO64Q252gQ")]
[DisplayName("Settlement Data Rate")]
public partial record SettlementDataRate2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the rate, in terms of volume, of the failed settlement instructions compared to the total volume, of settlement instructions performed (settled and failed) during the period covered by the report.
    /// </summary>
    [IsoId("_vb6L4Y0SEemUAO64Q252gQ")]
    [DisplayName("Volume")]
    [IsoXmlTag("Vol")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Volume { get; init; } 
    
    /// <summary>
    /// Specifies the rate, in terms of value, of the failed settlement instructions compared to the total value of settlement instructions performed (settled and failed) during the period covered by the report.
    /// </summary>
    [IsoId("_vb6L440SEemUAO64Q252gQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Value { get; init; } 
    
    
    #nullable disable
    
}
