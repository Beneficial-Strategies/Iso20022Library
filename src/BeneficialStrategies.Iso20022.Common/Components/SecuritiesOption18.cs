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
[IsoId("_uXkz4fL9Ed-3lpUMQaXLjQ")]
[DisplayName("Securities Option")]
public record SecuritiesOption18
{
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_uXkz4_L9Ed-3lpUMQaXLjQ")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification14 SecurityIdentification { get; init; }

    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_uXkz5fL9Ed-3lpUMQaXLjQ")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Specifies that the security identified is a temporary security identification used for processing reasons, for example, contra security used in the US.
    /// </summary>
    [IsoId("_uXkz5_L9Ed-3lpUMQaXLjQ")]
    [DisplayName("Temporary Financial Instrument Indicator")]
    [IsoXmlTag("TempFinInstrmInd")]
    public TemporaryFinancialInstrumentIndicator1Choice_? TemporaryFinancialInstrumentIndicator { get; init; }

    /// <summary>
    /// Quantity of securities that have been posted (credit or debit) to the safekeeping account.
    /// </summary>
    [IsoId("_uXkz6fL9Ed-3lpUMQaXLjQ")]
    [DisplayName("Posting Quantity")]
    [IsoXmlTag("PstngQty")]
    public required Quantity6Choice_ PostingQuantity { get; init; }

    /// <summary>
    /// Location where the financial instruments are/will be safekept.
    /// </summary>
    [IsoId("_uXkz6_L9Ed-3lpUMQaXLjQ")]
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; }

    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_uXkz7fL9Ed-3lpUMQaXLjQ")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType4Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    [IsoId("_uXkz7_L9Ed-3lpUMQaXLjQ")]
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Provides information about the dates related to securities movement.
    /// </summary>
    [IsoId("_uXkz8fL9Ed-3lpUMQaXLjQ")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public required SecurityDate6 DateDetails { get; init; }

    /// <summary>
    /// Provides information about the rates related to securities movement.
    /// </summary>
    [IsoId("_uXkz8_L9Ed-3lpUMQaXLjQ")]
    [DisplayName("Rate Details")]
    [IsoXmlTag("RateDtls")]
    public CorporateActionRate21? RateDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to securities movement.
    /// </summary>
    [IsoId("_uXkz9fL9Ed-3lpUMQaXLjQ")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice9? PriceDetails { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_uXkz9_L9Ed-3lpUMQaXLjQ")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties15? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_uXkz-fL9Ed-3lpUMQaXLjQ")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties15? DeliveringSettlementParties { get; init; }
}
