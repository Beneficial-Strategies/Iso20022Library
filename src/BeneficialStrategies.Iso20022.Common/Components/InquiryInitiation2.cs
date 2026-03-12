// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the inquiry initiation message.
/// </summary>
[IsoId("_FSdbIYEREeu6D49Gi-ZPwQ")]
[DisplayName("Inquiry Initiation")]
public partial record InquiryInitiation2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_FW-uwYEREeu6D49Gi-ZPwQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment18 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_FW-uw4EREeu6D49Gi-ZPwQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context11 Context { get; init; } 
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_FW-uxYEREeu6D49Gi-ZPwQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction131 Transaction { get; init; } 
    
    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages
    /// </summary>
    [IsoId("_6bmnASX7Eeym0KcvJF9aDQ")]
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public AddendumData5? AddendumData { get; init; } 
    
    /// <summary>
    /// Result of the inquiry processing.
    /// ISO 8583:87 bit 110
    /// ISO 8583:93 bit 111
    /// ISO 8583:2003 bit 50
    /// </summary>
    [IsoId("_FW-ux4EREeu6D49Gi-ZPwQ")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult11? ProcessingResult { get; init; } 
    
    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_FW-uyYEREeu6D49Gi-ZPwQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_FW-uy4EREeu6D49Gi-ZPwQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_FW-uzYEREeu6D49Gi-ZPwQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
