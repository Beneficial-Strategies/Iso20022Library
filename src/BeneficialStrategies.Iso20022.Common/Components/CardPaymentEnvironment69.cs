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
[IsoId("_RWUgAds-Eee9e6xduATmQg")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment69
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_RfUD8ds-Eee9e6xduATmQg")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public GenericIdentification53? AcquirerIdentification { get; init; }

    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_RfUD89s-Eee9e6xduATmQg")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_RfUD9ds-Eee9e6xduATmQg")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification32? POIIdentification { get; init; }

    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    [IsoId("_RfUD99s-Eee9e6xduATmQg")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard28? Card { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_RfUD-ds-Eee9e6xduATmQg")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken4? PaymentToken { get; init; }
}
