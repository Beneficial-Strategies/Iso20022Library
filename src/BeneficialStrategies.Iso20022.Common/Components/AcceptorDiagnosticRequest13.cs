// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor Diagnostic Request13.
/// </summary>
[IsoId("_-3eBcaEwEe-MRKYsaX6JDg")]
[DisplayName("Acceptor Diagnostic Request13")]
public partial record AcceptorDiagnosticRequest13
{
    #nullable enable

    /// <summary>
    /// Acquirer Availability Requested.
    /// </summary>
    [DisplayName("Acquirer Availability Requested")]
    [IsoXmlTag("AcqrrAvlbtyReqd")]
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; } 

    /// <summary>
    /// Environment.
    /// </summary>
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment81 Environment { get; init; } 

    
    #nullable disable
    
}
