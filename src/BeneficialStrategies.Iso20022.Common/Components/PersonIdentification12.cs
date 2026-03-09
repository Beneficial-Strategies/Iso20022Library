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
/// Specifies the identification of a person.
/// </summary>
[IsoId("_eNbcAVyuEeWBopJHIRjb4g")]
[DisplayName("Person Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PersonIdentification12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PersonIdentification12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PersonIdentification12( string reqCountryOfBranch,GenericPersonIdentification1 reqOther )
    {
        CountryOfBranch = reqCountryOfBranch;
        Other = reqOther;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Branch where the trader is located.
    /// </summary>
    [IsoId("_elevo1yuEeWBopJHIRjb4g")]
    [DisplayName("Country Of Branch")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfBrnch")]
    #endif
    [IsoXmlTag("CtryOfBrnch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode CountryOfBranch { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string CountryOfBranch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string CountryOfBranch { get; init; } 
    #else
    public string CountryOfBranch { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of a person, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_elevoVyuEeWBopJHIRjb4g")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericPersonIdentification1 Other { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericPersonIdentification1 Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericPersonIdentification1 Other { get; init; } 
    #else
    public GenericPersonIdentification1 Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
