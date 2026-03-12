// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for an unmatched status.
/// </summary>
[IsoId("_UzmP49p-Ed-ak6NoX_4Aeg_413742327")]
[DisplayName("Transfer Unmatched Status Reason")]
public partial record TransferUnmatchedStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for a rejected status in structured form.
    /// </summary>
    [IsoId("_UzmP5Np-Ed-ak6NoX_4Aeg_744365174")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required TransferUnmatchedReason1Code Structured { get; init; } 
    
    /// <summary>
    /// Additional information about the reason for the unmatched status in textual form.
    /// </summary>
    [IsoId("_UzmP5dp-Ed-ak6NoX_4Aeg_744365217")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
