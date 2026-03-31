// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides transaction type and identification information.
/// </summary>
[IsoId("_UkGbVNp-Ed-ak6NoX_4Aeg_-140305171")]
[DisplayName("Settlement Type And Identification")]
public record SettlementTypeAndIdentification3
{
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_UkGbVdp-Ed-ak6NoX_4Aeg_-140305154")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_UkGbVtp-Ed-ak6NoX_4Aeg_-140305119")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_UkGbV9p-Ed-ak6NoX_4Aeg_-140305101")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }
}
