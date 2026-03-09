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
/// Details of the transaction in the authorisation response contained in a batch.
/// </summary>
[IsoId("_5ZOFMfnGEeaYndR2y_Ep9g")]
[DisplayName("Card Payment Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransactionDetails43
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentTransactionDetails43 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentTransactionDetails43( ImpliedCurrencyAndAmount reqTotalAmount )
    {
        TotalAmount = reqTotalAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_5rlAgfnGEeaYndR2y_Ep9g")]
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
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_5rlAg_nGEeaYndR2y_Ep9g")]
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
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_5rlAhfnGEeaYndR2y_Ep9g")]
    [DisplayName("Detailed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtldAmt")]
    #endif
    [IsoXmlTag("DtldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount15? DetailedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount15? DetailedAmount { get; init; } 
    #else
    public DetailedAmount15? DetailedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the transaction that will be invoiced to the cardholder.
    /// </summary>
    [IsoId("_5rlAh_nGEeaYndR2y_Ep9g")]
    [DisplayName("Invoice Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcAmt")]
    #endif
    [IsoXmlTag("InvcAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? InvoiceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? InvoiceAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? InvoiceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_5rlnkfnGEeaYndR2y_Ep9g")]
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
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_5rlnk_nGEeaYndR2y_Ep9g")]
    [DisplayName("Account Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTp")]
    #endif
    [IsoXmlTag("AcctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccountType3Code? AccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccountType3Code? AccountType { get; init; } 
    #else
    public CardAccountType3Code? AccountType { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_5rlnlfnGEeaYndR2y_Ep9g")]
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
