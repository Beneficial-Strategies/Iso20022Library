// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the event that require an action from one of the parties to the trade transaction.
/// </summary>
[IsoId("_RJy3otp-Ed-ak6NoX_4Aeg_-149569640")]
[DisplayName("Pending Activity")]
public partial record PendingActivity1
{
    #nullable enable
    
    /// <summary>
    /// Code which specifies the next course of action that the receiver of the message must take.
    /// </summary>
    [IsoId("_RJy3o9p-Ed-ak6NoX_4Aeg_-86769311")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required Action1Code Type { get; init; } 
    
    /// <summary>
    /// Further information on the course of action that the receiver of the message must take.
    /// </summary>
    [IsoId("_RJy3pNp-Ed-ak6NoX_4Aeg_-420755965")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Description { get; init; } 
    
    
    #nullable disable
    
}
