// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
[IsoId("_hSEYgY0QEeWRYffwL7E13A")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment45
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_hdPtwY0QEeWRYffwL7E13A")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer4? Acquirer { get; init; }

    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_hdPtw40QEeWRYffwL7E13A")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation25? Merchant { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_hdPtxY0QEeWRYffwL7E13A")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction5 POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_hdPtx40QEeWRYffwL7E13A")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard21 Card { get; init; }

    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_hdPtyY0QEeWRYffwL7E13A")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice1? CustomerDevice { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_hdPty40QEeWRYffwL7E13A")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice1? Wallet { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_hdPtzY0QEeWRYffwL7E13A")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken1? PaymentToken { get; init; }

    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_hdPtz40QEeWRYffwL7E13A")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder10? Cardholder { get; init; }

    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_hdPt0Y0QEeWRYffwL7E13A")]
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType10? ProtectedCardholderData { get; init; }
}
