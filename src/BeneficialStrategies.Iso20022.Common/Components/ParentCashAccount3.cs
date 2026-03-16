// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the cash account elements of a parent cash account.
/// </summary>
[IsoId("_Gy28a24-EeiU9cctagi5ow")]
[DisplayName("Parent Cash Account")]
public record ParentCashAccount3
{
    /// <summary>
    /// Defines the parent account level within a hierarchy.
    /// </summary>
    [IsoId("_G-eWcW4-EeiU9cctagi5ow")]
    [DisplayName("Level")]
    [IsoXmlTag("Lvl")]
    public AccountLevel1Code? Level { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for the parent account between the parent account owner and the parent account servicer.
    /// </summary>
    [IsoId("_G-eWc24-EeiU9cctagi5ow")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required CashAccount38 Identification { get; init; }

    /// <summary>
    /// Financial institution in which the parent account resides.
    /// </summary>
    [IsoId("_G-eWdW4-EeiU9cctagi5ow")]
    [DisplayName("Servicer")]
    [IsoXmlTag("Svcr")]
    public BranchAndFinancialInstitutionIdentification6? Servicer { get; init; }
}
