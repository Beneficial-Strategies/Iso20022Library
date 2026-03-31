// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the original transaction.
/// </summary>
[IsoId("_M7ozIXGVEe2TbaNWBpRZpQ")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction126
{
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_NJXtIXGVEe2TbaNWBpRZpQ")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_NJXtI3GVEe2TbaNWBpRZpQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_NJYUMXGVEe2TbaNWBpRZpQ")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification32 POIIdentification { get; init; }

    /// <summary>
    /// Link to a previous currency conversion.
    /// </summary>
    [IsoId("_NJYUM3GVEe2TbaNWBpRZpQ")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion28? CurrencyConversion { get; init; }
}
