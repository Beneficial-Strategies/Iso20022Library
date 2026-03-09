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
/// Identifies the financial instrument.
/// </summary>
[IsoId("_TBTL1dp-Ed-ak6NoX_4Aeg_1946780155")]
[DisplayName("Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrument15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrument15( SecurityIdentification6Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument using a choice of either ISIN, local code, or a description of the instrument. ISIN is the preferred format.
    /// </summary>
    [IsoId("_TBTL1tp-Ed-ak6NoX_4Aeg_1946780251")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification6Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification6Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification6Choice_ Identification { get; init; } 
    #else
    public SecurityIdentification6Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the ability to describe the instrument through a description and main characteristics.
    /// </summary>
    [IsoId("_TBc80Np-Ed-ak6NoX_4Aeg_1946780178")]
    [DisplayName("Instrument Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrmDesc")]
    #endif
    [IsoXmlTag("InstrmDesc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityInstrumentDescription2? InstrumentDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityInstrumentDescription2? InstrumentDescription { get; init; } 
    #else
    public SecurityInstrumentDescription2? InstrumentDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details of the underlying financial instrument for which the transaction report is being sent. If there is more than one underlying financial instrument then it is the dominant/ultimate instrument that should be identified here.
    /// </summary>
    [IsoId("_TBc80dp-Ed-ak6NoX_4Aeg_1946780234")]
    [DisplayName("Underlying Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygInstrmId")]
    #endif
    [IsoXmlTag("UndrlygInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification6Choice_? UnderlyingInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification6Choice_? UnderlyingInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification6Choice_? UnderlyingInstrumentIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
