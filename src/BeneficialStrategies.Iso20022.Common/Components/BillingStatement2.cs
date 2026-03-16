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
[IsoId("_arIxfTq2EeWZFYSPlduMhw")]
[DisplayName("Billing Statement")]
public record BillingStatement2
{
    /// <summary>
    /// Identification of the customer billing statement.
    /// </summary>
    [IsoId("_ayMbsTq2EeWZFYSPlduMhw")]
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text StatementIdentification { get; init; }

    /// <summary>
    /// Date range between the start date and the end date for which the statement is issued.
    /// </summary>
    [IsoId("_ayMbszq2EeWZFYSPlduMhw")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public required DatePeriod1 FromToDate { get; init; }

    /// <summary>
    /// Date the statement message was created.
    /// </summary>
    [IsoId("_ayMbtTq2EeWZFYSPlduMhw")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Defines the status of the statement.
    /// </summary>
    [IsoId("_ayMbtzq2EeWZFYSPlduMhw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required BillingStatementStatus1Code Status { get; init; }

    /// <summary>
    /// Specifies the details of the account characteristics.
    /// </summary>
    [IsoId("_ayMbuTq2EeWZFYSPlduMhw")]
    [DisplayName("Account Characteristics")]
    [IsoXmlTag("AcctChrtcs")]
    public required CashAccountCharacteristics2 AccountCharacteristics { get; init; }

    /// <summary>
    /// Identifies the non tax per annum rate and factor values used within the statement along with any time dependent charge basis.
    /// </summary>
    [IsoId("_ayMbuzq2EeWZFYSPlduMhw")]
    [DisplayName("Rate Data")]
    [IsoXmlTag("RateData")]
    public BillingRate1? RateData { get; init; }

    /// <summary>
    /// Specifies details related to currency exchange data.
    /// </summary>
    [IsoId("_ayMbvTq2EeWZFYSPlduMhw")]
    [DisplayName("Currency Exchange")]
    [IsoXmlTag("CcyXchg")]
    public CurrencyExchange6? CurrencyExchange { get; init; }

    /// <summary>
    /// Identifies the average value of balances held within the statement period.
    /// </summary>
    [IsoId("_ayMbvzq2EeWZFYSPlduMhw")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public BillingBalance1? Balance { get; init; }

    /// <summary>
    /// Identifies the set of values and totals that are used to provide compensation information, service and tax totals.
    /// </summary>
    [IsoId("_ayMbwTq2EeWZFYSPlduMhw")]
    [DisplayName("Compensation")]
    [IsoXmlTag("Compstn")]
    public BillingCompensation1? Compensation { get; init; }

    /// <summary>
    /// Specifies the values used for every line item service in the statement.
    /// </summary>
    [IsoId("_ayMbwzq2EeWZFYSPlduMhw")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public BillingService2? Service { get; init; }

    /// <summary>
    /// Tax region(s) that levy a tax on the services within this statement.
    /// </summary>
    [IsoId("_ayMbxTq2EeWZFYSPlduMhw")]
    [DisplayName("Tax Region")]
    [IsoXmlTag("TaxRgn")]
    public BillingTaxRegion1? TaxRegion { get; init; }

    /// <summary>
    /// One or more sections that identify balance or float adjustments to the account. They can reflect either adjustments to the current statement or adjustments to statements from prior reporting periods.
    /// </summary>
    [IsoId("_ayMbxzq2EeWZFYSPlduMhw")]
    [DisplayName("Balance Adjustment")]
    [IsoXmlTag("BalAdjstmnt")]
    public BalanceAdjustment1? BalanceAdjustment { get; init; }

    /// <summary>
    /// One or more sections that identify line item service adjustments to the account. They reflect adjustments to statements from prior reporting periods.
    /// </summary>
    [IsoId("_ayMbyTq2EeWZFYSPlduMhw")]
    [DisplayName("Service Adjustment")]
    [IsoXmlTag("SvcAdjstmnt")]
    public BillingServiceAdjustment1? ServiceAdjustment { get; init; }
}
