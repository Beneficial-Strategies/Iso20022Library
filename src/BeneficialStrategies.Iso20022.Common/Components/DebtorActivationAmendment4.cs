// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the amendment of the information that serves as a basis to debit an account.
/// </summary>
[IsoId("_UQacM-H7Eeqbls7Gk4-ckA")]
[DisplayName("Debtor Activation Amendment")]
public partial record DebtorActivationAmendment4
{
    #nullable enable
    
    /// <summary>
    /// Specific attributes provided the debtor, as requested by the creditor, for the activation request.
    /// </summary>
    [IsoId("_URmu4eH7Eeqbls7Gk4-ckA")]
    [DisplayName("Debtor Activation")]
    [IsoXmlTag("DbtrActvtn")]
    public DebtorActivation4? DebtorActivation { get; init; } 
    
    /// <summary>
    /// Further data related to the electronic invoice (e-invoice).
    /// </summary>
    [IsoId("_URmu4-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Electronic Invoice Data")]
    [IsoXmlTag("ElctrncInvcData")]
    public ElectronicInvoice1? ElectronicInvoiceData { get; init; } 
    
    
    #nullable disable
    
}
