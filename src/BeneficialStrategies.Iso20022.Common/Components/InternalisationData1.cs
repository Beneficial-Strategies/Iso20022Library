// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the aggregated data and failed rate of internalised settlement instructions.
/// </summary>
[IsoId("_WeS9UO3nEeaWjpoyrnG6Rw")]
[DisplayName("Internalisation Data")]
public partial record InternalisationData1
{
    #nullable enable
    
    /// <summary>
    /// Aggregated volume and value of settled,  failed, total of internalised settlement instructions performed during the period covered by the report, for financial instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_iT1jwO3uEeaWjpoyrnG6Rw")]
    [DisplayName("Aggregate")]
    [IsoXmlTag("Aggt")]
    public required InternalisationData2 Aggregate { get; init; } 
    
    /// <summary>
    /// Rate of failed internalised settlement instructions compared to the total volume and value, of internalised settlement instructions performed (settled and failed) during the period covered by the report.
    /// </summary>
    [IsoId("_kjstkO3uEeaWjpoyrnG6Rw")]
    [DisplayName("Failed Rate")]
    [IsoXmlTag("FaildRate")]
    public required InternalisationDataRate1 FailedRate { get; init; } 
    
    
    #nullable disable
    
}
