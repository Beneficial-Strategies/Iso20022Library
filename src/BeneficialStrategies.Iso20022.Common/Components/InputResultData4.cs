// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to an Input request.
/// </summary>
[IsoId("_F-SBQVFEEeyApZmLzm74zA")]
[DisplayName("Input Result Data")]
public partial record InputResultData4
{
    #nullable enable
    
    /// <summary>
    /// Type of processed input.
    /// </summary>
    [IsoId("_GEkPcVFEEeyApZmLzm74zA")]
    [DisplayName("Input Command")]
    [IsoXmlTag("InptCmd")]
    public required InputCommand1Code InputCommand { get; init; } 
    
    /// <summary>
    /// Flag of notification of card to be entered in the POI card reader.
    /// </summary>
    [IsoId("_GEkPc1FEEeyApZmLzm74zA")]
    [DisplayName("Confirmed Flag")]
    [IsoXmlTag("ConfdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ConfirmedFlag { get; init; } 
    
    /// <summary>
    /// The number of the function key which is typed by the Customer on the POI system or the Cashier on the Sale System.
    /// </summary>
    [IsoId("_GEkPdVFEEeyApZmLzm74zA")]
    [DisplayName("Function Key")]
    [IsoXmlTag("FctnKey")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? FunctionKey { get; init; } 
    
    /// <summary>
    /// The input text and data given by the POI or the Sale System.
    /// </summary>
    [IsoId("_GEkPd1FEEeyApZmLzm74zA")]
    [DisplayName("Input Message")]
    [IsoXmlTag("InptMsg")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    public IsoMax20000Text? InputMessage { get; init; } 
    
    /// <summary>
    /// An enciphered password typed by the Customer on the POI system or the Cashier on the Sale system.
    /// </summary>
    [IsoId("_GEkPeVFEEeyApZmLzm74zA")]
    [DisplayName("Password")]
    [IsoXmlTag("Pwd")]
    public ContentInformationType30? Password { get; init; } 
    
    /// <summary>
    /// Numeric value of a handwritten signature.
    /// </summary>
    [IsoId("_GEk2gVFEEeyApZmLzm74zA")]
    [DisplayName("Image Captured Signature")]
    [IsoXmlTag("ImgCaptrdSgntr")]
    public CapturedSignature1? ImageCapturedSignature { get; init; } 
    
    
    #nullable disable
    
}
