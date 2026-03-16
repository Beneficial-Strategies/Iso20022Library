// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Command16.
/// </summary>
[IsoId("_2Uu_kZ9oEe-nbM0aSPcoiQ")]
[DisplayName("ATM Command16")]
public partial record ATMCommand16
{
    #nullable enable

    /// <summary>
    /// Command Identification.
    /// </summary>
    [DisplayName("Command Identification")]
    [IsoXmlTag("CmdId")]
    public ATMCommandIdentification1? CommandIdentification { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ATMCommand7Code Type { get; init; } 

    
    #nullable disable
    
}
