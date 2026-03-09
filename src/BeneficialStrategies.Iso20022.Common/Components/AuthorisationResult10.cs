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
/// Outcome of the authorisation, and actions to perform.
/// </summary>
[IsoId("_2XRDEY0wEeW1W6lLicSC4w")]
[DisplayName("Authorisation Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AuthorisationResult10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AuthorisationResult10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AuthorisationResult10( ResponseType5 reqResponseToAuthorisation )
    {
        ResponseToAuthorisation = reqResponseToAuthorisation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_2iTOYY0wEeW1W6lLicSC4w")]
    [DisplayName("Authorisation Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnNtty")]
    #endif
    [IsoXmlTag("AuthstnNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification90? AuthorisationEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification90? AuthorisationEntity { get; init; } 
    #else
    public GenericIdentification90? AuthorisationEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Response to an authorisation request.
    /// </summary>
    [IsoId("_2iTOY40wEeW1W6lLicSC4w")]
    [DisplayName("Response To Authorisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnToAuthstn")]
    #endif
    [IsoXmlTag("RspnToAuthstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType5 ResponseToAuthorisation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType5 ResponseToAuthorisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType5 ResponseToAuthorisation { get; init; } 
    #else
    public ResponseType5 ResponseToAuthorisation { get; set; } 
    #endif
    
    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_2iTOZY0wEeW1W6lLicSC4w")]
    [DisplayName("Authorisation Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnCd")]
    #endif
    [IsoXmlTag("AuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Min6Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 6)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin6Max8Text? AuthorisationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthorisationCode { get; init; } 
    #else
    public System.String? AuthorisationCode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the acquirer requires a further exchange completion after the completion of the transaction.
    /// </summary>
    [IsoId("_2iTOZ40wEeW1W6lLicSC4w")]
    [DisplayName("Completion Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpltnReqrd")]
    #endif
    [IsoXmlTag("CmpltnReqrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CompletionRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CompletionRequired { get; init; } 
    #else
    public System.String? CompletionRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Instructs the point of interaction (POI) how to contact the host to initiate the maintenance of the terminal.
    /// </summary>
    [IsoId("_2iTOaY0wEeW1W6lLicSC4w")]
    [DisplayName("TMS Trigger")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMSTrggr")]
    #endif
    [IsoXmlTag("TMSTrggr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TMSTrigger1? TMSTrigger { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TMSTrigger1? TMSTrigger { get; init; } 
    #else
    public TMSTrigger1? TMSTrigger { get; set; } 
    #endif
    
    
    #nullable disable
    
}
