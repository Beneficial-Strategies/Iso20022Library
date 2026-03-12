// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fulfilment instructions for the retrieval
/// </summary>
[IsoId("_zvnyIeE2EeeV6-yubHrZaQ")]
[DisplayName("Retrieval Fulfilment Instructions")]
public partial record RetrievalFulfilmentInstructions1
{
    #nullable enable
    
    /// <summary>
    /// Contains information describing the fulfilment information delivery methods.
    /// </summary>
    [IsoId("_z_Pig-E2EeeV6-yubHrZaQ")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    public RetrievalDeliveryMethod1Choice_? Method { get; init; } 
    
    /// <summary>
    /// Information related to a retrieval fulfilment.
    /// </summary>
    [IsoId("_z_PiieE2EeeV6-yubHrZaQ")]
    [DisplayName("Delivery Information")]
    [IsoXmlTag("DlvryInf")]
    public DeliveryInformation2? DeliveryInformation { get; init; } 
    
    /// <summary>
    /// Additional information relevant for the retrieval.
    /// </summary>
    [IsoId("_z_Pii-E2EeeV6-yubHrZaQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation22? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
