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
[IsoId("_JqiHUQ04EeqUVL7sB4m7NA")]
[DisplayName("Stored Value Response")]
public partial record StoredValueResponse3
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_J3MDQQ04EeqUVL7sB4m7NA")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    
    /// <summary>
    /// Result of loading/reloading a stored value card.
    /// </summary>
    [IsoId("_J3MDQw04EeqUVL7sB4m7NA")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public StoredValueData3? Result { get; init; } 
    
    /// <summary>
    /// Customer or Merchant payment receipt.
    /// </summary>
    [IsoId("_J3MDRQ04EeqUVL7sB4m7NA")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public PaymentReceipt2? Receipt { get; init; } 
    
    
    #nullable disable
    
}
