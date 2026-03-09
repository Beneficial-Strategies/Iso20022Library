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
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument17Choice
{
    /// <summary>
    /// Settlement instructions for a payment by direct debit.
    /// </summary>
    [IsoId("_t7vvGxdHEeK5g-3oYI0_9Q")]
    [DisplayName("Direct Debit Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DirectDebitDetails : PaymentInstrument17Choice_
    #else
    public partial class DirectDebitDetails : PaymentInstrument17Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DirectDebitDetails instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DirectDebitDetails( AccountIdentificationAndName3 reqDebtorAccount,FinancialInstitutionIdentification3Choice_ reqDebtorAgent )
        {
            DebtorAccount = reqDebtorAccount;
            DebtorAgent = reqDebtorAgent;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
        /// </summary>
        [IsoId("_QdGJutp-Ed-ak6NoX_4Aeg_1879706")]
        [DisplayName("Debtor Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrAcct")]
        #endif
        [IsoXmlTag("DbtrAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AccountIdentificationAndName3 DebtorAccount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AccountIdentificationAndName3 DebtorAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentificationAndName3 DebtorAccount { get; init; } 
        #else
        public AccountIdentificationAndName3 DebtorAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Party that owes the cash to the creditor/final party. The debtor is also the debit account owner.
        /// </summary>
        [IsoId("_QdGJu9p-Ed-ak6NoX_4Aeg_1879782")]
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
        /// Number assigned by a tax authority to an entity.
        /// </summary>
        [IsoId("_QdGJvNp-Ed-ak6NoX_4Aeg_1879799")]
        [DisplayName("Debtor Tax Identification Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrTaxIdNb")]
        #endif
        [IsoXmlTag("DbtrTaxIdNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? DebtorTaxIdentificationNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? DebtorTaxIdentificationNumber { get; init; } 
        #else
        public System.String? DebtorTaxIdentificationNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Number assigned by a national registration authority to an entity.
        /// </summary>
        [IsoId("_QdGJvdp-Ed-ak6NoX_4Aeg_1879817")]
        [DisplayName("Debtor National Registration Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrNtlRegnNb")]
        #endif
        [IsoXmlTag("DbtrNtlRegnNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? DebtorNationalRegistrationNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? DebtorNationalRegistrationNumber { get; init; } 
        #else
        public System.String? DebtorNationalRegistrationNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
        /// </summary>
        [IsoId("_QdGJvtp-Ed-ak6NoX_4Aeg_1879877")]
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
        /// Financial institution that receives the direct debit instruction from the creditor or other authorised party.
        /// </summary>
        [IsoId("_QdPToNp-Ed-ak6NoX_4Aeg_1879912")]
        [DisplayName("Debtor Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrAgt")]
        #endif
        [IsoXmlTag("DbtrAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required FinancialInstitutionIdentification3Choice_ DebtorAgent { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required FinancialInstitutionIdentification3Choice_ DebtorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification3Choice_ DebtorAgent { get; init; } 
        #else
        public FinancialInstitutionIdentification3Choice_ DebtorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
        /// </summary>
        [IsoId("_QdPTodp-Ed-ak6NoX_4Aeg_1880154")]
        [DisplayName("Debtor Agent Branch")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DbtrAgtBrnch")]
        #endif
        [IsoXmlTag("DbtrAgtBrnch")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchData? DebtorAgentBranch { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchData? DebtorAgentBranch { get; init; } 
        #else
        public BranchData? DebtorAgentBranch { get; set; } 
        #endif
        
        /// <summary>
        /// Financial institution that receives the payment transaction on behalf of the creditor, or other nominated party, and credits the account.
        /// </summary>
        [IsoId("_QdPTotp-Ed-ak6NoX_4Aeg_1880189")]
        [DisplayName("Creditor Agent")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAgt")]
        #endif
        [IsoXmlTag("CdtrAgt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FinancialInstitutionIdentification3Choice_? CreditorAgent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FinancialInstitutionIdentification3Choice_? CreditorAgent { get; init; } 
        #else
        public FinancialInstitutionIdentification3Choice_? CreditorAgent { get; set; } 
        #endif
        
        /// <summary>
        /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
        /// </summary>
        [IsoId("_QdPTo9p-Ed-ak6NoX_4Aeg_1880206")]
        [DisplayName("Creditor Agent Branch")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrAgtBrnch")]
        #endif
        [IsoXmlTag("CdtrAgtBrnch")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchData? CreditorAgentBranch { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchData? CreditorAgentBranch { get; init; } 
        #else
        public BranchData? CreditorAgentBranch { get; set; } 
        #endif
        
        /// <summary>
        /// Reference assigned to a creditor by its financial institution, or relevant authority, authorising the creditor to take part in a direct debit scheme.
        /// </summary>
        [IsoId("_QdPTpNp-Ed-ak6NoX_4Aeg_1880224")]
        [DisplayName("Registration Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RegnId")]
        #endif
        [IsoXmlTag("RegnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? RegistrationIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? RegistrationIdentification { get; init; } 
        #else
        public System.String? RegistrationIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Reference of the direct debit mandate that has been agreed upon by the debtor and creditor.
        /// </summary>
        [IsoId("_QdPTpdp-Ed-ak6NoX_4Aeg_1880249")]
        [DisplayName("Mandate Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MndtId")]
        #endif
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MandateIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MandateIdentification { get; init; } 
        #else
        public System.String? MandateIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
