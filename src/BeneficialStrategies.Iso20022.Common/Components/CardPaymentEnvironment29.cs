// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the diagnostic exchange.
/// </summary>
[IsoId("_ykqVgTTZEeO5e9wx3yvd8g")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment29
{
    /// <summary>
    /// Acquirer involved in the card payment transaction.
    /// </summary>
    [IsoId("_zHsWgFOYEeO1RfnvbrvgKg")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required Acquirer2 Acquirer { get; init; }

    /// <summary>
    /// The availability of the acquirer to process transaction must be provided.
    /// </summary>
    [IsoId("_7GGXgFOYEeO1RfnvbrvgKg")]
    [DisplayName("Acquirer Availability Requested")]
    [IsoXmlTag("AcqrrAvlbtyReqd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; }

    /// <summary>
    /// Identification of the merchant requesting the diagnostic.
    /// </summary>
    [IsoId("_yz1Z8zTZEeO5e9wx3yvd8g")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) requesting the diagnostic.
    /// </summary>
    [IsoId("_yz1Z9TTZEeO5e9wx3yvd8g")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification32? POIIdentification { get; init; }

    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) performing the payment transactions.
    /// </summary>
    [IsoId("_6h6f8DTZEeO5e9wx3yvd8g")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public ValueList<PointOfInteractionComponent4> POIComponent { get; init; } = [];
}
