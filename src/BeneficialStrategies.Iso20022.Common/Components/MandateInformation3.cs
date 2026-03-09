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
/// Information that serves as a basis to debit an account.
/// </summary>
[IsoId("_T3P8a9p-Ed-ak6NoX_4Aeg_1018029248")]
[DisplayName("Mandate Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateInformation3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MandateInformation3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MandateInformation3( System.String reqMandateIdentification )
    {
        MandateIdentification = reqMandateIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_T3P8bNp-Ed-ak6NoX_4Aeg_1018029309")]
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
    [IsoId("_T3P8bdp-Ed-ak6NoX_4Aeg_1018029278")]
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
    [IsoId("_T3ZGUNp-Ed-ak6NoX_4Aeg_1018030197")]
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
    /// Set of elements used to provide details of the duration of the mandate and occurrence of the underlying transactions.
    /// </summary>
    [IsoId("_T3ZGUdp-Ed-ak6NoX_4Aeg_1018030166")]
    [DisplayName("Occurrences")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ocrncs")]
    #endif
    [IsoXmlTag("Ocrncs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MandateOccurrences1? Occurrences { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MandateOccurrences1? Occurrences { get; init; } 
    #else
    public MandateOccurrences1? Occurrences { get; set; } 
    #endif
    
    /// <summary>
    /// Fixed amount to be collected from the debtor&apos;s account.
    /// </summary>
    [IsoId("_T3ZGUtp-Ed-ak6NoX_4Aeg_1018029340")]
    [DisplayName("Collection Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ColltnAmt")]
    #endif
    [IsoXmlTag("ColltnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CollectionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum amount that may be collected from the debtor&apos;s account, per instruction.
    /// </summary>
    [IsoId("_T3ZGU9p-Ed-ak6NoX_4Aeg_1018029363")]
    [DisplayName("Maximum Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAmt")]
    #endif
    [IsoXmlTag("MaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? MaximumAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_T3ZGVNp-Ed-ak6NoX_4Aeg_1018030320")]
    [DisplayName("Creditor Scheme Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrSchmeId")]
    #endif
    [IsoXmlTag("CdtrSchmeId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification32? CreditorSchemeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32? CreditorSchemeIdentification { get; init; } 
    #else
    public PartyIdentification32? CreditorSchemeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party that signs the mandate and to whom an amount of money is due.
    /// </summary>
    [IsoId("_T3ZGVdp-Ed-ak6NoX_4Aeg_1018029673")]
    [DisplayName("Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdtr")]
    #endif
    [IsoXmlTag("Cdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification32? Creditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32? Creditor { get; init; } 
    #else
    public PartyIdentification32? Creditor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_T3ZGVtp-Ed-ak6NoX_4Aeg_1018029402")]
    [DisplayName("Creditor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAcct")]
    #endif
    [IsoXmlTag("CdtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount16? CreditorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16? CreditorAccount { get; init; } 
    #else
    public CashAccount16? CreditorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_T3ZGV9p-Ed-ak6NoX_4Aeg_1018030105")]
    [DisplayName("Creditor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrAgt")]
    #endif
    [IsoXmlTag("CdtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_T3ZGWNp-Ed-ak6NoX_4Aeg_1018029734")]
    [DisplayName("Ultimate Creditor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtCdtr")]
    #endif
    [IsoXmlTag("UltmtCdtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification32? UltimateCreditor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32? UltimateCreditor { get; init; } 
    #else
    public PartyIdentification32? UltimateCreditor { get; set; } 
    #endif
    
    /// <summary>
    /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_T3ZGWdp-Ed-ak6NoX_4Aeg_1018029765")]
    [DisplayName("Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dbtr")]
    #endif
    [IsoXmlTag("Dbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification32? Debtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32? Debtor { get; init; } 
    #else
    public PartyIdentification32? Debtor { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("_T3i3UNp-Ed-ak6NoX_4Aeg_1018029425")]
    [DisplayName("Debtor Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAcct")]
    #endif
    [IsoXmlTag("DbtrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount16? DebtorAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount16? DebtorAccount { get; init; } 
    #else
    public CashAccount16? DebtorAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_T3i3Udp-Ed-ak6NoX_4Aeg_1018030135")]
    [DisplayName("Debtor Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtrAgt")]
    #endif
    [IsoXmlTag("DbtrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification4? DebtorAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification4? DebtorAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification4? DebtorAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_T3i3Utp-Ed-ak6NoX_4Aeg_1018029796")]
    [DisplayName("Ultimate Debtor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UltmtDbtr")]
    #endif
    [IsoXmlTag("UltmtDbtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification32? UltimateDebtor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification32? UltimateDebtor { get; init; } 
    #else
    public PartyIdentification32? UltimateDebtor { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide information to identify the underlying documents associated with the mandate.
    /// </summary>
    [IsoId("_T3i3U9p-Ed-ak6NoX_4Aeg_1018030258")]
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
