// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_Xqq34YjJEeeqaMoyJI1HbA")]
[DisplayName("Fee")]
public record Fee4
{
    /// <summary>
    /// Type of fee.
    /// </summary>
    [IsoId("_X518V4jJEeeqaMoyJI1HbA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType6Choice_ Type { get; init; }

    /// <summary>
    /// Method used to calculate the fee.
    /// </summary>
    [IsoId("_X518WYjJEeeqaMoyJI1HbA")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public ChargeBasis2Choice_? Basis { get; init; }

    /// <summary>
    /// Fee amount.
    /// </summary>
    [IsoId("_X518W4jJEeeqaMoyJI1HbA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Discount or waiver applied to the fee.
    /// </summary>
    [IsoId("_X518X4jJEeeqaMoyJI1HbA")]
    [DisplayName("Discount Details")]
    [IsoXmlTag("DscntDtls")]
    public ChargeOrCommissionDiscount2? DiscountDetails { get; init; }

    /// <summary>
    /// Party that bears the fee.
    /// </summary>
    [IsoId("_SMRgEYjKEeeqaMoyJI1HbA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearer1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Party entitled to the amount of money resulting from the fee.
    /// </summary>
    [IsoId("_X518Z4jJEeeqaMoyJI1HbA")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification113? RecipientIdentification { get; init; }
}
