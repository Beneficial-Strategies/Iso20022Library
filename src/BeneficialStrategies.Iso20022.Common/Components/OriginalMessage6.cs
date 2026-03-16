// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Original Message6.
/// </summary>
[IsoId("_46ZaWTEyEe6g-ffJsqGiSA")]
[DisplayName("Original Message6")]
public partial record OriginalMessage6
{
    #nullable enable

    /// <summary>
    /// Original Creation Date Time.
    /// </summary>
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 

    /// <summary>
    /// Original Message Identification.
    /// </summary>
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 

    /// <summary>
    /// Original Message Name Identification.
    /// </summary>
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 

    /// <summary>
    /// Original Package Identification.
    /// </summary>
    [DisplayName("Original Package Identification")]
    [IsoXmlTag("OrgnlPackgId")]
    public IsoMax35Text? OriginalPackageIdentification { get; init; } 

    /// <summary>
    /// Original Record Identification.
    /// </summary>
    [DisplayName("Original Record Identification")]
    [IsoXmlTag("OrgnlRcrdId")]
    public required IsoMax35Text OriginalRecordIdentification { get; init; } 

    /// <summary>
    /// Original Sender.
    /// </summary>
    [DisplayName("Original Sender")]
    [IsoXmlTag("OrgnlSndr")]
    public Party50Choice_? OriginalSender { get; init; } 

    
    #nullable disable
    
}
