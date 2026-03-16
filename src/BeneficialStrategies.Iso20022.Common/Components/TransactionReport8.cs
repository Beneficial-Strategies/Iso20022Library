// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Report8.
/// </summary>
[IsoId("_1wbYqTEyEe6g-ffJsqGiSA")]
[DisplayName("Transaction Report8")]
public partial record TransactionReport8
{
    #nullable enable

    /// <summary>
    /// Payment Identification.
    /// </summary>
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification8Choice_ PaymentIdentification { get; init; } 

    /// <summary>
    /// Transaction Or Error.
    /// </summary>
    [DisplayName("Transaction Or Error")]
    [IsoXmlTag("TxOrErr")]
    public required TransactionOrError6Choice_ TransactionOrError { get; init; } 

    
    #nullable disable
    
}
