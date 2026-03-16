// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the final agent.
/// </summary>
[IsoId("_Prd4cdp-Ed-ak6NoX_4Aeg_-1258143330")]
[DisplayName("Instruction For Final Agent")]
public record InstructionForFinalAgent
{
    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the final agent, in coded form.
    /// </summary>
    [IsoId("_Prd4ctp-Ed-ak6NoX_4Aeg_-357710298")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<Instruction3Code> Code { get; init; } = [];

    /// <summary>
    /// Instruction to the final agent that is specific to a user community and is required for use within that user community.||Usage: The proprietary element should only be used when the coded element does not provide sufficient codes or when the selected code in the coded element needs to be supplemented by additional information such as a passport number or telephone number.
    /// </summary>
    [IsoId("_Prd4c9p-Ed-ak6NoX_4Aeg_-100044573")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Proprietary { get; init; }
}
