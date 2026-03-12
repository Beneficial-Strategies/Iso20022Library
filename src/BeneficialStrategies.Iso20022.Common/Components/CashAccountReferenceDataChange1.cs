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
[IsoId("_k2l3k-5NEeCisYr99QEiWA_603606073")]
[DisplayName("Cash Account Reference Data Change")]
public partial record CashAccountReferenceDataChange1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the cash account for which the changes are listed in the advice.
    /// </summary>
    [IsoId("_k2l3lO5NEeCisYr99QEiWA_70533986")]
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public required CashAccount24 CashAccountIdentification { get; init; } 
    
    /// <summary>
    /// Name of the element, as specified in the short tag name for the field in the message.
    /// </summary>
    [IsoId("_k2vBgO5NEeCisYr99QEiWA_489767007")]
    [DisplayName("Field Name")]
    [IsoXmlTag("FldNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text FieldName { get; init; } 
    
    /// <summary>
    /// Value of the related field before the change was applied.
    /// </summary>
    [IsoId("_k2vBge5NEeCisYr99QEiWA_-1504377699")]
    [DisplayName("Old Field Value")]
    [IsoXmlTag("OdFldVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text OldFieldValue { get; init; } 
    
    /// <summary>
    /// Value of the related field after the change was applied.
    /// </summary>
    [IsoId("_k2vBgu5NEeCisYr99QEiWA_-158428075")]
    [DisplayName("New Field Value")]
    [IsoXmlTag("NewFldVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text NewFieldValue { get; init; } 
    
    /// <summary>
    /// Specifies the timestamp of the operation.
    /// </summary>
    [IsoId("_k2vBg-5NEeCisYr99QEiWA_-393466280")]
    [DisplayName("Operation Time Stamp")]
    [IsoXmlTag("OprTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime OperationTimeStamp { get; init; } 
    
    
    #nullable disable
    
}
