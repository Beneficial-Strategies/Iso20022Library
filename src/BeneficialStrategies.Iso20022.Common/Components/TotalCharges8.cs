// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Total Charges8.
/// </summary>
[IsoId("_vxQ40bK9Ee2BYd2ScWif6A")]
[DisplayName("Total Charges8")]
public partial record TotalCharges8
{
    #nullable enable

    /// <summary>
    /// Control Sum.
    /// </summary>
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    public IsoDecimalNumber? ControlSum { get; init; } 

    /// <summary>
    /// Credit Debit Indicator.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; } 

    /// <summary>
    /// Number Of Charges Breakdown Items.
    /// </summary>
    [DisplayName("Number Of Charges Breakdown Items")]
    [IsoXmlTag("NbOfChrgsBrkdwnItms")]
    public required IsoMax15NumericText NumberOfChargesBreakdownItems { get; init; } 

    /// <summary>
    /// Total Charges Amount.
    /// </summary>
    [DisplayName("Total Charges Amount")]
    [IsoXmlTag("TtlChrgsAmt")]
    public ActiveCurrencyAndAmount? TotalChargesAmount { get; init; } 

    
    #nullable disable
    
}
