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
/// Credit default swap derivative specific for reporting derivatives on a single name.
/// </summary>
[IsoId("_NdTzAX5fEea2k7EBUopqxw")]
[DisplayName("Credit Default Swap Derivative")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditDefaultSwapDerivative4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreditDefaultSwapDerivative4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditDefaultSwapDerivative4( System.String reqObligationIdentification,CreditDefaultSwapSingleName2 reqSingleName )
    {
        ObligationIdentification = reqObligationIdentification;
        SingleName = reqSingleName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Derivative on a credit default swap with the ISIN code of the underlying swap.
    /// </summary>
    [IsoId("_Nmrxc35fEea2k7EBUopqxw")]
    [DisplayName("Underlying Name Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygNmId")]
    #endif
    [IsoXmlTag("UndrlygNmId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISINOct2015Identifier? UnderlyingNameIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UnderlyingNameIdentification { get; init; } 
    #else
    public System.String? UnderlyingNameIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reference obligation for a derivative on a credit default swap.
    /// </summary>
    [IsoId("_NmrxdX5fEea2k7EBUopqxw")]
    [DisplayName("Obligation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OblgtnId")]
    #endif
    [IsoXmlTag("OblgtnId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINOct2015Identifier ObligationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ObligationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ObligationIdentification { get; init; } 
    #else
    public System.String ObligationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the single name specific details the derivative is being made on.
    /// </summary>
    [IsoId("_Nmrxd35fEea2k7EBUopqxw")]
    [DisplayName("Single Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SnglNm")]
    #endif
    [IsoXmlTag("SnglNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CreditDefaultSwapSingleName2 SingleName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CreditDefaultSwapSingleName2 SingleName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDefaultSwapSingleName2 SingleName { get; init; } 
    #else
    public CreditDefaultSwapSingleName2 SingleName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
