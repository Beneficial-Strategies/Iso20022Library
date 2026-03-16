// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Remittance Location8.
/// </summary>
[IsoId("_0IULUTEyEe6g-ffJsqGiSA")]
[DisplayName("Remittance Location8")]
public partial record RemittanceLocation8
{
    #nullable enable

    /// <summary>
    /// Remittance Identification.
    /// </summary>
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    public IsoMax35Text? RemittanceIdentification { get; init; } 

    /// <summary>
    /// Remittance Location Details.
    /// </summary>
    [DisplayName("Remittance Location Details")]
    [IsoXmlTag("RmtLctnDtls")]
    public ValueList<RemittanceLocationData2> RemittanceLocationDetails { get; init; } = [];

    
    #nullable disable
    
}
