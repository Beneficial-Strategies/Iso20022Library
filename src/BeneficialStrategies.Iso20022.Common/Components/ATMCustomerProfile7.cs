// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Customer Profile7.
/// </summary>
[IsoId("_QhXrcee-Ee-AuZFZ3aE3Cg")]
[DisplayName("ATM Customer Profile7")]
public partial record ATMCustomerProfile7
{
    #nullable enable

    /// <summary>
    /// Allowed Services.
    /// </summary>
    [DisplayName("Allowed Services")]
    [IsoXmlTag("AllwdSvcs")]
    public ValueList<ATMService28> AllowedServices { get; init; } = [];

    /// <summary>
    /// Customer Identification.
    /// </summary>
    [DisplayName("Customer Identification")]
    [IsoXmlTag("CstmrId")]
    public IsoMax35Text? CustomerIdentification { get; init; } 

    /// <summary>
    /// Profile Description.
    /// </summary>
    [DisplayName("Profile Description")]
    [IsoXmlTag("PrflDesc")]
    public IsoMax70Text? ProfileDescription { get; init; } 

    /// <summary>
    /// Profile Reference.
    /// </summary>
    [DisplayName("Profile Reference")]
    [IsoXmlTag("PrflRef")]
    public IsoMax35Text? ProfileReference { get; init; } 

    
    #nullable disable
    
}
