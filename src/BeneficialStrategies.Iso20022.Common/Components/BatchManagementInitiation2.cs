// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the batch management.
/// </summary>
[IsoId("_l4pjgYdOEeuBS50MFjViNw")]
[DisplayName("Batch Management Initiation")]
public partial record BatchManagementInitiation2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_l-CZ0YdOEeuBS50MFjViNw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment33 Environment { get; init; } 
    
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_l-CZ04dOEeuBS50MFjViNw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; } 
    
    /// <summary>
    /// Batch management transaction.
    /// </summary>
    [IsoId("_l-CZ1YdOEeuBS50MFjViNw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction151 Transaction { get; init; } 
    
    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_l-CZ14dOEeuBS50MFjViNw")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_l-CZ2YdOEeuBS50MFjViNw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
