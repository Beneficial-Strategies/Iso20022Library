// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services relating to financial products to investors, eg, advice on products and placement of orders for the investment fund.
/// </summary>
[IsoId("_QNckI9p-Ed-ak6NoX_4Aeg_-1292309592")]
[DisplayName("Intermediary")]
public partial record Intermediary7
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_QNckJNp-Ed-ak6NoX_4Aeg_-1292309129")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification2Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_QNckJdp-Ed-ak6NoX_4Aeg_-1292308939")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account2? Account { get; init; } 
    
    
    #nullable disable
    
}
