// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Addendum message is used in conjunction with an authorisation or financial message to provide supplemental data above that required to complete an authorisation initiation or financial initiation. 
/// </summary>
[IsoId("_EOI42vJAEeiJn9rM2Znz2w")]
[DisplayName("Addendum Initiation")]
public partial record AddendumInitiation1
{
    #nullable enable
    
    /// <summary>
    /// Contains or describes the information pertaining to the actors interacting with the transaction.
    /// </summary>
    [IsoId("_EOJf4fJAEeiJn9rM2Znz2w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment16 Environment { get; init; } 
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_EOJf4_JAEeiJn9rM2Znz2w")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context8? Context { get; init; } 
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_EOJf6PJAEeiJn9rM2Znz2w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction91 Transaction { get; init; } 
    
    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages. 
    /// </summary>
    [IsoId("_EOJf5_JAEeiJn9rM2Znz2w")]
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public required AddendumData1 AddendumData { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_EOJf5fJAEeiJn9rM2Znz2w")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_EOJf5vJAEeiJn9rM2Znz2w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
