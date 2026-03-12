// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a pending settlement status.
/// </summary>
[IsoId("_U1YYkNp-Ed-ak6NoX_4Aeg_-1256636316")]
[DisplayName("Pending Settlement Status Reason")]
public partial record PendingSettlementStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for a settlement pending status in structured form.
    /// </summary>
    [IsoId("_U1YYkdp-Ed-ak6NoX_4Aeg_-913088435")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required PendingSettlementStatusReason1Code Structured { get; init; } 
    
    /// <summary>
    /// Additional information about the reason for the settlement pending status in textual form.
    /// </summary>
    [IsoId("_U1YYktp-Ed-ak6NoX_4Aeg_-888151424")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
