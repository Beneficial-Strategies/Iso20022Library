// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor Diagnostic Response10.
/// </summary>
[IsoId("_vkoZ8ZN4Ee6im_tx3Nh8SA")]
[DisplayName("Acceptor Diagnostic Response10")]
public partial record AcceptorDiagnosticResponse10
{
    #nullable enable

    /// <summary>
    /// Acquirer Available.
    /// </summary>
    [DisplayName("Acquirer Available")]
    [IsoXmlTag("AcqrrAvlbl")]
    public IsoTrueFalseIndicator? AcquirerAvailable { get; init; } 

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment80 Environment { get; init; } 

    /// <summary>
    /// TMS Trigger.
    /// </summary>
    [DisplayName("TMS Trigger")]
    [IsoXmlTag("TMSTrggr")]
    public TMSTrigger1? TMSTrigger { get; init; } 

    
    #nullable disable
    
}
