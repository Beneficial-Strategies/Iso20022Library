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
/// Quantity of a security.
/// </summary>
[IsoId("_SoH21Np-Ed-ak6NoX_4Aeg_-1748202213")]
[DisplayName("Financial Instrument Quantity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentQuantity1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentQuantity1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentQuantity1( System.UInt64 reqUnit )
    {
        Unit = reqUnit;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity expressed as a number, eg, a number of shares.
    /// </summary>
    [IsoId("_SoH21dp-Ed-ak6NoX_4Aeg_-1748202212")]
    [DisplayName("Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Unit")]
    #endif
    [IsoXmlTag("Unit")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumber Unit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Unit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Unit { get; init; } 
    #else
    public System.UInt64 Unit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
