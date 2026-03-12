// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the reponse to the interest payment request.
/// </summary>
[IsoId("_Qki1hNp-Ed-ak6NoX_4Aeg_1044109408")]
[DisplayName("Interest Response")]
public partial record InterestResponse1
{
    #nullable enable
    
    /// <summary>
    /// Provides the type of the response, either accepted or rejected.
    /// </summary>
    [IsoId("_Qki1hdp-Ed-ak6NoX_4Aeg_-1991695647")]
    [DisplayName("Response Type")]
    [IsoXmlTag("RspnTp")]
    public required Status4Code ResponseType { get; init; } 
    
    /// <summary>
    /// Provides a reason for rejection identified using a code or a proprietary format.
    /// </summary>
    [IsoId("_Qki1htp-Ed-ak6NoX_4Aeg_749006670")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    public RejectionReason21FormatChoice_? RejectionReason { get; init; } 
    
    /// <summary>
    /// Provides additional information on the rejection reason.
    /// </summary>
    [IsoId("_Qki1h9p-Ed-ak6NoX_4Aeg_-1579101885")]
    [DisplayName("Rejection Reason Information")]
    [IsoXmlTag("RjctnRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? RejectionReasonInformation { get; init; } 
    
    /// <summary>
    /// Provides the reference to the interest payment request.
    /// </summary>
    [IsoId("_Qki1iNp-Ed-ak6NoX_4Aeg_1472856857")]
    [DisplayName("Interest Payment Request Identification")]
    [IsoXmlTag("IntrstPmtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text InterestPaymentRequestIdentification { get; init; } 
    
    
    #nullable disable
    
}
