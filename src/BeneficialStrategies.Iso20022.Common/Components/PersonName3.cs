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
/// Identifies a person via its first name and surname.
/// </summary>
[IsoId("_FhKN1bqcEemCAOifqHrKJw")]
[DisplayName("Person Name")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PersonName3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PersonName3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PersonName3( System.String reqFirstName,System.String reqSurname )
    {
        FirstName = reqFirstName;
        Surname = reqSurname;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Prefix, as a title before a person&apos;s name.
    /// </summary>
    [IsoId("_LmDvgbqcEemCAOifqHrKJw")]
    [DisplayName("Name Prefix")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmPrfx")]
    #endif
    [IsoXmlTag("NmPrfx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NamePrefix2Code? NamePrefix { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NamePrefix2Code? NamePrefix { get; init; } 
    #else
    public NamePrefix2Code? NamePrefix { get; set; } 
    #endif
    
    /// <summary>
    /// First name(s) by which a natural person is known.
    /// </summary>
    [IsoId("_FhKN2LqcEemCAOifqHrKJw")]
    [DisplayName("First Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstNm")]
    #endif
    [IsoXmlTag("FrstNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text FirstName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FirstName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FirstName { get; init; } 
    #else
    public System.String FirstName { get; set; } 
    #endif
    
    /// <summary>
    /// Name (s) by which a natural person is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_FhKN2bqcEemCAOifqHrKJw")]
    [DisplayName("Surname")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Srnm")]
    #endif
    [IsoXmlTag("Srnm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text Surname { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Surname { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Surname { get; init; } 
    #else
    public System.String Surname { get; set; } 
    #endif
    
    /// <summary>
    /// Postal address of the party.
    /// </summary>
    [IsoId("_FhKN17qcEemCAOifqHrKJw")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress26? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress26? Address { get; init; } 
    #else
    public PostalAddress26? Address { get; set; } 
    #endif
    
    
    #nullable disable
    
}
