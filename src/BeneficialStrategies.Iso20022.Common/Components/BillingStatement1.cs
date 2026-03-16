// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the statement reporting the bank services billing.
/// </summary>
[IsoId("_6QZvpZqlEeGSON8vddiWzQ_856759895")]
[DisplayName("Billing Statement")]
public record BillingStatement1
{
    /// <summary>
    /// Identification of the customer billing statement.
    /// </summary>
    [IsoId("_6QZvppqlEeGSON8vddiWzQ_-1768257610")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text StatementIdentification { get; init; }

    /// <summary>
    /// Date range between the start date and the end date for which the statement is issued.
    /// </summary>
    [IsoId("_6QZvp5qlEeGSON8vddiWzQ_-1590138938")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public required DatePeriod1 FromToDate { get; init; }

    /// <summary>
    /// Date the statement message was created.
    /// </summary>
    [IsoId("_6Qi5kJqlEeGSON8vddiWzQ_-1882096676")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Defines the status of the statement.
    /// </summary>
    [IsoId("_6Qi5kZqlEeGSON8vddiWzQ_-122990175")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required BillingStatementStatus1Code Status { get; init; }

    /// <summary>
    /// Specifies the details of the account characteristics.
    /// </summary>
    [IsoId("_6Qi5kpqlEeGSON8vddiWzQ_-1896816822")]
    [DisplayName("Account Characteristics")]
    [IsoXmlTag("AcctChrtcs")]
    public required CashAccountCharacteristics1 AccountCharacteristics { get; init; }

    /// <summary>
    /// Identifies the non tax per annum rate and factor values used within the statement along with any time dependent charge basis.
    /// </summary>
    [IsoId("_6Qi5k5qlEeGSON8vddiWzQ_1222959449")]
    [DisplayName("Rate Data")]
    [IsoXmlTag("RateData")]
    public BillingRate1? RateData { get; init; }

    /// <summary>
    /// Specifies details related to currency exchange data.
    /// </summary>
    [IsoId("_6Qi5lJqlEeGSON8vddiWzQ_1401078121")]
    [DisplayName("Currency Exchange")]
    [IsoXmlTag("CcyXchg")]
    public CurrencyExchange6? CurrencyExchange { get; init; }

    /// <summary>
    /// Identifies the average value of balances held within the statement period.
    /// </summary>
    [IsoId("_6Qi5lZqlEeGSON8vddiWzQ_1109120383")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public BillingBalance1? Balance { get; init; }

    /// <summary>
    /// Identifies the set of values and totals that are used to provide compensation information, service and tax totals.
    /// </summary>
    [IsoId("_6Qi5lpqlEeGSON8vddiWzQ_-1426740412")]
    [DisplayName("Compensation")]
    [IsoXmlTag("Compstn")]
    public BillingCompensation1? Compensation { get; init; }

    /// <summary>
    /// Specifies the values used for every line item service in the statement.
    /// </summary>
    [IsoId("_6Qi5l5qlEeGSON8vddiWzQ_-519065905")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public BillingService1? Service { get; init; }

    /// <summary>
    /// Tax region(s) that levy a tax on the services within this statement.
    /// </summary>
    [IsoId("_6Qi5mJqlEeGSON8vddiWzQ_1765944533")]
    [DisplayName("Tax Region")]
    [IsoXmlTag("TaxRgn")]
    public BillingTaxRegion1? TaxRegion { get; init; }

    /// <summary>
    /// One or more sections that identify balance or float adjustments to the account. They can reflect either adjustments to the current statement or adjustments to statements from prior reporting periods.
    /// </summary>
    [IsoId("_6QsqkJqlEeGSON8vddiWzQ_1944063205")]
    [DisplayName("Balance Adjustment")]
    [IsoXmlTag("BalAdjstmnt")]
    public BalanceAdjustment1? BalanceAdjustment { get; init; }

    /// <summary>
    /// One or more sections that identify line item service adjustments to the account. They reflect adjustments to statements from prior reporting periods.
    /// </summary>
    [IsoId("_6QsqkZqlEeGSON8vddiWzQ_1652105467")]
    [DisplayName("Service Adjustment")]
    [IsoXmlTag("SvcAdjstmnt")]
    public BillingServiceAdjustment1? ServiceAdjustment { get; init; }
}
