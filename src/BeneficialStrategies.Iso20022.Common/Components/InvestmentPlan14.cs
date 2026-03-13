// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Plan that allows investors to schedule periodical investments or divestments, according to pre-defined criteria.
/// </summary>
[IsoId("_q3k0QU_eEeaB8-OWTiMVrQ")]
[DisplayName("Investment Plan")]
public partial record InvestmentPlan14
{
    #nullable enable
    
    /// <summary>
    /// Frequency of the investment or divestment.
    /// </summary>
    [IsoId("_rQayFU_eEeaB8-OWTiMVrQ")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency20Choice_ Frequency { get; init; } 
    
    /// <summary>
    /// Date the investment plan starts.
    /// </summary>
    [IsoId("_rQayF0_eEeaB8-OWTiMVrQ")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; } 
    
    /// <summary>
    /// Date the investment plan stops.
    /// </summary>
    [IsoId("_rQayGU_eEeaB8-OWTiMVrQ")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; } 
    
    /// <summary>
    /// Amount of the periodical payments.
    /// </summary>
    [IsoId("_rQayG0_eEeaB8-OWTiMVrQ")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required UnitsOrAmount1Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Indicates whether an ordered amount is a gross amount (including transaction overhead). If it is not a gross amount, the ordered amount is a net amount (amount to be invested or redeemed from the fund to which other elements will be added).
    /// </summary>
    [IsoId("_rQayHU_eEeaB8-OWTiMVrQ")]
    [DisplayName("Gross Amount Indicator")]
    [IsoXmlTag("GrssAmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? GrossAmountIndicator { get; init; } 
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_rQayH0_eEeaB8-OWTiMVrQ")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference2Code? IncomePreference { get; init; } 
    
    /// <summary>
    /// Initial amount or number of initial instalments.
    /// </summary>
    [IsoId("_rQayIU_eEeaB8-OWTiMVrQ")]
    [DisplayName("Initial Amount")]
    [IsoXmlTag("InitlAmt")]
    public InitialAmount1Choice_? InitialAmount { get; init; } 
    
    /// <summary>
    /// Total number of times the amount must be invested at the predefined frequency as of the start date of the investment plan.
    /// </summary>
    [IsoId("_rQayI0_eEeaB8-OWTiMVrQ")]
    [DisplayName("Total Number Of Instalments")]
    [IsoXmlTag("TtlNbOfInstlmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfInstalments { get; init; } 
    
    /// <summary>
    /// Indicates the rounding direction when an amount is to be spread over several funds.
    /// </summary>
    [IsoId("_rQayJU_eEeaB8-OWTiMVrQ")]
    [DisplayName("Rounding Direction")]
    [IsoXmlTag("RndgDrctn")]
    public RoundingDirection1Code? RoundingDirection { get; init; } 
    
    /// <summary>
    /// Security that an investment plan invests in, or from which the investment plan divests.
    /// </summary>
    [IsoId("_rQayJ0_eEeaB8-OWTiMVrQ")]
    [DisplayName("Security Details")]
    [IsoXmlTag("SctyDtls")]
    [MinLength(1)]
    [MaxLength(50)]
    public ValueList<Repartition5> SecurityDetails { get; init; } = [];
    
    /// <summary>
    /// Cash settlement standing instruction associated to the investment plan.
    /// </summary>
    [IsoId("_rQayKU_eEeaB8-OWTiMVrQ")]
    [DisplayName("Cash Settlement")]
    [IsoXmlTag("CshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<CashSettlement1> CashSettlement { get; init; } = [];
    
    /// <summary>
    /// Reference of the underlying investment contract. In some markets, such as Italy, this might be required to segregate holdings between the same investment account.
    /// </summary>
    [IsoId("_rQayK0_eEeaB8-OWTiMVrQ")]
    [DisplayName("Contract Reference")]
    [IsoXmlTag("CtrctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ContractReference { get; init; } 
    
    /// <summary>
    /// Reference of the previous contract to which this savings or withdrawal plan is related.
    /// </summary>
    [IsoId("_rQayLU_eEeaB8-OWTiMVrQ")]
    [DisplayName("Related Contract Reference")]
    [IsoXmlTag("RltdCtrctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RelatedContractReference { get; init; } 
    
    /// <summary>
    /// Identification of the product as designated by the fund manager. In some markets, such as Italy, the financial product or service related to a savings plan or withdrawal plan are identified by a product identification or number.
    /// </summary>
    [IsoId("_rQayL0_eEeaB8-OWTiMVrQ")]
    [DisplayName("Product Identification")]
    [IsoXmlTag("PdctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProductIdentification { get; init; } 
    
    /// <summary>
    /// Reference of the underlying service level agreement (SLA) governing fees.
    /// </summary>
    [IsoId("_rQayMU_eEeaB8-OWTiMVrQ")]
    [DisplayName("SLA Charge And Commission Reference")]
    [IsoXmlTag("SLAChrgAndComssnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SLAChargeAndCommissionReference { get; init; } 
    
    /// <summary>
    /// Specifies the type of insurance contract to which the savings investment plan is linked.
    /// </summary>
    [IsoId("_rQayM0_eEeaB8-OWTiMVrQ")]
    [DisplayName("Insurance Cover")]
    [IsoXmlTag("InsrncCover")]
    public InsuranceType2Choice_? InsuranceCover { get; init; } 
    
    /// <summary>
    /// Status of the savings or withdrawal investment plan.
    /// </summary>
    [IsoId("_rQayNU_eEeaB8-OWTiMVrQ")]
    [DisplayName("Plan Status")]
    [IsoXmlTag("PlanSts")]
    public PlanStatus2Choice_? PlanStatus { get; init; } 
    
    /// <summary>
    /// Role or function of the instalment manager.
    /// </summary>
    [IsoId("_rQayN0_eEeaB8-OWTiMVrQ")]
    [DisplayName("Instalment Manager Role")]
    [IsoXmlTag("InstlmtMgrRole")]
    public PartyRole4Choice_? InstalmentManagerRole { get; init; } 
    
    
    #nullable disable
    
}
