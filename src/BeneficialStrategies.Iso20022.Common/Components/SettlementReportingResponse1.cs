// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the  settlement response message.
/// </summary>
[IsoId("_g00XsVdPEeeIAMBcVOw01w")]
[DisplayName("Settlement Reporting Response")]
public partial record SettlementReportingResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_hAW5UVdPEeeIAMBcVOw01w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment9 Environment { get; init; } 
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_zQsWoWqYEema8a4DGUe7Lw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context6? Context { get; init; } 
    
    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_hAW5U1dPEeeIAMBcVOw01w")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction84 Transaction { get; init; } 
    
    /// <summary>
    /// Processing results of the settlement service.
    /// </summary>
    [IsoId("_HgCkQe-_EeeJbIMlSHFAag")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult3 ProcessingResult { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_SJfPgdXyEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_fQOecaK8EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
