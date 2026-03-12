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
[IsoId("_8C5sEKMgEeCJ6YNENx4h-w_-792076459")]
[DisplayName("Payment Instruction")]
public partial record PaymentInstruction3
{
    #nullable enable
    
    /// <summary>
    /// Date at which the initiating party requests that the payment instruction be processed. |.
    /// </summary>
    [IsoId("_8C5sEaMgEeCJ6YNENx4h-w_1832250156")]
    [DisplayName("Requested Execution Date Time")]
    [IsoXmlTag("ReqdExctnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RequestedExecutionDateTime { get; init; } 
    
    /// <summary>
    /// Type, or nature, of the payment, for example an express payment.
    /// </summary>
    [IsoId("_8C5sEqMgEeCJ6YNENx4h-w_1116036764")]
    [DisplayName("Payment Type")]
    [IsoXmlTag("PmtTp")]
    public PaymentType3Choice_? PaymentType { get; init; } 
    
    
    #nullable disable
    
}
