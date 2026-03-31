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
[IsoId("_ZvugheXsEemEj48jhmlA0Q")]
[DisplayName("Cash Option")]
public record CashOption71
{
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    [IsoId("_aAYyu-XsEemEj48jhmlA0Q")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Specifies exceptions to contractual payment service.
    /// </summary>
    [IsoId("_aAYyw-XsEemEj48jhmlA0Q")]
    [DisplayName("Contractual Payment Indicator")]
    [IsoXmlTag("CtrctlPmtInd")]
    public Payment2Code? ContractualPaymentIndicator { get; init; }

    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    [IsoId("_aAYyxeXsEemEj48jhmlA0Q")]
    [DisplayName("Non Eligible Proceeds Indicator")]
    [IsoXmlTag("NonElgblPrcdsInd")]
    public NonEligibleProceedsIndicator3Choice_? NonEligibleProceedsIndicator { get; init; }

    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    [IsoId("_aAYyzeXsEemEj48jhmlA0Q")]
    [DisplayName("Issuer Offeror Taxability Indicator")]
    [IsoXmlTag("IssrOfferrTaxbltyInd")]
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; init; }

    /// <summary>
    /// Specifies the type of income.
    /// </summary>
    [IsoId("_aAYyz-XsEemEj48jhmlA0Q")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification30? IncomeType { get; init; }

    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    [IsoId("_aAYy1-XsEemEj48jhmlA0Q")]
    [DisplayName("Exemption Type")]
    [IsoXmlTag("XmptnTp")]
    public ValueList<GenericIdentification30> ExemptionType { get; init; } = [];

    /// <summary>
    /// Indicates the country from which the income originates.
    /// </summary>
    [IsoId("_aAYy2eXsEemEj48jhmlA0Q")]
    [DisplayName("Country Of Income Source")]
    [IsoXmlTag("CtryOfIncmSrc")]
    public CountryCode? CountryOfIncomeSource { get; init; }

    /// <summary>
    /// Identification of the account in which cash is maintained.
    /// </summary>
    [IsoId("_aAYy2-XsEemEj48jhmlA0Q")]
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public CashAccountIdentification5Choice_? CashAccountIdentification { get; init; }

    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    [IsoId("_aAYy4-XsEemEj48jhmlA0Q")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public CorporateActionAmounts54? AmountDetails { get; init; }

    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    [IsoId("_aAYy6-XsEemEj48jhmlA0Q")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required CorporateActionDate62 DateDetails { get; init; }

    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    [IsoId("_aAYy8-XsEemEj48jhmlA0Q")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms24? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    [IsoId("_aAYy--XsEemEj48jhmlA0Q")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public Rate36? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    [IsoId("_aAYy_eXsEemEj48jhmlA0Q")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceDetails22? PriceDetails { get; init; }
}
