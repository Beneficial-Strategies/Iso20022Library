// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Plan that allows investors to schedule periodical investments or divestments, according to pre-defined criteria.
/// </summary>
[IsoId("_SsJ5oRRdEeOKWo1NF21OVw")]
[DisplayName("Investment Plan")]
public record InvestmentPlan8
{
    /// <summary>
    /// Frequency of the investment or divestment.
    /// </summary>
    [IsoId("_TSjyUxRdEeOKWo1NF21OVw")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public required Frequency20Choice_ Frequency { get; init; }

    /// <summary>
    /// Date the investment plan starts.
    /// </summary>
    [IsoId("_TSjyVRRdEeOKWo1NF21OVw")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// Date the investment plan stops.
    /// </summary>
    [IsoId("_TSjyVxRdEeOKWo1NF21OVw")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; }

    /// <summary>
    /// Amount of the periodical payments.
    /// </summary>
    [IsoId("_TSjyWRRdEeOKWo1NF21OVw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required UnitsOrAmount1Choice_ Quantity { get; init; }

    /// <summary>
    /// Indicates whether an ordered amount is a gross amount (including all charges, commissions, tax). If it is not a gross amount, the ordered amount is a net amount (amount to be invested or redeemed from the fund to which other elements will be added).
    /// </summary>
    [IsoId("_TSjyWxRdEeOKWo1NF21OVw")]
    [DisplayName("Gross Amount Indicator")]
    [IsoXmlTag("GrssAmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? GrossAmountIndicator { get; init; }

    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    [IsoId("_TSjyXRRdEeOKWo1NF21OVw")]
    [DisplayName("Income Preference")]
    [IsoXmlTag("IncmPref")]
    public IncomePreference1Code? IncomePreference { get; init; }

    /// <summary>
    /// Number of pre-paid instalment periods at the time the investment plan is created.
    /// </summary>
    [IsoId("_TSjyXxRdEeOKWo1NF21OVw")]
    [DisplayName("Initial Number Of Instalments")]
    [IsoXmlTag("InitlNbOfInstlmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? InitialNumberOfInstalments { get; init; }

    /// <summary>
    /// Total number of times the amount must be invested at the predefined frequency as of the start date of the investment plan.
    /// </summary>
    [IsoId("_TSjyYRRdEeOKWo1NF21OVw")]
    [DisplayName("Total Number Of Instalments")]
    [IsoXmlTag("TtlNbOfInstlmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberOfInstalments { get; init; }

    /// <summary>
    /// Indicates the rounding direction when an amount is to be spread over several funds.
    /// </summary>
    [IsoId("_TSjyYxRdEeOKWo1NF21OVw")]
    [DisplayName("Rounding Direction")]
    [IsoXmlTag("RndgDrctn")]
    public RoundingDirection1Code? RoundingDirection { get; init; }

    /// <summary>
    /// Security that an investment plan invests in, or from which the investment plan divests.
    /// </summary>
    [IsoId("_TSjyZRRdEeOKWo1NF21OVw")]
    [DisplayName("Security Details")]
    [IsoXmlTag("SctyDtls")]
    [MinLength(1)]
    [MaxLength(50)]
    public ValueList<Repartition2> SecurityDetails { get; init; } = [];

    /// <summary>
    /// Cash settlement standing instruction associated to the investment plan and to be either inserted or deleted.
    /// </summary>
    [IsoId("_TSjyZxRdEeOKWo1NF21OVw")]
    [DisplayName("Modified Cash Settlement")]
    [IsoXmlTag("ModfdCshSttlm")]
    [MinLength(0)]
    [MaxLength(8)]
    public ValueList<InvestmentFundCashSettlementInformation8> ModifiedCashSettlement { get; init; } =
        [];

    /// <summary>
    /// Reference of the underlying investment contract. In some markets, such as Italy, this might be required to segregate holdings between the same investment account.
    /// </summary>
    [IsoId("_TSjyaRRdEeOKWo1NF21OVw")]
    [DisplayName("Contract Reference")]
    [IsoXmlTag("CtrctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ContractReference { get; init; }

    /// <summary>
    /// Reference of the previous contract to which this savings or withdrawal plan is related.
    /// </summary>
    [IsoId("_TSjyaxRdEeOKWo1NF21OVw")]
    [DisplayName("Related Contract Reference")]
    [IsoXmlTag("RltdCtrctRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RelatedContractReference { get; init; }

    /// <summary>
    /// Identification of the product as designated by the fund manager. In some markets, such as Italy, the financial product or service related to a savings plan or withdrawal plan are identified by a product identification or number.
    /// </summary>
    [IsoId("_TSjybRRdEeOKWo1NF21OVw")]
    [DisplayName("Product Identification")]
    [IsoXmlTag("PdctId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProductIdentification { get; init; }

    /// <summary>
    /// Reference of the underlying service level agreement (SLA) governing charges and commission.
    /// </summary>
    [IsoId("_TSjybxRdEeOKWo1NF21OVw")]
    [DisplayName("SLA Charge And Commission Reference")]
    [IsoXmlTag("SLAChrgAndComssnRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SLAChargeAndCommissionReference { get; init; }

    /// <summary>
    /// Specifies the type of insurance contract to which the savings investment plan is linked.
    /// </summary>
    [IsoId("_TSjycRRdEeOKWo1NF21OVw")]
    [DisplayName("Insurance Cover")]
    [IsoXmlTag("InsrncCover")]
    public InsuranceType1Choice_? InsuranceCover { get; init; }
}
