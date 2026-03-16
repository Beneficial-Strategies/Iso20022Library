// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Clearing Member Fee1.
/// </summary>
[IsoId("_zbMlUF7rEe-hdLDytyjg_A")]
[DisplayName("Clearing Member Fee1")]
public partial record ClearingMemberFee1
{
    #nullable enable

    /// <summary>
    /// Clearing Fee.
    /// </summary>
    [DisplayName("Clearing Fee")]
    [IsoXmlTag("ClrFee")]
    public required ActiveCurrencyAndAmount ClearingFee { get; init; } 

    /// <summary>
    /// Clearing Member Identification.
    /// </summary>
    [DisplayName("Clearing Member Identification")]
    [IsoXmlTag("ClrMmbId")]
    public required PartyIdentification118Choice_ ClearingMemberIdentification { get; init; } 

    
    #nullable disable
    
}
