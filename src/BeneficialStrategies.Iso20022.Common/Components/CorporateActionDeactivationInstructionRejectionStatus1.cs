// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of a deactivation instruction.
/// </summary>
[IsoId("_RkeBdtp-Ed-ak6NoX_4Aeg_1522075746")]
[DisplayName("Corporate Action Deactivation Instruction Rejection Status")]
public partial record CorporateActionDeactivationInstructionRejectionStatus1
{
    #nullable enable
    
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_RkeBd9p-Ed-ak6NoX_4Aeg_1534080534")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason12FormatChoice_> Reason { get; init; } = new ValueList<RejectionReason12FormatChoice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _RkeBd9p-Ed-ak6NoX_4Aeg_1534080534
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RknycNp-Ed-ak6NoX_4Aeg_1534080564")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
