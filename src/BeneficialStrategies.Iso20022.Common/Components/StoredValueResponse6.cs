// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response data to a stored value request.
/// </summary>
[IsoId("_IGTQgXHEEe2TbaNWBpRZpQ")]
[DisplayName("Stored Value Response")]
public partial record StoredValueResponse6
{
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_INZ-EXHEEe2TbaNWBpRZpQ")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_INZ-E3HEEe2TbaNWBpRZpQ")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    
    /// <summary>
    /// Result of loading/reloading a stored value card.
    /// </summary>
    [IsoId("_INZ-FXHEEe2TbaNWBpRZpQ")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public StoredValueData6? Result { get; init; } 
    
    /// <summary>
    /// Customer or Merchant payment receipt.
    /// </summary>
    [IsoId("_INZ-F3HEEe2TbaNWBpRZpQ")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public PaymentReceipt5? Receipt { get; init; } 
    
    
    #nullable disable
    
}
