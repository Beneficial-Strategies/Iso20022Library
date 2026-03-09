// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate4Choice
{
    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_c4CjZUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Mandate")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OriginalMandate : OriginalMandate4Choice_
    #else
    public partial class OriginalMandate : OriginalMandate4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OriginalMandate instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OriginalMandate( System.String reqMandateIdentification,System.String reqTrackingIndicator,PartyIdentification43 reqCreditor,PartyIdentification43 reqDebtor,BranchAndFinancialInstitutionIdentification5 reqDebtorAgent )
        {
            MandateIdentification = reqMandateIdentification;
            TrackingIndicator = reqTrackingIndicator;
            Creditor = reqCreditor;
            Debtor = reqDebtor;
            DebtorAgent = reqDebtorAgent;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identification, as assigned by the responsible party (such as the creditor) or agent (such as the debtor agent), to unambiguously identify the mandate.
        /// </summary>
        [IsoId("_dBASJ0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Mandate Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MndtId")]
        #endif
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text MandateIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String MandateIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String MandateIdentification { get; init; } 
        #else
        public System.String MandateIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification for the mandate request, as assigned by the initiating party.
        /// </summary>
        [IsoId("_dBASKUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Mandate Request Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MndtReqId")]
        #endif
        [IsoXmlTag("MndtReqId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MandateRequestIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MandateRequestIdentification { get; init; } 
        #else
        public System.String? MandateRequestIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the transport authentication details related to the mandate.
        /// </summary>
        [IsoId("_jArg0WoGEearR-CA7eRZXQ")]
        [DisplayName("Authentication")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Authntcn")]
        #endif
        [IsoXmlTag("Authntcn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateAuthentication1? Authentication { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateAuthentication1? Authentication { get; init; } 
        #else
        public MandateAuthentication1? Authentication { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the type of mandate, such as paper, electronic or scheme.
        /// </summary>
        [IsoId("_dBASK0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateTypeInformation2? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateTypeInformation2? Type { get; init; } 
        #else
        public MandateTypeInformation2? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Provides details of the duration of the mandate and occurrence of the underlying transactions.
        /// </summary>
        [IsoId("_dBASLUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Occurrences")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ocrncs")]
        #endif
        [IsoXmlTag("Ocrncs")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateOccurrences4? Occurrences { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateOccurrences4? Occurrences { get; init; } 
        #else
        public MandateOccurrences4? Occurrences { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the direct debit instructions should be automatically re-submitted periodically when bilaterally agreed.
        /// </summary>
        [IsoId("_Zx4UIGn0EearR-CA7eRZXQ")]
        [DisplayName("Tracking Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrckgInd")]
        #endif
        [IsoXmlTag("TrckgInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoTrueFalseIndicator TrackingIndicator { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String TrackingIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String TrackingIndicator { get; init; } 
        #else
        public System.String TrackingIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Amount different from the collection amount, as it includes the costs associated with the first debited amount.
        /// </summary>
        [IsoId("_eWoD8WnvEearR-CA7eRZXQ")]
        [DisplayName("First Collection Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FrstColltnAmt")]
        #endif
        [IsoXmlTag("FrstColltnAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveOrHistoricCurrencyAndAmount? FirstCollectionAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveOrHistoricCurrencyAndAmount? FirstCollectionAmount { get; init; } 
        #else
        public ActiveOrHistoricCurrencyAndAmount? FirstCollectionAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Fixed amount to be collected from the debtor&apos;s account.
        /// </summary>
        [IsoId("_dBASL0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Collection Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ColltnAmt")]
        #endif
        [IsoXmlTag("ColltnAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; } 
        #else
        public ActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Maximum amount that may be collected from the debtor&apos;s account, per instruction.
        /// </summary>
        [IsoId("_dBASMUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Maximum Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MaxAmt")]
        #endif
        [IsoXmlTag("MaxAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; } 
        #else
        public ActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the characteristics of the adjustment applied to the collection amount of a direct debit instruction.
        /// </summary>
        [IsoId("_JHq7cWoGEearR-CA7eRZXQ")]
        [DisplayName("Adjustment")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Adjstmnt")]
        #endif
        [IsoXmlTag("Adjstmnt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateAdjustment1? Adjustment { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateAdjustment1? Adjustment { get; init; } 
        #else
        public MandateAdjustment1? Adjustment { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the reason for the setup of the mandate.
        /// </summary>
        [IsoId("_dBASM0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Rsn")]
        #endif
        [IsoXmlTag("Rsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateSetupReason1Choice_? Reason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateSetupReason1Choice_? Reason { get; init; } 
        #else
        public MandateSetupReason1Choice_? Reason { get; set; } 
        #endif
        
        /// <summary>
        /// Credit party that signs the mandate.
        /// </summary>
        [IsoId("_dBASNUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Creditor Scheme Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrSchmeId")]
        #endif
        [IsoXmlTag("CdtrSchmeId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification43? CreditorSchemeIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification43? CreditorSchemeIdentification { get; init; } 
        #else
        public PartyIdentification43? CreditorSchemeIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Party that signs the mandate and to whom an amount of money is due.
        /// </summary>
        [IsoId("_dBASN0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Creditor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cdtr")]
        #endif
        [IsoXmlTag("Cdtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification43 Creditor { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification43 Creditor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification43 Creditor { get; init; } 
        #else
        public PartyIdentification43 Creditor { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
        /// </summary>
        [IsoId("_dBASOUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Creditor Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAcct")]
        #endif
        [IsoXmlTag("CdtrAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccount24? CreditorAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount24? CreditorAccount { get; init; } 
        #else
        public CashAccount24? CreditorAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution servicing an account for the creditor.
        /// </summary>
        [IsoId("_dBASO0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Creditor Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAgt")]
        #endif
        [IsoXmlTag("CdtrAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Ultimate party to which an amount of money is due.
        /// </summary>
        [IsoId("_dBASPUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Ultimate Creditor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UltmtCdtr")]
        #endif
        [IsoXmlTag("UltmtCdtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification43? UltimateCreditor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification43? UltimateCreditor { get; init; } 
        #else
        public PartyIdentification43? UltimateCreditor { get; set; } 
        #endif
        
        /// <summary>
        /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
        /// </summary>
        [IsoId("_dBASP0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Debtor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Dbtr")]
        #endif
        [IsoXmlTag("Dbtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyIdentification43 Debtor { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyIdentification43 Debtor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification43 Debtor { get; init; } 
        #else
        public PartyIdentification43 Debtor { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
        /// </summary>
        [IsoId("_dBASQUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Debtor Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrAcct")]
        #endif
        [IsoXmlTag("DbtrAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccount24? DebtorAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount24? DebtorAccount { get; init; } 
        #else
        public CashAccount24? DebtorAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution servicing an account for the debtor.
        /// </summary>
        [IsoId("_dBASQ0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Debtor Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrAgt")]
        #endif
        [IsoXmlTag("DbtrAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Ultimate party that owes an amount of money to the (ultimate) creditor.
        /// </summary>
        [IsoId("_dBASRUjwEeaVLL5QKJ4f-A")]
        [DisplayName("Ultimate Debtor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UltmtDbtr")]
        #endif
        [IsoXmlTag("UltmtDbtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification43? UltimateDebtor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification43? UltimateDebtor { get; init; } 
        #else
        public PartyIdentification43? UltimateDebtor { get; set; } 
        #endif
        
        /// <summary>
        /// Reference assigned by a creditor or ultimate creditor for internal usage for the mandate.
        /// </summary>
        [IsoId("_OHvTIGnyEearR-CA7eRZXQ")]
        [DisplayName("Mandate Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MndtRef")]
        #endif
        [IsoXmlTag("MndtRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MandateReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MandateReference { get; init; } 
        #else
        public System.String? MandateReference { get; set; } 
        #endif
        
        /// <summary>
        /// Provides information to identify the underlying documents associated with the mandate.
        /// </summary>
        [IsoId("_dBASR0jwEeaVLL5QKJ4f-A")]
        [DisplayName("Referred Document")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RfrdDoc")]
        #endif
        [IsoXmlTag("RfrdDoc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReferredMandateDocument1? ReferredDocument { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReferredMandateDocument1? ReferredDocument { get; init; } 
        #else
        public ReferredMandateDocument1? ReferredDocument { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
