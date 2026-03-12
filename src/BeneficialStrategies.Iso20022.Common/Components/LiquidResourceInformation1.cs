// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the liquid resources.
/// </summary>
[IsoId("_nNjvsESrEemM8-DVOYzdVQ")]
[DisplayName("Liquid Resource Information")]
public partial record LiquidResourceInformation1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the facility provider.
    /// </summary>
    [IsoId("_xUlDAESrEemM8-DVOYzdVQ")]
    [DisplayName("Counter Party Identification")]
    [IsoXmlTag("CntrPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CounterPartyIdentification { get; init; } 
    
    /// <summary>
    /// Amount of liquid resources available to meet liquid requirements.
    /// </summary>
    [IsoId("_2i3s0ESrEemM8-DVOYzdVQ")]
    [DisplayName("Liquid Resource Value")]
    [IsoXmlTag("LqdRsrcVal")]
    public required AmountAndDirection102 LiquidResourceValue { get; init; } 
    
    /// <summary>
    /// The market value of the financial instruments being used to secure the facility.
    /// </summary>
    [IsoId("_FuOcsESsEemM8-DVOYzdVQ")]
    [DisplayName("Market Value")]
    [IsoXmlTag("MktVal")]
    public AmountAndDirection102? MarketValue { get; init; } 
    
    /// <summary>
    /// Indicates whether the facility is secured or not.
    /// </summary>
    [IsoId("_VvbPcESsEemM8-DVOYzdVQ")]
    [DisplayName("Secured")]
    [IsoXmlTag("Scrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Secured { get; init; } 
    
    /// <summary>
    /// Indicates whether the financial instruments are encumbered or not. This includes where financial instruments must be pledged to secure liquidity facilities.
    /// </summary>
    [IsoId("_bFJ-AESsEemM8-DVOYzdVQ")]
    [DisplayName("Asset Encumbered")]
    [IsoXmlTag("AsstNcmbrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator AssetEncumbered { get; init; } 
    
    /// <summary>
    /// Indicates whether the available liquid resource counts towards the liquid requirements in the scenario or not.
    /// </summary>
    [IsoId("_gVPXkESsEemM8-DVOYzdVQ")]
    [DisplayName("Qualifying Resource")]
    [IsoXmlTag("QlfygRsrc")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator QualifyingResource { get; init; } 
    
    /// <summary>
    /// Indicates the reliance on third party entities to settle payment obligations for the CCP or a clearing member. The article 32(4) of Commission Delegated Regulated 153/2013 includes a full list of third party entities which a CCP may have a liquidity exposure to. If the value is true, the portion of the liquid resource which is assumed to be unavailable due to a dependency on third party entities. If the value is false, the portion of the liquid resource which is assumed to be available as no dependency on third party entities.
    /// </summary>
    [IsoId("_lPmYwESsEemM8-DVOYzdVQ")]
    [DisplayName("Agency Arrangements")]
    [IsoXmlTag("AgcyArrgmnts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator AgencyArrangements { get; init; } 
    
    
    #nullable disable
    
}
