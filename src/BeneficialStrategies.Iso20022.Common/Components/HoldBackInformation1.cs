// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about hold back.
/// </summary>
[IsoId("_SdsIetp-Ed-ak6NoX_4Aeg_1440751245")]
[DisplayName("Hold Back Information")]
public partial record HoldBackInformation1
{
    #nullable enable
    
    /// <summary>
    /// Value of the redemption amount subject to hold back.
    /// </summary>
    [IsoId("_SdsIe9p-Ed-ak6NoX_4Aeg_1820317430")]
    [DisplayName("Hold Back Amount")]
    [IsoXmlTag("HldBckAmt")]
    public ActiveCurrencyAndAmount? HoldBackAmount { get; init; } 
    
    /// <summary>
    /// Date on which the hold back amount is to be released.
    /// </summary>
    [IsoId("_SdsIfNp-Ed-ak6NoX_4Aeg_-2030432920")]
    [DisplayName("Hold Back Release Date")]
    [IsoXmlTag("HldBckRlsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? HoldBackReleaseDate { get; init; } 
    
    
    #nullable disable
    
}
