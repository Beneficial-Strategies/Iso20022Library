// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Method of voting participation to a general meeting.
/// </summary>
[IsoId("_XENzQRrlEeyhRdHRjakS2w")]
[DisplayName("Participation Method")]
public partial record ParticipationMethod2
{
    #nullable enable
    
    /// <summary>
    /// Method of voting participation to the general meeting.
    /// </summary>
    [IsoId("_XZhU4RrlEeyhRdHRjakS2w")]
    [DisplayName("Participation Method")]
    [IsoXmlTag("PrtcptnMtd")]
    public required ParticipationMethod3Choice_ ParticipationMethod { get; init; } 
    
    /// <summary>
    /// Deadline for voting on agenda resolutions at the general meeting.
    /// </summary>
    [IsoId("_XZhU4xrlEeyhRdHRjakS2w")]
    [DisplayName("Issuer Deadline For Voting")]
    [IsoXmlTag("IssrDdlnForVtng")]
    public required DateFormat58Choice_ IssuerDeadlineForVoting { get; init; } 
    
    /// <summary>
    /// Indicates whether the specific participation method proposed by the issuer is supported by the account servicer.
    /// </summary>
    [IsoId("_X2ut8BroEeyhRdHRjakS2w")]
    [DisplayName("Supported By Account Servicer")]
    [IsoXmlTag("SpprtdByAcctSvcr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SupportedByAccountServicer { get; init; } 
    
    /// <summary>
    /// Account servicer deadline for voting on agenda resolutions at the general meeting.
    /// </summary>
    [IsoId("_iIeDgBroEeyhRdHRjakS2w")]
    [DisplayName("Response Deadline For Voting")]
    [IsoXmlTag("RspnDdlnForVtng")]
    public DateFormat58Choice_? ResponseDeadlineForVoting { get; init; } 
    
    
    #nullable disable
    
}
