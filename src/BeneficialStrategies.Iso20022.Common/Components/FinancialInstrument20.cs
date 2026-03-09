// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
[IsoId("_ScDJsNp-Ed-ak6NoX_4Aeg_159174189")]
[DisplayName("Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrument20 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrument20( System.String reqPhysicalBearerSecurities,System.String reqDematerialisedBearerSecurities,System.String reqPhysicalRegisteredSecurities,System.String reqDematerialisedRegisteredSecurities,DistributionPolicy1Code reqDistributionPolicy,System.String reqFrontEndLoad,System.String reqBackEndLoad,System.String reqSwitchFee,EUSavingsDirective1Code reqEUSavingsDirective )
    {
        PhysicalBearerSecurities = reqPhysicalBearerSecurities;
        DematerialisedBearerSecurities = reqDematerialisedBearerSecurities;
        PhysicalRegisteredSecurities = reqPhysicalRegisteredSecurities;
        DematerialisedRegisteredSecurities = reqDematerialisedRegisteredSecurities;
        DistributionPolicy = reqDistributionPolicy;
        FrontEndLoad = reqFrontEndLoad;
        BackEndLoad = reqBackEndLoad;
        SwitchFee = reqSwitchFee;
        EUSavingsDirective = reqEUSavingsDirective;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicate whether or note it is possible to hold bearer units/shares in this class in certified form.
    /// </summary>
    [IsoId("_ScDJsdp-Ed-ak6NoX_4Aeg_1592322274")]
    [DisplayName("Physical Bearer Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysBrScties")]
    #endif
    [IsoXmlTag("PhysBrScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator PhysicalBearerSecurities { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PhysicalBearerSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PhysicalBearerSecurities { get; init; } 
    #else
    public System.String PhysicalBearerSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Indicate whether or not it is possible to hold bearer units/shares in paperless form.
    /// </summary>
    [IsoId("_ScDJstp-Ed-ak6NoX_4Aeg_-1417437996")]
    [DisplayName("Dematerialised Bearer Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmtrlsdBrScties")]
    #endif
    [IsoXmlTag("DmtrlsdBrScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator DematerialisedBearerSecurities { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DematerialisedBearerSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DematerialisedBearerSecurities { get; init; } 
    #else
    public System.String DematerialisedBearerSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Indicate whether or not it is possible to hold registered units/shares in this class in paperless form.
    /// </summary>
    [IsoId("_ScDJs9p-Ed-ak6NoX_4Aeg_-542520058")]
    [DisplayName("Physical Registered Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysRegdScties")]
    #endif
    [IsoXmlTag("PhysRegdScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator PhysicalRegisteredSecurities { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PhysicalRegisteredSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PhysicalRegisteredSecurities { get; init; } 
    #else
    public System.String PhysicalRegisteredSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Indicate whether or not it is possible to hold registered units/shares in this class in paperless form.
    /// </summary>
    [IsoId("_ScDJtNp-Ed-ak6NoX_4Aeg_24760581")]
    [DisplayName("Dematerialised Registered Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmtrlsdRegdScties")]
    #endif
    [IsoXmlTag("DmtrlsdRegdScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator DematerialisedRegisteredSecurities { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DematerialisedRegisteredSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DematerialisedRegisteredSecurities { get; init; } 
    #else
    public System.String DematerialisedRegisteredSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Income policy relating to a class type, ie, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_ScDJtdp-Ed-ak6NoX_4Aeg_159174675")]
    [DisplayName("Distribution Policy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstrbtnPlcy")]
    #endif
    [IsoXmlTag("DstrbtnPlcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DistributionPolicy1Code DistributionPolicy { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DistributionPolicy1Code DistributionPolicy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionPolicy1Code DistributionPolicy { get; init; } 
    #else
    public DistributionPolicy1Code DistributionPolicy { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend policy of the fund, eg, cash, units.
    /// </summary>
    [IsoId("_ScDJttp-Ed-ak6NoX_4Aeg_159174797")]
    [DisplayName("Dividend Policy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddPlcy")]
    #endif
    [IsoXmlTag("DvddPlcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DividendPolicy1Code? DividendPolicy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DividendPolicy1Code? DividendPolicy { get; init; } 
    #else
    public DividendPolicy1Code? DividendPolicy { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency with which the income is allocated to investors.
    /// </summary>
    [IsoId("_ScDJt9p-Ed-ak6NoX_4Aeg_159175106")]
    [DisplayName("Dividend Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddFrqcy")]
    #endif
    [IsoXmlTag("DvddFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EventFrequency5Code? DividendFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventFrequency5Code? DividendFrequency { get; init; } 
    #else
    public EventFrequency5Code? DividendFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency with which the reinvestment takes place, This is the same or less than the dividend frequency.
    /// </summary>
    [IsoId("_ScDJuNp-Ed-ak6NoX_4Aeg_159174828")]
    [DisplayName("Reinvestment Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstmtFrqcy")]
    #endif
    [IsoXmlTag("RinvstmtFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EventFrequency5Code? ReinvestmentFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventFrequency5Code? ReinvestmentFrequency { get; init; } 
    #else
    public EventFrequency5Code? ReinvestmentFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Front end charge on subscription orders for this class can be applied.
    /// </summary>
    [IsoId("_ScM6sNp-Ed-ak6NoX_4Aeg_159175198")]
    [DisplayName("Front End Load")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrntEndLd")]
    #endif
    [IsoXmlTag("FrntEndLd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator FrontEndLoad { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FrontEndLoad { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FrontEndLoad { get; init; } 
    #else
    public System.String FrontEndLoad { get; set; } 
    #endif
    
    /// <summary>
    /// Exit charge (eg. CDSC) on redemption orders for this class can be applied.
    /// </summary>
    [IsoId("_ScM6sdp-Ed-ak6NoX_4Aeg_159175229")]
    [DisplayName("Back End Load")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BckEndLd")]
    #endif
    [IsoXmlTag("BckEndLd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator BackEndLoad { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BackEndLoad { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BackEndLoad { get; init; } 
    #else
    public System.String BackEndLoad { get; set; } 
    #endif
    
    /// <summary>
    /// If a separate fee for switching between sub-funds of the same umbrella can be applied.
    /// </summary>
    [IsoId("_ScM6stp-Ed-ak6NoX_4Aeg_159175259")]
    [DisplayName("Switch Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SwtchFee")]
    #endif
    [IsoXmlTag("SwtchFee")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator SwitchFee { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SwitchFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SwitchFee { get; init; } 
    #else
    public System.String SwitchFee { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the investment fund class is subject to the European Union Saving Directive.
    /// </summary>
    [IsoId("_ScM6s9p-Ed-ak6NoX_4Aeg_159175137")]
    [DisplayName("EU Savings Directive")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EUSvgsDrctv")]
    #endif
    [IsoXmlTag("EUSvgsDrctv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EUSavingsDirective1Code EUSavingsDirective { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EUSavingsDirective1Code EUSavingsDirective { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EUSavingsDirective1Code EUSavingsDirective { get; init; } 
    #else
    public EUSavingsDirective1Code EUSavingsDirective { get; set; } 
    #endif
    
    
    #nullable disable
    
}
