// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a fee collection response message.
/// </summary>
[IsoId("_JA1Z0YaBEeuSbct6WWD-Ng")]
[DisplayName("Fee Collection Response")]
public partial record FeeCollectionResponse2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction
    /// </summary>
    [IsoId("_JGA0wYaBEeuSbct6WWD-Ng")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment23 Environment { get; init; } 
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_JGA0w4aBEeuSbct6WWD-Ng")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context16? Context { get; init; } 
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_JGA0xYaBEeuSbct6WWD-Ng")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction156 Transaction { get; init; } 
    
    /// <summary>
    /// Outcome of the processing of the authorisation
    /// </summary>
    [IsoId("_JGA0x4aBEeuSbct6WWD-Ng")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult19 ProcessingResult { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_JGA0yYaBEeuSbct6WWD-Ng")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
