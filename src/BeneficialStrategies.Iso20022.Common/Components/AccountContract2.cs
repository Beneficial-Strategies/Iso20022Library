// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies target dates dates related to account opening and closing.
/// </summary>
[IsoId("_UkZWQtp-Ed-ak6NoX_4Aeg_-1896166238")]
[DisplayName("Account Contract")]
public partial record AccountContract2
{
    #nullable enable
    
    /// <summary>
    /// Date on which the account and related basic services are expected to be operational for the account owner.
    /// </summary>
    [IsoId("_UkZWQ9p-Ed-ak6NoX_4Aeg_-2010005304")]
    [DisplayName("Target Go Live Date")]
    [IsoXmlTag("TrgtGoLiveDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TargetGoLiveDate { get; init; } 
    
    /// <summary>
    /// Date on which the account and related services are expected to cease to be operational for the account owner.
    /// </summary>
    [IsoId("_UkZWRNp-Ed-ak6NoX_4Aeg_1287889639")]
    [DisplayName("Target Closing Date")]
    [IsoXmlTag("TrgtClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TargetClosingDate { get; init; } 
    
    /// <summary>
    /// Indicator that the account opening/maintenance/closing process needs to be treated urgently, that is, sooner than the terms established by the service level agreed between the account holder customer and the account servicing institution.
    /// </summary>
    [IsoId("_UkZWRdp-Ed-ak6NoX_4Aeg_-1703327420")]
    [DisplayName("Urgency Flag")]
    [IsoXmlTag("UrgcyFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? UrgencyFlag { get; init; } 
    
    
    #nullable disable
    
}
