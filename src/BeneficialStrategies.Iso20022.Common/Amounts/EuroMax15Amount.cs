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
/// Number of monetary units specified in a currency, where the unit of currency is the EUR and compliant with ISO 4217. The decimal separator is a dot, of maximum 15 digits before the dot and 2 after.|Note: A zero amount is not allowed.
/// </summary>
public partial record EuroMax15Amount
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EuroMax15Amount instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EuroMax15Amount( System.String reqCurrency,System.Decimal reqAmount )
    {
        Currency = reqCurrency;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The currency in which this amount is measured.
    /// </summary>
    [IsoId("_VwiZQNp-Ed-ak6NoX_4Aeg_-197866358_Currency")]
    [DisplayName("Euro Max 15 Amount _ Currency")]
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
    [IsoId("_VwiZQNp-Ed-ak6NoX_4Aeg_-197866358_Amount")]
    [DisplayName("Euro Max 15 Amount _ Amount")]
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
