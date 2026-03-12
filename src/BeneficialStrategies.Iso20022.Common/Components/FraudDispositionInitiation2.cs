// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the  fraud disposition initiation message.
/// </summary>
[IsoId("_I5XAQYgrEeu8-LhY4KPfWg")]
[DisplayName("Fraud Disposition Initiation")]
public partial record FraudDispositionInitiation2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction
    /// </summary>
    [IsoId("_I-jCQYgrEeu8-LhY4KPfWg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment28 Environment { get; init; } 
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_I-jCQ4grEeu8-LhY4KPfWg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; } 
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_I-jCRYgrEeu8-LhY4KPfWg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction128 Transaction { get; init; } 
    
    /// <summary>
    /// Contains the disposition of the previously submitted fraud reporting message.
    /// </summary>
    [IsoId("_I-jCR4grEeu8-LhY4KPfWg")]
    [DisplayName("Fraud Disposition Status")]
    [IsoXmlTag("FrdDspstnSts")]
    public required FraudDispositionStatus2 FraudDispositionStatus { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_I-jCSYgrEeu8-LhY4KPfWg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
