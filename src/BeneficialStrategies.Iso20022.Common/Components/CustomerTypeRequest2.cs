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
/// Specifies the type of customer identification requested.
/// </summary>
[IsoId("_AEhcceH5Eeqbls7Gk4-ckA")]
[DisplayName("Customer Type Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomerTypeRequest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CustomerTypeRequest2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustomerTypeRequest2( System.String reqRequested )
    {
        Requested = reqRequested;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the customer identification is required by the creditor or not.
    /// </summary>
    [IsoId("_AGP6w-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Requested")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Reqd")]
    #endif
    [IsoXmlTag("Reqd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRequestedIndicator Requested { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Requested { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Requested { get; init; } 
    #else
    public System.String Requested { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which type of customer identification is requested for an organisation.
    /// </summary>
    [IsoId("_AGP6xeH5Eeqbls7Gk4-ckA")]
    [DisplayName("Organisation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgTp")]
    #endif
    [IsoXmlTag("OrgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationType2? OrganisationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationType2? OrganisationType { get; init; } 
    #else
    public OrganisationType2? OrganisationType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which type of customer identification is requested for a person.
    /// </summary>
    [IsoId("_AGP6x-H5Eeqbls7Gk4-ckA")]
    [DisplayName("Private Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvtTp")]
    #endif
    [IsoXmlTag("PrvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PersonType2? PrivateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonType2? PrivateType { get; init; } 
    #else
    public PersonType2? PrivateType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
