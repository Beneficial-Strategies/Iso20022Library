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
[IsoId("_rA6moWl8EeSxgrJ0GX4SQQ")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment36
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_rPE-cWl8EeSxgrJ0GX4SQQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer4? Acquirer { get; init; }

    /// <summary>
    /// Merchant performing the card payment.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_rPE-c2l8EeSxgrJ0GX4SQQ")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation8? Merchant { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_rPE-dWl8EeSxgrJ0GX4SQQ")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction4 POI { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_rPE-d2l8EeSxgrJ0GX4SQQ")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard11 Card { get; init; }

    /// <summary>
    /// Device used by the customer to perform the payment.
    /// </summary>
    [IsoId("_YxRw8Gl9EeSxgrJ0GX4SQQ")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice1? CustomerDevice { get; init; }

    /// <summary>
    /// Container of tenders used by the customer to perform the payment.
    /// </summary>
    [IsoId("_bY4FUGl9EeSxgrJ0GX4SQQ")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice1? Wallet { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_hRHrEGl9EeSxgrJ0GX4SQQ")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken3? PaymentToken { get; init; }
}
