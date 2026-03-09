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
/// Credit default swap derivative specific for reporting derivatives on a credit default swap index.
/// </summary>
[IsoId("_xfbL2X5eEea2k7EBUopqxw")]
[DisplayName("Credit Default Swap Index")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CreditDefaultSwapIndex2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CreditDefaultSwapIndex2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CreditDefaultSwapIndex2( string reqNotionalCurrency )
    {
        NotionalCurrency = reqNotionalCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Series number of the composition of the index if applicable.
    /// </summary>
    [IsoId("_xtQzgX5eEea2k7EBUopqxw")]
    [DisplayName("Series")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Srs")]
    #endif
    [IsoXmlTag("Srs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Series { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Series { get; init; } 
    #else
    public System.UInt64? Series { get; set; } 
    #endif
    
    /// <summary>
    /// New version of a series is issued if one of the constituents defaults and the index has to be re-weighted to account for the new number of total constituents within the index.
    /// </summary>
    [IsoId("_xtQzg35eEea2k7EBUopqxw")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Version { get; init; } 
    #else
    public System.UInt64? Version { get; set; } 
    #endif
    
    /// <summary>
    /// All months when the roll is expected as established by the index provider for a given year. Field should be repeated for each month in the roll.
    /// </summary>
    [IsoId("_xtQzhX5eEea2k7EBUopqxw")]
    [DisplayName("Roll Month")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RollMnth")]
    #endif
    [IsoXmlTag("RollMnth")]
    [IsoSimpleType(IsoSimpleType.RestrictedMonthExact2Number)]
    [MinLength(0)]
    [MaxLength(12)]
    public SimpleValueList<System.UInt64> RollMonth { get; init; } = new SimpleValueList<System.UInt64>(){};
    
    /// <summary>
    /// To be populated in the case of a CDS Index or a derivative CDS Index with the next roll date of the index as established by the index provider.
    /// </summary>
    [IsoId("_xtQzh35eEea2k7EBUopqxw")]
    [DisplayName("Next Roll Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NxtRollDt")]
    #endif
    [IsoXmlTag("NxtRollDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? NextRollDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? NextRollDate { get; init; } 
    #else
    public System.DateOnly? NextRollDate { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_xtQziX5eEea2k7EBUopqxw")]
    [DisplayName("Notional Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlCcy")]
    #endif
    [IsoXmlTag("NtnlCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode NotionalCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string NotionalCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string NotionalCurrency { get; init; } 
    #else
    public string NotionalCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
