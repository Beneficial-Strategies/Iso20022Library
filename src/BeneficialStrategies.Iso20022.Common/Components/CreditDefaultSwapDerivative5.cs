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
/// Credit default swap derivative specific for reporting derivatives on a credit default swap index.
/// </summary>
[IsoId("_xS0KYSe0Eei12pGEsJIAeQ")]
[DisplayName("Credit Default Swap Derivative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditDefaultSwapDerivative5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreditDefaultSwapDerivative5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditDefaultSwapDerivative5( CreditDefaultSwapIndex3 reqUnderlyingCreditDefaultSwapIndex )
    {
        UnderlyingCreditDefaultSwapIndex = reqUnderlyingCreditDefaultSwapIndex;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Derivative on a credit default swap with the ISIN code of the underlying swap.
    /// </summary>
    [IsoId("__ZOEYie0Eei12pGEsJIAeQ")]
    [DisplayName("Underlying Credit Default Swap Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygCdtDfltSwpId")]
    #endif
    [IsoXmlTag("UndrlygCdtDfltSwpId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISINOct2015Identifier? UnderlyingCreditDefaultSwapIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UnderlyingCreditDefaultSwapIdentification { get; init; } 
    #else
    public System.String? UnderlyingCreditDefaultSwapIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the Credit Default Swap Index specific details the derivative is being made on.
    /// </summary>
    [IsoId("_xczM1Se0Eei12pGEsJIAeQ")]
    [DisplayName("Underlying Credit Default Swap Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygCdtDfltSwpIndx")]
    #endif
    [IsoXmlTag("UndrlygCdtDfltSwpIndx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDefaultSwapIndex3 UnderlyingCreditDefaultSwapIndex { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDefaultSwapIndex3 UnderlyingCreditDefaultSwapIndex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDefaultSwapIndex3 UnderlyingCreditDefaultSwapIndex { get; init; } 
    #else
    public CreditDefaultSwapIndex3 UnderlyingCreditDefaultSwapIndex { get; set; } 
    #endif
    
    
    #nullable disable
    
}
