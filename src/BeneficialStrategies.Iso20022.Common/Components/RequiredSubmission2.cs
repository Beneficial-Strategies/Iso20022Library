// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details relative to the submission of a data set.
/// </summary>
[IsoId("_Rax58Np-Ed-ak6NoX_4Aeg_1462344534")]
[DisplayName("Required Submission")]
public record RequiredSubmission2
{
    /// <summary>
    /// Specifies with party(ies) is authorised to submit the data set as part of the transaction.
    /// </summary>
    [IsoId("_Rax58dp-Ed-ak6NoX_4Aeg_1833600823")]
    [DisplayName("Submitter")]
    [IsoXmlTag("Submitr")]
    public ValueList<BICIdentification1> Submitter { get; init; } = [];
    // ID for the above is _Rax58dp-Ed-ak6NoX_4Aeg_1833600823
}
