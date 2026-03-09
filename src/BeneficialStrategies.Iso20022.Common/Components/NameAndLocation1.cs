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
/// Provides the identification of the reported party through the name and the location.
/// </summary>
[IsoId("_ZxnU2cEcEea7jLfvGi1PDw")]
[DisplayName("Name And Location")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NameAndLocation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NameAndLocation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NameAndLocation1( System.String reqName,string reqLocation )
    {
        Name = reqName;
        Location = reqLocation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Internal name of the counterparty of the reporting agent used by the reporting agent.
    /// </summary>
    [IsoId("_x2XHQcEcEea7jLfvGi1PDw")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Name { get; init; } 
    #else
    public System.String Name { get; set; } 
    #endif
    
    /// <summary>
    /// Location of the country in which the counterparty is incorporated.
    /// </summary>
    [IsoId("_Z6PFU8EcEea7jLfvGi1PDw")]
    [DisplayName("Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lctn")]
    #endif
    [IsoXmlTag("Lctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode Location { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Location { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Location { get; init; } 
    #else
    public string Location { get; set; } 
    #endif
    
    
    #nullable disable
    
}
