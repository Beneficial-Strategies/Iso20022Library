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
/// Margin required to cover the risk because of the price fluctuations occurred on the unsettled exposures towards the central counterparty.
/// </summary>
[IsoId("_Uk2CNNp-Ed-ak6NoX_4Aeg_-526751507")]
[DisplayName("Total Variation Margin")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TotalVariationMargin1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TotalVariationMargin1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TotalVariationMargin1( Amount2 reqAmountDetails )
    {
        AmountDetails = reqAmountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the variation margin position is short or long, that is, wether the balance is a negative or positive balance.
    /// </summary>
    [IsoId("_Uk2CNdp-Ed-ak6NoX_4Aeg_-1149405445")]
    [DisplayName("Short Long Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtLngInd")]
    #endif
    [IsoXmlTag("ShrtLngInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ShortLong1Code? ShortLongIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShortLong1Code? ShortLongIndicator { get; init; } 
    #else
    public ShortLong1Code? ShortLongIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the variation margin amount in the reporting currency and optionally in the original currency.
    /// </summary>
    [IsoId("_Uk2CNtp-Ed-ak6NoX_4Aeg_464053575")]
    [DisplayName("Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtDtls")]
    #endif
    [IsoXmlTag("AmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount2 AmountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount2 AmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2 AmountDetails { get; init; } 
    #else
    public Amount2 AmountDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
