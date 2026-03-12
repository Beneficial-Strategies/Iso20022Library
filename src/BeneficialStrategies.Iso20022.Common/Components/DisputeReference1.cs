// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains dispute reference details.
/// </summary>
[IsoId("_sXZCwOCmEee9RadpHmUgYw")]
[DisplayName("Dispute Reference")]
public partial record DisputeReference1
{
    #nullable enable
    
    /// <summary>
    /// Name of the entity assigning the dispute reference.
    /// </summary>
    [IsoId("_8BhZUOCmEee9RadpHmUgYw")]
    [DisplayName("Assigner Entity")]
    [IsoXmlTag("AssgnrNtty")]
    public PartyType32Code? AssignerEntity { get; init; } 
    
    /// <summary>
    /// Other assigner entity.
    /// </summary>
    [IsoId("_krXOYOCqEee9RadpHmUgYw")]
    [DisplayName("Other Assigner Entity")]
    [IsoXmlTag("OthrAssgnrNtty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherAssignerEntity { get; init; } 
    
    /// <summary>
    /// Identification of the dispute.
    /// </summary>
    [IsoId("_NvLt4OCnEee9RadpHmUgYw")]
    [DisplayName("Dispute Identification")]
    [IsoXmlTag("DsptId")]
    public ValueList<DisputeIdentification1> DisputeIdentification { get; init; } = new ValueList<DisputeIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _NvLt4OCnEee9RadpHmUgYw
    
    
    #nullable disable
    
}
