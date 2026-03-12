// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the file action.
/// </summary>
[IsoId("_dUB4wVZjEeen1vB4iz5SyA")]
[DisplayName("File Action Response")]
public partial record FileActionResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the file action transaction.
    /// </summary>
    [IsoId("_dfe60VZjEeen1vB4iz5SyA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment3 Environment { get; init; } 
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_ApdkAWqYEema8a4DGUe7Lw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context8? Context { get; init; } 
    
    /// <summary>
    /// File action transaction details.
    /// </summary>
    [IsoId("_dfe601ZjEeen1vB4iz5SyA")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction90 Transaction { get; init; } 
    
    /// <summary>
    /// Results of the file action processing.
    /// </summary>
    [IsoId("_dfe61VZjEeen1vB4iz5SyA")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ResultData4 ProcessingResult { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_i0FPcdXwEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_c8tEAaK5EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
