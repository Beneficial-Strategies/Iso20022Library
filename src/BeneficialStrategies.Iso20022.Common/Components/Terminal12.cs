// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Terminal performing a card transaction.
/// </summary>
[IsoId("_Dx2WYWP1EfCX7uJiAWHfoQ")]
[DisplayName("Terminal12")]
public record Terminal12
{
    [IsoId("_Dx2WYWP1EfCX7uJiAWHfoQ-id")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax16Text Identification { get; init; }

    [IsoId("_Dx2WYWP1EfCX7uJiAWHfoQ-pvdt")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_Dx2WYWP1EfCX7uJiAWHfoQ-ntdt")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
