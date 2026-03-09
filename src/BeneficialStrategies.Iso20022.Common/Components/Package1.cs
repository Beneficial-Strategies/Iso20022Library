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
/// Combination of two or more transactions that are reported separately but that are negotiated together as the product of a single economic agreement.
/// </summary>
[IsoId("_6GXWkAFJEeqUa4noT3P56A")]
[DisplayName("Package")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Package1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Package1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Package1( System.String reqComplexTradeIdentification )
    {
        ComplexTradeIdentification = reqComplexTradeIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the identifier determined by the reporting counterparty to connect:|- two or more transactions that are reported separately but that are negotiated together as the product of a single economic agreement,|- or two or more reports pertaining to the same transaction whenever jurisdictional reporting requirement does not allow the transaction to be reported with a single report to TRs.||Usage:|Where the package identifier is not known when a new transaction is reported, the package identifier is updated as it becomes available.
    /// |
    /// </summary>
    [IsoId("_P4pg9eXcEemdgrQysCNNxg")]
    [DisplayName("Complex Trade Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmplxTradId")]
    #endif
    [IsoXmlTag("CmplxTradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ComplexTradeIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ComplexTradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ComplexTradeIdentification { get; init; } 
    #else
    public System.String ComplexTradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the traded price of the entire package in which the reported derivative transaction is a component.
    /// </summary>
    [IsoId("_q4mWcAFKEeqUa4noT3P56A")]
    [DisplayName("Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pric")]
    #endif
    [IsoXmlTag("Pric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice17Choice_? Price { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice17Choice_? Price { get; init; } 
    #else
    public SecuritiesTransactionPrice17Choice_? Price { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the traded price (expressed as a difference between two reference prices) of the entire package in which the reported derivative transaction is a component.
    /// </summary>
    [IsoId("_BTNF0QFMEeqUa4noT3P56A")]
    [DisplayName("Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sprd")]
    #endif
    [IsoXmlTag("Sprd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice13Choice_? Spread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice13Choice_? Spread { get; init; } 
    #else
    public SecuritiesTransactionPrice13Choice_? Spread { get; set; } 
    #endif
    
    
    #nullable disable
    
}
