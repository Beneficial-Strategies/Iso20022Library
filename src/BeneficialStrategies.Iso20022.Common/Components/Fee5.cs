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
[IsoId("_T8nZAW1bEeiqaPNRWUnGNA")]
[DisplayName("Fee")]
public record Fee5
{
    /// <summary>
    /// Type of fee (charge/commission).
    /// </summary>
    [IsoId("_UNkmI21bEeiqaPNRWUnGNA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType5Choice_ Type { get; init; }

    /// <summary>
    /// Method used to calculate the fee (charge/commission).
    /// </summary>
    [IsoId("_UNkmJW1bEeiqaPNRWUnGNA")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public ChargeBasis2Choice_? Basis { get; init; }

    /// <summary>
    /// Standard fee (charge/commission) amount as specified in the fund prospectus or agreed for the account.
    /// </summary>
    [IsoId("_UNkmJ21bEeiqaPNRWUnGNA")]
    [DisplayName("Standard Amount")]
    [IsoXmlTag("StdAmt")]
    public ActiveCurrencyAndAmount? StandardAmount { get; init; }

    /// <summary>
    /// Standard fee (charge/commission) rate used to calculate the amount of the charge or fee, as specified in the fund prospectus or agreed for the account.
    /// </summary>
    [IsoId("_UNkmKW1bEeiqaPNRWUnGNA")]
    [DisplayName("Standard Rate")]
    [IsoXmlTag("StdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? StandardRate { get; init; }

    /// <summary>
    /// Discount or waiver applied to the fee (charge/commission).
    /// </summary>
    [IsoId("_UNkmK21bEeiqaPNRWUnGNA")]
    [DisplayName("Discount Details")]
    [IsoXmlTag("DscntDtls")]
    public ChargeOrCommissionDiscount1? DiscountDetails { get; init; }

    /// <summary>
    /// Fee (charge/commission) amount applied to the transaction.
    /// </summary>
    [IsoId("_UNkmLW1bEeiqaPNRWUnGNA")]
    [DisplayName("Applied Amount")]
    [IsoXmlTag("ApldAmt")]
    public ActiveCurrencyAndAmount? AppliedAmount { get; init; }

    /// <summary>
    /// Final rate used to calculate the fee (charge/commission) amount.
    /// </summary>
    [IsoId("_UNkmL21bEeiqaPNRWUnGNA")]
    [DisplayName("Applied Rate")]
    [IsoXmlTag("ApldRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? AppliedRate { get; init; }

    /// <summary>
    /// Reference to a sales agreement that overrides normal processing or the Service Level Agreement (SLA), such as a fee (charge/commission).
    /// </summary>
    [IsoId("_UNkmMW1bEeiqaPNRWUnGNA")]
    [DisplayName("Non Standard SLA Reference")]
    [IsoXmlTag("NonStdSLARef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NonStandardSLAReference { get; init; }

    /// <summary>
    /// Party entitled to the amount of money resulting from a fee (charge/commission).
    /// </summary>
    [IsoId("_UNkmM21bEeiqaPNRWUnGNA")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification139? RecipientIdentification { get; init; }

    /// <summary>
    /// Indicates the information is provided for information purposes only. When the value is ‘false’ or ‘0’ the amount provided is taken into consideration in the transaction overhead. When the value is ‘true’ or ‘1’ the amount provided is not taken into consideration in the transaction overhead.
    /// </summary>
    [IsoId("_UNkmNW1bEeiqaPNRWUnGNA")]
    [DisplayName("Informative Indicator")]
    [IsoXmlTag("InftvInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator InformativeIndicator { get; init; }
}
