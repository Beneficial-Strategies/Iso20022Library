// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the collateral counterparty(ies) of Party A with his eligibility set profile.
/// </summary>
[IsoId("_WfxEk_osEeiAfJEqh4xF_Q")]
[DisplayName("Collateral Parties")]
public partial record CollateralParties4
{
    #nullable enable
    
    /// <summary>
    /// Counterparty of party A. 
    /// </summary>
    [IsoId("_WfxElPosEeiAfJEqh4xF_Q")]
    [DisplayName("Party B")]
    [IsoXmlTag("PtyB")]
    public required PartyIdentification232 PartyB { get; init; } 
    
    /// <summary>
    /// Party that instructs party B to settle the instruction on its behalf.
    /// </summary>
    [IsoId("_WfxElfosEeiAfJEqh4xF_Q")]
    [DisplayName("Client Party B")]
    [IsoXmlTag("ClntPtyB")]
    public PartyIdentification232? ClientPartyB { get; init; } 
    
    /// <summary>
    /// Number identifying the collateral eligibility set profile of the counterparty.
    /// </summary>
    [IsoId("_2lmYkfosEeiAfJEqh4xF_Q")]
    [DisplayName("Eligibility Set Profile")]
    [IsoXmlTag("ElgbltySetPrfl")]
    public GenericIdentification37? EligibilitySetProfile { get; init; } 
    
    
    #nullable disable
    
}
