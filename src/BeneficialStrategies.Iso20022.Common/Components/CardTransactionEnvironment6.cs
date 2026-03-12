// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
[IsoId("_hI8j0XvDEeSKFIcWw3l4Yw")]
[DisplayName("Card Transaction Environment")]
public partial record CardTransactionEnvironment6
{
    #nullable enable
    
    /// <summary>
    /// Institution initiator of the reconciliation (correspond to the ISO 8583 field 94).
    /// </summary>
    [IsoId("_hV6o0XvDEeSKFIcWw3l4Yw")]
    [DisplayName("Sending Institution")]
    [IsoXmlTag("SndgInstn")]
    public required GenericIdentification73 SendingInstitution { get; init; } 
    
    /// <summary>
    /// Institution destination of the reconciliation (correspond to the ISO 8583 field 93).
    /// </summary>
    [IsoId("_hV6o03vDEeSKFIcWw3l4Yw")]
    [DisplayName("Receiving Institution")]
    [IsoXmlTag("RcvgInstn")]
    public required GenericIdentification73 ReceivingInstitution { get; init; } 
    
    
    #nullable disable
    
}
