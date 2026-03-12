// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details on the status of the payment conditions.
/// </summary>
[IsoId("_IGiOt3VlEeiEU7thYTAN1w")]
[DisplayName("Payment Condition Status")]
public partial record PaymentConditionStatus1
{
    #nullable enable
    
    /// <summary>
    /// Amount accepted to be paid.
    /// Usage:
    /// May only be present when AmountModificationAllowed is present in the request.
    /// </summary>
    [IsoId("_p7y48HVlEeiEU7thYTAN1w")]
    [DisplayName("Accepted Amount")]
    [IsoXmlTag("AccptdAmt")]
    public ActiveCurrencyAndAmount? AcceptedAmount { get; init; } 
    
    /// <summary>
    /// Indicates if the DebtorAgent guarantees the payment, assuming a payment guarantee contract exists between the different actors.
    /// </summary>
    [IsoId("_IGiOvXVlEeiEU7thYTAN1w")]
    [DisplayName("Guaranteed Payment")]
    [IsoXmlTag("GrntedPmt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator GuaranteedPayment { get; init; } 
    
    /// <summary>
    /// Indicates if the debtor will pay before the requested execution date.
    /// </summary>
    [IsoId("_IGiOuHVlEeiEU7thYTAN1w")]
    [DisplayName("Early Payment")]
    [IsoXmlTag("EarlyPmt")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator EarlyPayment { get; init; } 
    
    
    #nullable disable
    
}
