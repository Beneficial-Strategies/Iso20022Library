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
[IsoId("_CagRkY3YEeW56qaqQ8B0kQ")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment55
{
    /// <summary>
    /// Acquirer involved in the card payment transaction.
    /// </summary>
    [IsoId("_Clq_wY3YEeW56qaqQ8B0kQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required Acquirer4 Acquirer { get; init; }

    /// <summary>
    /// The availability of the acquirer to process transaction must be provided.
    /// </summary>
    [IsoId("_Clq_w43YEeW56qaqQ8B0kQ")]
    [DisplayName("Acquirer Availability Requested")]
    [IsoXmlTag("AcqrrAvlbtyReqd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; }

    /// <summary>
    /// Identification of the merchant requesting the diagnostic.
    /// </summary>
    [IsoId("_Clq_xY3YEeW56qaqQ8B0kQ")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification53? MerchantIdentification { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) requesting the diagnostic.
    /// </summary>
    [IsoId("_Clq_x43YEeW56qaqQ8B0kQ")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification32? POIIdentification { get; init; }

    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) performing the payment transactions.
    /// </summary>
    [IsoId("_Clq_yY3YEeW56qaqQ8B0kQ")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public ValueList<PointOfInteractionComponent6> POIComponent { get; init; } = [];
}
