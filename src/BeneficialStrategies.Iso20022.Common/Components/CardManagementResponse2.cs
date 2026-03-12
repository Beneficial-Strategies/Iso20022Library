// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the card management response message.
/// </summary>
[IsoId("_mb2JwYN1EeuHqfO1LgkE9Q")]
[DisplayName("Card Management Response")]
public partial record CardManagementResponse2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_mgL3MYN1EeuHqfO1LgkE9Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment25 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_mgL3M4N1EeuHqfO1LgkE9Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context13 Context { get; init; } 
    
    /// <summary>
    /// Response to a card management Initiation transaction.
    /// </summary>
    [IsoId("_mgL3NYN1EeuHqfO1LgkE9Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction153 Transaction { get; init; } 
    
    /// <summary>
    /// Outcome of the processing of the transaction.
    /// </summary>
    [IsoId("_mgL3N4N1EeuHqfO1LgkE9Q")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult9 ProcessingResult { get; init; } 
    
    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_mgL3OYN1EeuHqfO1LgkE9Q")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_mgL3O4N1EeuHqfO1LgkE9Q")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_mgL3PYN1EeuHqfO1LgkE9Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
