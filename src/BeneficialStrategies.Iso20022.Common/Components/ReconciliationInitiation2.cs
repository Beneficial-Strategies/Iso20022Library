// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the reconciliation.
/// </summary>
[IsoId("_2EQXoYv9EeuC5632vxUfGg")]
[DisplayName("Reconciliation Initiation")]
public partial record ReconciliationInitiation2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_2JRagYv9EeuC5632vxUfGg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment33 Environment { get; init; } 
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_2JRag4v9EeuC5632vxUfGg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; } 
    
    /// <summary>
    /// Data pertaining to the reconciliation transaction.
    /// </summary>
    [IsoId("_2JRahYv9EeuC5632vxUfGg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction135 Transaction { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_2JRah4v9EeuC5632vxUfGg")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_2JRaiYv9EeuC5632vxUfGg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
