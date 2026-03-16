// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the charges related to the payment transaction.
/// </summary>
[IsoId("_Ru5v09p-Ed-ak6NoX_4Aeg_2074358064")]
[DisplayName("Charges Information")]
public record ChargesInformation6
{
    /// <summary>
    /// Total of all charges and taxes applied to the entry.
    /// </summary>
    [IsoId("_Ru5v1Np-Ed-ak6NoX_4Aeg_2081742859")]
    [DisplayName("Total Charges And Tax Amount")]
    [IsoXmlTag("TtlChrgsAndTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalChargesAndTaxAmount { get; init; }

    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_Ru5v1dp-Ed-ak6NoX_4Aeg_2074358066")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether the charges amount is a credit or a debit amount. |Usage: A zero amount is considered to be a credit.
    /// </summary>
    [IsoId("_Ru5v1tp-Ed-ak6NoX_4Aeg_2043943488")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Specifies the type of charge.
    /// </summary>
    [IsoId("_Ru5v19p-Ed-ak6NoX_4Aeg_-1093257310")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ChargeType2Choice_? Type { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("_Ru5v2Np-Ed-ak6NoX_4Aeg_2074358148")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_RvC5wNp-Ed-ak6NoX_4Aeg_2081742829")]
    [DisplayName("Bearer")]
    [IsoXmlTag("Br")]
    public ChargeBearerType1Code? Bearer { get; init; }

    /// <summary>
    /// Party that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    [IsoId("_RvC5wdp-Ed-ak6NoX_4Aeg_2081743013")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public BranchAndFinancialInstitutionIdentification4? Party { get; init; }

    /// <summary>
    /// Set of elements used to provide details on the tax applied to charges.
    /// </summary>
    [IsoId("_RvC5wtp-Ed-ak6NoX_4Aeg_2081742963")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxCharges2? Tax { get; init; }
}
