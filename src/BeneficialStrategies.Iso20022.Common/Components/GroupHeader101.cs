// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IGroupHeader101"/>
[IsoId("_csUdkdfYEeqoweZZxm4TPQ")]
[DisplayName("Group Header")]
public partial record GroupHeader101
{
    /// <inheritdoc cref="IGroupHeader101.MessageIdentification"/>
    [IsoId("_cu7FodfYEeqoweZZxm4TPQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <inheritdoc cref="IGroupHeader101.CreationDateTime"/>
    [IsoId("_cu7Fo9fYEeqoweZZxm4TPQ")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <inheritdoc cref="IGroupHeader101.InstructingAgent"/>
    [IsoId("_cu7FpdfYEeqoweZZxm4TPQ")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader101.InstructedAgent"/>
    [IsoId("_cu7Fp9fYEeqoweZZxm4TPQ")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="IGroupHeader101.OriginalBusinessQuery"/>
    [IsoId("_fYizQdfYEeqoweZZxm4TPQ")]
    [DisplayName("Original Business Query")]
    [IsoXmlTag("OrgnlBizQry")]
    public OriginalBusinessQuery1? OriginalBusinessQuery { get; init; }
}
