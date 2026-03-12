// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
[IsoId("_ScDJsNp-Ed-ak6NoX_4Aeg_159174189")]
[DisplayName("Financial Instrument")]
public partial record FinancialInstrument20
{
    #nullable enable
    
    /// <summary>
    /// Indicate whether or note it is possible to hold bearer units/shares in this class in certified form.
    /// </summary>
    [IsoId("_ScDJsdp-Ed-ak6NoX_4Aeg_1592322274")]
    [DisplayName("Physical Bearer Securities")]
    [IsoXmlTag("PhysBrScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalBearerSecurities { get; init; } 
    
    /// <summary>
    /// Indicate whether or not it is possible to hold bearer units/shares in paperless form.
    /// </summary>
    [IsoId("_ScDJstp-Ed-ak6NoX_4Aeg_-1417437996")]
    [DisplayName("Dematerialised Bearer Securities")]
    [IsoXmlTag("DmtrlsdBrScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator DematerialisedBearerSecurities { get; init; } 
    
    /// <summary>
    /// Indicate whether or not it is possible to hold registered units/shares in this class in paperless form.
    /// </summary>
    [IsoId("_ScDJs9p-Ed-ak6NoX_4Aeg_-542520058")]
    [DisplayName("Physical Registered Securities")]
    [IsoXmlTag("PhysRegdScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator PhysicalRegisteredSecurities { get; init; } 
    
    /// <summary>
    /// Indicate whether or not it is possible to hold registered units/shares in this class in paperless form.
    /// </summary>
    [IsoId("_ScDJtNp-Ed-ak6NoX_4Aeg_24760581")]
    [DisplayName("Dematerialised Registered Securities")]
    [IsoXmlTag("DmtrlsdRegdScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator DematerialisedRegisteredSecurities { get; init; } 
    
    /// <summary>
    /// Income policy relating to a class type, ie, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_ScDJtdp-Ed-ak6NoX_4Aeg_159174675")]
    [DisplayName("Distribution Policy")]
    [IsoXmlTag("DstrbtnPlcy")]
    public required DistributionPolicy1Code DistributionPolicy { get; init; } 
    
    /// <summary>
    /// Dividend policy of the fund, eg, cash, units.
    /// </summary>
    [IsoId("_ScDJttp-Ed-ak6NoX_4Aeg_159174797")]
    [DisplayName("Dividend Policy")]
    [IsoXmlTag("DvddPlcy")]
    public DividendPolicy1Code? DividendPolicy { get; init; } 
    
    /// <summary>
    /// Frequency with which the income is allocated to investors.
    /// </summary>
    [IsoId("_ScDJt9p-Ed-ak6NoX_4Aeg_159175106")]
    [DisplayName("Dividend Frequency")]
    [IsoXmlTag("DvddFrqcy")]
    public EventFrequency5Code? DividendFrequency { get; init; } 
    
    /// <summary>
    /// Frequency with which the reinvestment takes place, This is the same or less than the dividend frequency.
    /// </summary>
    [IsoId("_ScDJuNp-Ed-ak6NoX_4Aeg_159174828")]
    [DisplayName("Reinvestment Frequency")]
    [IsoXmlTag("RinvstmtFrqcy")]
    public EventFrequency5Code? ReinvestmentFrequency { get; init; } 
    
    /// <summary>
    /// Front end charge on subscription orders for this class can be applied.
    /// </summary>
    [IsoId("_ScM6sNp-Ed-ak6NoX_4Aeg_159175198")]
    [DisplayName("Front End Load")]
    [IsoXmlTag("FrntEndLd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator FrontEndLoad { get; init; } 
    
    /// <summary>
    /// Exit charge (eg. CDSC) on redemption orders for this class can be applied.
    /// </summary>
    [IsoId("_ScM6sdp-Ed-ak6NoX_4Aeg_159175229")]
    [DisplayName("Back End Load")]
    [IsoXmlTag("BckEndLd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator BackEndLoad { get; init; } 
    
    /// <summary>
    /// If a separate fee for switching between sub-funds of the same umbrella can be applied.
    /// </summary>
    [IsoId("_ScM6stp-Ed-ak6NoX_4Aeg_159175259")]
    [DisplayName("Switch Fee")]
    [IsoXmlTag("SwtchFee")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SwitchFee { get; init; } 
    
    /// <summary>
    /// Indicates whether the investment fund class is subject to the European Union Saving Directive.
    /// </summary>
    [IsoId("_ScM6s9p-Ed-ak6NoX_4Aeg_159175137")]
    [DisplayName("EU Savings Directive")]
    [IsoXmlTag("EUSvgsDrctv")]
    public required EUSavingsDirective1Code EUSavingsDirective { get; init; } 
    
    
    #nullable disable
    
}
