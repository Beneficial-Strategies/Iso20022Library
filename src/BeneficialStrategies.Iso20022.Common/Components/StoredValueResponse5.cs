// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response data to a Stored Value request.
/// </summary>
[IsoId("_9IcKYU4AEey_VecAUE-C9Q")]
[DisplayName("Stored Value Response")]
public partial record StoredValueResponse5
{
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_UrmWAU7uEeyGi9JAv6wq7Q")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_9OyC8U4AEey_VecAUE-C9Q")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    
    /// <summary>
    /// Result of loading/reloading a stored value card.
    /// </summary>
    [IsoId("_9OyC804AEey_VecAUE-C9Q")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public StoredValueData5? Result { get; init; } 
    
    /// <summary>
    /// Customer or Merchant payment receipt.
    /// </summary>
    [IsoId("_9OyC9U4AEey_VecAUE-C9Q")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public PaymentReceipt4? Receipt { get; init; } 
    
    
    #nullable disable
    
}
