// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the settlement obligation report.
/// </summary>
[IsoId("_7jLUES9dEeS94oXWDaBauA")]
[DisplayName("Report")]
public partial record Report5
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification for the non-clearing member. This is mandatory if the clearing member identification equals a general clearing member.
    /// </summary>
    [IsoId("_71U0AS9dEeS94oXWDaBauA")]
    [DisplayName("Non Clearing Member")]
    [IsoXmlTag("NonClrMmb")]
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    
    /// <summary>
    /// Provides information about the settlement obligation details.
    /// </summary>
    [IsoId("_71U0Ay9dEeS94oXWDaBauA")]
    [DisplayName("Settlement Obligation Details")]
    [IsoXmlTag("SttlmOblgtnDtls")]
    public ValueList<SettlementObligation8> SettlementObligationDetails { get; init; } = new ValueList<SettlementObligation8>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _71U0Ay9dEeS94oXWDaBauA
    
    
    #nullable disable
    
}
