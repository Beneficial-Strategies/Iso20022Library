// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parent Cash Account5.
/// </summary>
[IsoId("_xiEh6zEyEe6g-ffJsqGiSA")]
[DisplayName("Parent Cash Account5")]
public record ParentCashAccount5
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required CashAccount40 Identification { get; init; }

    /// <summary>
    /// Level.
    /// </summary>
    [DisplayName("Level")]
    [IsoXmlTag("Lvl")]
    public AccountLevel1Code? Level { get; init; }

    /// <summary>
    /// Servicer.
    /// </summary>
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public BranchAndFinancialInstitutionIdentification8? Servicer { get; init; }
}
