// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information on statistics per combination of counterparties.
/// </summary>
[IsoId("_MYzuUVfdEeqZr5K1Woax-g")]
[DisplayName("Detailed Statistics Per Counterparty")]
public partial record DetailedStatisticsPerCounterparty6
{
    #nullable enable
    
    /// <summary>
    /// Reference period for statistics collection.
    /// </summary>
    [IsoId("_MweAYVfdEeqZr5K1Woax-g")]
    [DisplayName("Reporting Period")]
    [IsoXmlTag("RptgPrd")]
    public required Period2 ReportingPeriod { get; init; } 
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_MweAY1fdEeqZr5K1Woax-g")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required CounterpartyData36 CounterpartyIdentification { get; init; } 
    
    /// <summary>
    /// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass validations.
    /// </summary>
    [IsoId("_MweAZVfdEeqZr5K1Woax-g")]
    [DisplayName("Rejection Statistics")]
    [IsoXmlTag("RjctnSttstcs")]
    public required RejectionStatistics3 RejectionStatistics { get; init; } 
    
    /// <summary>
    /// Identification of the competent authority which supervises the reporting counterparty.
    /// </summary>
    [IsoId("_MweAZ1fdEeqZr5K1Woax-g")]
    [DisplayName("Competent Authority")]
    [IsoXmlTag("CmptntAuthrty")]
    public CompetentAuthority1? CompetentAuthority { get; init; } 
    
    
    #nullable disable
    
}
