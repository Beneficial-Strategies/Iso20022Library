// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the terms of the contract in case of fixed interest rates.
/// </summary>
[IsoId("_aB8l4U9xEeeRtrXYXV38uA")]
[DisplayName("Fixed Term Contract")]
public partial record FixedTermContract2
{
    #nullable enable
    
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the secured financing transaction. This information shall not be reported for open term agreements.
    /// </summary>
    [IsoId("_aMOjQU9xEeeRtrXYXV38uA")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; } 
    
    /// <summary>
    /// Indication whether the counterparties to the transaction have agreed to an evergreen or extendable agreement.
    /// </summary>
    [IsoId("_aMOjQ09xEeeRtrXYXV38uA")]
    [DisplayName("Termination Option")]
    [IsoXmlTag("TermntnOptn")]
    public RepoTerminationOption2Code? TerminationOption { get; init; } 
    
    
    #nullable disable
    
}
