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
[IsoId("_g6fJIWpAEeS4VPLpYyQgxQ")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment42
{
    /// <summary>
    /// Acquirer involved in the card payment transaction.
    /// </summary>
    [IsoId("_hUasEWpAEeS4VPLpYyQgxQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required Acquirer4 Acquirer { get; init; }

    /// <summary>
    /// The availability of the acquirer to process transaction must be provided.
    /// </summary>
    [IsoId("_hUasE2pAEeS4VPLpYyQgxQ")]
    [DisplayName("Acquirer Availability Requested")]
    [IsoXmlTag("AcqrrAvlbtyReqd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; }

    /// <summary>
    /// Identification of the merchant requesting the diagnostic.
    /// </summary>
    [IsoId("_hUasFWpAEeS4VPLpYyQgxQ")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification53? MerchantIdentification { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) requesting the diagnostic.
    /// </summary>
    [IsoId("_hUasF2pAEeS4VPLpYyQgxQ")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification32? POIIdentification { get; init; }

    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) performing the payment transactions.
    /// </summary>
    [IsoId("_hUasGWpAEeS4VPLpYyQgxQ")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public PointOfInteractionComponent5? POIComponent { get; init; }
}
