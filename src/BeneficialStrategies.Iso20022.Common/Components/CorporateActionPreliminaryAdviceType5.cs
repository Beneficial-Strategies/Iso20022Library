// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Preliminary Advice Type5.
/// </summary>
[IsoId("_9dMJgXl_Ee6_FuzYWj2GYQ")]
[DisplayName("Corporate Action Preliminary Advice Type5")]
public partial record CorporateActionPreliminaryAdviceType5
{
    #nullable enable

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
    public IsoRestrictedFINXMax16Text? MovementPreliminaryAdviceIdentification { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CorporateActionPreliminaryAdviceType1Code Type { get; init; } 

    
    #nullable disable
    
}
