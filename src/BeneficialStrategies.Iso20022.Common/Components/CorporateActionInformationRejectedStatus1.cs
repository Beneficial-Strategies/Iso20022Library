// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of an information advice.
/// </summary>
[IsoId("_RknydNp-Ed-ak6NoX_4Aeg_-920261162")]
[DisplayName("Corporate Action Information Rejected Status")]
public partial record CorporateActionInformationRejectedStatus1
{
    #nullable enable
    
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_Rknyddp-Ed-ak6NoX_4Aeg_35582095")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason15FormatChoice_> Reason { get; init; } = [];
    // ID for the above is _Rknyddp-Ed-ak6NoX_4Aeg_35582095
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_Rknydtp-Ed-ak6NoX_4Aeg_35582096")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
