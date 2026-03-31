// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Securities Option104.
/// </summary>
[IsoId("_Ur8lJ3SdEe6VWZz2tTgENw")]
[DisplayName("Securities Option104")]
public record SecuritiesOption104
{
    /// <summary>
    /// Amount Details.
    /// </summary>
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public CorporateActionAmounts61? AmountDetails { get; init; }

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
    /// Currency Option.
    /// </summary>
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Date Details.
    /// </summary>
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required SecurityDate26 DateDetails { get; init; }

    /// <summary>
    /// Delivering Settlement Parties.
    /// </summary>
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties103? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Exemption Type.
    /// </summary>
    [DisplayName("Exemption Type")]
    [IsoXmlTag("XmptnTp")]
    public ValueList<GenericIdentification47> ExemptionType { get; init; } = [];

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Fraction Disposition.
    /// </summary>
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType30Choice_? FractionDisposition { get; init; }

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
    /// New Securities Issuance Indicator.
    /// </summary>
    [DisplayName("New Securities Issuance Indicator")]
    [IsoXmlTag("NewSctiesIssncInd")]
    public NewSecuritiesIssuanceType6Code? NewSecuritiesIssuanceIndicator { get; init; }

    /// <summary>
    /// Other Income Type.
    /// </summary>
    [DisplayName("Other Income Type")]
    [IsoXmlTag("OthrIncmTp")]
    public ValueList<GenericIdentification47> OtherIncomeType { get; init; } = [];

    /// <summary>
    /// Posting Quantity.
    /// </summary>
    [DisplayName("Posting Quantity")]
    [IsoXmlTag("PstngQty")]
    public required Quantity54Choice_ PostingQuantity { get; init; }

    /// <summary>
    /// Price Details.
    /// </summary>
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice78? PriceDetails { get; init; }

    /// <summary>
    /// Rate Details.
    /// </summary>
    [DisplayName("Rate Details")]
    [IsoXmlTag("RateDtls")]
    public CorporateActionRate114? RateDetails { get; init; }

    /// <summary>
    /// Receiving Settlement Parties.
    /// </summary>
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties103? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Safekeeping Place.
    /// </summary>
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat39Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Temporary Financial Instrument Indicator.
    /// </summary>
    [DisplayName("Temporary Financial Instrument Indicator")]
    [IsoXmlTag("TempFinInstrmInd")]
    public TemporaryFinancialInstrumentIndicator4Choice_? TemporaryFinancialInstrumentIndicator { get; init; }
}
