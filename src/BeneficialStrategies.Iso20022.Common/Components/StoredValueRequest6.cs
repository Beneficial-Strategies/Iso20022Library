// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a stored value service (prepaid card or account).
/// </summary>
[IsoId("_dKP-sXG0Ee2TbaNWBpRZpQ")]
[DisplayName("Stored Value Request")]
public partial record StoredValueRequest6
{
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_dQkpIXG0Ee2TbaNWBpRZpQ")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Data related to the stored value card.
    /// </summary>
    [IsoId("_dQkpI3G0Ee2TbaNWBpRZpQ")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public ValueList<StoredValueData6> Data { get; init; } = [];
    // ID for the above is _dQkpI3G0Ee2TbaNWBpRZpQ
    
    
    #nullable disable
    
}
