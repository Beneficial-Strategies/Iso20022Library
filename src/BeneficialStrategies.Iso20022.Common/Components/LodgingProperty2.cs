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
/// Company in charge of a lodging establishment
/// </summary>
[IsoId("_-3z8AcWlEeuhguwJmlgagQ")]
[DisplayName("Lodging Property")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LodgingProperty2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LodgingProperty2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LodgingProperty2( PartyIdentification258 reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of accommodations.
    /// </summary>
    [IsoId("_-8GmIcWlEeuhguwJmlgagQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LodgingActivity1Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LodgingActivity1Code? Type { get; init; } 
    #else
    public LodgingActivity1Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of lodging establishment when Other National or Other Private is selected as a type code. 
    /// </summary>
    [IsoId("_-8GmI8WlEeuhguwJmlgagQ")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier that describes the lodging establishment as a prestigious property. 
    /// </summary>
    [IsoId("_-8GmJcWlEeuhguwJmlgagQ")]
    [DisplayName("Prestigious Property")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrstgsPrprty")]
    #endif
    [IsoXmlTag("PrstgsPrprty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? PrestigiousProperty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PrestigiousProperty { get; init; } 
    #else
    public System.String? PrestigiousProperty { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the property.
    /// </summary>
    [IsoId("_-8GmJ8WlEeuhguwJmlgagQ")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the lodging company.
    /// </summary>
    [IsoId("_-8GmKcWlEeuhguwJmlgagQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification258 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification258 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification258 Identification { get; init; } 
    #else
    public PartyIdentification258 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Address of the property.
    /// </summary>
    [IsoId("_-8GmK8WlEeuhguwJmlgagQ")]
    [DisplayName("Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lctn")]
    #endif
    [IsoXmlTag("Lctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Location4? Location { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Location4? Location { get; init; } 
    #else
    public Location4? Location { get; set; } 
    #endif
    
    /// <summary>
    /// Party in charge of assigning the identification.
    /// </summary>
    [IsoId("_-8GmLcWlEeuhguwJmlgagQ")]
    [DisplayName("Assigner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnr")]
    #endif
    [IsoXmlTag("Assgnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompanyAssigner2Code? Assigner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompanyAssigner2Code? Assigner { get; init; } 
    #else
    public CompanyAssigner2Code? Assigner { get; set; } 
    #endif
    
    /// <summary>
    /// Contact details at property.
    /// </summary>
    [IsoId("_-8GmL8WlEeuhguwJmlgagQ")]
    [DisplayName("Contact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctct")]
    #endif
    [IsoXmlTag("Ctct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Contact3? Contact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Contact3? Contact { get; init; } 
    #else
    public Contact3? Contact { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the property.
    /// ISO 3166
    /// </summary>
    [IsoId("_-8GmMcWlEeuhguwJmlgagQ")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISOMax3ACountryCode? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Country { get; init; } 
    #else
    public string? Country { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the lodging facility complies with the US Hotel and Motel Fire Safety Act of 1990 (PL101-391) or similar legislation.
    /// True = in compliance
    /// False = not in compliance
    /// </summary>
    [IsoId("_-8GmM8WlEeuhguwJmlgagQ")]
    [DisplayName("Fire Safety Act Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FireSftyActInd")]
    #endif
    [IsoXmlTag("FireSftyActInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? FireSafetyActIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FireSafetyActIndicator { get; init; } 
    #else
    public System.String? FireSafetyActIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
