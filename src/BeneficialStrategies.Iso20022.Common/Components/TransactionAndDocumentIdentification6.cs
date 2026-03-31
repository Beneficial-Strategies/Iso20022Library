// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction and document identification details.
/// </summary>
[IsoId("_p8kywTp7EemwKdP955WBJQ")]
[DisplayName("Transaction And Document Identification")]
public record TransactionAndDocumentIdentification6
{
    /// <summary>
    /// Unambiguous identification of the transaction as known by the instructing party.
    /// </summary>
    [IsoId("_qGtmMTp7EemwKdP955WBJQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Unique identifier of the document (message) assigned by the sender of the document.
    /// </summary>
    [IsoId("_qGtmOTp7EemwKdP955WBJQ")]
    [DisplayName("Document Identification")]
    [IsoXmlTag("DocId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DocumentIdentification { get; init; }

    /// <summary>
    /// Date and time at which the transaction was created by the instructing party in its business application.
    /// </summary>
    [IsoId("_qGtmOzp7EemwKdP955WBJQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public DateAndDateTime2Choice_? CreationDateTime { get; init; }

    /// <summary>
    /// Specifies if this document is a copy, a duplicate, or a duplicate of a copy.
    /// </summary>
    [IsoId("_qGtmQzp7EemwKdP955WBJQ")]
    [DisplayName("Copy Duplicate")]
    [IsoXmlTag("CpyDplct")]
    public CopyDuplicate1Code? CopyDuplicate { get; init; }

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_qGtmSzp7EemwKdP955WBJQ")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public PartyIdentification136? MessageOriginator { get; init; }

    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_qGtmTTp7EemwKdP955WBJQ")]
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public PartyIdentification136? MessageRecipient { get; init; }
}
