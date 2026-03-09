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
/// Details of fraudulent case.
/// </summary>
[IsoId("_08BmYcZdEeiCDcGzDHI_9Q")]
[DisplayName("Fraud Case Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FraudCaseDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of market segment of confirmed fraud.
    /// </summary>
    [IsoId("_EVHQQsZeEeiCDcGzDHI_9Q")]
    [DisplayName("Market Segment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktSgmt")]
    #endif
    [IsoXmlTag("MktSgmt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MarketSegment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MarketSegment { get; init; } 
    #else
    public System.String? MarketSegment { get; set; } 
    #endif
    
    /// <summary>
    /// Locator reference.
    /// </summary>
    [IsoId("_EVHQQ8ZeEeiCDcGzDHI_9Q")]
    [DisplayName("Locator Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LctrNb")]
    #endif
    [IsoXmlTag("LctrNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LocatorNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LocatorNumber { get; init; } 
    #else
    public System.String? LocatorNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to fraudulent case.
    /// </summary>
    [IsoId("_EVHQRMZeEeiCDcGzDHI_9Q")]
    [DisplayName("Case Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CaseRef")]
    #endif
    [IsoXmlTag("CaseRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CaseReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CaseReference { get; init; } 
    #else
    public System.String? CaseReference { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the party that committed fraud was arrested or not.
    /// False: the party was not arrested
    /// True: the party was arrested
    /// Default: False
    /// </summary>
    [IsoId("_EVHQRcZeEeiCDcGzDHI_9Q")]
    [DisplayName("Arrest Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ArrstInd")]
    #endif
    [IsoXmlTag("ArrstInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ArrestIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ArrestIndicator { get; init; } 
    #else
    public System.String? ArrestIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
