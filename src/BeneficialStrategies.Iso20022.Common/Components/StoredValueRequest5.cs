// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to request a Stored Value service (Prepaid card or account).
/// </summary>
[IsoId("_UzMk8U4AEey_VecAUE-C9Q")]
[DisplayName("Stored Value Request")]
public record StoredValueRequest5
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_Re45gU7aEeyGi9JAv6wq7Q")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Data related to the stored value card.
    /// </summary>
    [IsoId("_U5bv0U4AEey_VecAUE-C9Q")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public ValueList<StoredValueData5> Data { get; init; } = [];
    // ID for the above is _U5bv0U4AEey_VecAUE-C9Q
}
