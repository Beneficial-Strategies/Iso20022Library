// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Billing Statement5.
/// </summary>
[IsoId("_xdpU0TEyEe6g-ffJsqGiSA")]
[DisplayName("Billing Statement5")]
public record BillingStatement5
{
    /// <summary>
    /// Statement Identification.
    /// </summary>
    [DisplayName("Statement Identification")]
    [IsoXmlTag("StmtId")]
    public required Max35Text StatementIdentification { get; init; }

    /// <summary>
    /// From To Date.
    /// </summary>
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public required DatePeriod1 FromToDate { get; init; }

    /// <summary>
    /// Creation Date Time.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required ISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required BillingStatementStatus1Code Status { get; init; }

    /// <summary>
    /// Account Characteristics.
    /// </summary>
    [DisplayName("Account Characteristics")]
    [IsoXmlTag("AcctChrtcs")]
    public required CashAccountCharacteristics5 AccountCharacteristics { get; init; }

    /// <summary>
    /// Rate Data.
    /// </summary>
    [DisplayName("Rate Data")]
    [IsoXmlTag("RateData")]
    public ValueList<BillingRate1> RateData { get; init; } = [];

    /// <summary>
    /// Currency Exchange.
    /// </summary>
    [DisplayName("Currency Exchange")]
    [IsoXmlTag("CcyXchg")]
    public ValueList<CurrencyExchange6> CurrencyExchange { get; init; } = [];

    /// <summary>
    /// Balance.
    /// </summary>
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<BillingBalance1> Balance { get; init; } = [];

    /// <summary>
    /// Compensation.
    /// </summary>
    [DisplayName("Compensation")]
    [IsoXmlTag("Compstn")]
    public ValueList<BillingCompensation1> Compensation { get; init; } = [];

    /// <summary>
    /// Service.
    /// </summary>
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public ValueList<BillingService2> Service { get; init; } = [];

    /// <summary>
    /// Tax Region.
    /// </summary>
    [DisplayName("Tax Region")]
    [IsoXmlTag("TaxRgn")]
    public ValueList<BillingTaxRegion3> TaxRegion { get; init; } = [];

    /// <summary>
    /// Balance Adjustment.
    /// </summary>
    [DisplayName("Balance Adjustment")]
    [IsoXmlTag("BalAdjstmnt")]
    public ValueList<BalanceAdjustment1> BalanceAdjustment { get; init; } = [];

    /// <summary>
    /// Service Adjustment.
    /// </summary>
    [DisplayName("Service Adjustment")]
    [IsoXmlTag("SvcAdjstmnt")]
    public ValueList<BillingServiceAdjustment1> ServiceAdjustment { get; init; } = [];
}
