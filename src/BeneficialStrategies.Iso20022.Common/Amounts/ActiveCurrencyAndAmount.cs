// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Amounts;

/// <summary>
/// A number of monetary units specified in an active currency where the unit of currency is explicit and compliant with ISO 4217.
/// </summary>
public partial record ActiveCurrencyAndAmount
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ActiveCurrencyAndAmount instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ActiveCurrencyAndAmount( System.String reqCurrency,System.Decimal reqAmount )
    {
        Currency = reqCurrency;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The currency in which this amount is measured.
    /// </summary>
    [IsoId("_YX4O9tp-Ed-ak6NoX_4Aeg_-836081793_Currency")]
    [DisplayName("Active Currency And Amount _ Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Currency")]
    #endif
    [IsoXmlTag("Currency")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required System.String Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Currency { get; init; } 
    #else
    public System.String Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_YX4O9tp-Ed-ak6NoX_4Aeg_-836081793_Amount")]
    [DisplayName("Active Currency And Amount _ Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amount")]
    #endif
    [IsoXmlTag("Amount")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required System.Decimal Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Amount { get; init; } 
    #else
    public System.Decimal Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
