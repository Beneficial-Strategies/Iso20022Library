// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the error
/// </summary>
[IsoId("_9egA0dBHEeuFC7k3JpyaRA")]
[DisplayName("Error Details")]
public partial record ErrorDetails2
{
    #nullable enable
    
    /// <summary>
    /// Code list containing a code that identifies the error condition.
    /// </summary>
    [IsoId("_9jUPYdBHEeuFC7k3JpyaRA")]
    [DisplayName("Message Error Type")]
    [IsoXmlTag("MsgErrTp")]
    public required MessageError1Code MessageErrorType { get; init; } 
    
    /// <summary>
    /// Other message error type defined at national or private level.
    /// </summary>
    [IsoId("_9jUPY9BHEeuFC7k3JpyaRA")]
    [DisplayName("Other Message Error Type")]
    [IsoXmlTag("OthrMsgErrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherMessageErrorType { get; init; } 
    
    /// <summary>
    /// Code that identifies the specific error found.
    /// </summary>
    [IsoId("_9jUPZdBHEeuFC7k3JpyaRA")]
    [DisplayName("Error Code")]
    [IsoXmlTag("ErrCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ErrorCode { get; init; } 
    
    /// <summary>
    /// Description of the error found.
    /// </summary>
    [IsoId("_9jUPZ9BHEeuFC7k3JpyaRA")]
    [DisplayName("Error Description")]
    [IsoXmlTag("ErrDesc")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? ErrorDescription { get; init; } 
    
    /// <summary>
    /// Data element in error. 
    /// </summary>
    [IsoId("_9jUPadBHEeuFC7k3JpyaRA")]
    [DisplayName("Data Element In Error")]
    [IsoXmlTag("DataElmtInErr")]
    [IsoSimpleType(IsoSimpleType.Max4000Text)]
    [StringLength(maximumLength: 4000 ,MinimumLength = 1)]
    public IsoMax4000Text? DataElementInError { get; init; } 
    
    
    #nullable disable
    
}
