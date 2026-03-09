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
/// Expiry and extension information.
/// </summary>
[IsoId("_5uOnIoAAEeGOn4dfTT_QdQ")]
[DisplayName("Expiry Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExpiryDetails2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Terms defining when the undertaking will cease to be available.
    /// </summary>
    [IsoId("_5uOnKIAAEeGOn4dfTT_QdQ")]
    [DisplayName("Expiry Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryTerms")]
    #endif
    [IsoXmlTag("XpryTerms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExpiryTerms2? ExpiryTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpiryTerms2? ExpiryTerms { get; init; } 
    #else
    public ExpiryTerms2? ExpiryTerms { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the expiry and expiry extension.
    /// </summary>
    [IsoId("_5uOnJYAAEeGOn4dfTT_QdQ")]
    [DisplayName("Additional Expiry Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlXpryInf")]
    #endif
    [IsoXmlTag("AddtlXpryInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalExpiryInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
