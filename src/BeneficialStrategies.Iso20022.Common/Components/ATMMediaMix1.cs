// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Media mix selected.
/// </summary>
[IsoId("_E2lAYIonEeSaAcF2oE2GNQ")]
[DisplayName("ATM Media Mix")]
public partial record ATMMediaMix1
{
    #nullable enable
    
    /// <summary>
    /// Logical unit number of the cash dispenser.
    /// </summary>
    [IsoId("_Sk_RIIonEeSaAcF2oE2GNQ")]
    [DisplayName("Cash Unit Number")]
    [IsoXmlTag("CshUnitNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? CashUnitNumber { get; init; } 
    
    /// <summary>
    /// Number of notes or coins.
    /// </summary>
    [IsoId("_YNkqQIonEeSaAcF2oE2GNQ")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Number { get; init; } 
    
    /// <summary>
    /// Unit value.
    /// </summary>
    [IsoId("_dJkqMIonEeSaAcF2oE2GNQ")]
    [DisplayName("Unit Value")]
    [IsoXmlTag("UnitVal")]
    public required ImpliedCurrencyAndAmount UnitValue { get; init; } 
    
    
    #nullable disable
    
}
