// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the card transaction is performed.
/// </summary>
[IsoId("_LAygUHsHEeSR68OJvMfxJQ")]
[DisplayName("Card Transaction Context")]
public record CardTransactionContext1
{
    /// <summary>
    /// Context of the card transaction.
    /// </summary>
    [IsoId("_RunDMHsHEeSR68OJvMfxJQ")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public required CardTransactionContext2 TransactionContext { get; init; }

    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_XAcJMHsHEeSR68OJvMfxJQ")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext1? SaleContext { get; init; }
}
