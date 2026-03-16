// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Debtor Activation Amendment6.
/// </summary>
[IsoId("_wjziwTEyEe6g-ffJsqGiSA")]
[DisplayName("Debtor Activation Amendment6")]
public partial record DebtorActivationAmendment6
{
    #nullable enable

    /// <summary>
    /// Debtor Activation.
    /// </summary>
    [DisplayName("Debtor Activation")]
    [IsoXmlTag("DbtrActvtn")]
    public DebtorActivation6? DebtorActivation { get; init; } 

    /// <summary>
    /// Electronic Invoice Data.
    /// </summary>
    [DisplayName("Electronic Invoice Data")]
    [IsoXmlTag("ElctrncInvcData")]
    public ElectronicInvoice1? ElectronicInvoiceData { get; init; } 

    
    #nullable disable
    
}
