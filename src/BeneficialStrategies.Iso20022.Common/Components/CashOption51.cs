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
[IsoId("_xfTfcYl0EeavwKddCbm3hg")]
[DisplayName("Cash Option")]
public record CashOption51
{
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_x3sxWYl0EeavwKddCbm3hg")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
    /// </summary>
    [IsoId("_x3sxYYl0EeavwKddCbm3hg")]
    [DisplayName("Contractual Payment Indicator")]
    [IsoXmlTag("CtrctlPmtInd")]
    public Payment1Code? ContractualPaymentIndicator { get; init; }

    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    [IsoId("_x3sxaYl0EeavwKddCbm3hg")]
    [DisplayName("Non Eligible Proceeds Indicator")]
    [IsoXmlTag("NonElgblPrcdsInd")]
    public NonEligibleProceedsIndicator3Choice_? NonEligibleProceedsIndicator { get; init; }

    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    [IsoId("_x3sxcYl0EeavwKddCbm3hg")]
    [DisplayName("Issuer Offeror Taxability Indicator")]
    [IsoXmlTag("IssrOfferrTaxbltyInd")]
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; init; }

    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_x3sxc4l0EeavwKddCbm3hg")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification30? IncomeType { get; init; }

    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    [IsoId("_x3sxe4l0EeavwKddCbm3hg")]
    [DisplayName("Exemption Type")]
    [IsoXmlTag("XmptnTp")]
    public ValueList<GenericIdentification30> ExemptionType { get; init; } = [];

    /// <summary>
    /// Indicates the country from which the income originates.
    /// </summary>
    [IsoId("_x3sxfYl0EeavwKddCbm3hg")]
    [DisplayName("Country Of Income Source")]
    [IsoXmlTag("CtryOfIncmSrc")]
    public CountryCode? CountryOfIncomeSource { get; init; }

    /// <summary>
    /// Identification of the account in which cash is maintained.
    /// </summary>
    [IsoId("_x3sxf4l0EeavwKddCbm3hg")]
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public CashAccountIdentification5Choice_? CashAccountIdentification { get; init; }

    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    [IsoId("_x3sxh4l0EeavwKddCbm3hg")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public CorporateActionAmounts38? AmountDetails { get; init; }

    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    [IsoId("_x3sxj4l0EeavwKddCbm3hg")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required CorporateActionDate47 DateDetails { get; init; }

    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    [IsoId("_x3sxl4l0EeavwKddCbm3hg")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms24? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    [IsoId("_x3sxn4l0EeavwKddCbm3hg")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public RateDetails26? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_x3sxoYl0EeavwKddCbm3hg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceDetails22? PriceDetails { get; init; }
}
