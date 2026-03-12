// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the payment transactions.
/// </summary>
[IsoId("_dksd0dcZEeqRFcf2R4bPBw")]
[DisplayName("Transaction Report")]
public partial record TransactionReport6
{
    #nullable enable
    
    /// <summary>
    /// Reference to the instruction related to the payment for which information is requested.
    /// </summary>
    [IsoId("_dmIBMdcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification6Choice_ PaymentIdentification { get; init; } 
    
    /// <summary>
    /// Requested information on the payment transaction when information has not been found.
    /// </summary>
    [IsoId("_dmIBM9cZEeqRFcf2R4bPBw")]
    [DisplayName("Transaction Or Error")]
    [IsoXmlTag("TxOrErr")]
    public required TransactionOrError5Choice_ TransactionOrError { get; init; } 
    
    
    #nullable disable
    
}
