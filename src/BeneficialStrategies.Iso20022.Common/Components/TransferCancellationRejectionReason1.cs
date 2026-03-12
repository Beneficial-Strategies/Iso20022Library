// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for the rejected status.
/// </summary>
[IsoId("_U0fAtdp-Ed-ak6NoX_4Aeg_1587150778")]
[DisplayName("Transfer Cancellation Rejection Reason")]
public partial record TransferCancellationRejectionReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for a rejected status in structured form.
    /// </summary>
    [IsoId("_U0fAttp-Ed-ak6NoX_4Aeg_1814337906")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required CancellationRejectedReason1Code Structured { get; init; } 
    
    /// <summary>
    /// Additional information about the reason for the rejected status in textual form.
    /// </summary>
    [IsoId("_U0fAt9p-Ed-ak6NoX_4Aeg_1814337864")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
