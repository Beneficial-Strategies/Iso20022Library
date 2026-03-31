// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the transaction in an unambiguous way.
/// </summary>
[IsoId("_TFsqdwEcEeCQm6a_G2yO_w_-629860519")]
[DisplayName("Transaction Identifier")]
public record TransactionIdentifier1
{
    /// <summary>
    /// Local date and time of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_TFsqeAEcEeCQm6a_G2yO_w_-1727684501")]
    [DisplayName("Transaction Date Time")]
    [IsoXmlTag("TxDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TransactionDateTime { get; init; }

    /// <summary>
    /// Identification of the transaction that has to be unique for a time period.
    /// </summary>
    [IsoId("_TFsqeQEcEeCQm6a_G2yO_w_-1113655904")]
    [DisplayName("Transaction Reference")]
    [IsoXmlTag("TxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionReference { get; init; }
}
