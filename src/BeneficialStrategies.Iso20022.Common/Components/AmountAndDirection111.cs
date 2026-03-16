// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount And Direction111.
/// </summary>
[IsoId("_cWbQAZ9TEe-nbM0aSPcoiQ")]
[DisplayName("Amount And Direction111")]
public partial record AmountAndDirection111
{
    #nullable enable

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; } 

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; } 

    /// <summary>
    /// Label.
    /// </summary>
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    public IsoMax70Text? Label { get; init; } 

    /// <summary>
    /// Sign.
    /// </summary>
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    public IsoPlusOrMinusIndicator? Sign { get; init; } 

    
    #nullable disable
    
}
