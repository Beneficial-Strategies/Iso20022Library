// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the underlying statement entry.
/// </summary>
[IsoId("_bmqFUdwYEee0mvR9H3APRg")]
[DisplayName("Underlying Statement Entry")]
public record UnderlyingStatementEntry2
{
    /// <summary>
    /// Set of elements used to provide information on the original message.
    /// </summary>
    [IsoId("_b3BckdwYEee0mvR9H3APRg")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
    /// </summary>
    [IsoId("_b3Bck9wYEee0mvR9H3APRg")]
    [DisplayName("Original Statement Identification")]
    [IsoXmlTag("OrgnlStmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalStatementIdentification { get; init; }

    /// <summary>
    /// Original unique identification, as assigned by the account servicer, to unambiguously identify the original entry.
    /// </summary>
    [IsoId("_b3BcldwYEee0mvR9H3APRg")]
    [DisplayName("Original Entry Identification")]
    [IsoXmlTag("OrgnlNtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEntryIdentification { get; init; }
}
