// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Switch order confirmation details.
/// </summary>
[IsoId("_RNqrBtp-Ed-ak6NoX_4Aeg_1790539148")]
[DisplayName("Switch Order Confirmation")]
public partial record SwitchOrderConfirmation1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.
    /// </summary>
    [IsoId("_RNqrB9p-Ed-ak6NoX_4Aeg_152297658")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AmendmentIndicator { get; init; } 
    
    /// <summary>
    /// Information related to a switch execution.
    /// </summary>
    [IsoId("_RNqrCNp-Ed-ak6NoX_4Aeg_1791463151")]
    [DisplayName("Switch Execution Details")]
    [IsoXmlTag("SwtchExctnDtls")]
    public ValueList<SwitchExecution4> SwitchExecutionDetails { get; init; } = new ValueList<SwitchExecution4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _RNqrCNp-Ed-ak6NoX_4Aeg_1791463151
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RNqrCdp-Ed-ak6NoX_4Aeg_1791462670")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}
