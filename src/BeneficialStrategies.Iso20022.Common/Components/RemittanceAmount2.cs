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
/// Nature of the amount and currency on a document referred to in the remittance section, typically either the original amount due/payable or the amount actually remitted for the referenced document.
/// </summary>
[IsoId("_tcu6UlkyEeGeoaLUQk__nA_1720061544")]
[DisplayName("Remittance Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RemittanceAmount2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount specified is the exact amount due and payable to the creditor.
    /// </summary>
    [IsoId("_tcu6U1kyEeGeoaLUQk__nA_410413505")]
    [DisplayName("Due Payable Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DuePyblAmt")]
    #endif
    [IsoXmlTag("DuePyblAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? DuePayableAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? DuePayableAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? DuePayableAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount specified for the referred document is the amount of discount to be applied to the amount due and payable to the creditor.
    /// </summary>
    [IsoId("_tc4rUFkyEeGeoaLUQk__nA_1468630199")]
    [DisplayName("Discount Applied Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscntApldAmt")]
    #endif
    [IsoXmlTag("DscntApldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DiscountAmountAndType1? DiscountAppliedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DiscountAmountAndType1? DiscountAppliedAmount { get; init; } 
    #else
    public DiscountAmountAndType1? DiscountAppliedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount specified for the referred document is the amount of a credit note.
    /// </summary>
    [IsoId("_tc4rUVkyEeGeoaLUQk__nA_-1624173271")]
    [DisplayName("Credit Note Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtNoteAmt")]
    #endif
    [IsoXmlTag("CdtNoteAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? CreditNoteAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? CreditNoteAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? CreditNoteAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of cash resulting from the calculation of the tax.
    /// </summary>
    [IsoId("_tc4rUlkyEeGeoaLUQk__nA_-1935934653")]
    [DisplayName("Tax Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxAmt")]
    #endif
    [IsoXmlTag("TaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxAmountAndType1? TaxAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxAmountAndType1? TaxAmount { get; init; } 
    #else
    public TaxAmountAndType1? TaxAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies detailed information on the amount and reason of the document adjustment.
    /// </summary>
    [IsoId("_tc4rU1kyEeGeoaLUQk__nA_41136424")]
    [DisplayName("Adjustment Amount And Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstmntAmtAndRsn")]
    #endif
    [IsoXmlTag("AdjstmntAmtAndRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentAdjustment1? AdjustmentAmountAndReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentAdjustment1? AdjustmentAmountAndReason { get; init; } 
    #else
    public DocumentAdjustment1? AdjustmentAmountAndReason { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money remitted for the referred document.
    /// </summary>
    [IsoId("_tc4rVFkyEeGeoaLUQk__nA_802163856")]
    [DisplayName("Remitted Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtdAmt")]
    #endif
    [IsoXmlTag("RmtdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? RemittedAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
