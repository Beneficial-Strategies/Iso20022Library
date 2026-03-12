// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the reversal of an authorisation or financial message.
/// </summary>
[IsoId("_LKK5gYHOEeuwq_rv81SdXw")]
[DisplayName("Reversal Initiation")]
public partial record ReversalInitiation2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_LPbM8YHOEeuwq_rv81SdXw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment19 Environment { get; init; } 
    
    /// <summary>
    /// Context of the reversal transaction.
    /// </summary>
    [IsoId("_LPbM84HOEeuwq_rv81SdXw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context14? Context { get; init; } 
    
    /// <summary>
    /// Reversal initiation transaction.
    /// </summary>
    [IsoId("_LPbM9YHOEeuwq_rv81SdXw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction142 Transaction { get; init; } 
    
    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_LPbM94HOEeuwq_rv81SdXw")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult16? ProcessingResult { get; init; } 
    
    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_LPbM-YHOEeuwq_rv81SdXw")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_LPbM-4HOEeuwq_rv81SdXw")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_LPbM_YHOEeuwq_rv81SdXw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
