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
/// Acquirer of the withdrawal transaction, in charge of the funds settlement with the issuer.
/// </summary>
[IsoId("_077-4Yn1EeS9F4Qrq_eaVA")]
[DisplayName("Acquirer")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Acquirer7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the acquirer.
    /// </summary>
    [IsoId("_1Ivr0Yn1EeS9F4Qrq_eaVA")]
    [DisplayName("Acquiring Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrgInstn")]
    #endif
    [IsoXmlTag("AcqrgInstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AcquiringInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcquiringInstitution { get; init; } 
    #else
    public System.String? AcquiringInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the acquirer branch.
    /// </summary>
    [IsoId("_1Ivr04n1EeS9F4Qrq_eaVA")]
    [DisplayName("Branch")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brnch")]
    #endif
    [IsoXmlTag("Brnch")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Branch { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Branch { get; init; } 
    #else
    public System.String? Branch { get; set; } 
    #endif
    
    
    #nullable disable
    
}
