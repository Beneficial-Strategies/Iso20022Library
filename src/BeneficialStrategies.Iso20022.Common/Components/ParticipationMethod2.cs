// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Method of voting participation to a general meeting.
/// </summary>
[IsoId("_XENzQRrlEeyhRdHRjakS2w")]
[DisplayName("Participation Method")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ParticipationMethod2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ParticipationMethod2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ParticipationMethod2( ParticipationMethod3Choice_ reqParticipationMethod,DateFormat58Choice_ reqIssuerDeadlineForVoting )
    {
        ParticipationMethod = reqParticipationMethod;
        IssuerDeadlineForVoting = reqIssuerDeadlineForVoting;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method of voting participation to the general meeting.
    /// </summary>
    [IsoId("_XZhU4RrlEeyhRdHRjakS2w")]
    [DisplayName("Participation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtcptnMtd")]
    #endif
    [IsoXmlTag("PrtcptnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ParticipationMethod3Choice_ ParticipationMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ParticipationMethod3Choice_ ParticipationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ParticipationMethod3Choice_ ParticipationMethod { get; init; } 
    #else
    public ParticipationMethod3Choice_ ParticipationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Deadline for voting on agenda resolutions at the general meeting.
    /// </summary>
    [IsoId("_XZhU4xrlEeyhRdHRjakS2w")]
    [DisplayName("Issuer Deadline For Voting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrDdlnForVtng")]
    #endif
    [IsoXmlTag("IssrDdlnForVtng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat58Choice_ IssuerDeadlineForVoting { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat58Choice_ IssuerDeadlineForVoting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_ IssuerDeadlineForVoting { get; init; } 
    #else
    public DateFormat58Choice_ IssuerDeadlineForVoting { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the specific participation method proposed by the issuer is supported by the account servicer.
    /// </summary>
    [IsoId("_X2ut8BroEeyhRdHRjakS2w")]
    [DisplayName("Supported By Account Servicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpprtdByAcctSvcr")]
    #endif
    [IsoXmlTag("SpprtdByAcctSvcr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SupportedByAccountServicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SupportedByAccountServicer { get; init; } 
    #else
    public System.String? SupportedByAccountServicer { get; set; } 
    #endif
    
    /// <summary>
    /// Account servicer deadline for voting on agenda resolutions at the general meeting.
    /// </summary>
    [IsoId("_iIeDgBroEeyhRdHRjakS2w")]
    [DisplayName("Response Deadline For Voting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnDdlnForVtng")]
    #endif
    [IsoXmlTag("RspnDdlnForVtng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? ResponseDeadlineForVoting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? ResponseDeadlineForVoting { get; init; } 
    #else
    public DateFormat58Choice_? ResponseDeadlineForVoting { get; set; } 
    #endif
    
    
    #nullable disable
    
}
