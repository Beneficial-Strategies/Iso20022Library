// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
[IsoId("_G7CU8GaxEeWZev0W8F756g")]
[DisplayName("Linkages")]
public record Linkages41
{
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction - for information only.
    /// </summary>
    [IsoId("_QiFHsGaxEeWZev0W8F756g")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition9Choice_? ProcessingPosition { get; init; }

    /// <summary>
    /// Unambiguous identification of a securities settlement transaction as known by the account owner (or instructing party acting on its behalf).
    /// </summary>
    [IsoId("_XLIfUGaxEeWZev0W8F756g")]
    [DisplayName("Securities Settlement Transaction Identification")]
    [IsoXmlTag("SctiesSttlmTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SecuritiesSettlementTransactionIdentification { get; init; }
}
