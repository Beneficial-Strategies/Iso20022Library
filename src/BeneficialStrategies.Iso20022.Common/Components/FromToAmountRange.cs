// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of amount values.
/// </summary>
[IsoId("_PVH1A9p-Ed-ak6NoX_4Aeg_-149353967")]
[DisplayName("From To Amount Range")]
public partial record FromToAmountRange
{
    #nullable enable
    
    /// <summary>
    /// Lower boundary of a range of amount values.
    /// </summary>
    [IsoId("_PVH1BNp-Ed-ak6NoX_4Aeg_-1340961900")]
    [DisplayName("From Amount")]
    [IsoXmlTag("FrAmt")]
    public required AmountRangeBoundary1 FromAmount { get; init; } 
    
    /// <summary>
    /// Upper boundary of a range of amount values.
    /// </summary>
    [IsoId("_PVH1Bdp-Ed-ak6NoX_4Aeg_-1328032668")]
    [DisplayName("To Amount")]
    [IsoXmlTag("ToAmt")]
    public required AmountRangeBoundary1 ToAmount { get; init; } 
    
    
    #nullable disable
    
}
