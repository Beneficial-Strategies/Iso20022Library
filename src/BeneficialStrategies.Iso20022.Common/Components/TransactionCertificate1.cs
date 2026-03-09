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
/// Certificate against which all currency control transactions are registered.
/// </summary>
[IsoId("_IXbngNLiEeSdq5yU2aaSNw")]
[DisplayName("Transaction Certificate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionCertificate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionCertificate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionCertificate1( System.String reqTransactionIdentification,DocumentIdentification28 reqCertificate )
    {
        TransactionIdentification = reqTransactionIdentification;
        Certificate = reqCertificate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the transaction.
    /// </summary>
    [IsoId("_f7w0gNLiEeSdq5yU2aaSNw")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the transaction certificate.
    /// </summary>
    [IsoId("_B1cu8NLnEeSDLevdaFPXHw")]
    [DisplayName("Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cert")]
    #endif
    [IsoXmlTag("Cert")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification28 Certificate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification28 Certificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification28 Certificate { get; init; } 
    #else
    public DocumentIdentification28 Certificate { get; set; } 
    #endif
    
    /// <summary>
    /// Cash account, linked to the registered contract, on which the cash entry is made.
    /// </summary>
    [IsoId("_nHn-QNLiEeSdq5yU2aaSNw")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount24? Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount24? Account { get; init; } 
    #else
    public CashAccount24? Account { get; set; } 
    #endif
    
    /// <summary>
    /// Country in which the bank account is located, when the bank which services the account is located in another country.
    /// </summary>
    [IsoId("_1uEqQNLiEeSdq5yU2aaSNw")]
    [DisplayName("Bank Account Domiciliation Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkAcctDmcltnCtry")]
    #endif
    [IsoXmlTag("BkAcctDmcltnCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? BankAccountDomiciliationCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? BankAccountDomiciliationCountry { get; init; } 
    #else
    public string? BankAccountDomiciliationCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Amendment indicator details.
    /// </summary>
    [IsoId("_Fd284NLjEeSdq5yU2aaSNw")]
    [DisplayName("Amendment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amdmnt")]
    #endif
    [IsoXmlTag("Amdmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentAmendment1? Amendment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentAmendment1? Amendment { get; init; } 
    #else
    public DocumentAmendment1? Amendment { get; set; } 
    #endif
    
    /// <summary>
    /// Record of the transaction certificate.
    /// </summary>
    [IsoId("_IfapYNLjEeSdq5yU2aaSNw")]
    [DisplayName("Certificate Record")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertRcrd")]
    #endif
    [IsoXmlTag("CertRcrd")]
    public ValueList<TransactionCertificateRecord1> CertificateRecord { get; init; } = new ValueList<TransactionCertificateRecord1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _IfapYNLjEeSdq5yU2aaSNw
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Uu73cTmzEeWDb47rJ6ki4Q")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
