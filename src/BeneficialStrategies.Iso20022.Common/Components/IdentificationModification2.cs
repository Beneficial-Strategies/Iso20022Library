// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the identification data that is advised to be modified.
/// </summary>
[IsoId("_tpZdUlkyEeGeoaLUQk__nA_-1518673695")]
[DisplayName("Identification Modification")]
public partial record IdentificationModification2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the party and account identification information group within the message.
    /// </summary>
    [IsoId("_tpZdU1kyEeGeoaLUQk__nA_1779221248")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Provides party and/or account identification information as given in the original message.
    /// </summary>
    [IsoId("_tpjOUFkyEeGeoaLUQk__nA_-393042130")]
    [DisplayName("Original Party And Account Identification")]
    [IsoXmlTag("OrgnlPtyAndAcctId")]
    public IdentificationInformation2? OriginalPartyAndAccountIdentification { get; init; } 
    
    /// <summary>
    /// Provides updated party and/or account identification information.
    /// </summary>
    [IsoId("_tpjOUVkyEeGeoaLUQk__nA_-849780288")]
    [DisplayName("Updated Party And Account Identification")]
    [IsoXmlTag("UpdtdPtyAndAcctId")]
    public required IdentificationInformation2 UpdatedPartyAndAccountIdentification { get; init; } 
    
    /// <summary>
    /// Additional information, in free text form, to complement the modification information.
    /// </summary>
    [IsoId("_tpjOUlkyEeGeoaLUQk__nA_-452820477")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
