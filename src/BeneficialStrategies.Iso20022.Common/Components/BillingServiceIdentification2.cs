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
/// Identification of the service to be billed.
/// </summary>
[IsoId("_6PWmxpqlEeGSON8vddiWzQ_-1512913674")]
[DisplayName("Billing Service Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingServiceIdentification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingServiceIdentification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingServiceIdentification2( System.String reqIdentification,System.String reqDescription )
    {
        Identification = reqIdentification;
        Description = reqDescription;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial institution&apos;s own, internal service identification code, different from the common code.|Usage: The financial institution own code is used to uniquely identify the service within the financial institution.
    /// </summary>
    [IsoId("_6PWmx5qlEeGSON8vddiWzQ_1784981269")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the financial institution sub-service identification if the financial institution service identification code is used for more than one service.
    /// </summary>
    [IsoId("_6PWmyJqlEeGSON8vddiWzQ_674069850")]
    [DisplayName("Sub Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubSvc")]
    #endif
    [IsoXmlTag("SubSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingSubServiceIdentification1? SubService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingSubServiceIdentification1? SubService { get; init; } 
    #else
    public BillingSubServiceIdentification1? SubService { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies further details to describe the financial institution service description, which is not the standard description related to the common code.
    /// </summary>
    [IsoId("_6PgXwJqlEeGSON8vddiWzQ_559746653")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text Description { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Description { get; init; } 
    #else
    public System.String Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
