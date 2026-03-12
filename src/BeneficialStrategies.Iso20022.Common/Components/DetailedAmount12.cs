// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts of the withdrawal transaction.
/// </summary>
[IsoId("_gtlD0YokEeSaAcF2oE2GNQ")]
[DisplayName("Detailed Amount")]
public partial record DetailedAmount12
{
    #nullable enable
    
    /// <summary>
    /// Amount to be dispensed by the ATM after the approval of the withdrawal transaction.
    /// </summary>
    [IsoId("_g6XipYokEeSaAcF2oE2GNQ")]
    [DisplayName("Amount To Dispense")]
    [IsoXmlTag("AmtToDspns")]
    public required ImpliedCurrencyAndAmount AmountToDispense { get; init; } 
    
    /// <summary>
    /// Currency of the amount to dispense when different from the base currency of the ATM.
    /// </summary>
    [IsoId("_8-oeoIokEeSaAcF2oE2GNQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Withdrawal fees, accepted by the customer.
    /// </summary>
    [IsoId("_NvDH0IolEeSaAcF2oE2GNQ")]
    [DisplayName("Fees")]
    [IsoXmlTag("Fees")]
    public DetailedAmount13? Fees { get; init; } 
    
    /// <summary>
    /// Amount of the donation.
    /// </summary>
    [IsoId("_g4F1QIolEeSaAcF2oE2GNQ")]
    [DisplayName("Donation")]
    [IsoXmlTag("Dontn")]
    public DetailedAmount13? Donation { get; init; } 
    
    
    #nullable disable
    
}
