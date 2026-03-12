// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of account owner and identifiers.
/// </summary>
[IsoId("_UHyvQCDvEeav65mEytrgaA")]
[DisplayName("Account Owner And Identification List")]
public partial record AccountOwnerAndIdentificationList1
{
    #nullable enable
    
    /// <summary>
    /// List of the identifier pairs.
    /// </summary>
    [IsoId("_qhLMECDvEeav65mEytrgaA")]
    [DisplayName("List")]
    [IsoXmlTag("List")]
    public ValueList<AccountOwnerAndIdentification1> List { get; init; } = new ValueList<AccountOwnerAndIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _qhLMECDvEeav65mEytrgaA
    
    
    #nullable disable
    
}
