// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the debit instrument.
/// </summary>
[IsoId("_u39RcSQTEeWXFu0Jt0z3Xw")]
[DisplayName("Debt Instrument")]
public record DebtInstrument2
{
    /// <summary>
    /// Total issued nominal amount in monetary value.
    /// </summary>
    [IsoId("_vhWMmyQTEeWXFu0Jt0z3Xw")]
    [DisplayName("Total Issued Nominal Amount")]
    [IsoXmlTag("TtlIssdNmnlAmt")]
    public required ActiveOrHistoricCurrencyAndAmount TotalIssuedNominalAmount { get; init; }

    /// <summary>
    /// Maturity date of the financial instrument.
    /// </summary>
    [IsoId("_vhWMmSQTEeWXFu0Jt0z3Xw")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Nominal value of each instrument. If not available, the minimum traded value should be populated.
    /// </summary>
    [IsoId("_vhWMlyQTEeWXFu0Jt0z3Xw")]
    [DisplayName("Nominal Value Per Unit")]
    [IsoXmlTag("NmnlValPerUnit")]
    public required ActiveOrHistoricCurrencyAndAmount NominalValuePerUnit { get; init; }

    /// <summary>
    /// Interest rate of the debt instrument.
    /// </summary>
    [IsoId("_vhWMkyQTEeWXFu0Jt0z3Xw")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public required InterestRate6Choice_ InterestRate { get; init; }

    /// <summary>
    /// Seniority for a specific debt instrument.
    /// </summary>
    [IsoId("_vhWMlSQTEeWXFu0Jt0z3Xw")]
    [DisplayName("Debt Seniority")]
    [IsoXmlTag("DebtSnrty")]
    public DebtInstrumentSeniorityType1Code? DebtSeniority { get; init; }
}
