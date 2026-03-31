// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Preliminary Advice Type4.
/// </summary>
[IsoId("_68dvkWHNEe6yt_d72zQZeQ")]
[DisplayName("Corporate Action Preliminary Advice Type4")]
public record CorporateActionPreliminaryAdviceType4
{
    /// <summary>
    /// Function.
    /// </summary>
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public required CorporateActionMovementPreliminaryAdviceFunction1Code Function { get; init; }

    /// <summary>
    /// Movement Preliminary Advice Identification.
    /// </summary>
    [DisplayName("Movement Preliminary Advice Identification")]
    [IsoXmlTag("MvmntPrlimryAdvcId")]
    public IsoMax35Text? MovementPreliminaryAdviceIdentification { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CorporateActionPreliminaryAdviceType1Code Type { get; init; }
}
