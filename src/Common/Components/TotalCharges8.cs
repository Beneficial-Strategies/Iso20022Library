// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Total Charges8.
/// </summary>
[IsoId("_vxQ40bK9Ee2BYd2ScWif6A")]
[DisplayName("Total Charges8")]
public partial record TotalCharges8
{
    /// <summary>
    /// Number Of Charges Breakdown Items.
    /// </summary>
    [DisplayName("Number Of Charges Breakdown Items")]
    [IsoXmlTag("NbOfChrgsBrkdwnItms")]
    public required Max15NumericText NumberOfChargesBreakdownItems { get; init; }

    /// <summary>
    /// Control Sum.
    /// </summary>
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    public DecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Total Charges Amount.
    /// </summary>
    [DisplayName("Total Charges Amount")]
    [IsoXmlTag("TtlChrgsAmt")]
    public ActiveCurrencyAndAmount? TotalChargesAmount { get; init; }

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }
}
