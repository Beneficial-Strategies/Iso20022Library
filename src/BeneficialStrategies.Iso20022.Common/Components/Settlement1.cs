// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the settlement details.
/// </summary>
[IsoId("_-dwqJaMOEeCojJW5vEuTEQ_-717706352")]
[DisplayName("Settlement")]
public partial record Settlement1
{
    #nullable enable
    
    /// <summary>
    /// Total amount to be settled.
    /// </summary>
    [IsoId("_-dwqJqMOEeCojJW5vEuTEQ_-831545418")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public required AmountAndDirection27 SettlementAmount { get; init; } 
    
    /// <summary>
    /// Place where settlement of the securities takes place.
    /// </summary>
    [IsoId("_-dwqJ6MOEeCojJW5vEuTEQ_-1828617771")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification34Choice_? Depository { get; init; } 
    
    
    #nullable disable
    
}
