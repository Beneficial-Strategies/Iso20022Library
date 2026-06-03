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
[IsoId("2032b87b-e2d0-40af-beb5-5df44422cf8e")]
[DisplayName("Fee11")]
public record Fee11
{
    /// <summary>
    /// Type of fee (charge/commission).
    /// </summary>
    [IsoId("802dd4a0-ac66-4ddf-a6a4-bfc911432d94")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType10Choice_ Type { get; init; }

    /// <summary>
    /// Method used to calculate the fee (charge/commission).
    /// </summary>
    [IsoId("01c17818-eabd-4c0b-8059-7490dd39645a")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public ChargeBasis2Choice_? Basis { get; init; }

    /// <summary>
    /// Standard fee (charge/commission) amount as specified in the fund prospectus or agreed for the account.
    /// </summary>
    [IsoId("ddbf1bef-cb78-4a0a-82f2-d5bfd2ec7ed2")]
    [DisplayName("Standard Amount")]
    [IsoXmlTag("StdAmt")]
    public ActiveCurrencyAndAmount? StandardAmount { get; init; }

    /// <summary>
    /// Standard fee (charge/commission) rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("b5a18c86-a401-4f96-800e-f246db079a91")]
    [DisplayName("Standard Rate")]
    [IsoXmlTag("StdRate")]
    public IsoPercentageRate? StandardRate { get; init; }

    /// <summary>
    /// Discount or waiver applied to the fee (charge/commission).
    /// </summary>
    [IsoId("70386c31-a2fb-4f8c-9bb0-7962452f70b8")]
    [DisplayName("Discount Details")]
    [IsoXmlTag("DscntDtls")]
    public ChargeOrCommissionDiscount1? DiscountDetails { get; init; }

    /// <summary>
    /// Fee (charge/commission) amount applied to the transaction.
    /// </summary>
    [IsoId("2e43a567-e52f-4ba1-aee8-456c51e2adb0")]
    [DisplayName("Applied Amount")]
    [IsoXmlTag("ApldAmt")]
    public ActiveCurrencyAndAmount? AppliedAmount { get; init; }

    /// <summary>
    /// Final rate used to calculate the fee (charge/commission) amount.
    /// </summary>
    [IsoId("5506958c-a8a7-430f-a9b3-d190eb213f75")]
    [DisplayName("Applied Rate")]
    [IsoXmlTag("ApldRate")]
    public IsoPercentageRate? AppliedRate { get; init; }

    /// <summary>
    /// Reference to a sales agreement that overrides normal processing or the Service Level Agreement (SLA).
    /// </summary>
    [IsoId("2da87538-6641-4a16-89df-1f38cec497f6")]
    [DisplayName("Non Standard SLA Reference")]
    [IsoXmlTag("NonStdSLARef")]
    public IsoMax35Text? NonStandardSLAReference { get; init; }

    /// <summary>
    /// Party entitled to the amount of money resulting from a fee (charge/commission).
    /// </summary>
    [IsoId("8e0d1f7c-22f3-4f4c-bacc-4c9065cbd369")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification139? RecipientIdentification { get; init; }

    /// <summary>
    /// Indicates the information is provided for information purposes only.
    /// </summary>
    [IsoId("dca993a2-0ee6-4344-8ca3-62fb99779ce3")]
    [DisplayName("Informative Indicator")]
    [IsoXmlTag("InftvInd")]
    public required IsoYesNoIndicator InformativeIndicator { get; init; }
}
