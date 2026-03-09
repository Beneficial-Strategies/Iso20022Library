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
/// Additional information from the underlying payment instruction which cannot be transferred in a regular statement message.
/// </summary>
[IsoId("_PgmFMdp-Ed-ak6NoX_4Aeg_-1588306924")]
[DisplayName("Payment Complementary Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentComplementaryInformation
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Remittance information.
    /// </summary>
    [IsoId("_PgmFMtp-Ed-ak6NoX_4Aeg_143459089")]
    [DisplayName("Remittance Choice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtChc")]
    #endif
    [IsoXmlTag("RmtChc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceInformation3Choice_? RemittanceChoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceInformation3Choice_? RemittanceChoice { get; init; } 
    #else
    public RemittanceInformation3Choice_? RemittanceChoice { get; set; } 
    #endif
    
    /// <summary>
    /// Debtor or Ordering customer of the payment instruction.
    /// </summary>
    [IsoId("_PgmFM9p-Ed-ak6NoX_4Aeg_959853172")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification1? Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification1? Debtor { get; init; } 
    #else
    public PartyIdentification1? Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Debtor account or Ordering customer account.
    /// </summary>
    [IsoId("_PgmFNNp-Ed-ak6NoX_4Aeg_1084527548")]
    [DisplayName("Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAcct")]
    #endif
    [IsoXmlTag("DbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount3? DebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount3? DebtorAccount { get; init; } 
    #else
    public CashAccount3? DebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// First Agent or Field 52 in Fin messages.
    /// </summary>
    [IsoId("_PgmFNdp-Ed-ak6NoX_4Aeg_1915694934")]
    [DisplayName("First Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstAgt")]
    #endif
    [IsoXmlTag("FrstAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification? FirstAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification? FirstAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification? FirstAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Instructed amount of the payment instruction (Field 33B).
    /// </summary>
    [IsoId("_PgmFNtp-Ed-ak6NoX_4Aeg_1310523944")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountType1Choice_? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountType1Choice_? Amount { get; init; } 
    #else
    public AmountType1Choice_? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the account used to cover a payment.
    /// </summary>
    [IsoId("_PgmFN9p-Ed-ak6NoX_4Aeg_-1751542726")]
    [DisplayName("Nostro Vostro Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NstrVstrAcct")]
    #endif
    [IsoXmlTag("NstrVstrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount3? NostroVostroAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount3? NostroVostroAccount { get; init; } 
    #else
    public CashAccount3? NostroVostroAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Intermediary bank.
    /// </summary>
    [IsoId("_PgmFONp-Ed-ak6NoX_4Aeg_-1119854487")]
    [DisplayName("Intermediary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrmy")]
    #endif
    [IsoXmlTag("Intrmy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Intermediary1? Intermediary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Intermediary1? Intermediary { get; init; } 
    #else
    public Intermediary1? Intermediary { get; set; } 
    #endif
    
    /// <summary>
    /// Correspondent of the first agent (Field 53 in MT202).
    /// </summary>
    [IsoId("_PgmFOdp-Ed-ak6NoX_4Aeg_-290532610")]
    [DisplayName("First Settlement Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstSttlmAgt")]
    #endif
    [IsoXmlTag("FrstSttlmAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification? FirstSettlementAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification? FirstSettlementAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification? FirstSettlementAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Correspondent of the Final agent (Field 54 of Mt 202).
    /// </summary>
    [IsoId("_PgvPINp-Ed-ak6NoX_4Aeg_53941590")]
    [DisplayName("Last Settlement Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastSttlmAgt")]
    #endif
    [IsoXmlTag("LastSttlmAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification? LastSettlementAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification? LastSettlementAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification? LastSettlementAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Equivalent to Field 55 in MT202.
    /// </summary>
    [IsoId("_PgvPIdp-Ed-ak6NoX_4Aeg_938673746")]
    [DisplayName("Intermediary Settlement Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmySttlmAgt")]
    #endif
    [IsoXmlTag("IntrmySttlmAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification? IntermediarySettlementAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification? IntermediarySettlementAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification? IntermediarySettlementAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Creditor or Beneficiary customer of the payment instruction.
    /// </summary>
    [IsoId("_PgvPItp-Ed-ak6NoX_4Aeg_1469699713")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification1? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification1? Creditor { get; init; } 
    #else
    public PartyIdentification1? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Creditor account or Beneficiary customer account.
    /// </summary>
    [IsoId("_PgvPI9p-Ed-ak6NoX_4Aeg_1772613182")]
    [DisplayName("Creditor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAcct")]
    #endif
    [IsoXmlTag("CdtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount3? CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount3? CreditorAccount { get; init; } 
    #else
    public CashAccount3? CreditorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Unformatted information from the sender to the receiver.
    /// </summary>
    [IsoId("_PgvPJNp-Ed-ak6NoX_4Aeg_1618675914")]
    [DisplayName("Sender To Receiver Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrToRcvrInf")]
    #endif
    [IsoXmlTag("SndrToRcvrInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(6)]
    public SimpleValueList<System.String> SenderToReceiverInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
