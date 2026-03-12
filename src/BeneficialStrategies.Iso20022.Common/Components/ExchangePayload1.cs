// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component includes the exchanged ISO20022 documents.
/// </summary>
[IsoId("_jLluU-5NEeCisYr99QEiWA_-2124206208")]
[DisplayName("Exchange Payload")]
public partial record ExchangePayload1
{
    #nullable enable
    
    /// <summary>
    /// The respective ISO 20022 standard document.
    /// </summary>
    [IsoId("_jLluVO5NEeCisYr99QEiWA_1978501179")]
    [DisplayName("Any")]
    [IsoXmlTag("Any")]
    public required LaxProcessing Any { get; init; } 
    
    
    #nullable disable
    
}
