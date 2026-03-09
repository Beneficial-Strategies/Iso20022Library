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
/// Indicators about rate lock.
/// </summary>
[IsoId("_vL6cgIZ7EeuSbct6WWD-Ng")]
[DisplayName("Rate Lock")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RateLock1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates if a rate lock is or was requested.
    /// </summary>
    [IsoId("_Gd4uMIZ8EeuSbct6WWD-Ng")]
    [DisplayName("Requested Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdInd")]
    #endif
    [IsoXmlTag("ReqdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? RequestedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RequestedIndicator { get; init; } 
    #else
    public System.String? RequestedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the transaction is rate lock eligible.
    /// </summary>
    [IsoId("_epXawIZ8EeuSbct6WWD-Ng")]
    [DisplayName("Eligible Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgblInd")]
    #endif
    [IsoXmlTag("ElgblInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? EligibleIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EligibleIndicator { get; init; } 
    #else
    public System.String? EligibleIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if a rate lock was applied.
    /// </summary>
    [IsoId("_ja7FQIZ8EeuSbct6WWD-Ng")]
    [DisplayName("Applied Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApldInd")]
    #endif
    [IsoXmlTag("ApldInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AppliedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AppliedIndicator { get; init; } 
    #else
    public System.String? AppliedIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
