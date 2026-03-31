// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash Option110.
/// </summary>
[IsoId("_kv9o8Zt3Ee-wQIOX0djF2w")]
[DisplayName("Cash Option110")]
public record CashOption110
{
    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account11Choice_? Account { get; init; }

    /// <summary>
    /// Amount Details.
    /// </summary>
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public required CorporateActionAmounts74 AmountDetails { get; init; }

    /// <summary>
    /// Cash Parties.
    /// </summary>
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties44? CashParties { get; init; }

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
    public required CorporateActionDate99 DateDetails { get; init; }

    /// <summary>
    /// Exemption Type.
    /// </summary>
    [DisplayName("Exemption Type")]
    [IsoXmlTag("XmptnTp")]
    public ValueList<GenericIdentification47> ExemptionType { get; init; } = [];

    /// <summary>
    /// Foreign Exchange Details.
    /// </summary>
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ValueList<ForeignExchangeTerms41> ForeignExchangeDetails { get; init; } = [];

    /// <summary>
    /// Income Type.
    /// </summary>
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification47? IncomeType { get; init; }

    /// <summary>
    /// Issuer Offeror Taxability Indicator.
    /// </summary>
    [DisplayName("Issuer Offeror Taxability Indicator")]
    [IsoXmlTag("IssrOfferrTaxbltyInd")]
    public IssuerOfferorTaxabilityIndicator1Choice_? IssuerOfferorTaxabilityIndicator { get; init; }

    /// <summary>
    /// Other Income Type.
    /// </summary>
    [DisplayName("Other Income Type")]
    [IsoXmlTag("OthrIncmTp")]
    public ValueList<GenericIdentification47> OtherIncomeType { get; init; } = [];

    /// <summary>
    /// Price Details.
    /// </summary>
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public PriceDetails41? PriceDetails { get; init; }

    /// <summary>
    /// Rate And Amount Details.
    /// </summary>
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public Rate45? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Tax Voucher Details.
    /// </summary>
    [DisplayName("Tax Voucher Details")]
    [IsoXmlTag("TaxVchrDtls")]
    public TaxVoucher5? TaxVoucherDetails { get; init; }
}
