// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action security option.
/// </summary>
[IsoId("_K28J5UEEEeWVgfuHGaKtRQ")]
[DisplayName("Securities Option")]
public record SecuritiesOption50
{
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_LECKVUEEEeWVgfuHGaKtRQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_LECKXUEEEeWVgfuHGaKtRQ")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Specifies that the security identified is a temporary security identification used for processing reasons, for example, contra security used in the US.
    /// </summary>
    [IsoId("_LECKZUEEEeWVgfuHGaKtRQ")]
    [DisplayName("Temporary Financial Instrument Indicator")]
    [IsoXmlTag("TempFinInstrmInd")]
    public TemporaryFinancialInstrumentIndicator3Choice_? TemporaryFinancialInstrumentIndicator { get; init; }

    /// <summary>
    /// Indicates whether the securities are newly issued or not.
    /// </summary>
    [IsoId("_LECKbUEEEeWVgfuHGaKtRQ")]
    [DisplayName("New Securities Issuance Indicator")]
    [IsoXmlTag("NewSctiesIssncInd")]
    public NewSecuritiesIssuanceType6Code? NewSecuritiesIssuanceIndicator { get; init; }

    /// <summary>
    /// Proceeds are taxable according to the information provided by the issuer / offeror.
    /// </summary>
    [IsoId("_9txZkWOOEeW4z96Yfj3Wng")]
    [DisplayName("Issuer Offeror Taxability Indicator")]
    [IsoXmlTag("IssrOfferrTaxbltyInd")]
    public GenericIdentification30? IssuerOfferorTaxabilityIndicator { get; init; }

    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("__3mUNWOLEeW4z96Yfj3Wng")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification30? IncomeType { get; init; }

    /// <summary>
    /// Specifies the basis for the reduced rate of withholding.
    /// </summary>
    [IsoId("__3mUOWOLEeW4z96Yfj3Wng")]
    [DisplayName("Exemption Type")]
    [IsoXmlTag("XmptnTp")]
    public ValueList<GenericIdentification30> ExemptionType { get; init; } = [];

    /// <summary>
    /// Indicates the country from which the income originates.
    /// </summary>
    [IsoId("_EV6CoWXpEeWht50_j0HXAQ")]
    [DisplayName("Country Of Income Source")]
    [IsoXmlTag("CtryOfIncmSrc")]
    public CountryCode? CountryOfIncomeSource { get; init; }

    /// <summary>
    /// Quantity of securities that have been posted (credit or debit) to the safekeeping account.
    /// </summary>
    [IsoId("_LECKb0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Posting Quantity")]
    [IsoXmlTag("PstngQty")]
    public required Quantity6Choice_ PostingQuantity { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_LECKd0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat10Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_LECKf0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType27Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_LECKh0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Provides information about the dates related to securities movement.
    /// </summary>
    [IsoId("_LECKj0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required SecurityDate11 DateDetails { get; init; }

    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    [IsoId("_LECKl0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Details")]
    [IsoXmlTag("RateDtls")]
    public CorporateActionRate72? RateDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    [IsoId("_LECKn0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice59? PriceDetails { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_LECKp0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties42? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_LECKr0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties42? DeliveringSettlementParties { get; init; }
}
