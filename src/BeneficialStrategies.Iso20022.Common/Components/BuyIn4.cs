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
/// Specifies elements related to the notification (or warn) sent by the central counterparty to the clearing member in the context of the buy in process.
/// </summary>
[IsoId("_7xh9US9WEeS94oXWDaBauA")]
[DisplayName("Buy In")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BuyIn4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BuyIn4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BuyIn4( DateFormat15Choice_ reqExpectedBuyInDate )
    {
        ExpectedBuyInDate = reqExpectedBuyInDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the message is a warning only or a notification.
    /// </summary>
    [IsoId("_8D9KES9WEeS94oXWDaBauA")]
    [DisplayName("Warning Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WrngInd")]
    #endif
    [IsoXmlTag("WrngInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? WarningIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WarningIndicator { get; init; } 
    #else
    public System.String? WarningIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the date at which the buy-in will occur.
    /// </summary>
    [IsoId("_8D9KEy9WEeS94oXWDaBauA")]
    [DisplayName("Expected Buy In Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdBuyInDt")]
    #endif
    [IsoXmlTag("XpctdBuyInDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat15Choice_ ExpectedBuyInDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat15Choice_ ExpectedBuyInDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat15Choice_ ExpectedBuyInDate { get; init; } 
    #else
    public DateFormat15Choice_ ExpectedBuyInDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the latest date by which the buy-in operation can be cancelled.
    /// </summary>
    [IsoId("_VXBUUC9YEeS94oXWDaBauA")]
    [DisplayName("Cancellation Limit Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlLmtDt")]
    #endif
    [IsoXmlTag("CxlLmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? CancellationLimitDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? CancellationLimitDate { get; init; } 
    #else
    public System.DateOnly? CancellationLimitDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the date by which the buy-in operation is reversed by the CCP.
    /// </summary>
    [IsoId("_T7O2UC9ZEeS94oXWDaBauA")]
    [DisplayName("Buy In Reversion Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyInRvrsnDt")]
    #endif
    [IsoXmlTag("BuyInRvrsnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? BuyInReversionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? BuyInReversionDate { get; init; } 
    #else
    public System.DateOnly? BuyInReversionDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
