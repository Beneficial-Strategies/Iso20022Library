// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the notification of the termination of an undertaking.
/// </summary>
[IsoId("_97ufHHltEeG7BsjMvd1mEw_-864278160")]
[DisplayName("Undertaking Termination Notice")]
public partial record UndertakingTerminationNotice1
{
    #nullable enable
    
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_974QEHltEeG7BsjMvd1mEw_1656167276")]
    [DisplayName("Undertaking Identification")]
    [IsoXmlTag("UdrtkgId")]
    public required Undertaking9 UndertakingIdentification { get; init; } 
    
    /// <summary>
    /// Details related to the termination of the undertaking.
    /// </summary>
    [IsoId("_974QEXltEeG7BsjMvd1mEw_1055156994")]
    [DisplayName("Termination Details")]
    [IsoXmlTag("TermntnDtls")]
    public required UndertakingTermination3 TerminationDetails { get; init; } 
    
    /// <summary>
    /// Document or template enclosed in the termination notification.
    /// </summary>
    [IsoId("_974QE3ltEeG7BsjMvd1mEw_1574400589")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public Document9? EnclosedFile { get; init; } 
    
    /// <summary>
    /// Additional information related to the notification.
    /// </summary>
    [IsoId("_974QFHltEeG7BsjMvd1mEw_1143129336")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
