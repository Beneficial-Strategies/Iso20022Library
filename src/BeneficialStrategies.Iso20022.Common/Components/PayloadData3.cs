// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the instance of the document exchanged.
/// </summary>
[IsoId("_b5oVIRUZEfCfALVKQ4rOew")]
[DisplayName("Payload Data3")]
public record PayloadData3
{
    /// <summary>
    /// Identifier unique within the sender of the file and assigned by the sender of the file.
    /// </summary>
    [IsoId("_b63rQRUZEfCfALVKQ4rOew")]
    [DisplayName("Business File Identifier")]
    [IsoXmlTag("BizFileIdr")]
    public required IsoMax35Text BusinessFileIdentifier { get; init; }

    /// <summary>
    /// Date and time when the file was created by the sender.
    /// </summary>
    [IsoId("_b63rQxUZEfCfALVKQ4rOew")]
    [DisplayName("Creation Date")]
    [IsoXmlTag("CreDt")]
    public required IsoISODateTime CreationDate { get; init; }

    /// <summary>
    /// Indicates whether the file is a Copy, a Duplicate or a copy of a duplicate of a previously sent ISO 20022 File.
    /// </summary>
    [IsoId("_O6BZMxUbEfCfALVKQ4rOew")]
    [DisplayName("Copy Duplicate")]
    [IsoXmlTag("CpyDplct")]
    public CopyDuplicate1Code? CopyDuplicate { get; init; }

    /// <summary>
    /// Flag indicating if the Business File exchanged between the MessagingEndpoints is possibly a duplicate.
    /// </summary>
    [IsoId("_O6BZNBUbEfCfALVKQ4rOew")]
    [DisplayName("Possible Duplicate")]
    [IsoXmlTag("PssblDplct")]
    public IsoTrueFalseIndicator? PossibleDuplicate { get; init; }

    /// <summary>
    /// Relative indication of the processing precedence of the file over a (set of) Business Files with assigned priorities.
    /// </summary>
    [IsoId("_O6BZNRUbEfCfALVKQ4rOew")]
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public BusinessFilePriorityCode? Priority { get; init; }
}
