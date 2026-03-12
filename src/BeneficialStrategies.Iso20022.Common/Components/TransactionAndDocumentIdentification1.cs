// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction and document identification details.
/// </summary>
[IsoId("_Qri1ZNp-Ed-ak6NoX_4Aeg_-896139049")]
[DisplayName("Transaction And Document Identification")]
public partial record TransactionAndDocumentIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_Qri1Zdp-Ed-ak6NoX_4Aeg_-896139031")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identifier of the document (message) assigned by the sender of the document.
    /// </summary>
    [IsoId("_Qri1Ztp-Ed-ak6NoX_4Aeg_-896139014")]
    [DisplayName("Document Identification")]
    [IsoXmlTag("DocId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DocumentIdentification { get; init; } 
    
    /// <summary>
    /// Date and time at which the transaction was created by the instructing party in its business application.
    /// </summary>
    [IsoId("_Qri1Z9p-Ed-ak6NoX_4Aeg_-896138996")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTimeChoice_? CreationDateTime { get; init; } 
    
    /// <summary>
    /// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_QrsmYNp-Ed-ak6NoX_4Aeg_-479300354")]
    [DisplayName("Copy Duplicate")]
    [IsoXmlTag("CpyDplct")]
    public CopyDuplicate1Code? CopyDuplicate { get; init; } 
    
    
    #nullable disable
    
}
