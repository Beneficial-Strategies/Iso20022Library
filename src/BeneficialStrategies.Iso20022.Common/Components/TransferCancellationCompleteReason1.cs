// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for the complete status.
/// </summary>
[IsoId("_U0V2yNp-Ed-ak6NoX_4Aeg_-1275943610")]
[DisplayName("Transfer Cancellation Complete Reason")]
public partial record TransferCancellationCompleteReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for a complete status in structured form.
    /// </summary>
    [IsoId("_U0fAsNp-Ed-ak6NoX_4Aeg_109339586")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required CancellationCompleteStatusReason1Code Structured { get; init; } 
    
    /// <summary>
    /// Additional information about the reason for the complete status in textual form.
    /// </summary>
    [IsoId("_U0fAsdp-Ed-ak6NoX_4Aeg_551704444")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
