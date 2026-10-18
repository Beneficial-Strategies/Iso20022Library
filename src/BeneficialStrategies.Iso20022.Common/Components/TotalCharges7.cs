// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Total Charges7.
/// </summary>
[IsoId("_ADkvALEkEe2bkoYTeYLN5Q")]
[DisplayName("Total Charges7")]
public record TotalCharges7
{
    /// <summary>
    /// Number Of Charges Records.
    /// </summary>
    [DisplayName("Number Of Charges Records")]
    [IsoXmlTag("NbOfChrgsRcrds")]
    public required Max15NumericText NumberOfChargesRecords { get; init; }

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
