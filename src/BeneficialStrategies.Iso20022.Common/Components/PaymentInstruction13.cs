// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction to pay an amount of money to an ultimate beneficiary, on behalf of an originator. This instruction may have to be forwarded several times to complete the settlement chain.|.
/// </summary>
[IsoId("_Lss7yxbwEeOy-PlRuFSUzQ")]
[DisplayName("Payment Instruction")]
public partial record PaymentInstruction13
{
    #nullable enable
    
    /// <summary>
    /// Date at which the initiating party requests that the payment instruction be processed. |.
    /// </summary>
    [IsoId("_MFP-oxbwEeOy-PlRuFSUzQ")]
    [DisplayName("Requested Execution Date Time")]
    [IsoXmlTag("ReqdExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RequestedExecutionDateTime { get; init; } 
    
    /// <summary>
    /// Type, or nature, of the payment, for example an express payment.
    /// </summary>
    [IsoId("_MFP-pRbwEeOy-PlRuFSUzQ")]
    [DisplayName("Payment Type")]
    [IsoXmlTag("PmtTp")]
    public PaymentType4Choice_? PaymentType { get; init; } 
    
    
    #nullable disable
    
}
