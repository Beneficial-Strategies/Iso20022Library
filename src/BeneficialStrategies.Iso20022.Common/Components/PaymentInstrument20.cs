// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Instrument20.
/// </summary>
[IsoId("_BrShIX_5Ee-5A_neRtHpSQ")]
[DisplayName("Payment Instrument20")]
public partial record PaymentInstrument20
{
    #nullable enable

    /// <summary>
    /// Credit Transfer Details.
    /// </summary>
    [DisplayName("Credit Transfer Details")]
    [IsoXmlTag("CdtTrfDtls")]
    public CreditTransfer11? CreditTransferDetails { get; init; } 

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; } 

    
    #nullable disable
    
}
