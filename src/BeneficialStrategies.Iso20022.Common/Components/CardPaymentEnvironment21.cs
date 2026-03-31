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
[IsoId("_hTbLMTGMEeO118ZQJgaQSQ")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment21
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_hkOnUTGMEeO118ZQJgaQSQ")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public GenericIdentification32? AcquirerIdentification { get; init; }

    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_hkOnUzGMEeO118ZQJgaQSQ")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_hkOnVTGMEeO118ZQJgaQSQ")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification32 POIIdentification { get; init; }

    /// <summary>
    /// Replacement of the message element PlainCardData by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_hkOnVzGMEeO118ZQJgaQSQ")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType7? ProtectedCardData { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_hkOnWTGMEeO118ZQJgaQSQ")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData5? PlainCardData { get; init; }
}
