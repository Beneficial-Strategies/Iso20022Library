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
/// Specifies corporate action dates.
/// </summary>
[IsoId("_Ts3lL199Ee262vCSVgjImg")]
[DisplayName("Corporate Action Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDate93
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date/time at which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    [IsoId("_Ts3lM199Ee262vCSVgjImg")]
    [DisplayName("Record Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrdDt")]
    #endif
    [IsoXmlTag("RcrdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat41Choice_? RecordDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat41Choice_? RecordDate { get; init; } 
    #else
    public DateFormat41Choice_? RecordDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    [IsoId("_Ts3lO199Ee262vCSVgjImg")]
    [DisplayName("Ex Dividend Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExDvddDt")]
    #endif
    [IsoXmlTag("ExDvddDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat41Choice_? ExDividendDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat41Choice_? ExDividendDate { get; init; } 
    #else
    public DateFormat41Choice_? ExDividendDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder&apos;s positions. This is also applicable to partial calls.
    /// </summary>
    [IsoId("_Ts3lQ199Ee262vCSVgjImg")]
    [DisplayName("Lottery Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtryDt")]
    #endif
    [IsoXmlTag("LtryDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat41Choice_? LotteryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat41Choice_? LotteryDate { get; init; } 
    #else
    public DateFormat41Choice_? LotteryDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
