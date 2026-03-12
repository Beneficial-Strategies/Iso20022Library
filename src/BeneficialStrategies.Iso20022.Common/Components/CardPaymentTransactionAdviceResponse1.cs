// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card payment completion advice response from the acquirer.
/// </summary>
[IsoId("_SwFm1QEcEeCQm6a_G2yO_w_-1200741519")]
[DisplayName("Card Payment Transaction Advice Response")]
public partial record CardPaymentTransactionAdviceResponse1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the transaction by the POI.
    /// </summary>
    [IsoId("_SwFm1gEcEeCQm6a_G2yO_w_-262963382")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Result of a requested service.
    /// </summary>
    [IsoId("_SwFm1wEcEeCQm6a_G2yO_w_871723701")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response1Code Response { get; init; } 
    
    
    #nullable disable
    
}
