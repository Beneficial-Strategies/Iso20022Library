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
[IsoId("_MO-qsQq_EeGFLZ_5tFfOnw")]
[DisplayName("Instructed Corporate Action Option")]
public record InstructedCorporateActionOption4
{
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_MPIbsQq_EeGFLZ_5tFfOnw")]
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? OptionNumber { get; init; }

    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_MPIbuwq_EeGFLZ_5tFfOnw")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption10Choice_ OptionType { get; init; }

    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_MPIbxQq_EeGFLZ_5tFfOnw")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public required BalanceFormat1Choice_ InstructedBalance { get; init; }

    /// <summary>
    /// Indicates the default action related to a corporate action event.
    /// </summary>
    [IsoId("_MPIbzwq_EeGFLZ_5tFfOnw")]
    [DisplayName("Default Action")]
    [IsoXmlTag("DfltActn")]
    public DefaultProcessingOrStandingInstruction1Choice_? DefaultAction { get; init; }

    /// <summary>
    /// Any deadline chosen by the account servicer (service level agreement).
    /// </summary>
    [IsoId("_MPIb2Qq_EeGFLZ_5tFfOnw")]
    [DisplayName("Deadline Date Time")]
    [IsoXmlTag("DdlnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DeadlineDateTime { get; init; }

    /// <summary>
    /// Specifies the type of deadline for instructing.
    /// </summary>
    [IsoId("_MPIb3Qq_EeGFLZ_5tFfOnw")]
    [DisplayName("Deadline Type")]
    [IsoXmlTag("DdlnTp")]
    public required DeadlineCode1Choice_ DeadlineType { get; init; }
}
