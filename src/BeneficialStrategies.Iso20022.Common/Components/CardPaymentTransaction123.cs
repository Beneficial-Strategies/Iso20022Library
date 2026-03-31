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
[IsoId("_w2FEAVE5EeyApZmLzm74zA")]
[DisplayName("Card Payment Transaction")]
public record CardPaymentTransaction123
{
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_w8RLkVE5EeyApZmLzm74zA")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// Unique identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_w8RLk1E5EeyApZmLzm74zA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_w8RLlVE5EeyApZmLzm74zA")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification32 POIIdentification { get; init; }

    /// <summary>
    /// Link to a previous currency conversion.
    /// </summary>
    [IsoId("_w8RLl1E5EeyApZmLzm74zA")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion25? CurrencyConversion { get; init; }
}
