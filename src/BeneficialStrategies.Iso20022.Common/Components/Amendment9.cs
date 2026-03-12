// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the amendment.
/// </summary>
[IsoId("_9_wDcHltEeG7BsjMvd1mEw_-868509945")]
[DisplayName("Amendment")]
public partial record Amendment9
{
    #nullable enable
    
    /// <summary>
    /// Contents of the related UndertakingAmendmentResponse message.
    /// </summary>
    [IsoId("_9_wDcXltEeG7BsjMvd1mEw_-1238548049")]
    [DisplayName("Undertaking Amendment Response Message")]
    [IsoXmlTag("UdrtkgAmdmntRspnMsg")]
    public required UndertakingAmendmentResponseMessage1 UndertakingAmendmentResponseMessage { get; init; } 
    
    
    #nullable disable
    
}
