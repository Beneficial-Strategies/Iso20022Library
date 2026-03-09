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
namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate2Choice
{
    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_tpGiYFkyEeGeoaLUQk__nA_-668633660")]
    [DisplayName("Original Mandate")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OriginalMandate : OriginalMandate2Choice_
    #else
    public partial class OriginalMandate : OriginalMandate2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OriginalMandate instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OriginalMandate( System.String reqMandateIdentification,PartyIdentification43 reqCreditor,PartyIdentification43 reqDebtor,BranchAndFinancialInstitutionIdentification5 reqDebtorAgent )
        {
            MandateIdentification = reqMandateIdentification;
            Creditor = reqCreditor;
            Debtor = reqDebtor;
            DebtorAgent = reqDebtorAgent;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
        /// </summary>
        [IsoId("_tyfH5FkyEeGeoaLUQk__nA_-1872236648")]
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
        [IsoId("_tyo44FkyEeGeoaLUQk__nA_-1111471495")]
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
        /// Specifies the type of mandate, such as paper, electronic or scheme.
        /// </summary>
        [IsoId("_tyo44VkyEeGeoaLUQk__nA_-1917957078")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateTypeInformation1? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateTypeInformation1? Type { get; init; } 
        #else
        public MandateTypeInformation1? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Provides details of the duration of the mandate and occurrence of the underlying transactions.
        /// </summary>
        [IsoId("_tyo44lkyEeGeoaLUQk__nA_1393687531")]
        [DisplayName("Occurrences")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ocrncs")]
        #endif
        [IsoXmlTag("Ocrncs")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MandateOccurrences2? Occurrences { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MandateOccurrences2? Occurrences { get; init; } 
        #else
        public MandateOccurrences2? Occurrences { get; set; } 
        #endif
        
        /// <summary>
        /// Fixed amount to be collected from the debtor&apos;s account.
        /// </summary>
        [IsoId("_tyo441kyEeGeoaLUQk__nA_-501069567")]
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
        [IsoId("_tyo45FkyEeGeoaLUQk__nA_705920533")]
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
        /// Credit party that signs the mandate.
        /// </summary>
        [IsoId("_tyyp4FkyEeGeoaLUQk__nA_1962059543")]
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
        [IsoId("_tyyp4VkyEeGeoaLUQk__nA_1240955787")]
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
        [IsoId("_tyyp4lkyEeGeoaLUQk__nA_-995188356")]
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
        [IsoId("_tyyp41kyEeGeoaLUQk__nA_-234423203")]
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
        [IsoId("_tyyp5FkyEeGeoaLUQk__nA_1932716250")]
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
        [IsoId("_ty7z0FkyEeGeoaLUQk__nA_875396210")]
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
        [IsoId("_ty7z0VkyEeGeoaLUQk__nA_1257851318")]
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
        [IsoId("_ty7z0lkyEeGeoaLUQk__nA_-75473929")]
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
        [IsoId("_ty7z01kyEeGeoaLUQk__nA_-86572706")]
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
        /// Provides information to identify the underlying documents associated with the mandate.
        /// </summary>
        [IsoId("_ty7z1FkyEeGeoaLUQk__nA_1034345484")]
        [DisplayName("Referred Document")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RfrdDoc")]
        #endif
        [IsoXmlTag("RfrdDoc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReferredDocumentInformation3? ReferredDocument { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReferredDocumentInformation3? ReferredDocument { get; init; } 
        #else
        public ReferredDocumentInformation3? ReferredDocument { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
