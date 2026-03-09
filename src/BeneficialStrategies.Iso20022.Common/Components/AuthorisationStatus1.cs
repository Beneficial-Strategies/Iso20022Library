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
/// Authorisation status about the fraudulent transaction.
/// </summary>
[IsoId("_HhcNkHbNEeef9c2nwgY9Xw")]
[DisplayName("Authorisation Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AuthorisationStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction was authorised or not.
    /// False: transaction was not authorised
    /// True: transaction was authorised
    /// </summary>
    [IsoId("_yZqtIHbNEeef9c2nwgY9Xw")]
    [DisplayName("Authorisation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnInd")]
    #endif
    [IsoXmlTag("AuthstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AuthorisationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthorisationIndicator { get; init; } 
    #else
    public System.String? AuthorisationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the entity which authorised the transaction (if relevant).
    /// </summary>
    [IsoId("_9p_x4HbNEeef9c2nwgY9Xw")]
    [DisplayName("Authorisation Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnNtty")]
    #endif
    [IsoXmlTag("AuthstnNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyType26Code? AuthorisationEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType26Code? AuthorisationEntity { get; init; } 
    #else
    public PartyType26Code? AuthorisationEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of authorisation entity.
    /// </summary>
    [IsoId("_jsIsQHbOEeef9c2nwgY9Xw")]
    [DisplayName("Other Authorisation Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAuthstnNtty")]
    #endif
    [IsoXmlTag("OthrAuthstnNtty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherAuthorisationEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherAuthorisationEntity { get; init; } 
    #else
    public System.String? OtherAuthorisationEntity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
