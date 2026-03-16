// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specific trade account for recording debits and credits to general accounting, cost accounting or budget accounting.
/// </summary>
[IsoId("_SmtBUAEcEeCQm6a_G2yO_w_1620788765")]
[DisplayName("Accounting Account")]
public record AccountingAccount1
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_SmtBUQEcEeCQm6a_G2yO_w_-842530775")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Template describing the mask of the structure for the format of the accounting account identifier for example AABBBBCC where AA represents the country, BBBB the service classification, CC the sales area.
    /// </summary>
    [IsoId("_SmtBUgEcEeCQm6a_G2yO_w_1034412203")]
    [DisplayName("Cost Reference Pattern")]
    [IsoXmlTag("CostRefPttrn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CostReferencePattern { get; init; }
}
