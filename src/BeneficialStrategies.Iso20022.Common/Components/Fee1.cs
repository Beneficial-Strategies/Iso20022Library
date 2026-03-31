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
[IsoId("_OIXCoDh4EeamLZQeccJa7w")]
[DisplayName("Fee")]
public record Fee1
{
    /// <summary>
    /// Type of fee (charge/commission).
    /// </summary>
    [IsoId("_8tq38jh4EeaH-93K5JKmzw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType5Choice_ Type { get; init; }

    /// <summary>
    /// Method used to calculate the fee (charge/commission).
    /// </summary>
    [IsoId("__VgAYjh5EeaH-93K5JKmzw")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public ChargeBasis2Choice_? Basis { get; init; }

    /// <summary>
    /// Standard fee (charge/commission) amount as specified in the fund prospectus or agreed for the account.
    /// </summary>
    [IsoId("_U-gJIzh6EeaH-93K5JKmzw")]
    [DisplayName("Standard Amount")]
    [IsoXmlTag("StdAmt")]
    public ActiveCurrencyAndAmount? StandardAmount { get; init; }

    /// <summary>
    /// Standard fee (charge/commission) rate used to calculate the amount of the charge or fee, as specified in the fund prospectus or agreed for the account.
    /// </summary>
    [IsoId("_U-gJJDh6EeaH-93K5JKmzw")]
    [DisplayName("Standard Rate")]
    [IsoXmlTag("StdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? StandardRate { get; init; }

    /// <summary>
    /// Discount or waiver applied to the fee (charge/commission).
    /// </summary>
    [IsoId("_gJBNQViZEeaMNZxYNthMeA")]
    [DisplayName("Discount Details")]
    [IsoXmlTag("DscntDtls")]
    public ChargeOrCommissionDiscount1? DiscountDetails { get; init; }

    /// <summary>
    /// Requested fee (charge/commission) amount as agreed for the account.
    /// </summary>
    [IsoId("_rBKSYGRIEeaj9PFzwy2f6A")]
    [DisplayName("Requested Amount")]
    [IsoXmlTag("ReqdAmt")]
    public ActiveCurrencyAndAmount? RequestedAmount { get; init; }

    /// <summary>
    /// Requested rate used to calculate the amount of the fee (charge/commission), as agreed for the account.
    /// </summary>
    [IsoId("_0cBqUWRIEeaj9PFzwy2f6A")]
    [DisplayName("Requested Rate")]
    [IsoXmlTag("ReqdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? RequestedRate { get; init; }

    /// <summary>
    /// Reference to a sales agreement that overrides normal processing or the Service Level Agreement (SLA), such as a fee (charge/commission).
    /// </summary>
    [IsoId("_WCFjcTkyEeapUO0vUIo9Xw")]
    [DisplayName("Non Standard SLA Reference")]
    [IsoXmlTag("NonStdSLARef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NonStandardSLAReference { get; init; }

    /// <summary>
    /// Party entitled to the amount of money resulting from a fee (charge/commission).
    /// </summary>
    [IsoId("_U-gJJTh6EeaH-93K5JKmzw")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification113? RecipientIdentification { get; init; }
}
