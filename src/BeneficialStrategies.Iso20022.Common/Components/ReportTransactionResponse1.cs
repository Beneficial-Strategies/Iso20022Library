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
[IsoId("_nL5KEN6VEeiwsev40qZGEQ")]
[DisplayName("Report Transaction Response")]
public partial record ReportTransactionResponse1
{
    #nullable enable
    
    /// <summary>
    /// The total number of transactions matching the search criteria.
    /// </summary>
    [IsoId("_sNpMsN6VEeiwsev40qZGEQ")]
    [DisplayName("Report Full Size")]
    [IsoXmlTag("RptFullSz")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public required IsoPositiveNumber ReportFullSize { get; init; } 
    
    /// <summary>
    /// Index of the first transaction reported in this message within the list of transactions matching the search criteria.
    /// </summary>
    [IsoId("_u7XXMN6VEeiwsev40qZGEQ")]
    [DisplayName("Block Start")]
    [IsoXmlTag("BlckStart")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public required IsoPositiveNumber BlockStart { get; init; } 
    
    /// <summary>
    /// Index of the last transaction reported in this message.
    /// </summary>
    [IsoId("_EOIKMN6WEeiwsev40qZGEQ")]
    [DisplayName("Block Stop")]
    [IsoXmlTag("BlckStop")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public required IsoPositiveNumber BlockStop { get; init; } 
    
    /// <summary>
    /// List of Transaction Report containing one Transaction Report for each transaction matching the Search criteria. This list may be partial according to requested block.
    /// </summary>
    [IsoId("_3MsUMN6VEeiwsev40qZGEQ")]
    [DisplayName("Transaction Report")]
    [IsoXmlTag("TxRpt")]
    public PointOfInteractionTransactionReport1? TransactionReport { get; init; } 
    
    
    #nullable disable
    
}
