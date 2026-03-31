// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the card payment transaction.
/// </summary>
[IsoId("_xfvlIY3NEeWjkqXgn_0Imw")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment52
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_xrgwQY3NEeWjkqXgn_0Imw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer4? Acquirer { get; init; }

    /// <summary>
    /// Merchant performing the transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_xrgwQ43NEeWjkqXgn_0Imw")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation25? Merchant { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_xrgwRY3NEeWjkqXgn_0Imw")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction5? POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_xrgwR43NEeWjkqXgn_0Imw")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard20 Card { get; init; }

    /// <summary>
    /// Device used by the customer to perform the payment.
    /// </summary>
    [IsoId("_xrgwSY3NEeWjkqXgn_0Imw")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice1? CustomerDevice { get; init; }

    /// <summary>
    /// Container of tenders used by the customer to perform the payment.
    /// </summary>
    [IsoId("_xrgwS43NEeWjkqXgn_0Imw")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice1? Wallet { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_xrgwTY3NEeWjkqXgn_0Imw")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken3? PaymentToken { get; init; }

    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_xrgwT43NEeWjkqXgn_0Imw")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder11? Cardholder { get; init; }

    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_xrgwUY3NEeWjkqXgn_0Imw")]
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType10? ProtectedCardholderData { get; init; }
}
