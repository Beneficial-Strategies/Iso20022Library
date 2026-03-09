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
/// Information provided to claim funds
/// </summary>
[IsoId("_jh2RQBcTEeit0dtP9bTmEg")]
[DisplayName("Claim Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ClaimInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Code presented by the customer to claim funds.
    /// </summary>
    [IsoId("_yZs2UBcTEeit0dtP9bTmEg")]
    [DisplayName("Claim Credentials")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClmCrdntls")]
    #endif
    [IsoXmlTag("ClmCrdntls")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? ClaimCredentials { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClaimCredentials { get; init; } 
    #else
    public System.String? ClaimCredentials { get; set; } 
    #endif
    
    /// <summary>
    /// Entity issuing the claim credential.
    /// </summary>
    [IsoId("_65wy4BcTEeit0dtP9bTmEg")]
    [DisplayName("Assigner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Assgnr")]
    #endif
    [IsoXmlTag("Assgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Assigner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Assigner { get; init; } 
    #else
    public System.String? Assigner { get; set; } 
    #endif
    
    
    #nullable disable
    
}
