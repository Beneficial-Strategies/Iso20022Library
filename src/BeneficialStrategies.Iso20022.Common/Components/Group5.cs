// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group5.
/// </summary>
[IsoId("_ymArETEyEe6g-ffJsqGiSA")]
[DisplayName("Group5")]
public partial record Group5
{
    #nullable enable

    /// <summary>
    /// Group Identification.
    /// </summary>
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    public required IsoMax4AlphaNumericText GroupIdentification { get; init; } 

    /// <summary>
    /// Modification Code.
    /// </summary>
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; } 

    /// <summary>
    /// Party.
    /// </summary>
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public ValueList<PartyAndCertificate7> Party { get; init; } = [];

    
    #nullable disable
    
}
