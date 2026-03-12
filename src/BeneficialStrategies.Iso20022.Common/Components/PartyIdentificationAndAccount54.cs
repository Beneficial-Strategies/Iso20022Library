// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about identification and account of the party.
/// </summary>
[IsoId("_uKdvgfL-Ed-3lpUMQaXLjQ")]
[DisplayName("Party Identification And Account")]
public partial record PartyIdentificationAndAccount54
{
    #nullable enable
    
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [IsoId("_uKnggfL-Ed-3lpUMQaXLjQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification42Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_uKngg_L-Ed-3lpUMQaXLjQ")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    
    /// <summary>
    /// Reference meaningful to the party identified.
    /// </summary>
    [IsoId("_uKnghfL-Ed-3lpUMQaXLjQ")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_uKngh_L-Ed-3lpUMQaXLjQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_uKngifL-Ed-3lpUMQaXLjQ")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification2? AlternateIdentification { get; init; } 
    
    
    #nullable disable
    
}
