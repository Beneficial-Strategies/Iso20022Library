// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation advice response from the acquirer.
/// </summary>
[IsoId("_SwFm2AEcEeCQm6a_G2yO_w_1721029493")]
[DisplayName("Card Payment Transaction Advice Response")]
public partial record CardPaymentTransactionAdviceResponse2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the transaction by the POI.
    /// </summary>
    [IsoId("_SwFm2QEcEeCQm6a_G2yO_w_-2048033866")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    
    
    #nullable disable
    
}
