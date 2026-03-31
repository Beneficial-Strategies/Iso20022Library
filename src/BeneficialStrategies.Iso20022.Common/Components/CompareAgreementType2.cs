// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether the infromation on the type of the master agrement is matching or not.
/// </summary>
[IsoId("_7a2ZUa5hEeuo-IflVgGqiA")]
[DisplayName("Compare Agreement Type")]
public record CompareAgreementType2
{
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [IsoId("_7p5h8a5hEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val1")]
    public AgreementType1Choice_? Value1 { get; init; }

    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [IsoId("_7p5h865hEeuo-IflVgGqiA")]
    [DisplayName("Value")]
    [IsoXmlTag("Val2")]
    public AgreementType1Choice_? Value2 { get; init; }
}
