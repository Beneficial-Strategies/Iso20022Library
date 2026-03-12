// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of a batch transfer initiation message.
/// </summary>
[IsoId("_70c0cZMrEeuleeHpFMMhmQ")]
[DisplayName("Batch Transfer Response")]
public partial record BatchTransferResponse2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the message.
    /// </summary>
    [IsoId("_76xe4ZMrEeuleeHpFMMhmQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment4 Environment { get; init; } 
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_76xe45MrEeuleeHpFMMhmQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; } 
    
    /// <summary>
    /// Batch transfer transaction.
    /// </summary>
    [IsoId("_76xe5ZMrEeuleeHpFMMhmQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction141 Transaction { get; init; } 
    
    /// <summary>
    /// Outcome of processing.
    /// </summary>
    [IsoId("_76xe55MrEeuleeHpFMMhmQ")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult13 ProcessingResult { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_76xe6ZMrEeuleeHpFMMhmQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_76xe65MrEeuleeHpFMMhmQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
