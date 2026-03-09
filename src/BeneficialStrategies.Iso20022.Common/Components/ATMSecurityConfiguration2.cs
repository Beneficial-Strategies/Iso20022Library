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
/// Configuration of the cryptographic keys.
/// </summary>
[IsoId("_Di0fIYr7EeSvuOJS0mmL0g")]
[DisplayName("ATM Security Configuration")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMSecurityConfiguration2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Maximum number of symmetric keys the security module is able to manage.
    /// </summary>
    [IsoId("_QbPjEIr7EeSvuOJS0mmL0g")]
    [DisplayName("Maximum Symmetric Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxSmmtrcKey")]
    #endif
    [IsoXmlTag("MaxSmmtrcKey")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumSymmetricKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumSymmetricKey { get; init; } 
    #else
    public System.UInt64? MaximumSymmetricKey { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of asymmetric keys the security module is able to manage.
    /// </summary>
    [IsoId("_T46j0Ir7EeSvuOJS0mmL0g")]
    [DisplayName("Maximum Asymmetric Key")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAsmmtrcKey")]
    #endif
    [IsoXmlTag("MaxAsmmtrcKey")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumAsymmetricKey { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumAsymmetricKey { get; init; } 
    #else
    public System.UInt64? MaximumAsymmetricKey { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum RSA key length (in number of bytes), the security module is able to manage.
    /// </summary>
    [IsoId("_XJMBwIr7EeSvuOJS0mmL0g")]
    [DisplayName("Maximum RSA Key Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxRSAKeyLngth")]
    #endif
    [IsoXmlTag("MaxRSAKeyLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumRSAKeyLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumRSAKeyLength { get; init; } 
    #else
    public System.UInt64? MaximumRSAKeyLength { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum RSA root key length (in number of bytes), the security module is able to manage, if different from the maximum RSA key length.
    /// </summary>
    [IsoId("_acT_YIr7EeSvuOJS0mmL0g")]
    [DisplayName("Maximum Root Key Length")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxRootKeyLngth")]
    #endif
    [IsoXmlTag("MaxRootKeyLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumRootKeyLength { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumRootKeyLength { get; init; } 
    #else
    public System.UInt64? MaximumRootKeyLength { get; set; } 
    #endif
    
    
    #nullable disable
    
}
