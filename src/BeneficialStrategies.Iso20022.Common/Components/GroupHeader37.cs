// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader37"/>
[IsoId("_P03FCtp-Ed-ak6NoX_4Aeg_130586071")]
[DisplayName("Group Header")]
public partial record GroupHeader37
{
    /// <inheritdoc cref="IGroupHeader37.MessageIdentification"/>
    [IsoId("_P1AO8Np-Ed-ak6NoX_4Aeg_130586102")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader37.CreationDateTime"/>
    [IsoId("_P1AO8dp-Ed-ak6NoX_4Aeg_130586380")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader37.InstructingAgent"/>
    [IsoId("_P1AO8tp-Ed-ak6NoX_4Aeg_-4271305")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader37.InstructedAgent"/>
    [IsoId("_P1AO89p-Ed-ak6NoX_4Aeg_-4271366")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; }
}
