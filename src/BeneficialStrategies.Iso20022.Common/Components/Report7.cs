// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report7.
/// </summary>
[IsoId("_PbV9AYcSEe-U27oWwgmhCQ")]
[DisplayName("Report7")]
public partial record Report7
{
    #nullable enable

    /// <summary>
    /// Non Clearing Member.
    /// </summary>
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public ValueList<PartyIdentificationAndAccount227> NonClearingMember { get; init; } = [];

    /// <summary>
    /// Settlement Obligation Details.
    /// </summary>
    [DisplayName("Settlement Obligation Details")]
    [IsoXmlTag("SttlmOblgtnDtls")]
    public ValueList<SettlementObligation9> SettlementObligationDetails { get; init; } = [];

    
    #nullable disable
    
}
