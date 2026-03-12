// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the financial initiation message.
/// </summary>
[IsoId("_fQ4TsYELEeu6D49Gi-ZPwQ")]
[DisplayName("Financial Initiation")]
public partial record FinancialInitiation2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_fWqLkYELEeu6D49Gi-ZPwQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment17 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_fWqLk4ELEeu6D49Gi-ZPwQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context10 Context { get; init; } 
    
    /// <summary>
    /// Card transaction for which a financial process is requested.
    /// </summary>
    [IsoId("_fWqLlYELEeu6D49Gi-ZPwQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction145 Transaction { get; init; } 
    
    /// <summary>
    /// Contains details of the transaction to be retrieved.
    /// </summary>
    [IsoId("_j2FuATEEEeyjbpgZW6G1Fg")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public required OriginalTransaction2 OriginalTransaction { get; init; } 
    
    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages. 
    /// </summary>
    [IsoId("_fWqLl4ELEeu6D49Gi-ZPwQ")]
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public AddendumData3? AddendumData { get; init; } 
    
    /// <summary>
    /// Outcome of the processing of the authorisation
    /// </summary>
    [IsoId("_fWqLmYELEeu6D49Gi-ZPwQ")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult16? ProcessingResult { get; init; } 
    
    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_fWqLm4ELEeu6D49Gi-ZPwQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_fWqLnYELEeu6D49Gi-ZPwQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_fWqLn4ELEeu6D49Gi-ZPwQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
