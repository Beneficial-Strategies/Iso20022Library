// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of an election advice.
/// </summary>
[IsoId("_Rkw8Ydp-Ed-ak6NoX_4Aeg_-175735359")]
[DisplayName("Corporate Action Instruction Rejection Status")]
public partial record CorporateActionInstructionRejectionStatus1
{
    #nullable enable
    
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_Rkw8Ytp-Ed-ak6NoX_4Aeg_-147105631")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason18FormatChoice_> Reason { get; init; } = [];
    // ID for the above is _Rkw8Ytp-Ed-ak6NoX_4Aeg_-147105631
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_Rkw8Y9p-Ed-ak6NoX_4Aeg_-147105352")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
