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
[IsoId("_rYIgkTJsEeOQDoPKFK41HQ")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment25
{
    /// <summary>
    /// Acquirer involved in the card payment reconciliation.
    /// </summary>
    [IsoId("_ro8jwTJsEeOQDoPKFK41HQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required Acquirer2 Acquirer { get; init; }

    /// <summary>
    /// Identification of the merchant requesting the reconciliation.
    /// </summary>
    [IsoId("_ro8jwzJsEeOQDoPKFK41HQ")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) requesting the reconciliation.
    /// </summary>
    [IsoId("_ro8jxTJsEeOQDoPKFK41HQ")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification32? POIIdentification { get; init; }

    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) that have been performed the payment transactions.
    /// </summary>
    [IsoId("_2T0LADJsEeOQDoPKFK41HQ")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public ValueList<PointOfInteractionComponent4> POIComponent { get; init; } = [];
}
