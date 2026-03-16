// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines proprietary reason to reject a transaction.
/// </summary>
[IsoId("_Ny9Dz5lPEee-Zps0fZQaFQ")]
[DisplayName("Proprietary Status Justification")]
public record ProprietaryStatusJustification1
{
    /// <summary>
    /// Defines the reason why the Target2 SSP system has rejected the transaction.
    /// </summary>
    [IsoId("_N7lbUZlPEee-Zps0fZQaFQ")]
    [DisplayName("Proprietary Status Reason")]
    [IsoXmlTag("PrtryStsRsn")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4AlphaNumericText ProprietaryStatusReason { get; init; }

    /// <summary>
    /// Provides detailed information about the reason why the Target2 SSP system has rejected the transaction.
    /// </summary>
    [IsoId("_N7lbU5lPEee-Zps0fZQaFQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public required IsoMax256Text Reason { get; init; }
}
