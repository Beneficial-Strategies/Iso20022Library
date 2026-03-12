// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_1AIewZEKEem-9Y6mq5ZH3Q")]
[DisplayName("Fee")]
public partial record Fee7
{
    #nullable enable
    
    /// <summary>
    /// Type of fee.
    /// </summary>
    [IsoId("_1T69cZEKEem-9Y6mq5ZH3Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType6Choice_ Type { get; init; } 
    
    /// <summary>
    /// Method used to calculate the fee.
    /// </summary>
    [IsoId("_1T69c5EKEem-9Y6mq5ZH3Q")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public ChargeBasis2Choice_? Basis { get; init; } 
    
    /// <summary>
    /// Fee amount.
    /// </summary>
    [IsoId("_1T69dZEKEem-9Y6mq5ZH3Q")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Discount or waiver applied to the fee.
    /// </summary>
    [IsoId("_1T69d5EKEem-9Y6mq5ZH3Q")]
    [DisplayName("Discount Details")]
    [IsoXmlTag("DscntDtls")]
    public ChargeOrCommissionDiscount2? DiscountDetails { get; init; } 
    
    /// <summary>
    /// Party that bears the fee.
    /// </summary>
    [IsoId("_1T69eZEKEem-9Y6mq5ZH3Q")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearer1Code? ChargeBearer { get; init; } 
    
    /// <summary>
    /// Party entitled to the amount of money resulting from the fee.
    /// </summary>
    [IsoId("_1T69e5EKEem-9Y6mq5ZH3Q")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification139? RecipientIdentification { get; init; } 
    
    
    #nullable disable
    
}
