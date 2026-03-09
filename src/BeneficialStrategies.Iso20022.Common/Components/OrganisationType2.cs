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
/// Specifies a type of identification requested for an organisation.
/// </summary>
[IsoId("_AGP6yeH5Eeqbls7Gk4-ckA")]
[DisplayName("Organisation Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OrganisationType2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Business identification code of the organisation is requested.
    /// Usage: When absent (default value), the identification is not requested. 
    /// </summary>
    [IsoId("_AIL0ceH5Eeqbls7Gk4-ckA")]
    [DisplayName("Any BIC")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AnyBIC")]
    #endif
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? AnyBIC { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AnyBIC { get; init; } 
    #else
    public System.String? AnyBIC { get; set; } 
    #endif
    
    /// <summary>
    /// Legal entity identification as an alternate identification for a party is requested.
    /// Usage: When absent (default value), the identification is not requested. 
    /// </summary>
    [IsoId("_AIL0c-H5Eeqbls7Gk4-ckA")]
    [DisplayName("LEI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LEI")]
    #endif
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? LEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LEI { get; init; } 
    #else
    public System.String? LEI { get; set; } 
    #endif
    
    /// <summary>
    /// Address for electronic mail (e-mail) is requested.
    /// Usage: When absent (default value), the identification is not requested. 
    /// </summary>
    [IsoId("_MfUwQeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Email Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EmailAdr")]
    #endif
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? EmailAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EmailAddress { get; init; } 
    #else
    public System.String? EmailAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of an organisation, as assigned by an institution, using an identification scheme is requested.
    /// </summary>
    [IsoId("_AIL0deH5Eeqbls7Gk4-ckA")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericOrganisationType1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericOrganisationType1? Other { get; init; } 
    #else
    public GenericOrganisationType1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
