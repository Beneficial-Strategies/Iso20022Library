// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of an election cancellation request.
/// </summary>
[IsoId("_RlD3WNp-Ed-ak6NoX_4Aeg_-1891281771")]
[DisplayName("Corporate Action Cancellation Rejection Status")]
public partial record CorporateActionCancellationRejectionStatus1
{
    #nullable enable
    
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_RlNoUNp-Ed-ak6NoX_4Aeg_-1877428616")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason9FormatChoice_> Reason { get; init; } = new ValueList<RejectionReason9FormatChoice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _RlNoUNp-Ed-ak6NoX_4Aeg_-1877428616
    
    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RlNoUdp-Ed-ak6NoX_4Aeg_-1877428585")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
