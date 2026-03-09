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
/// Information related to counterparty identification.
/// </summary>
[IsoId("_-X1pgeXDEemhPvlMxbmo_g")]
[DisplayName("Counterparty")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Counterparty31
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Counterparty31 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Counterparty31( PartyIdentification235Choice_ reqIdentificationType )
    {
        IdentificationType = reqIdentificationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The code of country where the registered office of the other counterparty is located or country of residence in case that the other counterparty is a natural person.
    /// </summary>
    [IsoId("_-lqDE-XDEemhPvlMxbmo_g")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Country { get; init; } 
    #else
    public string? Country { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the counterparty is a legal entity or a natural person.
    /// </summary>
    [IsoId("_fSkuYO9KEemVGdgB8P8uQQ")]
    [DisplayName("Identification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdTp")]
    #endif
    [IsoXmlTag("IdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification235Choice_ IdentificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification235Choice_ IdentificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification235Choice_ IdentificationType { get; init; } 
    #else
    public PartyIdentification235Choice_ IdentificationType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
