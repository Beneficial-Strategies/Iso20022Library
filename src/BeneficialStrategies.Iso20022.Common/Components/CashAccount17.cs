// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash account.
/// </summary>
[IsoId("_SQINk9p-Ed-ak6NoX_4Aeg_-1116675143")]
[DisplayName("Cash Account")]
public record CashAccount17
{
    /// <summary>
    /// Identification of the cash account.
    /// </summary>
    [IsoId("_SQINlNp-Ed-ak6NoX_4Aeg_-521005462")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required CashAccountIdentification1Choice_ AccountIdentification { get; init; }

    /// <summary>
    /// Currency of the payment.
    /// </summary>
    [IsoId("_SQINldp-Ed-ak6NoX_4Aeg_1500837063")]
    [DisplayName("Payment Currency")]
    [IsoXmlTag("PmtCcy")]
    public required ActiveCurrencyCode PaymentCurrency { get; init; }

    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_SQINltp-Ed-ak6NoX_4Aeg_781895629")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; }

    /// <summary>
    /// Identification of the cash correspondent back.
    /// </summary>
    [IsoId("_SQINl9p-Ed-ak6NoX_4Aeg_-1046488323")]
    [DisplayName("Correspondent Bank Identification")]
    [IsoXmlTag("CrspdtBkId")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    public required IsoBICIdentifier CorrespondentBankIdentification { get; init; }
}
