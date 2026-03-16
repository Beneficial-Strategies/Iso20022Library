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
[IsoId("_PwXRsY3TEeWjkqXgn_0Imw")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment54
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_P9egoY3TEeWjkqXgn_0Imw")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public GenericIdentification53? AcquirerIdentification { get; init; }

    /// <summary>
    /// Merchant performing the card payment.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_P9ego43TEeWjkqXgn_0Imw")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; }

    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_P9egpY3TEeWjkqXgn_0Imw")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification32? POIIdentification { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_P9egp43TEeWjkqXgn_0Imw")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard19? Card { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_BAypcI3UEeWjkqXgn_0Imw")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken2? PaymentToken { get; init; }
}
