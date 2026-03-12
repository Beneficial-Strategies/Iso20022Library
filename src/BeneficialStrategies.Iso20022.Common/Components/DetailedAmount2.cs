// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
[IsoId("_TEzSnQEcEeCQm6a_G2yO_w_-2106105980")]
[DisplayName("Detailed Amount")]
public partial record DetailedAmount2
{
    #nullable enable
    
    /// <summary>
    /// Type of amount.
    /// </summary>
    [IsoId("_TE9DkAEcEeCQm6a_G2yO_w_2075022250")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeOfAmount2Code Type { get; init; } 
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_TE9DkQEcEeCQm6a_G2yO_w_1077949897")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required ImpliedCurrencyAndAmount Value { get; init; } 
    
    /// <summary>
    /// Short description of the amount.
    /// </summary>
    [IsoId("_TE9DkgEcEeCQm6a_G2yO_w_80877544")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Label { get; init; } 
    
    
    #nullable disable
    
}
