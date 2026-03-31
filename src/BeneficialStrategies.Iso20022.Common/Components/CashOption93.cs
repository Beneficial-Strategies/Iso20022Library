// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash Option93.
/// </summary>
[IsoId("_hvMsgWHmEe6yt_d72zQZeQ")]
[DisplayName("Cash Option93")]
public record CashOption93
{
    /// <summary>
    /// Amount Details.
    /// </summary>
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public CorporateActionAmounts64? AmountDetails { get; init; }

    /// <summary>
    /// Cash Account Identification.
    /// </summary>
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public CashAccountIdentification5Choice_? CashAccountIdentification { get; init; }

    /// <summary>
    /// Contractual Payment Indicator.
    /// </summary>
    [DisplayName("Contractual Payment Indicator")]
    [IsoXmlTag("CtrctlPmtInd")]
    public Payment1Code? ContractualPaymentIndicator { get; init; }

    /// <summary>
    /// Country Of Income Source.
    /// </summary>
    [DisplayName("Country Of Income Source")]
    [IsoXmlTag("CtryOfIncmSrc")]
    public CountryCode? CountryOfIncomeSource { get; init; }

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Date Details.
    /// </summary>
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required CorporateActionDate84 DateDetails { get; init; }

    /// <summary>
    /// Exemption Type.
    /// </summary>
    [DisplayName("Exemption Type")]
    [IsoXmlTag("XmptnTp")]
    public ValueList<GenericIdentification30> ExemptionType { get; init; } = [];

    /// <summary>
    /// Foreign Exchange Details.
    /// </summary>
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms24? ForeignExchangeDetails { get; init; }

    /// <summary>
    /// Income Type.
    /// </summary>
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification30? IncomeType { get; init; }

    /// <summary>
    /// Issuer Offeror Taxability Indicator.
    /// </summary>
    [DisplayName("Issuer Offeror Taxability Indicator")]
    [IsoXmlTag("IssrOfferrTaxbltyInd")]
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; init; }

    /// <summary>
    /// Non Eligible Proceeds Indicator.
    /// </summary>
    [DisplayName("Non Eligible Proceeds Indicator")]
    [IsoXmlTag("NonElgblPrcdsInd")]
    public NonEligibleProceedsIndicator3Choice_? NonEligibleProceedsIndicator { get; init; }

    /// <summary>
    /// Other Income Type.
    /// </summary>
    [DisplayName("Other Income Type")]
    [IsoXmlTag("OthrIncmTp")]
    public ValueList<GenericIdentification30> OtherIncomeType { get; init; } = [];

    /// <summary>
    /// Price Details.
    /// </summary>
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceDetails31? PriceDetails { get; init; }

    /// <summary>
    /// Rate And Amount Details.
    /// </summary>
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public Rate36? RateAndAmountDetails { get; init; }
}
