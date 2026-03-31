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
[IsoId("_TOVcpZcFEee8S7xwGG7Veg")]
[DisplayName("Instructed Corporate Action Option")]
public record InstructedCorporateActionOption8
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_TdWwEZcFEee8S7xwGG7Veg")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_TdWwGZcFEee8S7xwGG7Veg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption18Choice_ OptionType { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_TdWwIZcFEee8S7xwGG7Veg")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public required BalanceFormat5Choice_ InstructedBalance { get; init; }

    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [IsoId("_TdWwKZcFEee8S7xwGG7Veg")]
    [DisplayName("Default Action")]
    [IsoXmlTag("DfltActn")]
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; }

    /// <summary>
    /// Provides information about the deadlines related to a corporate action option.
    /// </summary>
    [IsoId("_cjGXIJcGEee8S7xwGG7Veg")]
    [DisplayName("Event Deadlines")]
    [IsoXmlTag("EvtDdlns")]
    public required CorporateActionEventDeadlines1 EventDeadlines { get; init; }
}
