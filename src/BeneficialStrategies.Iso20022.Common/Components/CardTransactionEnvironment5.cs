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
[IsoId("_Gj-mcXu6EeSLmfFG0DG7zQ")]
[DisplayName("Card Transaction Environment")]
public partial record CardTransactionEnvironment5
{
    #nullable enable
    
    /// <summary>
    /// Institution initiator of the reconciliation.
    /// It corresponds to the ISO 8583 field number 94.
    /// </summary>
    [IsoId("_UJ0xEHu6EeSLmfFG0DG7zQ")]
    [DisplayName("Sending Institution")]
    [IsoXmlTag("SndgInstn")]
    public required GenericIdentification73 SendingInstitution { get; init; } 
    
    /// <summary>
    /// Institution destination of the reconciliation.
    /// It corresponds to the ISO 8583 field number 93.
    /// </summary>
    [IsoId("_eIpKoHu6EeSLmfFG0DG7zQ")]
    [DisplayName("Receiving Institution")]
    [IsoXmlTag("RcvgInstn")]
    public required GenericIdentification73 ReceivingInstitution { get; init; } 
    
    /// <summary>
    /// Institution in charge of the settlement of the transaction.
    /// </summary>
    [IsoId("_kcNacHu6EeSLmfFG0DG7zQ")]
    [DisplayName("Settlement Institution")]
    [IsoXmlTag("SttlmInstn")]
    public required GenericIdentification73 SettlementInstitution { get; init; } 
    
    
    #nullable disable
    
}
