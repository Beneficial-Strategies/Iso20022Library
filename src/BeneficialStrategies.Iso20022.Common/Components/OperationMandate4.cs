// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information specifying the mandate.
/// </summary>
[IsoId("_Cj9vd249EeiU9cctagi5ow")]
[DisplayName("Operation Mandate")]
public partial record OperationMandate4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the mandate.
    /// </summary>
    [IsoId("_CtgF8W49EeiU9cctagi5ow")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Channel for which the operation mandate is valid. If ApplicableChannel equals Fax, this means that a bank operation instruction sent by fax will be processed according to the mandates exchanged in this message.
    /// </summary>
    [IsoId("_CtgF8249EeiU9cctagi5ow")]
    [DisplayName("Applicable Channel")]
    [IsoXmlTag("AplblChanl")]
    public ValueList<Channel2Choice_> ApplicableChannel { get; init; } = new ValueList<Channel2Choice_>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _CtgF8249EeiU9cctagi5ow
    
    /// <summary>
    /// Number of required and necessary signatures by the mandate.
    /// </summary>
    [IsoId("_CtgF9W49EeiU9cctagi5ow")]
    [DisplayName("Required Signature Number")]
    [IsoXmlTag("ReqrdSgntrNb")]
    [IsoSimpleType(IsoSimpleType.Max15PlusSignedNumericText)]
    public required IsoMax15PlusSignedNumericText RequiredSignatureNumber { get; init; } 
    
    /// <summary>
    /// Indicator whether a certain order of signatures has to be respected or not.
    /// </summary>
    [IsoId("_CtgF9249EeiU9cctagi5ow")]
    [DisplayName("Signature Order Indicator")]
    [IsoXmlTag("SgntrOrdrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator SignatureOrderIndicator { get; init; } 
    
    /// <summary>
    /// Holder of the mandate.
    /// </summary>
    [IsoId("_CtgF-W49EeiU9cctagi5ow")]
    [DisplayName("Mandate Holder")]
    [IsoXmlTag("MndtHldr")]
    public PartyAndAuthorisation4? MandateHolder { get; init; } 
    
    /// <summary>
    /// Bank operation allowed by a mandate.
    /// </summary>
    [IsoId("_CtgF-249EeiU9cctagi5ow")]
    [DisplayName("Bank Operation")]
    [IsoXmlTag("BkOpr")]
    public ValueList<BankTransactionCodeStructure4> BankOperation { get; init; } = new ValueList<BankTransactionCodeStructure4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _CtgF-249EeiU9cctagi5ow
    
    /// <summary>
    /// Specifies the date when the mandate becomes valid.
    /// </summary>
    [IsoId("_CtgF_W49EeiU9cctagi5ow")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; } 
    
    /// <summary>
    /// Specifies the date when the mandate stops to be valid.
    /// </summary>
    [IsoId("_CtgF_249EeiU9cctagi5ow")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; } 
    
    
    #nullable disable
    
}
