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
/// Set of elements used to qualify the interest rate.
/// </summary>
[IsoId("_uoQ2MbTVEee_k7HqaUKERA")]
[DisplayName("Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Rate4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Rate4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Rate4( RateType4Choice_ reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of interest rate.
    /// </summary>
    [IsoId("_uwTX47TVEee_k7HqaUKERA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RateType4Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RateType4Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateType4Choice_ Type { get; init; } 
    #else
    public RateType4Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// An amount range where the interest rate is applicable.
    /// </summary>
    [IsoId("_uwTX5bTVEee_k7HqaUKERA")]
    [DisplayName("Validity Range")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyRg")]
    #endif
    [IsoXmlTag("VldtyRg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmountRange2? ValidityRange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmountRange2? ValidityRange { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmountRange2? ValidityRange { get; set; } 
    #endif
    
    
    #nullable disable
    
}
