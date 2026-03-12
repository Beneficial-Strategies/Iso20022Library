// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the aggregated data of internalised settlement instructions.
/// </summary>
[IsoId("_RCmFcO3uEeaWjpoyrnG6Rw")]
[DisplayName("Internalisation Data")]
public partial record InternalisationData2
{
    #nullable enable
    
    /// <summary>
    /// Aggregated volume and value of internalised settlement instructions settled during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_XApYQO3uEeaWjpoyrnG6Rw")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public required InternalisationDataVolume1 Settled { get; init; } 
    
    /// <summary>
    /// Aggregated volume and value of internalised settlement instructions failed during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_ZQXYIO3uEeaWjpoyrnG6Rw")]
    [DisplayName("Failed")]
    [IsoXmlTag("Faild")]
    public required InternalisationDataVolume1 Failed { get; init; } 
    
    /// <summary>
    /// Aggregated total volume and value of internalised settlement instructions performed (settled and failed) during the period covered by the report, for financial Instruments, types of transactions, types of clients and cash transfers.
    /// </summary>
    [IsoId("_cRK2sO3uEeaWjpoyrnG6Rw")]
    [DisplayName("Total")]
    [IsoXmlTag("Ttl")]
    public required InternalisationDataVolume1 Total { get; init; } 
    
    
    #nullable disable
    
}
