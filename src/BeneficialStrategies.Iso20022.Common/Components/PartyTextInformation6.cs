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
/// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
/// </summary>
[IsoId("_0GUwgQVLEeq4ZaI1b_-GPA")]
[DisplayName("Party Text Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyTextInformation6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides declaration details narrative relative to the party.
    /// </summary>
    [IsoId("_0aj7IwVLEeq4ZaI1b_-GPA")]
    [DisplayName("Declaration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrtnDtls")]
    #endif
    [IsoXmlTag("DclrtnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? DeclarationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeclarationDetails { get; init; } 
    #else
    public System.String? DeclarationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_0aj7JQVLEeq4ZaI1b_-GPA")]
    [DisplayName("Party Contact Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyCtctDtls")]
    #endif
    [IsoXmlTag("PtyCtctDtls")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? PartyContactDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartyContactDetails { get; init; } 
    #else
    public System.String? PartyContactDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [IsoId("_0aj7JwVLEeq4ZaI1b_-GPA")]
    [DisplayName("Registration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnDtls")]
    #endif
    [IsoXmlTag("RegnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? RegistrationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RegistrationDetails { get; init; } 
    #else
    public System.String? RegistrationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Address of the nominee company that holds the assets at the transfer agent or International Central Securities Depository or Central Securities Depository on behalf of the party.
    /// </summary>
    [IsoId("_N37GUAVMEeq4ZaI1b_-GPA")]
    [DisplayName("Registration Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnAdr")]
    #endif
    [IsoXmlTag("RegnAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress1? RegistrationAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress1? RegistrationAddress { get; init; } 
    #else
    public PostalAddress1? RegistrationAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
