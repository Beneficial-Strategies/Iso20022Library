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
/// Amount of money debited or credited on the books of an account servicer.
/// </summary>
[IsoId("_WSOKB9p-Ed-ak6NoX_4Aeg_-1965842707")]
[DisplayName("Amount And Direction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountAndDirection19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountAndDirection19 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountAndDirection19( RestrictedFINActiveCurrencyAndAmount reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money that is debited or credited.
    /// </summary>
    [IsoId("_WSOKCNp-Ed-ak6NoX_4Aeg_334979883")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RestrictedFINActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RestrictedFINActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RestrictedFINActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public RestrictedFINActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the amount is a debited or a credited.
    /// </summary>
    [IsoId("_WSOKCdp-Ed-ak6NoX_4Aeg_-1659164823")]
    [DisplayName("Credit Debit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbt")]
    #endif
    [IsoXmlTag("CdtDbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebitCode? CreditDebit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode? CreditDebit { get; init; } 
    #else
    public CreditDebitCode? CreditDebit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
