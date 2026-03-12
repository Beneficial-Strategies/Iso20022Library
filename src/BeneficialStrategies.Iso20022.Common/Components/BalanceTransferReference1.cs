// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference to enable the receiving account servicer to reconcile the payment with the message.
/// </summary>
[IsoId("_60SyMQ2aEeSNWNtJlXOAhg")]
[DisplayName("Balance Transfer Reference")]
public partial record BalanceTransferReference1
{
    #nullable enable
    
    /// <summary>
    /// Used by the debtor in a suitable reference field of a payment message sent over an alternative payment channel to enable the creditor to match the payment with the payment request.
    /// </summary>
    [IsoId("_-1hL8A2aEeSNWNtJlXOAhg")]
    [DisplayName("Balance Transfer Reference")]
    [IsoXmlTag("BalTrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text BalanceTransferReference { get; init; } 
    
    
    #nullable disable
    
}
