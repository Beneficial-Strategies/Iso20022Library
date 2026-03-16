// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the underlying statement entry, to which the investigation message refers.
/// </summary>
[IsoId("_CXmpX1RtEe23M4WgERMsYw")]
[DisplayName("Underlying Statement Entry")]
public record UnderlyingStatementEntry4
{
    /// <summary>
    /// Provides details of the account, for which the original statement was generated.
    /// </summary>
    [IsoId("_CXmpYFRtEe23M4WgERMsYw")]
    [DisplayName("Original Account")]
    [IsoXmlTag("OrgnlAcct")]
    public CashAccount40? OriginalAccount { get; init; }

    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_CXmpYVRtEe23M4WgERMsYw")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
    /// </summary>
    [IsoId("_CXmpYlRtEe23M4WgERMsYw")]
    [DisplayName("Original Statement Identification")]
    [IsoXmlTag("OrgnlStmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalStatementIdentification { get; init; }

    /// <summary>
    /// Original unique identification, as assigned by the account servicer, to unambiguously identify the original entry.
    /// </summary>
    [IsoId("_CXmpY1RtEe23M4WgERMsYw")]
    [DisplayName("Original Entry Identification")]
    [IsoXmlTag("OrgnlNtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEntryIdentification { get; init; }

    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_CXmpZFRtEe23M4WgERMsYw")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }
}
