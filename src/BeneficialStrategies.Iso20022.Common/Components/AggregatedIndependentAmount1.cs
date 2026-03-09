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
/// Independent amount could be defined at a trade level or portfolio level. It is assumed that their treatment will be based on the exposure convention that is whether netted together or treated on a gross basis.
/// </summary>
[IsoId("_UlI9I9p-Ed-ak6NoX_4Aeg_1735271850")]
[DisplayName("Aggregated Independent Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AggregatedIndependentAmount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Total independent amount defined in the confirmations of individual trades.
    /// </summary>
    [IsoId("_UlI9JNp-Ed-ak6NoX_4Aeg_-1821696591")]
    [DisplayName("Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trad")]
    #endif
    [IsoXmlTag("Trad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndependentAmount1? Trade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndependentAmount1? Trade { get; init; } 
    #else
    public IndependentAmount1? Trade { get; set; } 
    #endif
    
    /// <summary>
    /// Portfolio level independent amount that reflects portfolio change over a short time period using statistical techniques such as volatility and risk factor correlations.
    /// </summary>
    [IsoId("_UlI9Jdp-Ed-ak6NoX_4Aeg_1452502446")]
    [DisplayName("Value At Risk")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValAtRsk")]
    #endif
    [IsoXmlTag("ValAtRsk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndependentAmount1? ValueAtRisk { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndependentAmount1? ValueAtRisk { get; init; } 
    #else
    public IndependentAmount1? ValueAtRisk { get; set; } 
    #endif
    
    /// <summary>
    /// Portfolio level independent amount related to parties net open position. Net open position means the total of the net long FX and the net options in respect of each currency where: net long FX for any currency shall be the net amount (if any) of that currency which the party “A” is long as against party “B” in respect of all FX transactions.
    /// </summary>
    [IsoId("_UlI9Jtp-Ed-ak6NoX_4Aeg_1859006819")]
    [DisplayName("Net Open Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetOpnPos")]
    #endif
    [IsoXmlTag("NetOpnPos")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndependentAmount1? NetOpenPosition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndependentAmount1? NetOpenPosition { get; init; } 
    #else
    public IndependentAmount1? NetOpenPosition { get; set; } 
    #endif
    
    /// <summary>
    /// Any other amount that should be considered to calculate the independent amount.
    /// </summary>
    [IsoId("_UlI9J9p-Ed-ak6NoX_4Aeg_-928458678")]
    [DisplayName("Other Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAmt")]
    #endif
    [IsoXmlTag("OthrAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndependentAmount2? OtherAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndependentAmount2? OtherAmount { get; init; } 
    #else
    public IndependentAmount2? OtherAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
