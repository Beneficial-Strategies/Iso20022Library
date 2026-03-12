// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products (Investment Funds).
/// </summary>
[IsoId("_QP-6ydp-Ed-ak6NoX_4Aeg_-172074213")]
[DisplayName("Intermediary")]
public partial record Intermediary2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of the intermediary.
    /// </summary>
    [IsoId("_QP-6ytp-Ed-ak6NoX_4Aeg_-285913279")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification10Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Function performed by the intermediary (investment funds).
    /// </summary>
    [IsoId("_QP-6y9p-Ed-ak6NoX_4Aeg_588690940")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public Role2Choice_? Role { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_QP-6zNp-Ed-ak6NoX_4Aeg_-408381413")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account9? Account { get; init; } 
    
    
    #nullable disable
    
}
