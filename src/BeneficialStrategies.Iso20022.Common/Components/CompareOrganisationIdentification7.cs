// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for an organisation identification.
/// </summary>
[IsoId("_dyRNwcgyEeuGrNSsxk3B0A")]
[DisplayName("Compare Organisation Identification")]
public record CompareOrganisationIdentification7
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_d0HA08gyEeuGrNSsxk3B0A")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public PartyIdentification236Choice_? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_d0HA1cgyEeuGrNSsxk3B0A")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public PartyIdentification236Choice_? Value2 { get; init; }
}
