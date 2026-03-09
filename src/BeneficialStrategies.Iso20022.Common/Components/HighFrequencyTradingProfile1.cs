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
/// Information about a high frequency trading profile.
/// </summary>
[IsoId("_O87qwCDUEeWCLu74WLgP4w")]
[DisplayName("High Frequency Trading Profile")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record HighFrequencyTradingProfile1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which the investor starts high frequency trading.
    /// </summary>
    [IsoId("_dfZOoCDUEeWCLu74WLgP4w")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? Date { get; init; } 
    #else
    public System.DateOnly? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of settlement.
    /// </summary>
    [IsoId("_gilS0CDUEeWCLu74WLgP4w")]
    [DisplayName("Settlement Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmFrqcy")]
    #endif
    [IsoXmlTag("SttlmFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementFrequency1Choice_? SettlementFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementFrequency1Choice_? SettlementFrequency { get; init; } 
    #else
    public SettlementFrequency1Choice_? SettlementFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether consolidation is done generally or at the level of segregated account.
    /// </summary>
    [IsoId("_KtmHECDVEeWCLu74WLgP4w")]
    [DisplayName("Consolidation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnsldtnTp")]
    #endif
    [IsoXmlTag("CnsldtnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConsolidationType1Choice_? ConsolidationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConsolidationType1Choice_? ConsolidationType { get; init; } 
    #else
    public ConsolidationType1Choice_? ConsolidationType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
