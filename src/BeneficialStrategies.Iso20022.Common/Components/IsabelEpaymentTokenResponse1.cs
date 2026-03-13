// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the token data on which the signature is calculated by the LRCI client.
/// </summary>
[IsoId("_vvpoEM_aEeWjSMe6YTKHlQ")]
[DisplayName("Isabel Epayment Token Response")]
public partial record IsabelEpaymentTokenResponse1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous transaction identification of the group of signed payment files.
    /// </summary>
    [IsoId("_q1xSkM_bEeWjSMe6YTKHlQ")]
    [DisplayName("LRCI Transaction Identification")]
    [IsoXmlTag("LRCITxId")]
    [IsoSimpleType(IsoSimpleType.Max50Binary)]
    public required IsoMax50Binary LRCITransactionIdentification { get; init; } 
    
    /// <summary>
    /// Individual record holding all data related to a payment file that is being used during the signature process.
    /// </summary>
    [IsoId("_ziCfIM_bEeWjSMe6YTKHlQ")]
    [DisplayName("Payment Information")]
    [IsoXmlTag("PmtInf")]
    [MinLength(1)]
    [MaxLength(100)]
    public ValueList<IsabelLRCIPaymentInformation1> PaymentInformation { get; init; } = [];
    
    /// <summary>
    /// Mathematical scheme for demonstrating the authenticity of the original server challenge exchanged by the LRCI protocol during the signature process.
    /// </summary>
    [IsoId("_21vEgM_bEeWjSMe6YTKHlQ")]
    [DisplayName("Server Signature")]
    [IsoXmlTag("SvrSgntr")]
    [IsoSimpleType(IsoSimpleType.Max1kBinary)]
    public required IsoMax1kBinary ServerSignature { get; init; } 
    
    
    #nullable disable
    
}
