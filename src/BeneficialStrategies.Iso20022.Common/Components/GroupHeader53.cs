// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader53"/>
[IsoId("_s7WrkFkyEeGeoaLUQk__nA_-536954472")]
[DisplayName("Group Header")]
public partial record GroupHeader53
{
    /// <inheritdoc cref="IGroupHeader53.MessageIdentification"/>
    [IsoId("_s7WrkVkyEeGeoaLUQk__nA_-840010987")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader53.CreationDateTime"/>
    [IsoId("_s7WrklkyEeGeoaLUQk__nA_-313015044")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader53.InstructingAgent"/>
    [IsoId("_s7Wrk1kyEeGeoaLUQk__nA_-1091038333")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader53.InstructedAgent"/>
    [IsoId("_s7gckFkyEeGeoaLUQk__nA_714358264")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }
}
