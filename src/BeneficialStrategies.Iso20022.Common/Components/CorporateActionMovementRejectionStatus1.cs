// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of a movement.
/// </summary>
[IsoId("_Rkw8Z9p-Ed-ak6NoX_4Aeg_-1530943533")]
[DisplayName("Corporate Action Movement Rejection Status")]
public partial record CorporateActionMovementRejectionStatus1
{
    #nullable enable
    
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_Rkw8aNp-Ed-ak6NoX_4Aeg_-1516165446")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason13FormatChoice_> Reason { get; init; } = [];
    // ID for the above is _Rkw8aNp-Ed-ak6NoX_4Aeg_-1516165446
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_Rk6tYNp-Ed-ak6NoX_4Aeg_-1516165445")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
