// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Certificate record in which all currency control transactions are registered.
/// </summary>
[IsoId("_gTmyEbGJEeuSTr8k0UEM8A")]
[DisplayName("Transaction Certificate Record")]
public partial record TransactionCertificateRecord2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the certificate record.
    /// </summary>
    [IsoId("_gUj0UbGJEeuSTr8k0UEM8A")]
    [DisplayName("Certificate Record Identification")]
    [IsoXmlTag("CertRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text CertificateRecordIdentification { get; init; } 
    
    /// <summary>
    /// Indication of procedure for submitting documents.
    /// </summary>
    [IsoId("_uZqkULMqEeueudaIbClZbQ")]
    [DisplayName("Document Submitting Procedure")]
    [IsoXmlTag("DocSubmitgPrcdr")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    public IsoExact1NumericText? DocumentSubmittingProcedure { get; init; } 
    
    /// <summary>
    /// Details of the transaction for which the record has been generated.
    /// </summary>
    [IsoId("_gUj0U7GJEeuSTr8k0UEM8A")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required TransactionCertificate5 Transaction { get; init; } 
    
    /// <summary>
    /// Contract registration details related to the certificate record.
    /// </summary>
    [IsoId("_gUj0VbGJEeuSTr8k0UEM8A")]
    [DisplayName("Contract")]
    [IsoXmlTag("Ctrct")]
    public TransactionCertificateContract2? Contract { get; init; } 
    
    /// <summary>
    /// Documents provided as attachments to the registered contract.
    /// </summary>
    [IsoId("_gUj0V7GJEeuSTr8k0UEM8A")]
    [DisplayName("Attachment")]
    [IsoXmlTag("Attchmnt")]
    public DocumentGeneralInformation5? Attachment { get; init; } 
    
    
    #nullable disable
    
}
