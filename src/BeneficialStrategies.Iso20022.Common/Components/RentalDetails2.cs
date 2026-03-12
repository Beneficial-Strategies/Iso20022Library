// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of car rental service.
/// </summary>
[IsoId("_Y2H6UcW1EeuhguwJmlgagQ")]
[DisplayName("Rental Details")]
public partial record RentalDetails2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the car rental service.
    /// </summary>
    [IsoId("_Y6vUkcW1EeuhguwJmlgagQ")]
    [DisplayName("Rental Identification")]
    [IsoXmlTag("RntlId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? RentalIdentification { get; init; } 
    
    /// <summary>
    /// Date and time of registration of car rental service as  per folio.
    /// </summary>
    [IsoId("_Y6vUk8W1EeuhguwJmlgagQ")]
    [DisplayName("Rental Date Time")]
    [IsoXmlTag("RntlDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RentalDateTime { get; init; } 
    
    /// <summary>
    /// Details of the vehicle at the start of the rental period.
    /// </summary>
    [IsoId("_Y6vUlcW1EeuhguwJmlgagQ")]
    [DisplayName("Rental Start")]
    [IsoXmlTag("RntlStart")]
    public ServiceStartEnd2? RentalStart { get; init; } 
    
    /// <summary>
    /// Details of the vehicle at the end of the rental period.
    /// </summary>
    [IsoId("_Y6vUl8W1EeuhguwJmlgagQ")]
    [DisplayName("Rental Return")]
    [IsoXmlTag("RntlRtr")]
    public ServiceStartEnd2? RentalReturn { get; init; } 
    
    /// <summary>
    /// Time period for the whole duration of rental.
    /// </summary>
    [IsoId("_Y6vUmcW1EeuhguwJmlgagQ")]
    [DisplayName("Rental Time Period")]
    [IsoXmlTag("RntlTmPrd")]
    public PeriodUnit2Code? RentalTimePeriod { get; init; } 
    
    /// <summary>
    /// Time period expressed in a number of units (for example, 1 week, 3 days, etc.).
    /// </summary>
    [IsoId("_Y6vUm8W1EeuhguwJmlgagQ")]
    [DisplayName("Time Period Unit")]
    [IsoXmlTag("TmPrdUnit")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? TimePeriodUnit { get; init; } 
    
    /// <summary>
    /// Rate for the time period.
    /// </summary>
    [IsoId("_Y6vUncW1EeuhguwJmlgagQ")]
    [DisplayName("Time Period Rate")]
    [IsoXmlTag("TmPrdRate")]
    public ImpliedCurrencyAndAmount? TimePeriodRate { get; init; } 
    
    /// <summary>
    /// Currency code applied for the rental.
    /// </summary>
    [IsoId("_Y6vUn8W1EeuhguwJmlgagQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; } 
    
    
    #nullable disable
    
}
