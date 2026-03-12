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
[IsoId("_nVT1sN6eEeiwsev40qZGEQ")]
[DisplayName("Message Status Request Data")]
public partial record MessageStatusRequestData1
{
    #nullable enable
    
    /// <summary>
    /// Transaction identification.
    /// </summary>
    [IsoId("_ClxWMN6fEeiwsev40qZGEQ")]
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ExchangeIdentification { get; init; } 
    
    /// <summary>
    /// Initiating Party information.
    /// </summary>
    [IsoId("_FRvNMN6fEeiwsev40qZGEQ")]
    [DisplayName("Initiating Party")]
    [IsoXmlTag("InitgPty")]
    public required GenericIdentification171 InitiatingParty { get; init; } 
    
    /// <summary>
    /// Request to reprint the POI receipt(s).
    /// </summary>
    [IsoId("_IA_BsN6fEeiwsev40qZGEQ")]
    [DisplayName("Receipt Reprint Flag")]
    [IsoXmlTag("RctRprntFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ReceiptReprintFlag { get; init; } 
    
    /// <summary>
    /// Customer or Cashier Receipt.
    /// </summary>
    [IsoId("_LQlKMN6fEeiwsev40qZGEQ")]
    [DisplayName("Document Qualifier")]
    [IsoXmlTag("DocQlfr")]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<DocumentType7Code> DocumentQualifier { get; init; } = new SimpleValueList<DocumentType7Code>(){};
    
    
    #nullable disable
    
}
