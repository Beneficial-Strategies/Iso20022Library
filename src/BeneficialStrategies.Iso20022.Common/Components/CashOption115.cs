// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
[IsoId("_jPlLAaLfEfCHi7w3_0pcpw")]
[DisplayName("Cash Option115")]
public record CashOption115
{
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_jWRB2aLfEfCHi7w3_0pcpw")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_jWRo4aLfEfCHi7w3_0pcpw")]
    [DisplayName("Non Eligible Proceeds Indicator")]
    [IsoXmlTag("NonElgblPrcdsInd")]
    public NonEligibleProceedsIndicator5Choice_? NonEligibleProceedsIndicator { get; init; }

    /// <summary>
    /// Specifies the type of income.
    /// </summary>
    [IsoId("_jWRo6aLfEfCHi7w3_0pcpw")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification30? IncomeType { get; init; }

    /// <summary>
    /// Type of income to be used under another tax regime.
    /// </summary>
    [IsoId("_jWRo8aLfEfCHi7w3_0pcpw")]
    [DisplayName("Other Income Type")]
    [IsoXmlTag("OthrIncmTp")]
    public ValueList<GenericIdentification30> OtherIncomeType { get; init; } = [];

    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    [IsoId("_jWRo86LfEfCHi7w3_0pcpw")]
    [DisplayName("Exemption Type")]
    [IsoXmlTag("XmptnTp")]
    public ValueList<GenericIdentification30> ExemptionType { get; init; } = [];

    /// <summary>
    /// Specifies the method applied for the calculation of the price.
    /// </summary>
    [IsoId("_jWRo9aLfEfCHi7w3_0pcpw")]
    [DisplayName("Price Calculation Method")]
    [IsoXmlTag("PricClctnMtd")]
    public PriceCalculationMethod2Choice_? PriceCalculationMethod { get; init; }

    /// <summary>
    /// Indicates the country from which the income originates.
    /// </summary>
    [IsoId("_jWRo96LfEfCHi7w3_0pcpw")]
    [DisplayName("Country Of Income Source")]
    [IsoXmlTag("CtryOfIncmSrc")]
    public CountryCode? CountryOfIncomeSource { get; init; }

    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    [IsoId("_jWRo-aLfEfCHi7w3_0pcpw")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public CorporateActionAmounts77? AmountDetails { get; init; }

    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    [IsoId("_jWRpAaLfEfCHi7w3_0pcpw")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required CorporateActionDate84 DateDetails { get; init; }

    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    [IsoId("_jWRpCaLfEfCHi7w3_0pcpw")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms39? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Indicates whether the rate is approximate.
    /// </summary>
    [IsoId("_jWRpEaLfEfCHi7w3_0pcpw")]
    [DisplayName("Estimated Rate Indicator")]
    [IsoXmlTag("EstmtdRateInd")]
    public IsoYesNoIndicator? EstimatedRateIndicator { get; init; }

    /// <summary>
    /// Indicates whether the income event is subject to withholding tax if paid to a non-U.S. resident alien (NRA).
    /// </summary>
    [IsoId("_jWRpGaLfEfCHi7w3_0pcpw")]
    [DisplayName("NRA Tax Reportable Indicator")]
    [IsoXmlTag("NRATaxRptblInd")]
    public IsoYesNoIndicator? NRATaxReportableIndicator { get; init; }

    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    [IsoId("_jWRpIaLfEfCHi7w3_0pcpw")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public Rate49? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_jWRpI6LfEfCHi7w3_0pcpw")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceDetails39? PriceDetails { get; init; }
}
