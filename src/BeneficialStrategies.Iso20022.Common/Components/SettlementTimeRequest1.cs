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
/// Information on the requested settlement time of the instruction.
/// </summary>
[IsoId("_QHyBEdp-Ed-ak6NoX_4Aeg_564730971")]
[DisplayName("Settlement Time Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementTimeRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementTimeRequest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementTimeRequest1( System.TimeOnly reqCLSTime )
    {
        CLSTime = reqCLSTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Time by which the funds must be credited, with confirmation, to the CLS Bank&apos;s account at the central bank, expressed in Central European Time (CET).
    /// </summary>
    [IsoId("_QHyBEtp-Ed-ak6NoX_4Aeg_605366498")]
    [DisplayName("CLS Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CLSTm")]
    #endif
    [IsoXmlTag("CLSTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISOTime CLSTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.TimeOnly CLSTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly CLSTime { get; init; } 
    #else
    public System.TimeOnly CLSTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
