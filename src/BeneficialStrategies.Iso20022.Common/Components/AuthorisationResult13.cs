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
/// Outcome of the withdrawal authorisation.
/// </summary>
[IsoId("_rG8tga1-EeWMg5rOByfExw")]
[DisplayName("Authorisation Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AuthorisationResult13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AuthorisationResult13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AuthorisationResult13( ResponseType7 reqAuthorisationResponse )
    {
        AuthorisationResponse = reqAuthorisationResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_rUW3Ya1-EeWMg5rOByfExw")]
    [DisplayName("Authorisation Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnNtty")]
    #endif
    [IsoXmlTag("AuthstnNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyType16Code? AuthorisationEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType16Code? AuthorisationEntity { get; init; } 
    #else
    public PartyType16Code? AuthorisationEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the authorisation.
    /// </summary>
    [IsoId("_rUW3Y61-EeWMg5rOByfExw")]
    [DisplayName("Authorisation Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnRspn")]
    #endif
    [IsoXmlTag("AuthstnRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType7 AuthorisationResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType7 AuthorisationResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType7 AuthorisationResponse { get; init; } 
    #else
    public ResponseType7 AuthorisationResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trace of response by the entities in the path from the issuer to the ATM.
    /// </summary>
    [IsoId("_NjiBAK2AEeWMg5rOByfExw")]
    [DisplayName("Response Trace")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnTrac")]
    #endif
    [IsoXmlTag("RspnTrac")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResponseType8? ResponseTrace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType8? ResponseTrace { get; init; } 
    #else
    public ResponseType8? ResponseTrace { get; set; } 
    #endif
    
    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_rUW3Z61-EeWMg5rOByfExw")]
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
    /// Sequence of actions to be performed by the ATM to complete the transaction.
    /// </summary>
    [IsoId("_rUW3aa1-EeWMg5rOByfExw")]
    [DisplayName("Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actn")]
    #endif
    [IsoXmlTag("Actn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Action7? Action { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Action7? Action { get; init; } 
    #else
    public Action7? Action { get; set; } 
    #endif
    
    
    #nullable disable
    
}
