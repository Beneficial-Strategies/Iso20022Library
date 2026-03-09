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
/// Range of amount values.
/// </summary>
[IsoId("_jomKS5ljEeeE1Ya-LgRsuQ")]
[DisplayName("From To Amount Range")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FromToAmountRange1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FromToAmountRange1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FromToAmountRange1( AmountRangeBoundary1 reqFromAmount,AmountRangeBoundary1 reqToAmount )
    {
        FromAmount = reqFromAmount;
        ToAmount = reqToAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Lower boundary of a range of amount values.
    /// </summary>
    [IsoId("_jw5KoZljEeeE1Ya-LgRsuQ")]
    [DisplayName("From Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrAmt")]
    #endif
    [IsoXmlTag("FrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountRangeBoundary1 FromAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountRangeBoundary1 FromAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountRangeBoundary1 FromAmount { get; init; } 
    #else
    public AmountRangeBoundary1 FromAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Upper boundary of a range of amount values.
    /// </summary>
    [IsoId("_jw5Ko5ljEeeE1Ya-LgRsuQ")]
    [DisplayName("To Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ToAmt")]
    #endif
    [IsoXmlTag("ToAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountRangeBoundary1 ToAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountRangeBoundary1 ToAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountRangeBoundary1 ToAmount { get; init; } 
    #else
    public AmountRangeBoundary1 ToAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
