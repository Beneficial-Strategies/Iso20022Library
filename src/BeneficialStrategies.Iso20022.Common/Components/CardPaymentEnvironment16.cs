// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction given in a response to a request in a batch.
/// </summary>
[IsoId("_HAOb4Rz1EeK5OKMB21JFBg")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment16
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_HMt_xRz1EeK5OKMB21JFBg")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("Acqrr")]
    public GenericIdentification32? AcquirerIdentification { get; init; }

    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_HMt_zBz1EeK5OKMB21JFBg")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; }

    /// <summary>
    /// Identification of the POI performing the transaction.
    /// </summary>
    [IsoId("_HMt_0xz1EeK5OKMB21JFBg")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification32? POIIdentification { get; init; }

    /// <summary>
    /// Sensitive data of the card (PlainCardData1 including the envelope), encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_HMt_2hz1EeK5OKMB21JFBg")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType5? ProtectedCardData { get; init; }

    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_HMt_4Rz1EeK5OKMB21JFBg")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData3? PlainCardData { get; init; }
}
