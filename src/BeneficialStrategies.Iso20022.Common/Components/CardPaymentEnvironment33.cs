// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction given in a response to a request.
/// </summary>
[IsoId("_kl0QQWkgEeSTIuB9A-QJ6g")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment33
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_kz1eIWkgEeSTIuB9A-QJ6g")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public GenericIdentification53? AcquirerIdentification { get; init; }

    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_kz1eI2kgEeSTIuB9A-QJ6g")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_kz1eJWkgEeSTIuB9A-QJ6g")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification32 POIIdentification { get; init; }

    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    [IsoId("_GBm_sGkjEeSTIuB9A-QJ6g")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard10? Card { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_jfIqIGkiEeSTIuB9A-QJ6g")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken2? PaymentToken { get; init; }
}
