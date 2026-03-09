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
/// Certificate record in which all currency control transactions are registered.
/// </summary>
[IsoId("_LUhDsNLiEeSdq5yU2aaSNw")]
[DisplayName("Transaction Certificate Record")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionCertificateRecord1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionCertificateRecord1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionCertificateRecord1( System.String reqCertificateRecordIdentification,TransactionCertificate2 reqTransaction )
    {
        CertificateRecordIdentification = reqCertificateRecordIdentification;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the certificate record.
    /// </summary>
    [IsoId("_RPZRQNLjEeSdq5yU2aaSNw")]
    [DisplayName("Certificate Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertRcrdId")]
    #endif
    [IsoXmlTag("CertRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CertificateRecordIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CertificateRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CertificateRecordIdentification { get; init; } 
    #else
    public System.String CertificateRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the transaction for which the record has been generated.
    /// </summary>
    [IsoId("_aSH2ANLjEeSdq5yU2aaSNw")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionCertificate2 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionCertificate2 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionCertificate2 Transaction { get; init; } 
    #else
    public TransactionCertificate2 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Contract registration details related to the certificate record.
    /// </summary>
    [IsoId("_KGGd4tLkEeSDLevdaFPXHw")]
    [DisplayName("Contract")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctrct")]
    #endif
    [IsoXmlTag("Ctrct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionCertificateContract1? Contract { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionCertificateContract1? Contract { get; init; } 
    #else
    public TransactionCertificateContract1? Contract { get; set; } 
    #endif
    
    /// <summary>
    /// Documents provided as attachments to the registered contract.
    /// </summary>
    [IsoId("_HyBtYTm5EeWDb47rJ6ki4Q")]
    [DisplayName("Attachment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Attchmnt")]
    #endif
    [IsoXmlTag("Attchmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentGeneralInformation3? Attachment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentGeneralInformation3? Attachment { get; init; } 
    #else
    public DocumentGeneralInformation3? Attachment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
