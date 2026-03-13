// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the securities movements.
/// </summary>
[IsoId("_UIYIptp-Ed-ak6NoX_4Aeg_1464286927")]
[DisplayName("Corporate Action Securities Movement")]
public partial record CorporateActionSecuritiesMovement1
{
    #nullable enable
    
    /// <summary>
    /// Date and time of the posting.
    /// </summary>
    [IsoId("_UIYIp9p-Ed-ak6NoX_4Aeg_1643449957")]
    [DisplayName("Posting Date Time")]
    [IsoXmlTag("PstngDtTm")]
    public DateAndDateTimeChoice_? PostingDateTime { get; init; } 
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UIYIqNp-Ed-ak6NoX_4Aeg_1698861252")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification7 SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Quantity of securities that is posted.
    /// </summary>
    [IsoId("_UIYIqdp-Ed-ak6NoX_4Aeg_1987000696")]
    [DisplayName("Posting Quantity")]
    [IsoXmlTag("PstngQty")]
    public required UnitOrFaceAmount1Choice_ PostingQuantity { get; init; } 
    
    /// <summary>
    /// Provides information about the account which is debited/credited.
    /// </summary>
    [IsoId("_UIh5oNp-Ed-ak6NoX_4Aeg_-1695911196")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<SecuritiesAccount8> AccountDetails { get; init; } = [];
    
    
    #nullable disable
    
}
