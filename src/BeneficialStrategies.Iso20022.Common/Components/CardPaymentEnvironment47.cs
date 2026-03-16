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
[IsoId("_1dKKQY07EeWPUZwhUA4U-w")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment47
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_1oFn4Y07EeWPUZwhUA4U-w")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer4? Acquirer { get; init; }

    /// <summary>
    /// Merchant performing the card payment.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_1oFn4407EeWPUZwhUA4U-w")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation25? Merchant { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_1oFn5Y07EeWPUZwhUA4U-w")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction5 POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_1oFn5407EeWPUZwhUA4U-w")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard20? Card { get; init; }

    /// <summary>
    /// Device used by the customer to perform the payment.
    /// </summary>
    [IsoId("_1oFn6Y07EeWPUZwhUA4U-w")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice1? CustomerDevice { get; init; }

    /// <summary>
    /// Container of tenders used by the customer to perform the payment.
    /// </summary>
    [IsoId("_1oFn6407EeWPUZwhUA4U-w")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice1? Wallet { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_1oFn7Y07EeWPUZwhUA4U-w")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken3? PaymentToken { get; init; }

    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_1oFn7407EeWPUZwhUA4U-w")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder11? Cardholder { get; init; }

    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_1oFn8Y07EeWPUZwhUA4U-w")]
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType10? ProtectedCardholderData { get; init; }
}
