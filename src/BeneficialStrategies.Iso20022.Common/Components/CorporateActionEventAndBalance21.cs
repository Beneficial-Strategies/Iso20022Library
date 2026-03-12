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
[IsoId("_pUC9AR9QEeuFz_FaCzCLgQ")]
[DisplayName("Corporate Action Event And Balance")]
public partial record CorporateActionEventAndBalance21
{
    #nullable enable
    
    /// <summary>
    /// Provides general information related to a corporate action event.
    /// </summary>
    [IsoId("_pUC9BR9QEeuFz_FaCzCLgQ")]
    [DisplayName("General Information")]
    [IsoXmlTag("GnlInf")]
    public required EventInformation16 GeneralInformation { get; init; } 
    
    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    [IsoId("_pUC9Bx9QEeuFz_FaCzCLgQ")]
    [DisplayName("Underlying Security")]
    [IsoXmlTag("UndrlygScty")]
    public required SecurityIdentification20 UnderlyingSecurity { get; init; } 
    
    /// <summary>
    /// Provides information about the balance related to a corporate action.
    /// </summary>
    [IsoId("_pUC9Dx9QEeuFz_FaCzCLgQ")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CorporateActionBalance45? Balance { get; init; } 
    
    /// <summary>
    /// Provides additional information related to the event and the balance of the corporate action.
    /// </summary>
    [IsoId("_pUC9Fx9QEeuFz_FaCzCLgQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
