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
/// Provides information about securities quantity linked to a corporate action option.
/// </summary>
[IsoId("_JSKGfef6Eei5aPS232E3Mw")]
[DisplayName("Securities Quantity SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesQuantitySD6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity not fully covered.
    /// </summary>
    [IsoId("_J0O4t-f6Eei5aPS232E3Mw")]
    [DisplayName("Open Uncovered Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpnUcvrdQty")]
    #endif
    [IsoXmlTag("OpnUcvrdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity31Choice_? OpenUncoveredQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity31Choice_? OpenUncoveredQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity31Choice_? OpenUncoveredQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity covered but transactions not in &quot;MADE&quot; status.
    /// </summary>
    [IsoId("_J0O4uef6Eei5aPS232E3Mw")]
    [DisplayName("Interim Covered Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmCvrdQty")]
    #endif
    [IsoXmlTag("IntrmCvrdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity31Choice_? InterimCoveredQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity31Choice_? InterimCoveredQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity31Choice_? InterimCoveredQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
