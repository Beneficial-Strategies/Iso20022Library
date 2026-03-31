// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Debtor Activation Amendment6.
/// </summary>
[IsoId("_wjziwTEyEe6g-ffJsqGiSA")]
[DisplayName("Debtor Activation Amendment6")]
public record DebtorActivationAmendment6
{
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
}
