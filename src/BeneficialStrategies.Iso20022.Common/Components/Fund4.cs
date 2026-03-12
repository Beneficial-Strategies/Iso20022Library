// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an investment fund.
/// </summary>
[IsoId("_h_KfYWASEeSkSfzdpzkxXg")]
[DisplayName("Fund")]
public partial record Fund4
{
    #nullable enable
    
    /// <summary>
    /// Name of the fund/sub fund.
    /// </summary>
    [IsoId("_iaGH6WASEeSkSfzdpzkxXg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; } 
    
    /// <summary>
    /// Identification of the fund/sub fund with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_iaGH62ASEeSkSfzdpzkxXg")]
    [DisplayName("Legal Entity Identifier")]
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for the fund/sub fund, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_iaGH7WASEeSkSfzdpzkxXg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public OtherIdentification4? Identification { get; init; } 
    
    /// <summary>
    /// Currency of the fund/sub fund.
    /// </summary>
    [IsoId("_iaGH72ASEeSkSfzdpzkxXg")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Total value of all the holdings, less the fund&apos;s liabilities, of the fund/sub fund.
    /// </summary>
    [IsoId("_iaGH8WASEeSkSfzdpzkxXg")]
    [DisplayName("Total NAV")]
    [IsoXmlTag("TtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; } 
    
    /// <summary>
    /// Previous total value of all the holdings, less the fund&apos;s liabilities, of the fund/sub fund.
    /// </summary>
    [IsoId("_iaGH82ASEeSkSfzdpzkxXg")]
    [DisplayName("Previous Total NAV")]
    [IsoXmlTag("PrvsTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; } 
    
    /// <summary>
    /// Total number of units of the fund/sub fund.
    /// </summary>
    [IsoId("_iaGH9WASEeSkSfzdpzkxXg")]
    [DisplayName("Total Units Number")]
    [IsoXmlTag("TtlUnitsNb")]
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Previous total number of units of the fund/sub fund.
    /// </summary>
    [IsoId("_iaGH92ASEeSkSfzdpzkxXg")]
    [DisplayName("Previous Total Units Number")]
    [IsoXmlTag("PrvsTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Consolidated net cash flow expressed as a percentage of the total NAV for the fund/sub fund.
    /// </summary>
    [IsoId("_iaGH-WASEeSkSfzdpzkxXg")]
    [DisplayName("Percentage Of Fund Total NAV")]
    [IsoXmlTag("PctgOfFndTtlNAV")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfFundTotalNAV { get; init; } 
    
    
    #nullable disable
    
}
