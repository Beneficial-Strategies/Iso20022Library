// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDateAndType1"/>
[IsoId("_wbqsoDHxEe6BxvG014AZzQ")]
[DisplayName("Date And Type1")]
public partial record DateAndType1
{
    /// <inheritdoc cref="IDateAndType1.Date"/>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public required IsoISODate Date { get; init; }

    /// <inheritdoc cref="IDateAndType1.Type"/>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required DateType2Choice_ Type { get; init; }
}
