// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the cancellation.
/// </summary>
[IsoId("_DlngcY1BEeWsypzzYao74A")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment48
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_DwprwY1BEeWsypzzYao74A")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer4? Acquirer { get; init; }

    /// <summary>
    /// Merchant performing the card payment cancellation.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_Dwprw41BEeWsypzzYao74A")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation25? Merchant { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_DwprxY1BEeWsypzzYao74A")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction5 POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_Dwprx41BEeWsypzzYao74A")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard20 Card { get; init; }

    /// <summary>
    /// Device used by the customer to perform the payment.
    /// </summary>
    [IsoId("_DwpryY1BEeWsypzzYao74A")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice1? CustomerDevice { get; init; }

    /// <summary>
    /// Container of tenders used by the customer to perform the payment.
    /// </summary>
    [IsoId("_Dwpry41BEeWsypzzYao74A")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice1? Wallet { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_DwprzY1BEeWsypzzYao74A")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken3? PaymentToken { get; init; }
}
