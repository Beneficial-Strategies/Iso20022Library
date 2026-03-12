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
[IsoId("_Dkb2pwVSEeqjd8n6wD9JVw")]
[DisplayName("Corporate Action Event And Balance")]
public partial record CorporateActionEventAndBalance18
{
    #nullable enable
    
    /// <summary>
    /// Provides general information related to a corporate action event.
    /// </summary>
    [IsoId("_Dkb2qwVSEeqjd8n6wD9JVw")]
    [DisplayName("General Information")]
    [IsoXmlTag("GnlInf")]
    public required EventInformation14 GeneralInformation { get; init; } 
    
    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_Dkb2rQVSEeqjd8n6wD9JVw")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required SecurityIdentification20 UnderlyingSecurity { get; init; } 
    
    /// <summary>
    /// Provides information about the balance related to a corporate action.
    /// </summary>
    [IsoId("_Dkb2tQVSEeqjd8n6wD9JVw")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CorporateActionBalance42? Balance { get; init; } 
    
    /// <summary>
    /// Provides additional information related to the event and the balance of the corporate action.
    /// </summary>
    [IsoId("_Dkb2vQVSEeqjd8n6wD9JVw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
