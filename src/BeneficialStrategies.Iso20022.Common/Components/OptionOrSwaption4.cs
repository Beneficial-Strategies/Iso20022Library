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
/// Option or swaption related attributes.
/// </summary>
[IsoId("_5YqYgagAEeW_OId9wS8dsQ")]
[DisplayName("Option Or Swaption")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OptionOrSwaption4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of the Option whether it is a call option (right to purchase a specific underlying asset) or a put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_5xdTAagAEeW_OId9wS8dsQ")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionType2Code? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType2Code? OptionType { get; init; } 
    #else
    public OptionType2Code? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_5xdTA6gAEeW_OId9wS8dsQ")]
    [DisplayName("Strike Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StrkPric")]
    #endif
    [IsoXmlTag("StrkPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice3Choice_? StrikePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice3Choice_? StrikePrice { get; init; } 
    #else
    public SecuritiesTransactionPrice3Choice_? StrikePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Indication as to whether the option may be exercised only at a fixed date (European, and Asian style), a series of pre-specified dates (Bermudan) or at any time during the life of the contract (American style). This field does not have to be populated for ISIN instruments.
    /// </summary>
    [IsoId("_5xdTB6gAEeW_OId9wS8dsQ")]
    [DisplayName("Option Exercise Style")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnExrcStyle")]
    #endif
    [IsoXmlTag("OptnExrcStyle")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionStyle6Code? OptionExerciseStyle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionStyle6Code? OptionExerciseStyle { get; init; } 
    #else
    public OptionStyle6Code? OptionExerciseStyle { get; set; } 
    #endif
    
    /// <summary>
    /// In case of swaptions, maturity date of the underlying swap.
    /// </summary>
    [IsoId("_5xdTCagAEeW_OId9wS8dsQ")]
    [DisplayName("Maturity Date Of Underlying")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDtOfUndrlyg")]
    #endif
    [IsoXmlTag("MtrtyDtOfUndrlyg")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MaturityDateOfUnderlying { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MaturityDateOfUnderlying { get; init; } 
    #else
    public System.DateOnly? MaturityDateOfUnderlying { get; set; } 
    #endif
    
    
    #nullable disable
    
}
