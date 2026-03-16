// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business Application Header8.
/// </summary>
[IsoId("_2aMHUTEyEe6g-ffJsqGiSA")]
[DisplayName("Business Application Header8")]
public partial record BusinessApplicationHeader8
{
    #nullable enable

    /// <summary>
    /// Business Message Identifier.
    /// </summary>
    [DisplayName("Business Message Identifier")]
    [IsoXmlTag("BizMsgIdr")]
    public required IsoMax35Text BusinessMessageIdentifier { get; init; } 

    /// <summary>
    /// Business Processing Date.
    /// </summary>
    [DisplayName("Business Processing Date")]
    [IsoXmlTag("BizPrcgDt")]
    public IsoISODateTime? BusinessProcessingDate { get; init; } 

    /// <summary>
    /// Business Service.
    /// </summary>
    [DisplayName("Business Service")]
    [IsoXmlTag("BizSvc")]
    public IsoMax35Text? BusinessService { get; init; } 

    /// <summary>
    /// Character Set.
    /// </summary>
    [DisplayName("Character Set")]
    [IsoXmlTag("CharSet")]
    public UnicodeChartsCode? CharacterSet { get; init; } 

    /// <summary>
    /// Copy Duplicate.
    /// </summary>
    [DisplayName("Copy Duplicate")]
    [IsoXmlTag("CpyDplct")]
    public CopyDuplicate1Code? CopyDuplicate { get; init; } 

    /// <summary>
    /// Creation Date.
    /// </summary>
    [DisplayName("Creation Date")]
    [IsoXmlTag("CreDt")]
    public required IsoISODateTime CreationDate { get; init; } 

    /// <summary>
    /// From.
    /// </summary>
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public required Party51Choice_ From { get; init; } 

    /// <summary>
    /// Market Practice.
    /// </summary>
    [DisplayName("Market Practice")]
    [IsoXmlTag("MktPrctc")]
    public ImplementationSpecification1? MarketPractice { get; init; } 

    /// <summary>
    /// Message Definition Identifier.
    /// </summary>
    [DisplayName("Message Definition Identifier")]
    [IsoXmlTag("MsgDefIdr")]
    public required IsoMax35Text MessageDefinitionIdentifier { get; init; } 

    /// <summary>
    /// Possible Duplicate.
    /// </summary>
    [DisplayName("Possible Duplicate")]
    [IsoXmlTag("PssblDplct")]
    public IsoYesNoIndicator? PossibleDuplicate { get; init; } 

    /// <summary>
    /// Priority.
    /// </summary>
    [DisplayName("Priority")]
    [IsoXmlTag("Prty")]
    public BusinessMessagePriorityCode? Priority { get; init; } 

    /// <summary>
    /// Signature.
    /// </summary>
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public SignatureEnvelope? Signature { get; init; } 

    /// <summary>
    /// To.
    /// </summary>
    [DisplayName("To")]
    [IsoXmlTag("To")]
    public required Party51Choice_ To { get; init; } 

    
    #nullable disable
    
}
