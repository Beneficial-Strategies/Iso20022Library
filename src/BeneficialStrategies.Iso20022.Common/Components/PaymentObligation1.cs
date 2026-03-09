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
/// Payment obligation contracted between two financial institutions related to the financing of a commercial transaction.
/// </summary>
[IsoId("_TmaED9p-Ed-ak6NoX_4Aeg_596881925")]
[DisplayName("Payment Obligation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentObligation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentObligation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentObligation1( BICIdentification1 reqObligorBank,BICIdentification1 reqRecipientBank,CurrencyAndAmount reqAmount,System.Decimal reqPercentage,System.DateOnly reqExpiryDate )
    {
        ObligorBank = reqObligorBank;
        RecipientBank = reqRecipientBank;
        Amount = reqAmount;
        Percentage = reqPercentage;
        ExpiryDate = reqExpiryDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Bank that has to pay under the obligation.
    /// </summary>
    [IsoId("_Tmj1ANp-Ed-ak6NoX_4Aeg_1171310523")]
    [DisplayName("Obligor Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OblgrBk")]
    #endif
    [IsoXmlTag("OblgrBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 ObligorBank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 ObligorBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 ObligorBank { get; init; } 
    #else
    public BICIdentification1 ObligorBank { get; set; } 
    #endif
    
    /// <summary>
    /// Bank that will be paid under the obligation.
    /// </summary>
    [IsoId("_Tmj1Adp-Ed-ak6NoX_4Aeg_1183317260")]
    [DisplayName("Recipient Bank")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptBk")]
    #endif
    [IsoXmlTag("RcptBk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 RecipientBank { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 RecipientBank { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 RecipientBank { get; init; } 
    #else
    public BICIdentification1 RecipientBank { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum amount that will be paid under the obligation.
    /// </summary>
    [IsoId("_Tmj1Atp-Ed-ak6NoX_4Aeg_1036477395")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount Amount { get; init; } 
    #else
    public CurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum amount that will be paid under the obligation, expressed as a percentage of the purchase order net amount.
    /// </summary>
    [IsoId("_Tmj1A9p-Ed-ak6NoX_4Aeg_68097507")]
    [DisplayName("Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pctg")]
    #endif
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Percentage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Percentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Percentage { get; init; } 
    #else
    public System.Decimal Percentage { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the charges taken by the obligor bank.
    /// </summary>
    [IsoId("_Tmj1BNp-Ed-ak6NoX_4Aeg_-899180987")]
    [DisplayName("Charges Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsAmt")]
    #endif
    [IsoXmlTag("ChrgsAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyAndAmount? ChargesAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount? ChargesAmount { get; init; } 
    #else
    public CurrencyAndAmount? ChargesAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the charges expressed as a percentage of the amount paid by the obligor bank.
    /// </summary>
    [IsoId("_Tmj1Bdp-Ed-ak6NoX_4Aeg_-870552237")]
    [DisplayName("Charges Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsPctg")]
    #endif
    [IsoXmlTag("ChrgsPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ChargesPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ChargesPercentage { get; init; } 
    #else
    public System.Decimal? ChargesPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the obligation will expire.
    /// </summary>
    [IsoId("_Tmj1Btp-Ed-ak6NoX_4Aeg_1478843016")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate ExpiryDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly ExpiryDate { get; init; } 
    #else
    public System.DateOnly ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Country of which the law governs the bank payment obligation.
    /// </summary>
    [IsoId("_Tmj1B9p-Ed-ak6NoX_4Aeg_-154804792")]
    [DisplayName("Applicable Law")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AplblLaw")]
    #endif
    [IsoXmlTag("AplblLaw")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? ApplicableLaw { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? ApplicableLaw { get; init; } 
    #else
    public string? ApplicableLaw { get; set; } 
    #endif
    
    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_Tms-8Np-Ed-ak6NoX_4Aeg_1971081576")]
    [DisplayName("Payment Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTerms")]
    #endif
    [IsoXmlTag("PmtTerms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTerms2? PaymentTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTerms2? PaymentTerms { get; init; } 
    #else
    public PaymentTerms2? PaymentTerms { get; set; } 
    #endif
    
    /// <summary>
    /// Instruction between two clearing agents stipulating the cash transfer characteristics between the two parties.
    /// </summary>
    [IsoId("_Tms-8dp-Ed-ak6NoX_4Aeg_-935706746")]
    [DisplayName("Settlement Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTerms")]
    #endif
    [IsoXmlTag("SttlmTerms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTerms2? SettlementTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTerms2? SettlementTerms { get; init; } 
    #else
    public SettlementTerms2? SettlementTerms { get; set; } 
    #endif
    
    
    #nullable disable
    
}
