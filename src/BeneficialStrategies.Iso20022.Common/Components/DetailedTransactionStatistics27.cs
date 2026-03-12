// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about outstanding derivatives, outstanding derivatives with no valuation and outstanding derivatives with outdated valuation.
/// </summary>
[IsoId("_x1GY5VyGEe24CqbZJK5XxA")]
[DisplayName("Detailed Transaction Statistics")]
public partial record DetailedTransactionStatistics27
{
    #nullable enable
    
    /// <summary>
    /// Number of outstanding derivatives. 
    /// </summary>
    [IsoId("_x2DbIFyGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Outstanding Derivatives")]
    [IsoXmlTag("NbOfOutsdngDerivs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfOutstandingDerivatives { get; init; } 
    
    /// <summary>
    /// Number of outstanding derivatives for which valuation amount was never reported.
    /// </summary>
    [IsoId("_x2DbIlyGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Outstanding Derivatives With No Valuation")]
    [IsoXmlTag("NbOfOutsdngDerivsWthNoValtn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfOutstandingDerivativesWithNoValuation { get; init; } 
    
    /// <summary>
    /// Number of outstanding derivatives with outdated valuation.
    /// </summary>
    [IsoId("_x2DbJFyGEe24CqbZJK5XxA")]
    [DisplayName("Number Of Outstanding Derivatives With Outdated Valuation")]
    [IsoXmlTag("NbOfOutsdngDerivsWthOutdtdValtn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfOutstandingDerivativesWithOutdatedValuation { get; init; } 
    
    /// <summary>
    /// Details of outstanding derivatives for which the valuation was not reported or the valuation reported is more than fourteen calendar days earlier than the date for which the report was generated shall be included in the report of missing valuations at the end of the day.
    /// </summary>
    [IsoId("_x2DbJlyGEe24CqbZJK5XxA")]
    [DisplayName("Warnings")]
    [IsoXmlTag("Wrnngs")]
    public ValueList<MissingValuationsData2> Warnings { get; init; } = new ValueList<MissingValuationsData2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _x2DbJlyGEe24CqbZJK5XxA
    
    
    #nullable disable
    
}
