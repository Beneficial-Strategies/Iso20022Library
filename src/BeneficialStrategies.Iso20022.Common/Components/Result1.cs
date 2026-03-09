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
/// Summation of the call amounts either due to A or due to B.
/// </summary>
[IsoId("_UlvaEtp-Ed-ak6NoX_4Aeg_1884281908")]
[DisplayName("Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Result1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount payable by party B to party A.
    /// </summary>
    [IsoId("_UlvaE9p-Ed-ak6NoX_4Aeg_-97807248")]
    [DisplayName("Due To Party A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DueToPtyA")]
    #endif
    [IsoXmlTag("DueToPtyA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? DueToPartyA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? DueToPartyA { get; init; } 
    #else
    public ActiveCurrencyAndAmount? DueToPartyA { get; set; } 
    #endif
    
    /// <summary>
    /// Amount payable by party A to party B.
    /// </summary>
    [IsoId("_UlvaFNp-Ed-ak6NoX_4Aeg_-1435615045")]
    [DisplayName("Due To Party B")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DueToPtyB")]
    #endif
    [IsoXmlTag("DueToPtyB")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? DueToPartyB { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? DueToPartyB { get; init; } 
    #else
    public ActiveCurrencyAndAmount? DueToPartyB { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information related to the collateral that may be requested.
    /// </summary>
    [IsoId("_UlvaFdp-Ed-ak6NoX_4Aeg_903687993")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
