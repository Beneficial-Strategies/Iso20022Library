// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
/// </summary>
[IsoId("_18UEUXsvEeSTS7uHCe8FPQ")]
[DisplayName("Transaction Identifier")]
public record TransactionIdentifier2
{
    /// <summary>
    /// Date of the reconciliation.
    /// It correspond to the ISO 8583 field number 28 for the versions 1993 and 2003.
    /// </summary>
    [IsoId("_Ai_vIHswEeSTS7uHCe8FPQ")]
    [DisplayName("Reconciliation Date")]
    [IsoXmlTag("RcncltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ReconciliationDate { get; init; }

    /// <summary>
    /// Identification of the reconciliation.
    /// It correspond to the ISO 8583 field number 29 for the versions 1993 and 2003.
    /// </summary>
    [IsoId("_Hn8YkHswEeSTS7uHCe8FPQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ReconciliationIdentification { get; init; }
}
