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
[IsoId("_5ITuAVfcEeqZr5K1Woax-g")]
[DisplayName("Detailed Statistics Per Counterparty")]
public partial record DetailedStatisticsPerCounterparty5
{
    #nullable enable
    
    /// <summary>
    /// Reference date for statistics collection.
    /// </summary>
    [IsoId("_5fuIcVfcEeqZr5K1Woax-g")]
    [DisplayName("Reference Date")]
    [IsoXmlTag("RefDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ReferenceDate { get; init; } 
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_5fuIc1fcEeqZr5K1Woax-g")]
    [DisplayName("Counterparty Identification")]
    [IsoXmlTag("CtrPtyId")]
    public required TradeCounterpartyReport9 CounterpartyIdentification { get; init; } 
    
    /// <summary>
    /// Detailed information on derivatives submitted for reconciliation.
    /// </summary>
    [IsoId("_5fuIdVfcEeqZr5K1Woax-g")]
    [DisplayName("Reconciliation Statistics")]
    [IsoXmlTag("RcncltnSttstcs")]
    public required ReconciliationStatisticsPerDerivativeContractGroup3 ReconciliationStatistics { get; init; } 
    
    /// <summary>
    /// Identification of the competent authority which supervises the reporting counterparty.
    /// </summary>
    [IsoId("_5fuId1fcEeqZr5K1Woax-g")]
    [DisplayName("Competent Authority")]
    [IsoXmlTag("CmptntAuthrty")]
    public CompetentAuthority1? CompetentAuthority { get; init; } 
    
    
    #nullable disable
    
}
