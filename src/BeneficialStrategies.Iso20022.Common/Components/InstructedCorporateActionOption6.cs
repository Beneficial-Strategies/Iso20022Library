// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides corporate action option details about total instructed balance.
/// </summary>
[IsoId("_lTehxTq5EeWQ1Y7f8kds2A")]
[DisplayName("Instructed Corporate Action Option")]
public record InstructedCorporateActionOption6
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_lgkikTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_lgkimTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption18Choice_ OptionType { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_lgkioTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public required BalanceFormat5Choice_ InstructedBalance { get; init; }

    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [IsoId("_lgkiqTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Default Action")]
    [IsoXmlTag("DfltActn")]
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; }

    /// <summary>
    /// Any deadline chosen by the account servicer (service level agreement).
    /// </summary>
    [IsoId("_lgkisTq5EeWQ1Y7f8kds2A")]
    [DisplayName("Deadline Date Time")]
    [IsoXmlTag("DdlnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DeadlineDateTime { get; init; }

    /// <summary>
    /// Specifies the type of deadline for instructing.
    /// </summary>
    [IsoId("_lgkiszq5EeWQ1Y7f8kds2A")]
    [DisplayName("Deadline Type")]
    [IsoXmlTag("DdlnTp")]
    public required DeadlineCode3Choice_ DeadlineType { get; init; }
}
