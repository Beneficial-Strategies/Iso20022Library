// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Service29.
/// </summary>
[IsoId("_Vf8eQee-Ee-AuZFZ3aE3Cg")]
[DisplayName("ATM Service29")]
public partial record ATMService29
{
    #nullable enable

    /// <summary>
    /// Limits.
    /// </summary>
    [DisplayName("Limits")]
    [IsoXmlTag("Lmts")]
    public ValueList<ATMTransactionAmounts6> Limits { get; init; } = [];

    /// <summary>
    /// Service Type.
    /// </summary>
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType13Code ServiceType { get; init; } 

    /// <summary>
    /// Service Variant.
    /// </summary>
    [DisplayName("Service Variant")]
    [IsoXmlTag("SvcVarnt")]
    public ValueList<ATMService18> ServiceVariant { get; init; } = [];

    
    #nullable disable
    
}
