// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status advising on the rejection of the cancellation request.
/// </summary>
[IsoId("_RVa42Np-Ed-ak6NoX_4Aeg_-1616407173")]
[DisplayName("Cancellation Rejection Status")]
public partial record CancellationRejectionStatus1
{
    #nullable enable
    
    /// <summary>
    /// Reason advising the rejection of the instruction cancellation request.
    /// </summary>
    [IsoId("_RVkCwNp-Ed-ak6NoX_4Aeg_-1615487184")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required RejectionReason2Code Reason { get; init; } 
    
    /// <summary>
    /// This code can be used in case another reason is required.
    /// </summary>
    [IsoId("_RVkCwdp-Ed-ak6NoX_4Aeg_1990577179")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; } 
    
    /// <summary>
    /// Additional information about the reason.
    /// </summary>
    [IsoId("_RVkCwtp-Ed-ak6NoX_4Aeg_218041376")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
