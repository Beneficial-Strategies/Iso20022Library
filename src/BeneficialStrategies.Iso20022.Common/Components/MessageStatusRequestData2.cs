// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Message TransactionStatus Request message.
/// </summary>
[IsoId("_QFd_4Q03EeqUVL7sB4m7NA")]
[DisplayName("Message Status Request Data")]
public partial record MessageStatusRequestData2
{
    #nullable enable
    
    /// <summary>
    /// Transaction identification.
    /// </summary>
    [IsoId("_QRlwUQ03EeqUVL7sB4m7NA")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ExchangeIdentification { get; init; } 
    
    /// <summary>
    /// Initiating Party information.
    /// </summary>
    [IsoId("_QRlwUw03EeqUVL7sB4m7NA")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification177 InitiatingParty { get; init; } 
    
    /// <summary>
    /// Request to reprint the POI receipt(s).
    /// </summary>
    [IsoId("_QRlwVQ03EeqUVL7sB4m7NA")]
    [DisplayName("Receipt Reprint Flag")]
    [IsoXmlTag("RctRprntFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReceiptReprintFlag { get; init; } 
    
    /// <summary>
    /// Customer or Cashier Receipt.
    /// </summary>
    [IsoId("_QRlwVw03EeqUVL7sB4m7NA")]
    [DisplayName("Document Qualifier")]
    [IsoXmlTag("DocQlfr")]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<DocumentType7Code> DocumentQualifier { get; init; } = new SimpleValueList<DocumentType7Code>(){};
    
    
    #nullable disable
    
}
