// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Context26.
/// </summary>
[IsoId("_YF3T4aB-Ee-mUP79iiSLcw")]
[DisplayName("ATM Context26")]
public partial record ATMContext26
{
    #nullable enable

    /// <summary>
    /// Service.
    /// </summary>
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public required ATMService25 Service { get; init; } 

    /// <summary>
    /// Session Reference.
    /// </summary>
    [DisplayName("Session Reference")]
    [IsoXmlTag("SsnRef")]
    public IsoMax35Text? SessionReference { get; init; } 

    
    #nullable disable
    
}
