// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the acknowledgement of an ATM reconciliation from the ATM. manager.
/// </summary>
[IsoId("_nXyMUIt0EeSLQutgI1Ulfw")]
[DisplayName("ATM Reconciliation Acknowledgement")]
public partial record ATMReconciliationAcknowledgement1
{
    #nullable enable
    
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_HCGzkIt2EeSLQutgI1Ulfw")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine3 ATM { get; init; } 
    
    /// <summary>
    /// Information about the reconciliation response.
    /// </summary>
    [IsoId("_V6iAYIt2EeSLQutgI1Ulfw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required ATMTransaction12 Transaction { get; init; } 
    
    
    #nullable disable
    
}
