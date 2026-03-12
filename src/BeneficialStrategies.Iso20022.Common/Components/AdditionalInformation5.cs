// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional information related to the message.
/// </summary>
[IsoId("_Qoao5dp-Ed-ak6NoX_4Aeg_478592239")]
[DisplayName("Additional Information")]
public partial record AdditionalInformation5
{
    #nullable enable
    
    /// <summary>
    /// Contains additional information related to the message.
    /// </summary>
    [IsoId("_Qoao5tp-Ed-ak6NoX_4Aeg_1159536818")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    public SimpleValueList<System.String> Information { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Qoao5tp-Ed-ak6NoX_4Aeg_1159536818
    
    
    #nullable disable
    
}
