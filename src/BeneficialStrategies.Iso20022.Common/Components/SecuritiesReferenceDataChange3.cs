// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the comparison between the currently established baseline elements and the proposed ones.
/// </summary>
[IsoId("_QSGgFZJKEeuAlLVx8pyt3w")]
[DisplayName("Securities Reference Data Change")]
public partial record SecuritiesReferenceDataChange3
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument for which the changes are listed in the advice.
    /// </summary>
    [IsoId("_QUEO8ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Name of the element, as specified in the short tag name for the field in the message.
    /// </summary>
    [IsoId("_QUEO85JKEeuAlLVx8pyt3w")]
    [DisplayName("Field Name")]
    [IsoXmlTag("FldNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text FieldName { get; init; } 
    
    /// <summary>
    /// Value of the related field before the change was applied.
    /// </summary>
    [IsoId("_QUEO9ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Old Field Value")]
    [IsoXmlTag("OdFldVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text OldFieldValue { get; init; } 
    
    /// <summary>
    /// Value of the related field after the change was applied.
    /// </summary>
    [IsoId("_QUEO95JKEeuAlLVx8pyt3w")]
    [DisplayName("New Field Value")]
    [IsoXmlTag("NewFldVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text NewFieldValue { get; init; } 
    
    /// <summary>
    /// Specifies the timestamp of the operation.
    /// </summary>
    [IsoId("_QUEO-ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Operation Time Stamp")]
    [IsoXmlTag("OprTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime OperationTimeStamp { get; init; } 
    
    
    #nullable disable
    
}
