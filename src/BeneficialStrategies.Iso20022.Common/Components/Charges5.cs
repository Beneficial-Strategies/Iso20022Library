// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Charges related to a payment obligation contracted between two financial institutions related to the financing of a commercial transaction.
/// </summary>
[IsoId("_D8zW4dP_EeK0PPbKncCqzA")]
[DisplayName("Charges")]
public partial record Charges5
{
    #nullable enable
    
    /// <summary>
    /// Bank which will pay the charges.
    /// </summary>
    [IsoId("_EaqXm9P_EeK0PPbKncCqzA")]
    [DisplayName("Charges Payer")]
    [IsoXmlTag("ChrgsPyer")]
    public required BankRole1Code ChargesPayer { get; init; } 
    
    /// <summary>
    /// Bank which will receive the charges.
    /// </summary>
    [IsoId("_EaqXndP_EeK0PPbKncCqzA")]
    [DisplayName("Charges Payee")]
    [IsoXmlTag("ChrgsPyee")]
    public required BankRole1Code ChargesPayee { get; init; } 
    
    /// <summary>
    /// Amount of the charges taken by the payer.
    /// </summary>
    [IsoId("_EaqXn9P_EeK0PPbKncCqzA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public CurrencyAndAmount? Amount { get; init; } 
    
    /// <summary>
    /// Amount of the charges expressed as a percentage of the amount paid by the obligor bank.
    /// </summary>
    [IsoId("_EaqXodP_EeK0PPbKncCqzA")]
    [DisplayName("Percentage")]
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Percentage { get; init; } 
    
    /// <summary>
    /// Type of charges. For example: transaction charges, financing charges, deferred payment, interests.
    /// </summary>
    [IsoId("_QeQdoBUsEeOCqpkCrPgk4g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    
    #nullable disable
    
}
