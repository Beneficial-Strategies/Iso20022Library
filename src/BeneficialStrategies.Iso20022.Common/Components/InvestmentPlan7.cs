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
[IsoId("_VthHIRQrEeKebsB9eKJSkA")]
[DisplayName("Investment Plan")]
public partial record InvestmentPlan7
{
    #nullable enable
    
    /// <summary>
    /// Frequency of the investment or divestment.
    /// </summary>
    [IsoId("_oIH_BRdREeK5g-3oYI0_9Q")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency19Choice_ Frequency { get; init; } 
    
    /// <summary>
    /// Date the investment plan starts.
    /// </summary>
    [IsoId("_WC0o0RQrEeKebsB9eKJSkA")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; } 
    
    /// <summary>
    /// Date the investment plan stops.
    /// </summary>
    [IsoId("_WC0o1RQrEeKebsB9eKJSkA")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; } 
    
    /// <summary>
    /// Amount of the periodical payments.
    /// </summary>
    [IsoId("_Lr7Q9RQsEeKebsB9eKJSkA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required UnitsOrAmount1Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Indicates whether an ordered amount is a gross amount (including all charges, commissions, tax). If it is not a gross amount, the ordered amount is a net amount (amount to be invested or redeemed from the fund to which other elements will be added).
    /// </summary>
    [IsoId("_WC0o3RQrEeKebsB9eKJSkA")]
    [DisplayName("Gross Amount Indicator")]
    [IsoXmlTag("GrssAmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? GrossAmountIndicator { get; init; } 
    
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_WC0o4RQrEeKebsB9eKJSkA")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; } 
    
    /// <summary>
    /// Number of pre-paid instalment periods at the time the investment plan is created.
    /// </summary>
    [IsoId("_WC0o5RQrEeKebsB9eKJSkA")]
    [DisplayName("Initial Number Of Instalment")]
    [IsoXmlTag("InitlNbOfInstlmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? InitialNumberOfInstalment { get; init; } 
    
    /// <summary>
    /// Total number of times the amount must be invested at the predefined frequency as of the start date of the investment plan.
    /// </summary>
    [IsoId("_WC0o6RQrEeKebsB9eKJSkA")]
    [DisplayName("Total Number Of Instalment")]
    [IsoXmlTag("TtlNbOfInstlmt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfInstalment { get; init; } 
    
    /// <summary>
    /// Indicates the rounding direction when an amount is to be spread over several funds.
    /// </summary>
    [IsoId("_WC0o7RQrEeKebsB9eKJSkA")]
    [DisplayName("Rounding Direction")]
    [IsoXmlTag("RndgDrctn")]
    public RoundingDirection1Code? RoundingDirection { get; init; } 
    
    /// <summary>
    /// Security that an investment plan invests in, or from which the investment plan divests.
    /// </summary>
    [IsoId("_WC0o8RQrEeKebsB9eKJSkA")]
    [DisplayName("Security Details")]
    [IsoXmlTag("SctyDtls")]
    [MinLength(1)]
    [MaxLength(50)]
    public ValueList<Repartition2> SecurityDetails { get; init; } = [];
    
    /// <summary>
    /// Cash settlement standing instruction associated to the investment plan and to be either inserted or deleted.
    /// </summary>
    [IsoId("_WC0o9RQrEeKebsB9eKJSkA")]
    [DisplayName("Modified Cash Settlement")]
    [IsoXmlTag("ModfdCshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<InvestmentFundCashSettlementInformation6> ModifiedCashSettlement { get; init; } = [];
    
    /// <summary>
    /// Reference of the underlying investment contract. In some markets, such as Italy, this might be required to segregate holdings between the same investment account.
    /// </summary>
    [IsoId("_hEbVDhQrEeKebsB9eKJSkA")]
    [DisplayName("Contract Reference")]
    [IsoXmlTag("CtrctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ContractReference { get; init; } 
    
    /// <summary>
    /// Reference of the previous contract to which this savings or withdrawal plan is related.
    /// </summary>
    [IsoId("_hEbVExQrEeKebsB9eKJSkA")]
    [DisplayName("Related Contract Reference")]
    [IsoXmlTag("RltdCtrctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RelatedContractReference { get; init; } 
    
    /// <summary>
    /// Identification of the product as designated by the fund manager. In some markets, such as Italy, the financial product or service related to a savings plan or withdrawal plan are identified by a product identification or number.
    /// </summary>
    [IsoId("_hEbVGBQrEeKebsB9eKJSkA")]
    [DisplayName("Product Identification")]
    [IsoXmlTag("PdctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProductIdentification { get; init; } 
    
    /// <summary>
    /// Reference of the underlying service level agreement (SLA) governing charges and commission.
    /// </summary>
    [IsoId("_hEbVHRQrEeKebsB9eKJSkA")]
    [DisplayName("SLA Charge And Commission Reference")]
    [IsoXmlTag("SLAChrgAndComssnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SLAChargeAndCommissionReference { get; init; } 
    
    /// <summary>
    /// Specifies the type of insurance contract to which the savings investment plan is linked.
    /// </summary>
    [IsoId("_B5mbRRQsEeKebsB9eKJSkA")]
    [DisplayName("Insurance Cover")]
    [IsoXmlTag("InsrncCover")]
    public InsuranceType1Choice_? InsuranceCover { get; init; } 
    
    
    #nullable disable
    
}
