// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fulfilment instructions for the retrieval
/// </summary>
[IsoId("_TtQmQcW5EeuhguwJmlgagQ")]
[DisplayName("Retrieval Fulfilment Instructions")]
public record RetrievalFulfilmentInstructions2
{
    /// <summary>
    /// Contains information describing the fulfilment information delivery methods.
    /// </summary>
    [IsoId("_TyoOccW5EeuhguwJmlgagQ")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    public RetrievalDeliveryMethod1Choice_? Method { get; init; }

    /// <summary>
    /// Information related to a retrieval fulfilment.
    /// </summary>
    [IsoId("_TyoOc8W5EeuhguwJmlgagQ")]
    [DisplayName("Delivery Information")]
    [IsoXmlTag("DlvryInf")]
    public DeliveryInformation5? DeliveryInformation { get; init; }

    /// <summary>
    /// Additional information relevant for the retrieval.
    /// </summary>
    [IsoId("_TyoOdcW5EeuhguwJmlgagQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation22? AdditionalInformation { get; init; }
}
