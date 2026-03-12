// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the clearing system identification.
/// </summary>
[IsoId("_XaEtifWfEemtd4wHZYvFUQ")]
[DisplayName("Tracker Clearing System Identification")]
public partial record TrackerClearingSystemIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Infrastructure through which the payment instruction is processed, as published in an external clearing system identification code list.
    /// </summary>
    [IsoId("_XaFUkfWfEemtd4wHZYvFUQ")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required ExternalCashClearingSystem1Code Code { get; init; } 
    
    
    #nullable disable
    
}
