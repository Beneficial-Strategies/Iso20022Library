// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements characterising a financial instrument.
/// </summary>
[IsoId("_ja4gschlEeadgvwNGwK05w")]
[DisplayName("Financial Instrument Attributes")]
public partial record FinancialInstrumentAttributes90
{
    #nullable enable
    
    /// <summary>
    /// Reference notional amount of the contract.
    /// </summary>
    [IsoId("_jjd08chlEeadgvwNGwK05w")]
    [DisplayName("Notional")]
    [IsoXmlTag("Ntnl")]
    public ActiveCurrencyAndAmount? Notional { get; init; } 
    
    /// <summary>
    /// Value of unit move in index if fixed in contract terms, and currency of payments relating to changes in the amount of the underlying.
    /// </summary>
    [IsoId("_jjd088hlEeadgvwNGwK05w")]
    [DisplayName("Unit Value")]
    [IsoXmlTag("UnitVal")]
    public required ActiveCurrencyAndAmount UnitValue { get; init; } 
    
    /// <summary>
    /// Unique identifier for underlying index on which final settlement price or periodic payments are calculated.
    /// </summary>
    [IsoId("_jjd09chlEeadgvwNGwK05w")]
    [DisplayName("Index Identification")]
    [IsoXmlTag("IndxId")]
    public required GenericIdentification168 IndexIdentification { get; init; } 
    
    /// <summary>
    /// Unit index, typically ‘Points’, or for interest rate and CDS products, ‘Bps’.
    /// </summary>
    [IsoId("_HF0BMMhoEeadgvwNGwK05w")]
    [DisplayName("Index Unit")]
    [IsoXmlTag("IndxUnit")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text IndexUnit { get; init; } 
    
    /// <summary>
    /// Day count convention for interest payments. Interest rate products only.
    /// </summary>
    [IsoId("_NMr40MhoEeadgvwNGwK05w")]
    [DisplayName("Interest Rate Terms")]
    [IsoXmlTag("IntrstRateTerms")]
    public InterestComputationMethod2Code? InterestRateTerms { get; init; } 
    
    
    #nullable disable
    
}
