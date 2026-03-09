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
/// Specifies a multi-leg interest derivative.
/// </summary>
[IsoId("_pMapccnYEeWpf-ImB_F2gQ")]
[DisplayName("Derivative Interest")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativeInterest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DerivativeInterest2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DerivativeInterest2( string reqOtherNotionalCurrency )
    {
        OtherNotionalCurrency = reqOtherNotionalCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency in which leg 2 of the contract is denominated, in case of multi-currency or cross-currency swaps.
    /// Currency in which leg 2 of the swap is denominated, in case of swaptions where the underlying swap is multi-currency.
    /// </summary>
    [IsoId("_pqvkNcnYEeWpf-ImB_F2gQ")]
    [DisplayName("Other Notional Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrNtnlCcy")]
    #endif
    [IsoXmlTag("OthrNtnlCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode OtherNotionalCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string OtherNotionalCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string OtherNotionalCurrency { get; init; } 
    #else
    public string OtherNotionalCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
