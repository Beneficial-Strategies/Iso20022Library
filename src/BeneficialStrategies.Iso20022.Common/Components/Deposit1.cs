// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money placed at a deposit taking institution.
/// </summary>
[IsoId("_-hi44LJUEeaYqc4G3TTwhA")]
[DisplayName("Deposit")]
public partial record Deposit1
{
    #nullable enable
    
    /// <summary>
    /// Date on which the deposit matures.
    /// </summary>
    [IsoId("_H_pLALJVEeaYqc4G3TTwhA")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate MaturityDate { get; init; } 
    
    /// <summary>
    /// Specifies the value of the deposit.
    /// </summary>
    [IsoId("_LYG7oLJVEeaYqc4G3TTwhA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required ActiveCurrencyAndAmount Value { get; init; } 
    
    /// <summary>
    /// Identifies the legal entity that takes the deposit.
    /// </summary>
    [IsoId("_N0LVcLJVEeaYqc4G3TTwhA")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier CounterpartyIdentification { get; init; } 
    
    
    #nullable disable
    
}
