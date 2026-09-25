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
[IsoId("_dFQq5OTXEfC01pKpYIyMTA")]
[DisplayName("Cash Account Reference Data Change3")]
public record CashAccountReferenceDataChange3
{
    /// <summary>
    /// Identifies the cash account for which the changes are listed in the advice.
    /// </summary>
    [IsoId("_dHp3keTXEfC01pKpYIyMTA")]
    [DisplayName("Cash Account Identification")]
    [IsoXmlTag("CshAcctId")]
    public required CashAccount40 CashAccountIdentification { get; init; }

    /// <summary>
    /// Name of the element, as specified in the short tag name for the field in the message.
    /// </summary>
    [IsoId("_dHp3k-TXEfC01pKpYIyMTA")]
    [DisplayName("Field Name")]
    [IsoXmlTag("FldNm")]
    public required IsoMax35Text FieldName { get; init; }

    /// <summary>
    /// Value of the related field before the change was applied.
    /// </summary>
    [IsoId("_dHp3leTXEfC01pKpYIyMTA")]
    [DisplayName("Old Field Value")]
    [IsoXmlTag("OdFldVal")]
    public required IsoMax350Text OldFieldValue { get; init; }

    /// <summary>
    /// Value of the related field after the change was applied.
    /// </summary>
    [IsoId("_dHp3l-TXEfC01pKpYIyMTA")]
    [DisplayName("New Field Value")]
    [IsoXmlTag("NewFldVal")]
    public required IsoMax350Text NewFieldValue { get; init; }

    /// <summary>
    /// Specifies the timestamp of the operation.
    /// </summary>
    [IsoId("_dHp3meTXEfC01pKpYIyMTA")]
    [DisplayName("Operation Time Stamp")]
    [IsoXmlTag("OprTmStmp")]
    public required IsoISODateTime OperationTimeStamp { get; init; }
}
