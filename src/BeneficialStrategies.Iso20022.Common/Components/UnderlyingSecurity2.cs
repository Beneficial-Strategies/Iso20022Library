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
/// Securitised right for entitlement, for example, equity or bond.
/// </summary>
[IsoId("_XA2xrdp-Ed-ak6NoX_4Aeg_-661527747")]
[DisplayName("Underlying Security")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnderlyingSecurity2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnderlyingSecurity2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnderlyingSecurity2( SecurityIdentification12 reqSecurityIdentification )
    {
        SecurityIdentification = reqSecurityIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_XA2xrtp-Ed-ak6NoX_4Aeg_1382534833")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification12 SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification12 SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification12 SecurityIdentification { get; init; } 
    #else
    public SecurityIdentification12 SecurityIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
