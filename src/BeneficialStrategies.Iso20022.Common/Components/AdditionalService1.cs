// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional functions or services to be performed in conjunction with the transaction.
/// </summary>
[IsoId("_tv_4oJ8NEei6TYPuA7AYQg")]
[DisplayName("Additional Service")]
public record AdditionalService1
{
    /// <summary>
    /// Type of additional service applied to the transaction.
    /// </summary>
    [IsoId("_tv_4o58NEei6TYPuA7AYQg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required AdditionalServiceType1Code Type { get; init; }

    /// <summary>
    /// Other additional service applied to the transaction.
    /// </summary>
    [IsoId("_tv_4op8NEei6TYPuA7AYQg")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }
}
