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
[IsoId("007ce36c-5435-41e1-9d75-9a75cef1c933")]
[DisplayName("Fee9")]
public record Fee9
{
    /// <summary>
    /// Type of fee (charge/commission).
    /// </summary>
    [IsoId("bc041f91-69dc-4e85-93f4-c49628c9dcf4")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType10Choice Type { get; init; }

    /// <summary>
    /// Method used to calculate the fee (charge/commission).
    /// </summary>
    [IsoId("603ff013-14e0-4592-adf7-6a1eaa0e4d36")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public ChargeBasis2Choice? Basis { get; init; }

    /// <summary>
    /// Standard fee (charge/commission) amount as specified in the fund prospectus or agreed for the account.
    /// </summary>
    [IsoId("b45d19e1-1ac7-4665-9b7e-7007f0d0136f")]
    [DisplayName("Standard Amount")]
    [IsoXmlTag("StdAmt")]
    public ActiveCurrencyAndAmount? StandardAmount { get; init; }

    /// <summary>
    /// Standard fee (charge/commission) rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("e26b0272-f9aa-4d43-a567-efa4171d8d74")]
    [DisplayName("Standard Rate")]
    [IsoXmlTag("StdRate")]
    public IsoPercentageRate? StandardRate { get; init; }

    /// <summary>
    /// Discount or waiver applied to the fee (charge/commission).
    /// </summary>
    [IsoId("0e230fca-d298-4f0f-8c93-b33aac1185d1")]
    [DisplayName("Discount Details")]
    [IsoXmlTag("DscntDtls")]
    public ChargeOrCommissionDiscount1? DiscountDetails { get; init; }

    /// <summary>
    /// Requested fee (charge/commission) amount as agreed for the account.
    /// </summary>
    [IsoId("ebee2350-f3eb-4515-8faf-d2de5ba82957")]
    [DisplayName("Requested Amount")]
    [IsoXmlTag("ReqdAmt")]
    public ActiveCurrencyAndAmount? RequestedAmount { get; init; }

    /// <summary>
    /// Requested rate used to calculate the amount of the fee (charge/commission), as agreed for the account.
    /// </summary>
    [IsoId("42fb98ff-b5ba-4247-a365-3bcf2283d15d")]
    [DisplayName("Requested Rate")]
    [IsoXmlTag("ReqdRate")]
    public IsoPercentageRate? RequestedRate { get; init; }

    /// <summary>
    /// Reference to a sales agreement that overrides normal processing or the Service Level Agreement (SLA).
    /// </summary>
    [IsoId("e779ed48-5041-4b87-9009-54680a66a524")]
    [DisplayName("Non Standard SLA Reference")]
    [IsoXmlTag("NonStdSLARef")]
    public IsoMax35Text? NonStandardSLAReference { get; init; }

    /// <summary>
    /// Party entitled to the amount of money resulting from a fee (charge/commission).
    /// </summary>
    [IsoId("27daa513-ff37-4cfc-b45b-145af39a7c7f")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification139? RecipientIdentification { get; init; }
}
