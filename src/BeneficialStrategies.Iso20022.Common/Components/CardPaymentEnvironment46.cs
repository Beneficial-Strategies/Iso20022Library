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
[IsoId("_wl-hQY0tEeW1W6lLicSC4w")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment46
{
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_wxcxcY0tEeW1W6lLicSC4w")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public GenericIdentification53? AcquirerIdentification { get; init; }

    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_wxcxc40tEeW1W6lLicSC4w")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_wxcxdY0tEeW1W6lLicSC4w")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification32 POIIdentification { get; init; }

    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    [IsoId("_wxcxd40tEeW1W6lLicSC4w")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard19? Card { get; init; }

    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_wxcxeY0tEeW1W6lLicSC4w")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken2? PaymentToken { get; init; }
}
