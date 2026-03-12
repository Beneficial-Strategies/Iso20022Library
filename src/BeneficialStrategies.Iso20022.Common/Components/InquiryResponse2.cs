// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the inquiry response message.
/// </summary>
[IsoId("_i4m8MYaZEeuSbct6WWD-Ng")]
[DisplayName("Inquiry Response")]
public partial record InquiryResponse2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_i84_QYaZEeuSbct6WWD-Ng")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment24 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_i84_Q4aZEeuSbct6WWD-Ng")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context13 Context { get; init; } 
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_i84_RYaZEeuSbct6WWD-Ng")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction132 Transaction { get; init; } 
    
    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages
    /// </summary>
    [IsoId("_9fZIISX7Eeym0KcvJF9aDQ")]
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public AddendumData5? AddendumData { get; init; } 
    
    /// <summary>
    /// Result of the inquiry processing.
    /// </summary>
    [IsoId("_i84_R4aZEeuSbct6WWD-Ng")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult17 ProcessingResult { get; init; } 
    
    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_i84_SYaZEeuSbct6WWD-Ng")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_i84_S4aZEeuSbct6WWD-Ng")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_i84_TYaZEeuSbct6WWD-Ng")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
