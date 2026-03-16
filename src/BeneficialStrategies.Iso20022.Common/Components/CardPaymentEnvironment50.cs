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
[IsoId("_vfaJsY1MEeWXALXlV0Ei2w")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment50
{
    /// <summary>
    /// Acquirer involved in the card payment reconciliation.
    /// </summary>
    [IsoId("_vqcVAY1MEeWXALXlV0Ei2w")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required Acquirer4 Acquirer { get; init; }

    /// <summary>
    /// Identification of the merchant requesting the reconciliation.
    /// </summary>
    [IsoId("_vqcVA41MEeWXALXlV0Ei2w")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification53? MerchantIdentification { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) requesting the reconciliation.
    /// </summary>
    [IsoId("_vqcVBY1MEeWXALXlV0Ei2w")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification53? POIIdentification { get; init; }

    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) that have been performed the payment transactions.
    /// </summary>
    [IsoId("_vqcVB41MEeWXALXlV0Ei2w")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public PointOfInteractionComponent6? POIComponent { get; init; }
}
