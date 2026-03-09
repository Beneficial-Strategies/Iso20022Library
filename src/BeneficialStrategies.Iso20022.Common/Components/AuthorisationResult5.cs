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
/// Outcome of the authorisation.
/// </summary>
[IsoId("_AT4g4WlwEeSGkpGpjm7tzg")]
[DisplayName("Authorisation Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AuthorisationResult5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AuthorisationResult5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AuthorisationResult5( ResponseType1 reqResponseToAuthorisation )
    {
        ResponseToAuthorisation = reqResponseToAuthorisation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_AgPh4WlwEeSGkpGpjm7tzg")]
    [DisplayName("Authorisation Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnNtty")]
    #endif
    [IsoXmlTag("AuthstnNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification70? AuthorisationEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification70? AuthorisationEntity { get; init; } 
    #else
    public GenericIdentification70? AuthorisationEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Response to an authorisation request.
    /// </summary>
    [IsoId("_AgPh42lwEeSGkpGpjm7tzg")]
    [DisplayName("Response To Authorisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnToAuthstn")]
    #endif
    [IsoXmlTag("RspnToAuthstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType1 ResponseToAuthorisation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType1 ResponseToAuthorisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType1 ResponseToAuthorisation { get; init; } 
    #else
    public ResponseType1 ResponseToAuthorisation { get; set; } 
    #endif
    
    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_AgPh5WlwEeSGkpGpjm7tzg")]
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
    
    
    #nullable disable
    
}
