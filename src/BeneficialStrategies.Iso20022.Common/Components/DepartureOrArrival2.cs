// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains departure or arrival information.
/// </summary>
[IsoId("_Hqx1RfcWEeiW-auGnDPZIw")]
[DisplayName("Departure Or Arrival")]
public partial record DepartureOrArrival2
{
    #nullable enable
    
    /// <summary>
    /// Code indicating the name of the passenger transport carrier (for example, United Airlines, Lufthansa, JetBlue, etc.) 
    /// </summary>
    [IsoId("_Hqx1SfcWEeiW-auGnDPZIw")]
    [DisplayName("Carrier Code")]
    [IsoXmlTag("CrrierCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CarrierCode { get; init; } 
    
    /// <summary>
    /// Route number (for example, flight number, bus number, train route or number, etc.)
    /// </summary>
    [IsoId("_Hqx1SPcWEeiW-auGnDPZIw")]
    [DisplayName("Route Number")]
    [IsoXmlTag("RouteNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? RouteNumber { get; init; } 
    
    /// <summary>
    /// Departure or arrival date.
    /// </summary>
    [IsoId("_Hqx1R_cWEeiW-auGnDPZIw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; } 
    
    /// <summary>
    /// Departure or arrival time. 
    /// </summary>
    [IsoId("_Hqx1RvcWEeiW-auGnDPZIw")]
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? Time { get; init; } 
    
    
    #nullable disable
    
}
