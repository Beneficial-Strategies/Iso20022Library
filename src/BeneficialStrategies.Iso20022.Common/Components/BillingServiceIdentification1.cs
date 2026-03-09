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
[IsoId("_6PWmwJqlEeGSON8vddiWzQ_-1688870750")]
[DisplayName("Billing Service Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingServiceIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingServiceIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingServiceIdentification1( System.String reqIdentification,System.String reqDescription )
    {
        Identification = reqIdentification;
        Description = reqDescription;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Financial institution&apos;s own, internal service identification code, different from the common code.|Usage: The financial institution own code is used to uniquely identify the service within the financial institution.
    /// </summary>
    [IsoId("_6PWmwZqlEeGSON8vddiWzQ_958913297")]
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
    [IsoId("_6PWmwpqlEeGSON8vddiWzQ_577029016")]
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
    [IsoId("_6PWmw5qlEeGSON8vddiWzQ_912294769")]
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
    
    /// <summary>
    /// Standard reference code used to uniquely identify this service across financial institutions. This is not the financial institution’s internal bank service identification.
    /// </summary>
    [IsoId("_6PWmxJqlEeGSON8vddiWzQ_84412588")]
    [DisplayName("Common Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonCd")]
    #endif
    [IsoXmlTag("CmonCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingServiceCommonIdentification1? CommonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingServiceCommonIdentification1? CommonCode { get; init; } 
    #else
    public BillingServiceCommonIdentification1? CommonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Type used to classify or organise different services by common characteristics.
    /// </summary>
    [IsoId("_6PWmxZqlEeGSON8vddiWzQ_2126236147")]
    [DisplayName("Service Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcTp")]
    #endif
    [IsoXmlTag("SvcTp")]
    [IsoSimpleType(IsoSimpleType.Max12Text)]
    [StringLength(maximumLength: 12 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax12Text? ServiceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceType { get; init; } 
    #else
    public System.String? ServiceType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
