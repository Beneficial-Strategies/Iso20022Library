// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the comparison between the currently established baseline elements and the proposed ones.
/// </summary>
[IsoId("_QPfxleGBEeWCAvUNsZ5u6g")]
[DisplayName("Securities Account Reference Data Change")]
public record SecuritiesAccountReferenceDataChange2
{
    /// <summary>
    /// Identifies the securities account for which the changes are listed in the advice.
    /// </summary>
    [IsoId("_QaW9weGBEeWCAvUNsZ5u6g")]
    [DisplayName("Securities Account Identification")]
    [IsoXmlTag("SctiesAcctId")]
    public required SecuritiesAccount19 SecuritiesAccountIdentification { get; init; }

    /// <summary>
    /// Name of the element, as specified in the short tag name for the field in the message.
    /// </summary>
    [IsoId("_QaW9w-GBEeWCAvUNsZ5u6g")]
    [DisplayName("Field Name")]
    [IsoXmlTag("FldNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text FieldName { get; init; }

    /// <summary>
    /// Value of the related field before the change was applied.
    /// </summary>
    [IsoId("_QaW9xeGBEeWCAvUNsZ5u6g")]
    [DisplayName("Old Field Value")]
    [IsoXmlTag("OdFldVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text OldFieldValue { get; init; }

    /// <summary>
    /// Value of the related field after the change was applied.
    /// </summary>
    [IsoId("_QaW9x-GBEeWCAvUNsZ5u6g")]
    [DisplayName("New Field Value")]
    [IsoXmlTag("NewFldVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text NewFieldValue { get; init; }

    /// <summary>
    /// Specifies the timestamp of the operation.
    /// </summary>
    [IsoId("_QaW9yeGBEeWCAvUNsZ5u6g")]
    [DisplayName("Operation Time Stamp")]
    [IsoXmlTag("OprTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime OperationTimeStamp { get; init; }
}
