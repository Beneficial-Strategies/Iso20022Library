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
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument12Choice
{
    /// <summary>
    /// Payment instrument between a debtor and a creditor, which flows through one or more financial institutions or systems.
    /// </summary>
    [IsoId("_SBX_6tp-Ed-ak6NoX_4Aeg_1545983660")]
    [DisplayName("Credit Transfer Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CreditTransferDetails : PaymentInstrument12Choice_
    #else
    public partial class CreditTransferDetails : PaymentInstrument12Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CreditTransferDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CreditTransferDetails( FinancialInstitutionIdentification3Choice_ reqCreditorAgent,AccountIdentificationAndName3 reqCreditorAccount )
        {
            CreditorAgent = reqCreditorAgent;
            CreditorAccount = reqCreditorAccount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
        /// </summary>
        [IsoId("_QcynvNp-Ed-ak6NoX_4Aeg_86583379")]
        [DisplayName("Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ref")]
        #endif
        [IsoXmlTag("Ref")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Reference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Reference { get; init; } 
        #else
        public System.String? Reference { get; set; } 
        #endif
        
        /// <summary>
        /// Party that owes an amount of money to the (ultimate) creditor. In the context of the payment model, the debtor is also the debit account owner.
        /// </summary>
        [IsoId("_Qcynvdp-Ed-ak6NoX_4Aeg_1082187783")]
        [DisplayName("Debtor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Dbtr")]
        #endif
        [IsoXmlTag("Dbtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification2Choice_? Debtor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification2Choice_? Debtor { get; init; } 
        #else
        public PartyIdentification2Choice_? Debtor { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
        /// </summary>
        [IsoId("_Qcynvtp-Ed-ak6NoX_4Aeg_1082187817")]
        [DisplayName("Debtor Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrAcct")]
        #endif
        [IsoXmlTag("DbtrAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentificationAndName3? DebtorAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentificationAndName3? DebtorAccount { get; init; } 
        #else
        public AccountIdentificationAndName3? DebtorAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution servicing an account for the debtor.
        /// </summary>
        [IsoId("_Qc8YsNp-Ed-ak6NoX_4Aeg_1082187800")]
        [DisplayName("Debtor Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrAgt")]
        #endif
        [IsoXmlTag("DbtrAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstitutionIdentification3Choice_? DebtorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification3Choice_? DebtorAgent { get; init; } 
        #else
        public FinancialInstitutionIdentification3Choice_? DebtorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the account of the debtor&apos;s agent.
        /// </summary>
        [IsoId("_Qc8Ysdp-Ed-ak6NoX_4Aeg_1407001793")]
        [DisplayName("Debtor Agent Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrAgtAcct")]
        #endif
        [IsoXmlTag("DbtrAgtAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentificationAndName3? DebtorAgentAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentificationAndName3? DebtorAgentAccount { get; init; } 
        #else
        public AccountIdentificationAndName3? DebtorAgentAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.
        /// </summary>
        [IsoId("_Qc8Ystp-Ed-ak6NoX_4Aeg_-1856986758")]
        [DisplayName("Intermediary Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrmyAgt1")]
        #endif
        [IsoXmlTag("IntrmyAgt1")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstitutionIdentification3Choice_? IntermediaryAgent1 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification3Choice_? IntermediaryAgent1 { get; init; } 
        #else
        public FinancialInstitutionIdentification3Choice_? IntermediaryAgent1 { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
        /// </summary>
        [IsoId("_Qc8Ys9p-Ed-ak6NoX_4Aeg_-1831128514")]
        [DisplayName("Intermediary Agent 1 Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrmyAgt1Acct")]
        #endif
        [IsoXmlTag("IntrmyAgt1Acct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentificationAndName3? IntermediaryAgent1Account { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentificationAndName3? IntermediaryAgent1Account { get; init; } 
        #else
        public AccountIdentificationAndName3? IntermediaryAgent1Account { get; set; } 
        #endif
        
        /// <summary>
        /// Agent between the debtor&apos;s agent and the creditor&apos;s agent.
        /// </summary>
        [IsoId("_Qc8YtNp-Ed-ak6NoX_4Aeg_-69049453")]
        [DisplayName("Intermediary Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrmyAgt2")]
        #endif
        [IsoXmlTag("IntrmyAgt2")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstitutionIdentification3Choice_? IntermediaryAgent2 { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification3Choice_? IntermediaryAgent2 { get; init; } 
        #else
        public FinancialInstitutionIdentification3Choice_? IntermediaryAgent2 { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
        /// </summary>
        [IsoId("_Qc8Ytdp-Ed-ak6NoX_4Aeg_60241180")]
        [DisplayName("Intermediary Agent 2 Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrmyAgt2Acct")]
        #endif
        [IsoXmlTag("IntrmyAgt2Acct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentificationAndName3? IntermediaryAgent2Account { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentificationAndName3? IntermediaryAgent2Account { get; init; } 
        #else
        public AccountIdentificationAndName3? IntermediaryAgent2Account { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution servicing an account for the creditor.
        /// </summary>
        [IsoId("_Qc8Yttp-Ed-ak6NoX_4Aeg_1162659793")]
        [DisplayName("Creditor Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAgt")]
        #endif
        [IsoXmlTag("CdtrAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstitutionIdentification3Choice_ CreditorAgent { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FinancialInstitutionIdentification3Choice_ CreditorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification3Choice_ CreditorAgent { get; init; } 
        #else
        public FinancialInstitutionIdentification3Choice_ CreditorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
        /// </summary>
        [IsoId("_Qc8Yt9p-Ed-ak6NoX_4Aeg_1562544074")]
        [DisplayName("Creditor Agent Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAgtAcct")]
        #endif
        [IsoXmlTag("CdtrAgtAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentificationAndName3? CreditorAgentAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentificationAndName3? CreditorAgentAccount { get; init; } 
        #else
        public AccountIdentificationAndName3? CreditorAgentAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
        /// </summary>
        [IsoId("_Qc8YuNp-Ed-ak6NoX_4Aeg_1975357297")]
        [DisplayName("Creditor")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cdtr")]
        #endif
        [IsoXmlTag("Cdtr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification2Choice_? Creditor { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification2Choice_? Creditor { get; init; } 
        #else
        public PartyIdentification2Choice_? Creditor { get; set; } 
        #endif
        
        /// <summary>
        /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
        /// </summary>
        [IsoId("_Qc8Yudp-Ed-ak6NoX_4Aeg_2089876270")]
        [DisplayName("Creditor Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAcct")]
        #endif
        [IsoXmlTag("CdtrAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AccountIdentificationAndName3 CreditorAccount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AccountIdentificationAndName3 CreditorAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentificationAndName3 CreditorAccount { get; init; } 
        #else
        public AccountIdentificationAndName3 CreditorAccount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
