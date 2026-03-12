// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related specifically to counterparties.
/// </summary>
[IsoId("_ongJkQz1Ee2YoLD-1vFj0g")]
[DisplayName("Counterparty Specific Data")]
public partial record CounterpartySpecificData36
{
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties of the reported transaction/position.
    /// </summary>
    [IsoId("_ooVQAQz1Ee2YoLD-1vFj0g")]
    [DisplayName("Counterparty")]
    [IsoXmlTag("CtrPty")]
    public required TradeCounterpartyReport20 Counterparty { get; init; } 
    
    /// <summary>
    /// Data specific to the valuation of the transaction.
    /// </summary>
    [IsoId("_ooVQAwz1Ee2YoLD-1vFj0g")]
    [DisplayName("Valuation")]
    [IsoXmlTag("Valtn")]
    public ContractValuationData8? Valuation { get; init; } 
    
    /// <summary>
    /// Indicates the date and time of the submission of the report to the trade repository.
    /// </summary>
    [IsoId("_ooVQBwz1Ee2YoLD-1vFj0g")]
    [DisplayName("Reporting Time Stamp")]
    [IsoXmlTag("RptgTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ReportingTimeStamp { get; init; } 
    
    
    #nullable disable
    
}
