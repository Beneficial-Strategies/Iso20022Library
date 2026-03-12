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
[IsoId("_LzP20WASEeSkSfzdpzkxXg")]
[DisplayName("Fund")]
public partial record Fund3
{
    #nullable enable
    
    /// <summary>
    /// Name of the fund/sub fund.
    /// </summary>
    [IsoId("_MNuzaWASEeSkSfzdpzkxXg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; } 
    
    /// <summary>
    /// Identification of the fund/sub fund with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_MNuza2ASEeSkSfzdpzkxXg")]
    [DisplayName("Legal Entity Identifier")]
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier for the fund/sub fund, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_MNuzbWASEeSkSfzdpzkxXg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public OtherIdentification4? Identification { get; init; } 
    
    /// <summary>
    /// Currency of the fund/sub fund.
    /// </summary>
    [IsoId("_MNuzb2ASEeSkSfzdpzkxXg")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Estimated total value of all the holdings, less the fund&apos;s liabilities, of the fund/sub fund.
    /// </summary>
    [IsoId("_MNuzdWASEeSkSfzdpzkxXg")]
    [DisplayName("Estimated Total NAV")]
    [IsoXmlTag("EstmtdTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? EstimatedTotalNAV { get; init; } 
    
    /// <summary>
    /// Previous total value of all the holdings, less the fund&apos;s liabilities, of the fund/sub fund.
    /// </summary>
    [IsoId("_MNuzd2ASEeSkSfzdpzkxXg")]
    [DisplayName("Previous Total NAV")]
    [IsoXmlTag("PrvsTtlNAV")]
    public ActiveOrHistoricCurrencyAndAmount? PreviousTotalNAV { get; init; } 
    
    /// <summary>
    /// Estimated total number of units of the fund/sub fund.
    /// </summary>
    [IsoId("_MNuzeWASEeSkSfzdpzkxXg")]
    [DisplayName("Estimated Total Units Number")]
    [IsoXmlTag("EstmtdTtlUnitsNb")]
    public FinancialInstrumentQuantity1? EstimatedTotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Previous total number of units of the fund/sub fund.
    /// </summary>
    [IsoId("_MNuze2ASEeSkSfzdpzkxXg")]
    [DisplayName("Previous Total Units Number")]
    [IsoXmlTag("PrvsTtlUnitsNb")]
    public FinancialInstrumentQuantity1? PreviousTotalUnitsNumber { get; init; } 
    
    /// <summary>
    /// Estimated consolidated net cash flow expressed as a percentage of the previous total NAV for the fund/sub fund.
    /// </summary>
    [IsoId("_MNuzfWASEeSkSfzdpzkxXg")]
    [DisplayName("Estimated Percentage Of Fund Total NAV")]
    [IsoXmlTag("EstmtdPctgOfFndTtlNAV")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? EstimatedPercentageOfFundTotalNAV { get; init; } 
    
    
    #nullable disable
    
}
