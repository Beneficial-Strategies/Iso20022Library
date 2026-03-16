// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_fGU5MRrdEeOVR9VN6fAMUg")]
[DisplayName("Charges Details")]
public record ChargesDetails3
{
    /// <summary>
    /// Specifies the type of charges as a code or free text.
    /// </summary>
    [IsoId("_Hl77kBreEeOVR9VN6fAMUg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargesType1Choice_ Type { get; init; }

    /// <summary>
    /// Specifies if it is a fixed amount or a percentage.
    /// </summary>
    [IsoId("_UqVmABreEeOVR9VN6fAMUg")]
    [DisplayName("Amount Or Percentage")]
    [IsoXmlTag("AmtOrPctg")]
    public required AmountOrPercentage2Choice_ AmountOrPercentage { get; init; }
}
