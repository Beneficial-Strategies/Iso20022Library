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
/// Statement information of an account.
/// </summary>
[IsoId("_O9ETgYq8EeSHjtO_wHA7PQ")]
[DisplayName("ATM Account Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMAccountStatement2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMAccountStatement2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMAccountStatement2( ImpliedCurrencyAndAmount reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date of the transaction.
    /// </summary>
    [IsoId("_eeqZIIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Transaction Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDt")]
    #endif
    [IsoXmlTag("TxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TransactionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TransactionDate { get; init; } 
    #else
    public System.DateOnly? TransactionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Value date of the transaction.
    /// </summary>
    [IsoId("_iEU4QIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValueDate { get; init; } 
    #else
    public System.DateOnly? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Short text to display or print for the statement.
    /// </summary>
    [IsoId("_p2DvMIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Short Text")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtTxt")]
    #endif
    [IsoXmlTag("ShrtTxt")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? ShortText { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShortText { get; init; } 
    #else
    public System.String? ShortText { get; set; } 
    #endif
    
    /// <summary>
    /// True if credit transaction.
    /// </summary>
    [IsoId("_tS5pgIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Credit Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtTx")]
    #endif
    [IsoXmlTag("CdtTx")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CreditTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditTransaction { get; init; } 
    #else
    public System.String? CreditTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_zc0OEIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount Amount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the amount.
    /// </summary>
    [IsoId("_5RrIoIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Alternative text of the statement to print or display.
    /// </summary>
    [IsoId("_99CrkIq8EeSHjtO_wHA7PQ")]
    [DisplayName("Long Text")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LngTxt")]
    #endif
    [IsoXmlTag("LngTxt")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? LongText { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LongText { get; init; } 
    #else
    public System.String? LongText { get; set; } 
    #endif
    
    
    #nullable disable
    
}
