// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context in which the card payment transaction is performed.
/// </summary>
[IsoId("_drTTUVBPEeedyPuM0kK2EQ")]
[DisplayName("Context")]
public record Context3
{
    /// <summary>
    /// Context of the card payment transaction at the point of service.
    /// </summary>
    [IsoId("_d3acsVBPEeedyPuM0kK2EQ")]
    [DisplayName("Point Of Service Context")]
    [IsoXmlTag("PtOfSvcCntxt")]
    public PointOfServiceContext1? PointOfServiceContext { get; init; }

    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_d3acs1BPEeedyPuM0kK2EQ")]
    [DisplayName("Transaction Context")]
    [IsoXmlTag("TxCntxt")]
    public required TransactionContext1 TransactionContext { get; init; }

    /// <summary>
    /// Method and data intended to be used for this transaction in order to authenticate or verify  the cardholder or his card.
    /// </summary>
    [IsoId("_FSoIEewTEeiMkKo2clXHdQ")]
    [DisplayName("Verification")]
    [IsoXmlTag("Vrfctn")]
    public ValueList<Verification2> Verification { get; init; } = [];

    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    [IsoId("_d3act1BPEeedyPuM0kK2EQ")]
    [DisplayName("Risk Context")]
    [IsoXmlTag("RskCntxt")]
    public RiskContext1? RiskContext { get; init; }

    /// <summary>
    /// Context of the sale associated with the card payment transaction.
    /// </summary>
    [IsoId("_xG_0MPljEeilft0P2fSiEQ")]
    [DisplayName("Sale Context")]
    [IsoXmlTag("SaleCntxt")]
    public SaleContext7? SaleContext { get; init; }
}
