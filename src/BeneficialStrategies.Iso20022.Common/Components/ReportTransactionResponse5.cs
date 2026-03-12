// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Transaction Report Response message.
/// </summary>
[IsoId("_tB5KYXJEEe299ZbWCkdR_w")]
[DisplayName("Report Transaction Response")]
public partial record ReportTransactionResponse5
{
    #nullable enable
    
    /// <summary>
    /// Specifies the total number of transactions matching the search criteria.
    /// </summary>
    [IsoId("_tJNTUXJEEe299ZbWCkdR_w")]
    [DisplayName("Report Full Size")]
    [IsoXmlTag("RptFullSz")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public required IsoPositiveNumber ReportFullSize { get; init; } 
    
    /// <summary>
    /// Index of the first transaction reported in this message within the list of transactions matching the search criteria.
    /// </summary>
    [IsoId("_tJNTU3JEEe299ZbWCkdR_w")]
    [DisplayName("Block Start")]
    [IsoXmlTag("BlckStart")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public required IsoPositiveNumber BlockStart { get; init; } 
    
    /// <summary>
    /// Index of the last transaction reported in this message.
    /// </summary>
    [IsoId("_tJNTVXJEEe299ZbWCkdR_w")]
    [DisplayName("Block Stop")]
    [IsoXmlTag("BlckStop")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public required IsoPositiveNumber BlockStop { get; init; } 
    
    /// <summary>
    /// List of Transaction Report containing one Transaction Report for each transaction matching the Search criteria. This list may be partial according to requested block.
    /// </summary>
    [IsoId("_tJNTV3JEEe299ZbWCkdR_w")]
    [DisplayName("Transaction Report")]
    [IsoXmlTag("TxRpt")]
    public ServiceResponse7? TransactionReport { get; init; } 
    
    
    #nullable disable
    
}
