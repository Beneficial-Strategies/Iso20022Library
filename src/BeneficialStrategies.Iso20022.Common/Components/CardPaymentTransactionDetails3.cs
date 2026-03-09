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
/// Details of the transaction in the completion advice.
/// </summary>
[IsoId("_TDwwywEcEeCQm6a_G2yO_w_-1880748120")]
[DisplayName("Card Payment Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransactionDetails3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentTransactionDetails3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentTransactionDetails3( string reqCurrency,ImpliedCurrencyAndAmount reqTotalAmount )
    {
        Currency = reqCurrency;
        TotalAmount = reqTotalAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_TDwwzAEcEeCQm6a_G2yO_w_332445650")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyCode Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Currency { get; init; } 
    #else
    public string Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_TDwwzQEcEeCQm6a_G2yO_w_972188653")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount TotalAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    [IsoId("_TD56sAEcEeCQm6a_G2yO_w_1005348422")]
    [DisplayName("Amount Qualifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtQlfr")]
    #endif
    [IsoXmlTag("AmtQlfr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfAmount1Code? AmountQualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount1Code? AmountQualifier { get; init; } 
    #else
    public TypeOfAmount1Code? AmountQualifier { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_TD56sQEcEeCQm6a_G2yO_w_-122207633")]
    [DisplayName("Detailed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldAmt")]
    #endif
    [IsoXmlTag("DtldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount1? DetailedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount1? DetailedAmount { get; init; } 
    #else
    public DetailedAmount1? DetailedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_TD56sgEcEeCQm6a_G2yO_w_776759709")]
    [DisplayName("Validity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyDt")]
    #endif
    [IsoXmlTag("VldtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValidityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValidityDate { get; init; } 
    #else
    public System.DateOnly? ValidityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    [IsoId("_TD56swEcEeCQm6a_G2yO_w_293560490")]
    [DisplayName("Unattended Level Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UattnddLvlCtgy")]
    #endif
    [IsoXmlTag("UattnddLvlCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UnattendedLevelCategory { get; init; } 
    #else
    public System.String? UnattendedLevelCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_TD56tAEcEeCQm6a_G2yO_w_1054325643")]
    [DisplayName("Account Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTp")]
    #endif
    [IsoXmlTag("AcctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccountType1Code? AccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccountType1Code? AccountType { get; init; } 
    #else
    public CardAccountType1Code? AccountType { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_TD56tQEcEeCQm6a_G2yO_w_333398876")]
    [DisplayName("Recurring Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrngTx")]
    #endif
    [IsoXmlTag("RcrngTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RecurringTransaction1? RecurringTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RecurringTransaction1? RecurringTransaction { get; init; } 
    #else
    public RecurringTransaction1? RecurringTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Product purchased with the transaction.
    /// </summary>
    [IsoId("_TD56tgEcEeCQm6a_G2yO_w_208461033")]
    [DisplayName("Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pdct")]
    #endif
    [IsoXmlTag("Pdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Product1? Product { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Product1? Product { get; init; } 
    #else
    public Product1? Product { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_TD56twEcEeCQm6a_G2yO_w_1081475433")]
    [DisplayName("ICC Related Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ICCRltdData")]
    #endif
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ICCRelatedData { get; init; } 
    #else
    public System.Byte[]? ICCRelatedData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
