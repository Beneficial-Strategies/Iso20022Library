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
[IsoId("_5yHBMdwhEeeKpa-yxjuKzQ")]
[DisplayName("Card Payment Environment")]
public record CardPaymentEnvironment71
{
    /// <summary>
    /// Acquirer involved in the card payment transaction.
    /// </summary>
    [IsoId("_57FXAdwhEeeKpa-yxjuKzQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required Acquirer4 Acquirer { get; init; }

    /// <summary>
    /// The availability of the acquirer to process transaction must be provided.
    /// </summary>
    [IsoId("_57FXA9whEeeKpa-yxjuKzQ")]
    [DisplayName("Acquirer Availability Requested")]
    [IsoXmlTag("AcqrrAvlbtyReqd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; }

    /// <summary>
    /// Identification of the merchant requesting the diagnostic.
    /// </summary>
    [IsoId("_57FXBdwhEeeKpa-yxjuKzQ")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification53? MerchantIdentification { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) requesting the diagnostic.
    /// </summary>
    [IsoId("_57FXB9whEeeKpa-yxjuKzQ")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification32? POIIdentification { get; init; }

    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) performing the payment transactions.
    /// </summary>
    [IsoId("_57FXCdwhEeeKpa-yxjuKzQ")]
    [DisplayName("POI Component")]
    [IsoXmlTag("POICmpnt")]
    public PointOfInteractionComponent8? POIComponent { get; init; }

    /// <summary>
    /// Indicates if the acquirer is available.
    /// </summary>
    [IsoId("_bnd4QN52EeeCre2qFaLC2A")]
    [DisplayName("Acquirer Available")]
    [IsoXmlTag("AcqrrAvlbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AcquirerAvailable { get; init; }
}
