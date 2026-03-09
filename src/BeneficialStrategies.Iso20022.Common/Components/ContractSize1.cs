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
/// Amount of an underlying of a derivative or security that constitutes one lot of such derivative on an exchange.
/// </summary>
[IsoId("_SCZ9ILb6EeabfchHYoktpA")]
[DisplayName("Contract Size")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractSize1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContractSize1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContractSize1( System.UInt64 reqLotSize )
    {
        LotSize = reqLotSize;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the total quantity of financial product to be delivered as per the terms of the contract.
    /// </summary>
    [IsoId("_QTnOILb8EeabfchHYoktpA")]
    [DisplayName("Lot Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LotSz")]
    #endif
    [IsoXmlTag("LotSz")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPositiveNumber LotSize { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 LotSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 LotSize { get; init; } 
    #else
    public System.UInt64 LotSize { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the unit of underlying.
    /// </summary>
    [IsoId("_O0sZELb8EeabfchHYoktpA")]
    [DisplayName("Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Unit")]
    #endif
    [IsoXmlTag("Unit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure5Choice_? Unit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure5Choice_? Unit { get; init; } 
    #else
    public UnitOfMeasure5Choice_? Unit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
