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
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
[IsoId("_SOTuYTf4Eei6RvewLQWEqw")]
[DisplayName("Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument66
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether it is possible to hold bearer units/shares in this class in certified form.
    /// </summary>
    [IsoId("_SerFpzf4Eei6RvewLQWEqw")]
    [DisplayName("Physical Bearer Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysBrScties")]
    #endif
    [IsoXmlTag("PhysBrScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PhysicalBearerSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PhysicalBearerSecurities { get; init; } 
    #else
    public System.String? PhysicalBearerSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether it is possible to hold bearer units/shares in paperless form.
    /// </summary>
    [IsoId("_SerFqTf4Eei6RvewLQWEqw")]
    [DisplayName("Dematerialised Bearer Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmtrlsdBrScties")]
    #endif
    [IsoXmlTag("DmtrlsdBrScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DematerialisedBearerSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DematerialisedBearerSecurities { get; init; } 
    #else
    public System.String? DematerialisedBearerSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether it is possible to hold registered units/shares in this class in paperless form.
    /// </summary>
    [IsoId("_SerFqzf4Eei6RvewLQWEqw")]
    [DisplayName("Physical Registered Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysRegdScties")]
    #endif
    [IsoXmlTag("PhysRegdScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PhysicalRegisteredSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PhysicalRegisteredSecurities { get; init; } 
    #else
    public System.String? PhysicalRegisteredSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether it is possible to hold registered units/shares in this class in paperless form.
    /// </summary>
    [IsoId("_SerFrTf4Eei6RvewLQWEqw")]
    [DisplayName("Dematerialised Registered Securities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmtrlsdRegdScties")]
    #endif
    [IsoXmlTag("DmtrlsdRegdScties")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DematerialisedRegisteredSecurities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DematerialisedRegisteredSecurities { get; init; } 
    #else
    public System.String? DematerialisedRegisteredSecurities { get; set; } 
    #endif
    
    /// <summary>
    /// Income policy relating to the class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_SerFrzf4Eei6RvewLQWEqw")]
    [DisplayName("Distribution Policy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstrbtnPlcy")]
    #endif
    [IsoXmlTag("DstrbtnPlcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    #else
    public DistributionPolicy1Code? DistributionPolicy { get; set; } 
    #endif
    
    /// <summary>
    /// Dividend policy of the fund, for example, cash, units.
    /// </summary>
    [IsoId("_SerFsTf4Eei6RvewLQWEqw")]
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
    [IsoId("_SerFszf4Eei6RvewLQWEqw")]
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
    /// Frequency with which the reinvestment takes place, this is the same or less than the dividend frequency.
    /// </summary>
    [IsoId("_SerFtTf4Eei6RvewLQWEqw")]
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
    /// Indicates whether a front end charge on subscription orders for this class can be applied.
    /// </summary>
    [IsoId("_SerFtzf4Eei6RvewLQWEqw")]
    [DisplayName("Front End Load")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrntEndLd")]
    #endif
    [IsoXmlTag("FrntEndLd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? FrontEndLoad { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FrontEndLoad { get; init; } 
    #else
    public System.String? FrontEndLoad { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether an exit charge (for example, CDSC) on redemption orders for this class can be applied.
    /// </summary>
    [IsoId("_SerFuTf4Eei6RvewLQWEqw")]
    [DisplayName("Back End Load")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BckEndLd")]
    #endif
    [IsoXmlTag("BckEndLd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? BackEndLoad { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BackEndLoad { get; init; } 
    #else
    public System.String? BackEndLoad { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a separate fee for switching between sub-funds of the same umbrella can be applied.
    /// </summary>
    [IsoId("_SerFuzf4Eei6RvewLQWEqw")]
    [DisplayName("Switch Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SwtchFee")]
    #endif
    [IsoXmlTag("SwtchFee")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SwitchFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SwitchFee { get; init; } 
    #else
    public System.String? SwitchFee { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the investment fund class is subject to the European Union Saving Directive.
    /// </summary>
    [IsoId("_SerFvTf4Eei6RvewLQWEqw")]
    [DisplayName("EU Savings Directive")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EUSvgsDrctv")]
    #endif
    [IsoXmlTag("EUSvgsDrctv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EUSavingsDirective1Code? EUSavingsDirective { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EUSavingsDirective1Code? EUSavingsDirective { get; init; } 
    #else
    public EUSavingsDirective1Code? EUSavingsDirective { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the fund is open for investment.
    /// </summary>
    [IsoId("_dbUTUGAOEeiNMJ262H2pWg")]
    [DisplayName("Launch Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LnchDt")]
    #endif
    [IsoXmlTag("LnchDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? LaunchDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? LaunchDate { get; init; } 
    #else
    public System.DateOnly? LaunchDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the fund is closed to investment.
    /// </summary>
    [IsoId("_hlU1oGAOEeiNMJ262H2pWg")]
    [DisplayName("Fund End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndEndDt")]
    #endif
    [IsoXmlTag("FndEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FundEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FundEndDate { get; init; } 
    #else
    public System.DateOnly? FundEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date the fund closes.
    /// </summary>
    [IsoId("_nm8Z0GAOEeiNMJ262H2pWg")]
    [DisplayName("Termination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnDt")]
    #endif
    [IsoXmlTag("TermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TerminationDate { get; init; } 
    #else
    public System.DateOnly? TerminationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the discount period of the newly launched investment fund ends.
    /// </summary>
    [IsoId("_sjGKwGAOEeiNMJ262H2pWg")]
    [DisplayName("Initial Offer End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlOfferEndDt")]
    #endif
    [IsoXmlTag("InitlOfferEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? InitialOfferEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? InitialOfferEndDate { get; init; } 
    #else
    public System.DateOnly? InitialOfferEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which valuation of the investment fund class is suspended.
    /// </summary>
    [IsoId("_0h-s4GAOEeiNMJ262H2pWg")]
    [DisplayName("Suspension Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SspnsnStartDt")]
    #endif
    [IsoXmlTag("SspnsnStartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SuspensionStartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SuspensionStartDate { get; init; } 
    #else
    public System.DateOnly? SuspensionStartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which valuation of the investment fund class is unsuspended.
    /// </summary>
    [IsoId("_4LaRsGAOEeiNMJ262H2pWg")]
    [DisplayName("Suspension End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SspnsnEndDt")]
    #endif
    [IsoXmlTag("SspnsnEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SuspensionEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SuspensionEndDate { get; init; } 
    #else
    public System.DateOnly? SuspensionEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Maturity date of the product. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00065. In EMT v1, the element Maturity Date is reference 05090.
    /// </summary>
    [IsoId("_JolpEYBiEei8Q7I_11BpAQ")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MaturityDate { get; init; } 
    #else
    public System.DateOnly? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the fund is close-ended.
    /// </summary>
    [IsoId("_8w-HkGAOEeiNMJ262H2pWg")]
    [DisplayName("Closed End Fund")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsdEndFnd")]
    #endif
    [IsoXmlTag("ClsdEndFnd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ClosedEndFund { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClosedEndFund { get; init; } 
    #else
    public System.String? ClosedEndFund { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether equalisation is applied.
    /// </summary>
    [IsoId("_B4yV8GAPEeiNMJ262H2pWg")]
    [DisplayName("Equalisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Equlstn")]
    #endif
    [IsoXmlTag("Equlstn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Equalisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Equalisation { get; init; } 
    #else
    public System.String? Equalisation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the fund is eligible for a tax efficient product.
    /// </summary>
    [IsoId("_InaKEGAPEeiNMJ262H2pWg")]
    [DisplayName("Tax Efficient Product Eligible")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxEffcntPdctElgbl")]
    #endif
    [IsoXmlTag("TaxEffcntPdctElgbl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TaxEfficientProductEligible { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxEfficientProductEligible { get; init; } 
    #else
    public System.String? TaxEfficientProductEligible { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the fund is authorised by the regulatory compliance authority.
    /// </summary>
    [IsoId("_McY3kGAPEeiNMJ262H2pWg")]
    [DisplayName("Authorised")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Authrsd")]
    #endif
    [IsoXmlTag("Authrsd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Authorised { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Authorised { get; init; } 
    #else
    public System.String? Authorised { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the fund is compliant with the Retail Distribution Review (RDR).
    /// </summary>
    [IsoId("_QT8X8GAPEeiNMJ262H2pWg")]
    [DisplayName("RDR Compliant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RDRCmplnt")]
    #endif
    [IsoXmlTag("RDRCmplnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RDRCompliant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RDRCompliant { get; init; } 
    #else
    public System.String? RDRCompliant { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies from where the management fee is taken.
    /// </summary>
    [IsoId("_T2Oy8GAPEeiNMJ262H2pWg")]
    [DisplayName("Management Fee Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MgmtFeeSrc")]
    #endif
    [IsoXmlTag("MgmtFeeSrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AnnualChargePaymentType1Code? ManagementFeeSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AnnualChargePaymentType1Code? ManagementFeeSource { get; init; } 
    #else
    public AnnualChargePaymentType1Code? ManagementFeeSource { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is a performance fee feature. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00045.
    /// </summary>
    [IsoId("_pAPSkGAPEeiNMJ262H2pWg")]
    [DisplayName("Performance Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrfrmncFee")]
    #endif
    [IsoXmlTag("PrfrmncFee")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PerformanceFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PerformanceFee { get; init; } 
    #else
    public System.String? PerformanceFee { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the fund.
    /// </summary>
    [IsoId("_OKRH8WAKEeiNMJ262H2pWg")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
