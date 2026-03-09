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
/// Alternate identification for a party using an identification type, a country code and a text field.
/// </summary>
[IsoId("_gAZqAYMEEeWhGPRU7TIQwQ")]
[DisplayName("Alternate Party Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AlternatePartyIdentification8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AlternatePartyIdentification8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AlternatePartyIdentification8( IdentificationType43Choice_ reqIdentificationType,string reqCountry,System.String reqAlternateIdentification )
    {
        IdentificationType = reqIdentificationType;
        Country = reqCountry;
        AlternateIdentification = reqAlternateIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of alternate identification of the party identified.
    /// </summary>
    [IsoId("_gWRMU4MEEeWhGPRU7TIQwQ")]
    [DisplayName("Identification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IdTp")]
    #endif
    [IsoXmlTag("IdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IdentificationType43Choice_ IdentificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IdentificationType43Choice_ IdentificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IdentificationType43Choice_ IdentificationType { get; init; } 
    #else
    public IdentificationType43Choice_ IdentificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Nation with its own government, occupying a particular territory.
    /// </summary>
    [IsoId("_gWRMW4MEEeWhGPRU7TIQwQ")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode Country { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Country { get; init; } 
    #else
    public string Country { get; set; } 
    #endif
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_gWRMY4MEEeWhGPRU7TIQwQ")]
    [DisplayName("Alternate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnId")]
    #endif
    [IsoXmlTag("AltrnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AlternateIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AlternateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AlternateIdentification { get; init; } 
    #else
    public System.String AlternateIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
