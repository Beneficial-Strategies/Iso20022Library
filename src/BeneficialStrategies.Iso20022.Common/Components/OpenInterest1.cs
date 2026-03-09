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
/// Measure of the current stock of a financial instrument that has been traded on an exchange or cleared via a central counterparty.
/// </summary>
[IsoId("_XEpRcLVZEeadLcJesEbkTQ")]
[DisplayName("Open Interest")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OpenInterest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OpenInterest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OpenInterest1( ActiveCurrencyAnd24Amount reqGrossNotionalAmount )
    {
        GrossNotionalAmount = reqGrossNotionalAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Gross notional of product cleared, if applicable.
    /// </summary>
    [IsoId("_bzGkoLVZEeadLcJesEbkTQ")]
    [DisplayName("Gross Notional Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssNtnlAmt")]
    #endif
    [IsoXmlTag("GrssNtnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAnd24Amount GrossNotionalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAnd24Amount GrossNotionalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd24Amount GrossNotionalAmount { get; init; } 
    #else
    public ActiveCurrencyAnd24Amount GrossNotionalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Open interest in number of lots, if applicable.
    /// </summary>
    [IsoId("_nF1dILVZEeadLcJesEbkTQ")]
    [DisplayName("Number Of Lots")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfLots")]
    #endif
    [IsoXmlTag("NbOfLots")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? NumberOfLots { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfLots { get; init; } 
    #else
    public System.UInt64? NumberOfLots { get; set; } 
    #endif
    
    
    #nullable disable
    
}
