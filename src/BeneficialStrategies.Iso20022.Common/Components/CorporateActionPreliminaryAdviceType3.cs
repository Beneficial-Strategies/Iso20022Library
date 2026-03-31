// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Type of movement preliminary advice document.
/// </summary>
[IsoId("_QE2AMTQSEe2o-K1dwNg8Gg")]
[DisplayName("Corporate Action Preliminary Advice Type")]
public record CorporateActionPreliminaryAdviceType3
{
    /// <summary>
    /// Type of movement preliminary advice, for example. new or replacement.
    /// </summary>
    [IsoId("_Qcr4cTQSEe2o-K1dwNg8Gg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CorporateActionPreliminaryAdviceType1Code Type { get; init; }

    /// <summary>
    /// Specifies whether the message advises about the final eligible balance and entitlements or about an upcoming posting or reversal of securities and/or cash postings.
    /// </summary>
    [IsoId("_97CFsDQSEe2o-K1dwNg8Gg")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public required CorporateActionMovementPreliminaryAdviceFunction1Code Function { get; init; }
}
