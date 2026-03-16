// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the balance inquiry response message.
/// </summary>
[IsoId("_DM8KUXHDEe2TbaNWBpRZpQ")]
[DisplayName("Balance Inquiry Response")]
public record BalanceInquiryResponse5
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_DT68EXHDEe2TbaNWBpRZpQ")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_DT68E3HDEe2TbaNWBpRZpQ")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public TransactionIdentifier1? POITransactionIdentification { get; init; }

    /// <summary>
    /// Payment account information.
    /// </summary>
    [IsoId("_DT68FXHDEe2TbaNWBpRZpQ")]
    [DisplayName("Payment Account")]
    [IsoXmlTag("PmtAcct")]
    public PaymentAccount3? PaymentAccount { get; init; }

    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_DT68F3HDEe2TbaNWBpRZpQ")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public LoyaltyAccount3? LoyaltyAccount { get; init; }

    /// <summary>
    /// Stored value account information.
    /// </summary>
    [IsoId("_DT68GXHDEe2TbaNWBpRZpQ")]
    [DisplayName("Stored Value Account")]
    [IsoXmlTag("StordValAcct")]
    public StoredValueAccount2? StoredValueAccount { get; init; }

    /// <summary>
    /// Receipt to print after a balance inquiry.
    /// </summary>
    [IsoId("_DT68G3HDEe2TbaNWBpRZpQ")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public PaymentReceipt5? Receipt { get; init; }
}
