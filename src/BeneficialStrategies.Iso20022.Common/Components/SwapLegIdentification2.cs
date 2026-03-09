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
/// Details of the legs of swap transaction.
/// </summary>
[IsoId("_Ky7eRYG-EeaalK9UbuVGFw")]
[DisplayName("Swap Leg Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SwapLegIdentification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Instrument received by the buyer.
    /// </summary>
    [IsoId("_K9fvgYG-EeaalK9UbuVGFw")]
    [DisplayName("Swap In")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SwpIn")]
    #endif
    [IsoXmlTag("SwpIn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentIdentification7Choice_? SwapIn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentIdentification7Choice_? SwapIn { get; init; } 
    #else
    public FinancialInstrumentIdentification7Choice_? SwapIn { get; set; } 
    #endif
    
    /// <summary>
    /// Instrument paid by the buyer.
    /// </summary>
    [IsoId("_K9fvg4G-EeaalK9UbuVGFw")]
    [DisplayName("Swap Out")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SwpOut")]
    #endif
    [IsoXmlTag("SwpOut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentIdentification7Choice_? SwapOut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentIdentification7Choice_? SwapOut { get; init; } 
    #else
    public FinancialInstrumentIdentification7Choice_? SwapOut { get; set; } 
    #endif
    
    
    #nullable disable
    
}
