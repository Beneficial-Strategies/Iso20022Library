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
[IsoId("_dsRUYb-CEeW_u_CSZtGM1g")]
[DisplayName("Linkages")]
public record Linkages50
{
    /// <summary>
    /// When the transaction is to be executed relative to a linked transaction - for information only.
    /// </summary>
    [IsoId("_eEEwYb-CEeW_u_CSZtGM1g")]
    [DisplayName("Processing Position")]
    [IsoXmlTag("PrcgPos")]
    public ProcessingPosition23Choice_? ProcessingPosition { get; init; }

    /// <summary>
    /// Unambiguous identification of a securities settlement transaction as known by the account owner (or instructing party acting on its behalf).
    /// </summary>
    [IsoId("_eEEwY7-CEeW_u_CSZtGM1g")]
    [DisplayName("Securities Settlement Transaction Identification")]
    [IsoXmlTag("SctiesSttlmTxId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text SecuritiesSettlementTransactionIdentification { get; init; }
}
