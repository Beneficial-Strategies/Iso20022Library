// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the terms of the contract in case of fixed or open interest rates.
/// </summary>
[IsoId("_xsKXZa5qEeuo-IflVgGqiA")]
[DisplayName("Fixed Open Term Contract")]
public record FixedOpenTermContract2
{
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the secured financing transaction.
    /// </summary>
    [IsoId("_x8jj0a5qEeuo-IflVgGqiA")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Indication whether the counterparties to the transaction have agreed to an evergreen or extendable agreement.
    /// </summary>
    [IsoId("_x8jj065qEeuo-IflVgGqiA")]
    [DisplayName("Termination Option")]
    [IsoXmlTag("TermntnOptn")]
    public RepoTerminationOption2Code? TerminationOption { get; init; }
}
