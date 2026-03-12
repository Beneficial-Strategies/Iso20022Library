// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Bank used by a central counterparty to allow for the convenient settlement of obligations between a central counterparty and a clearing member, typically in commercial bank money.
/// </summary>
[IsoId("_R_WoILIjEeaYqc4G3TTwhA")]
[DisplayName("Settlement Agent")]
public partial record SettlementAgent1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the settlement agent.
    /// </summary>
    [IsoId("_ZYv3kLIjEeaYqc4G3TTwhA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier Identification { get; init; } 
    
    /// <summary>
    /// CCP’s account at the settlement agent.
    /// </summary>
    [IsoId("_cMw3ULIjEeaYqc4G3TTwhA")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public ValueList<PaymentAccount1> Account { get; init; } = new ValueList<PaymentAccount1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _cMw3ULIjEeaYqc4G3TTwhA
    
    
    #nullable disable
    
}
