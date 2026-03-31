// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Commercial agreement in which the buyer agrees to pay the seller an amount of cash. Some aspects of the payment may be defined in the agreement, for example, the method of the payment.
/// </summary>
[IsoId("_64s9gRF-EeSahYR-dAI4lQ")]
[DisplayName("Premium Amount")]
public record PremiumAmount3
{
    /// <summary>
    /// Specifies the calculation method of the premium amount.
    /// </summary>
    [IsoId("_7SevcxF-EeSahYR-dAI4lQ")]
    [DisplayName("Premium Quote")]
    [IsoXmlTag("PrmQt")]
    public required PremiumQuote1Choice_ PremiumQuote { get; init; }

    /// <summary>
    /// Identification of the premium currency in which the option is held.
    /// </summary>
    [IsoId("_mvqqIIaXEeSzIqahkBT6cQ")]
    [DisplayName("Premium Currency")]
    [IsoXmlTag("PrmCcy")]
    public required ActiveOrHistoricCurrencyCode PremiumCurrency { get; init; }

    /// <summary>
    /// Result of the calculation of the premium amount on the basis of the premium quote and one of the amounts of the underlying foreign exchange trade.
    /// </summary>
    [IsoId("_7SevdRF-EeSahYR-dAI4lQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Number of decimal places to which quantities of units/shares are rounded.
    /// </summary>
    [IsoId("_X0udMIGnEeSCANvq7-Awnw")]
    [DisplayName("Decimal Places")]
    [IsoXmlTag("DcmlPlcs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber DecimalPlaces { get; init; }

    /// <summary>
    /// Date on which the premium must be settled.
    /// </summary>
    [IsoId("_Ii_qMIcmEeSSpbtwQkzChA")]
    [DisplayName("Premium Settlement Date")]
    [IsoXmlTag("PrmSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate PremiumSettlementDate { get; init; }

    /// <summary>
    /// Premium fee payer related information.
    /// </summary>
    [IsoId("_BKYN8EUnEeSGWeX3z5zSZQ")]
    [DisplayName("Payer Party Reference")]
    [IsoXmlTag("PyerPtyRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PayerPartyReference { get; init; }

    /// <summary>
    /// Premium fee receiver related information.
    /// </summary>
    [IsoId("_ZC3igEUmEeSGWeX3z5zSZQ")]
    [DisplayName("Receiver Party Reference")]
    [IsoXmlTag("RcvrPtyRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ReceiverPartyReference { get; init; }
}
