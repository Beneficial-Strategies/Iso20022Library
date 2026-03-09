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
/// Quantity expressed as a number and its details.
/// </summary>
[IsoId("_72Uo4xgKEeKqWJINzXcn5g")]
[DisplayName("Unit")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Unit4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Unit4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Unit4( FinancialInstrumentQuantity1 reqTotalUnitsNumber )
    {
        TotalUnitsNumber = reqTotalUnitsNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity expressed as a number, for example, a number of shares.
    /// </summary>
    [IsoId("_jQnpABgLEeKqWJINzXcn5g")]
    [DisplayName("Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlUnitsNb")]
    #endif
    [IsoXmlTag("TtlUnitsNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    #else
    public FinancialInstrumentQuantity1 TotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    [IsoId("_swUdoBgLEeKqWJINzXcn5g")]
    [DisplayName("Unit Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitDtls")]
    #endif
    [IsoXmlTag("UnitDtls")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Unit5> UnitDetails { get; init; } = new ValueList<Unit5>(){};
    
    
    #nullable disable
    
}
