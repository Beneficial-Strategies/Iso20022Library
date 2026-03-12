// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the verification response message.
/// </summary>
[IsoId("_IUYWcVgNEeedJb6VxsnkPg")]
[DisplayName("Verification Response")]
public partial record VerificationResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_IgI6gVgNEeedJb6VxsnkPg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment2 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_IgI6g1gNEeedJb6VxsnkPg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context2 Context { get; init; } 
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_IgI6hVgNEeedJb6VxsnkPg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction88 Transaction { get; init; } 
    
    /// <summary>
    /// Outcome of the processing of the verification.
    /// </summary>
    [IsoId("_IgI6iVgNEeedJb6VxsnkPg")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult6 ProcessingResult { get; init; } 
    
    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_IgI6i1gNEeedJb6VxsnkPg")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_kAo0EdXuEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_phNmEaK8EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
