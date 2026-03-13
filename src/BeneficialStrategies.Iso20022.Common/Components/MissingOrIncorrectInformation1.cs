// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the reason for the UnableToApply. It can be missing and/or incorrect information.
/// </summary>
[IsoId("_T-ZtStp-Ed-ak6NoX_4Aeg_-1840697394")]
[DisplayName("Missing Or Incorrect Information")]
public partial record MissingOrIncorrectInformation1
{
    #nullable enable
    
    /// <summary>
    /// Indicates the missing information.
    /// </summary>
    [IsoId("_T-ZtS9p-Ed-ak6NoX_4Aeg_-1840697101")]
    [DisplayName("Missing Information")]
    [IsoXmlTag("MssngInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public SimpleValueList<UnableToApplyMissingInfo1Code> MissingInformation { get; init; } = [];
    
    /// <summary>
    /// Indicates the incorrect information.
    /// </summary>
    [IsoId("_T-ZtTNp-Ed-ak6NoX_4Aeg_-1839776740")]
    [DisplayName("Incorrect Information")]
    [IsoXmlTag("IncrrctInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public SimpleValueList<UnableToApplyIncorrectInfo2Code> IncorrectInformation { get; init; } = [];
    
    
    #nullable disable
    
}
