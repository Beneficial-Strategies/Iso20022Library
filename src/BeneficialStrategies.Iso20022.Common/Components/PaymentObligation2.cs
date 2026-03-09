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
[IsoId("_H7FLkdNVEeKdOs2hjJ_3WQ")]
[DisplayName("Payment Obligation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentObligation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentObligation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentObligation2( BICIdentification1 reqObligorBank,BICIdentification1 reqRecipientBank,AmountOrPercentage2Choice_ reqPaymentObligationAmount,System.DateOnly reqExpiryDate )
    {
        ObligorBank = reqObligorBank;
        RecipientBank = reqRecipientBank;
        PaymentObligationAmount = reqPaymentObligationAmount;
        ExpiryDate = reqExpiryDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Bank that has to pay under the obligation.
    /// </summary>
    [IsoId("_IbM2E9NVEeKdOs2hjJ_3WQ")]
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
    [IsoId("_IbM2FdNVEeKdOs2hjJ_3WQ")]
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
    /// Payment obligation amount specified as an amount or percentage.
    /// </summary>
    [IsoId("_qRrnENP_EeK0PPbKncCqzA")]
    [DisplayName("Payment Obligation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtOblgtnAmt")]
    #endif
    [IsoXmlTag("PmtOblgtnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountOrPercentage2Choice_ PaymentObligationAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountOrPercentage2Choice_ PaymentObligationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountOrPercentage2Choice_ PaymentObligationAmount { get; init; } 
    #else
    public AmountOrPercentage2Choice_ PaymentObligationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Charges related to the payment obligation.
    /// </summary>
    [IsoId("_bUWsINP_EeK0PPbKncCqzA")]
    [DisplayName("Charges")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Chrgs")]
    #endif
    [IsoXmlTag("Chrgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Charges5? Charges { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Charges5? Charges { get; init; } 
    #else
    public Charges5? Charges { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the obligation will expire.
    /// </summary>
    [IsoId("_IbM2H9NVEeKdOs2hjJ_3WQ")]
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
    /// Rules which apply to the BPO (Bank Payment Obligation).
    /// </summary>
    [IsoId("_VaMaENNrEeKdOs2hjJ_3WQ")]
    [DisplayName("Applicable Rules")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AplblRules")]
    #endif
    [IsoXmlTag("AplblRules")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BPOApplicableRules1Choice_? ApplicableRules { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BPOApplicableRules1Choice_? ApplicableRules { get; init; } 
    #else
    public BPOApplicableRules1Choice_? ApplicableRules { get; set; } 
    #endif
    
    /// <summary>
    /// Country of which the law governs the bank payment obligation.
    /// </summary>
    [IsoId("_IbM2IdNVEeKdOs2hjJ_3WQ")]
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
    /// Location and forum for dispute resolution.
    /// </summary>
    [IsoId("_aiswQNQAEeK0PPbKncCqzA")]
    [DisplayName("Place Of Jurisdiction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfJursdctn")]
    #endif
    [IsoXmlTag("PlcOfJursdctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Location2? PlaceOfJurisdiction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Location2? PlaceOfJurisdiction { get; init; } 
    #else
    public Location2? PlaceOfJurisdiction { get; set; } 
    #endif
    
    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_IbM2I9NVEeKdOs2hjJ_3WQ")]
    [DisplayName("Payment Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTerms")]
    #endif
    [IsoXmlTag("PmtTerms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTerms4? PaymentTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTerms4? PaymentTerms { get; init; } 
    #else
    public PaymentTerms4? PaymentTerms { get; set; } 
    #endif
    
    /// <summary>
    /// Instruction between two clearing agents stipulating the cash transfer characteristics between the two parties.
    /// </summary>
    [IsoId("_IbM2JdNVEeKdOs2hjJ_3WQ")]
    [DisplayName("Settlement Terms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTerms")]
    #endif
    [IsoXmlTag("SttlmTerms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTerms3? SettlementTerms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTerms3? SettlementTerms { get; init; } 
    #else
    public SettlementTerms3? SettlementTerms { get; set; } 
    #endif
    
    
    #nullable disable
    
}
