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
[IsoId("_gTmyEbGJEeuSTr8k0UEM8A")]
[DisplayName("Transaction Certificate Record")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionCertificateRecord2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionCertificateRecord2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionCertificateRecord2( System.String reqCertificateRecordIdentification,TransactionCertificate5 reqTransaction )
    {
        CertificateRecordIdentification = reqCertificateRecordIdentification;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the certificate record.
    /// </summary>
    [IsoId("_gUj0UbGJEeuSTr8k0UEM8A")]
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
    /// Indication of procedure for submitting documents.
    /// </summary>
    [IsoId("_uZqkULMqEeueudaIbClZbQ")]
    [DisplayName("Document Submitting Procedure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocSubmitgPrcdr")]
    #endif
    [IsoXmlTag("DocSubmitgPrcdr")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact1NumericText? DocumentSubmittingProcedure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DocumentSubmittingProcedure { get; init; } 
    #else
    public System.String? DocumentSubmittingProcedure { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the transaction for which the record has been generated.
    /// </summary>
    [IsoId("_gUj0U7GJEeuSTr8k0UEM8A")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionCertificate5 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionCertificate5 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionCertificate5 Transaction { get; init; } 
    #else
    public TransactionCertificate5 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Contract registration details related to the certificate record.
    /// </summary>
    [IsoId("_gUj0VbGJEeuSTr8k0UEM8A")]
    [DisplayName("Contract")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctrct")]
    #endif
    [IsoXmlTag("Ctrct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionCertificateContract2? Contract { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionCertificateContract2? Contract { get; init; } 
    #else
    public TransactionCertificateContract2? Contract { get; set; } 
    #endif
    
    /// <summary>
    /// Documents provided as attachments to the registered contract.
    /// </summary>
    [IsoId("_gUj0V7GJEeuSTr8k0UEM8A")]
    [DisplayName("Attachment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Attchmnt")]
    #endif
    [IsoXmlTag("Attchmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentGeneralInformation5? Attachment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentGeneralInformation5? Attachment { get; init; } 
    #else
    public DocumentGeneralInformation5? Attachment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
