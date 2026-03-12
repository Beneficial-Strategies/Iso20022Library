// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed account holdings information report for a corporate action event.
/// </summary>
[IsoId("_Jrnu74r8EeaNFeVGetd6Xw")]
[DisplayName("Corporate Action Event And Balance")]
public partial record CorporateActionEventAndBalance11
{
    #nullable enable
    
    /// <summary>
    /// Provides general information related to a corporate action event.
    /// </summary>
    [IsoId("_KDRZ04r8EeaNFeVGetd6Xw")]
    [DisplayName("General Information")]
    [IsoXmlTag("GnlInf")]
    public required EventInformation9 GeneralInformation { get; init; } 
    
    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_KDRZ1Yr8EeaNFeVGetd6Xw")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required SecurityIdentification19 UnderlyingSecurity { get; init; } 
    
    /// <summary>
    /// Provides information about the balance related to a corporate action.
    /// </summary>
    [IsoId("_KDRZ3Yr8EeaNFeVGetd6Xw")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CorporateActionBalanceDetails30? Balance { get; init; } 
    
    /// <summary>
    /// Provides additional information related to the event and the balance of the corporate action.
    /// </summary>
    [IsoId("_KDRZ5Yr8EeaNFeVGetd6Xw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
