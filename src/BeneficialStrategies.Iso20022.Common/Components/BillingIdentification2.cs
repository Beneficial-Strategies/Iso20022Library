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
/// Unique identifier of a the related Invoice.
/// </summary>
[IsoId("_ee6h2-F6EeWCAvUNsZ5u6g")]
[DisplayName("Billing Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingIdentification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingIdentification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingIdentification2( System.String reqBillingIdentification )
    {
        BillingIdentification = reqBillingIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique reference of a the related Invoice.
    /// </summary>
    [IsoId("_eqOZ8-F6EeWCAvUNsZ5u6g")]
    [DisplayName("Billing Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BllgId")]
    #endif
    [IsoXmlTag("BllgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text BillingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BillingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BillingIdentification { get; init; } 
    #else
    public System.String BillingIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
