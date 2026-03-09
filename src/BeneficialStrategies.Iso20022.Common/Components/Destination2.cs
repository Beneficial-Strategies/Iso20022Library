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
/// Contains the details of the destination. 
/// </summary>
[IsoId("_REQg1fQbEeihCvvpsmGI2w")]
[DisplayName("Destination")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Destination2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name and location of the destination.
    /// </summary>
    [IsoId("_REQg2fQbEeihCvvpsmGI2w")]
    [DisplayName("Name And Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmAndLctn")]
    #endif
    [IsoXmlTag("NmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax99Text? NameAndLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NameAndLocation { get; init; } 
    #else
    public System.String? NameAndLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Specific address of the destination.
    /// </summary>
    [IsoId("_REQg1_QbEeihCvvpsmGI2w")]
    [DisplayName("Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adr")]
    #endif
    [IsoXmlTag("Adr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Address1? Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Address1? Address { get; init; } 
    #else
    public Address1? Address { get; set; } 
    #endif
    
    
    #nullable disable
    
}
