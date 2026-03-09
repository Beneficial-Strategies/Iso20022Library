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
/// Additional references linked to the updated interest request such the original InterestRequest identification, and optionaly the InterestResponse identification.
/// </summary>
[IsoId("_Qkr_cNp-Ed-ak6NoX_4Aeg_2036685643")]
[DisplayName("Reference")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Reference20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Reference20 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Reference20( System.String reqInterestPaymentRequestIdentification )
    {
        InterestPaymentRequestIdentification = reqInterestPaymentRequestIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the reference to the interest payment request.
    /// </summary>
    [IsoId("_Qkr_cdp-Ed-ak6NoX_4Aeg_-1576527728")]
    [DisplayName("Interest Payment Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstPmtReqId")]
    #endif
    [IsoXmlTag("IntrstPmtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text InterestPaymentRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InterestPaymentRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InterestPaymentRequestIdentification { get; init; } 
    #else
    public System.String InterestPaymentRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the reference to the interest payment response.
    /// </summary>
    [IsoId("_Qkr_ctp-Ed-ak6NoX_4Aeg_-1163077636")]
    [DisplayName("Interest Payment Response Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstPmtRspnId")]
    #endif
    [IsoXmlTag("IntrstPmtRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? InterestPaymentResponseIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InterestPaymentResponseIdentification { get; init; } 
    #else
    public System.String? InterestPaymentResponseIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
