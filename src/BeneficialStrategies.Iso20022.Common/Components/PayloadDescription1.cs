// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains information about the payload.
/// </summary>
[IsoId("_jLvfUu5NEeCisYr99QEiWA_-1263684777")]
[DisplayName("Payload Description")]
public partial record PayloadDescription1
{
    #nullable enable
    
    /// <summary>
    /// This component is used to identify the instance of the document exchanged.
    /// </summary>
    [IsoId("_jLvfU-5NEeCisYr99QEiWA_897283407")]
    [DisplayName("Payload Details")]
    [IsoXmlTag("PyldDtls")]
    public required PayloadDetails1 PayloadDetails { get; init; } 
    
    /// <summary>
    /// Contains business information that is considered as necessary by the service provider.
    /// </summary>
    [IsoId("_jLvfVO5NEeCisYr99QEiWA_-232163905")]
    [DisplayName("Application Specific Information")]
    [IsoXmlTag("ApplSpcfcInf")]
    public ApplicationSpecifics1? ApplicationSpecificInformation { get; init; } 
    
    /// <summary>
    /// Identification of the type of payload.
    /// </summary>
    [IsoId("_jL4pQO5NEeCisYr99QEiWA_-1404370216")]
    [DisplayName("Payload Type Details")]
    [IsoXmlTag("PyldTpDtls")]
    public required PayloadTypeDetails1 PayloadTypeDetails { get; init; } 
    
    /// <summary>
    /// Manifest that describes the related items or attachments.
    /// This block is repeated for each different type of item.
    /// </summary>
    [IsoId("_jL4pQe5NEeCisYr99QEiWA_54247380")]
    [DisplayName("Manifest Details")]
    [IsoXmlTag("MnfstDtls")]
    public ManifestDetails1? ManifestDetails { get; init; } 
    
    
    #nullable disable
    
}
