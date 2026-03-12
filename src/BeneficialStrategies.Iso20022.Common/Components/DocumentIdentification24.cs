// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the message number and the query identification.
/// </summary>
[IsoId("_QBS1o_5REeCtrO5qCU90cA")]
[DisplayName("Document Identification")]
public partial record DocumentIdentification24
{
    #nullable enable
    
    /// <summary>
    /// Message type number/message identifier of the message referenced in the linkage sequence.
    /// </summary>
    [IsoId("_VwemEf5REeCtrO5qCU90cA")]
    [DisplayName("Message Number")]
    [IsoXmlTag("MsgNb")]
    public DocumentNumber1Choice_? MessageNumber { get; init; } 
    
    /// <summary>
    /// Reference to the query identification.
    /// </summary>
    [IsoId("_ZyRnkf5REeCtrO5qCU90cA")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required Identification1 Reference { get; init; } 
    
    
    #nullable disable
    
}
