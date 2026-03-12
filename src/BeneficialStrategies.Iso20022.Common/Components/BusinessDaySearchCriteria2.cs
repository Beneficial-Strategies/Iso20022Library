// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for system business day information.
/// </summary>
[IsoId("_yNYGiZlcEeeE1Ya-LgRsuQ")]
[DisplayName("Business Day Search Criteria")]
public partial record BusinessDaySearchCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Date for which the availability information is provided.
    /// </summary>
    [IsoId("_yVMlw5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("System Date")]
    [IsoXmlTag("SysDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? SystemDate { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of the system, as assigned by the system administrator.
    /// </summary>
    [IsoId("_yVMlxZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("System Identification")]
    [IsoXmlTag("SysId")]
    public SystemIdentification2Choice_? SystemIdentification { get; init; } 
    
    /// <summary>
    /// Currency which may be processed by the system. A system may process transactions in a single currency or in multiple currencies.
    /// </summary>
    [IsoId("_yVMlx5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("System Currency")]
    [IsoXmlTag("SysCcy")]
    public ActiveCurrencyCode? SystemCurrency { get; init; } 
    
    /// <summary>
    /// Nature of the event that has occurred.
    /// </summary>
    [IsoId("_yVMlyZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    public SystemEventType2Choice_? EventType { get; init; } 
    
    /// <summary>
    /// Period of time when the system is closed/not operating.
    /// </summary>
    [IsoId("_yVMly5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Closure Period")]
    [IsoXmlTag("ClsrPrd")]
    public DateTimePeriod1Choice_? ClosurePeriod { get; init; } 
    
    
    #nullable disable
    
}
