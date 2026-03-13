// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount and trigger information.
/// </summary>
[IsoId("_-GTXZnltEeG7BsjMvd1mEw_-1985688302")]
[DisplayName("Amount And Trigger")]
public partial record AmountAndTrigger1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the amount and trigger details.
    /// </summary>
    [IsoId("_-GTXZ3ltEeG7BsjMvd1mEw_-1458509078")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Choice between an amount and a percentage.
    /// </summary>
    [IsoId("_-GTXaHltEeG7BsjMvd1mEw_-1720196234")]
    [DisplayName("Amount Details Choice")]
    [IsoXmlTag("AmtDtlsChc")]
    public required AmountOrPercentage1Choice_ AmountDetailsChoice { get; init; } 
    
    /// <summary>
    /// Trigger that causes the variation to come into effect.
    /// </summary>
    [IsoId("_-GdIYHltEeG7BsjMvd1mEw_-206552408")]
    [DisplayName("Trigger")]
    [IsoXmlTag("Trggr")]
    public ValueList<Trigger1> Trigger { get; init; } = [];
    // ID for the above is _-GdIYHltEeG7BsjMvd1mEw_-206552408
    
    
    #nullable disable
    
}
