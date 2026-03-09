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
/// Information for the first side of the transaction.
/// </summary>
[IsoId("_k2Zhy__9Eemefbt-QjTNnA")]
[DisplayName("Collateral Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralType14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specific to securities and related fields used as a collateral.
    /// </summary>
    [IsoId("_k7YIYf_9Eemefbt-QjTNnA")]
    [DisplayName("Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scty")]
    #endif
    [IsoXmlTag("Scty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Security16? Security { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Security16? Security { get; init; } 
    #else
    public Security16? Security { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of funds provided as collateral for borrowing the securities or commodities.
    /// </summary>
    [IsoId("_k7YIY__9Eemefbt-QjTNnA")]
    [DisplayName("Cash")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Csh")]
    #endif
    [IsoXmlTag("Csh")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountHaircutMargin1? Cash { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountHaircutMargin1? Cash { get; init; } 
    #else
    public AmountHaircutMargin1? Cash { get; set; } 
    #endif
    
    /// <summary>
    /// Data specific to commodities and related fields used as a collateral.
    /// </summary>
    [IsoId("_k7YIZf_9Eemefbt-QjTNnA")]
    [DisplayName("Commodity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmmdty")]
    #endif
    [IsoXmlTag("Cmmdty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commodity20? Commodity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commodity20? Commodity { get; init; } 
    #else
    public Commodity20? Commodity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
