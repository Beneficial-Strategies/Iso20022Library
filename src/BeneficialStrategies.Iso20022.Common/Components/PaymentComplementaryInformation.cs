// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information from the underlying payment instruction which cannot be transferred in a regular statement message.
/// </summary>
[IsoId("_PgmFMdp-Ed-ak6NoX_4Aeg_-1588306924")]
[DisplayName("Payment Complementary Information")]
public partial record PaymentComplementaryInformation
{
    #nullable enable
    
    /// <summary>
    /// Remittance information.
    /// </summary>
    [IsoId("_PgmFMtp-Ed-ak6NoX_4Aeg_143459089")]
    [DisplayName("Remittance Choice")]
    [IsoXmlTag("RmtChc")]
    public RemittanceInformation3Choice_? RemittanceChoice { get; init; } 
    
    /// <summary>
    /// Debtor or Ordering customer of the payment instruction.
    /// </summary>
    [IsoId("_PgmFM9p-Ed-ak6NoX_4Aeg_959853172")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification1? Debtor { get; init; } 
    
    /// <summary>
    /// Debtor account or Ordering customer account.
    /// </summary>
    [IsoId("_PgmFNNp-Ed-ak6NoX_4Aeg_1084527548")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount3? DebtorAccount { get; init; } 
    
    /// <summary>
    /// First Agent or Field 52 in Fin messages.
    /// </summary>
    [IsoId("_PgmFNdp-Ed-ak6NoX_4Aeg_1915694934")]
    [DisplayName("First Agent")]
    [IsoXmlTag("FrstAgt")]
    public BranchAndFinancialInstitutionIdentification? FirstAgent { get; init; } 
    
    /// <summary>
    /// Instructed amount of the payment instruction (Field 33B).
    /// </summary>
    [IsoId("_PgmFNtp-Ed-ak6NoX_4Aeg_1310523944")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType1Choice_? Amount { get; init; } 
    
    /// <summary>
    /// Indicates the account used to cover a payment.
    /// </summary>
    [IsoId("_PgmFN9p-Ed-ak6NoX_4Aeg_-1751542726")]
    [DisplayName("Nostro Vostro Account")]
    [IsoXmlTag("NstrVstrAcct")]
    public CashAccount3? NostroVostroAccount { get; init; } 
    
    /// <summary>
    /// Intermediary bank.
    /// </summary>
    [IsoId("_PgmFONp-Ed-ak6NoX_4Aeg_-1119854487")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    public Intermediary1? Intermediary { get; init; } 
    
    /// <summary>
    /// Correspondent of the first agent (Field 53 in MT202).
    /// </summary>
    [IsoId("_PgmFOdp-Ed-ak6NoX_4Aeg_-290532610")]
    [DisplayName("First Settlement Agent")]
    [IsoXmlTag("FrstSttlmAgt")]
    public BranchAndFinancialInstitutionIdentification? FirstSettlementAgent { get; init; } 
    
    /// <summary>
    /// Correspondent of the Final agent (Field 54 of Mt 202).
    /// </summary>
    [IsoId("_PgvPINp-Ed-ak6NoX_4Aeg_53941590")]
    [DisplayName("Last Settlement Agent")]
    [IsoXmlTag("LastSttlmAgt")]
    public BranchAndFinancialInstitutionIdentification? LastSettlementAgent { get; init; } 
    
    /// <summary>
    /// Equivalent to Field 55 in MT202.
    /// </summary>
    [IsoId("_PgvPIdp-Ed-ak6NoX_4Aeg_938673746")]
    [DisplayName("Intermediary Settlement Agent")]
    [IsoXmlTag("IntrmySttlmAgt")]
    public BranchAndFinancialInstitutionIdentification? IntermediarySettlementAgent { get; init; } 
    
    /// <summary>
    /// Creditor or Beneficiary customer of the payment instruction.
    /// </summary>
    [IsoId("_PgvPItp-Ed-ak6NoX_4Aeg_1469699713")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification1? Creditor { get; init; } 
    
    /// <summary>
    /// Creditor account or Beneficiary customer account.
    /// </summary>
    [IsoId("_PgvPI9p-Ed-ak6NoX_4Aeg_1772613182")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount3? CreditorAccount { get; init; } 
    
    /// <summary>
    /// Unformatted information from the sender to the receiver.
    /// </summary>
    [IsoId("_PgvPJNp-Ed-ak6NoX_4Aeg_1618675914")]
    [DisplayName("Sender To Receiver Information")]
    [IsoXmlTag("SndrToRcvrInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(6)]
    public SimpleValueList<System.String> SenderToReceiverInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
