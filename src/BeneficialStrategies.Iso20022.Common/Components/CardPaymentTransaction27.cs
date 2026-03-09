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
/// Cancellation response from the acquirer.
/// </summary>
[IsoId("_LEtegTJWEeO58eY-wGOnqw")]
[DisplayName("Card Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransaction27
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentTransaction27 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentTransaction27( AuthorisationResult3 reqAuthorisationResult )
    {
        AuthorisationResult = reqAuthorisationResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_LVqroTJWEeO58eY-wGOnqw")]
    [DisplayName("Authorisation Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnRslt")]
    #endif
    [IsoXmlTag("AuthstnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AuthorisationResult3 AuthorisationResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AuthorisationResult3 AuthorisationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthorisationResult3 AuthorisationResult { get; init; } 
    #else
    public AuthorisationResult3 AuthorisationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_LVqrozJWEeO58eY-wGOnqw")]
    [DisplayName("Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actn")]
    #endif
    [IsoXmlTag("Actn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Action1? Action { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Action1? Action { get; init; } 
    #else
    public Action1? Action { get; set; } 
    #endif
    
    
    #nullable disable
    
}
