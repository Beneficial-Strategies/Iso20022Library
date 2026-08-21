// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit details of one particular limit set by the member and managed by the transaction administrator.
/// </summary>
[IsoId("_4Oc6QTEyEe6g-ffJsqGiSA")]
[DisplayName("Limit Structure6")]
public record LimitStructure6
{
    /// <summary>
    /// Amount of money of the limit, expressed in an eligible currency.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount2Choice_ Amount { get; init; }

    /// <summary>
    /// Specifies if a limit is a debit limit or a credit limit.
    /// </summary>
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public CreditDebitCode? CreditDebitIndicator { get; init; }

    /// <summary>
    /// Identification of the default limit.
    /// </summary>
    [DisplayName("Limit Identification")]
    [IsoXmlTag("LmtId")]
    public required LimitIdentification8 LimitIdentification { get; init; }

    /// <summary>
    /// Date and time at which the limit becomes effective.
    /// </summary>
    [DisplayName("Start Date Time")]
    [IsoXmlTag("StartDtTm")]
    public DateAndDateTime2Choice_? StartDateTime { get; init; }
}
