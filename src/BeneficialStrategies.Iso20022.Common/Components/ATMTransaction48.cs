// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction48.
/// </summary>
[IsoId("_KLMHgaEoEe-MRKYsaX6JDg")]
[DisplayName("ATM Transaction48")]
public record ATMTransaction48
{
    /// <summary>
    /// Account Information.
    /// </summary>
    [DisplayName("Account Information")]
    [IsoXmlTag("AcctInf")]
    public ValueList<CardAccount18> AccountInformation { get; init; } = [];

    /// <summary>
    /// Account Statement Data.
    /// </summary>
    [DisplayName("Account Statement Data")]
    [IsoXmlTag("AcctStmtData")]
    public ValueList<ATMAccountStatement3> AccountStatementData { get; init; } = [];

    /// <summary>
    /// Action.
    /// </summary>
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public ValueList<Action7> Action { get; init; } = [];

    /// <summary>
    /// Authorisation Result.
    /// </summary>
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public AuthorisationResult20? AuthorisationResult { get; init; }

    /// <summary>
    /// Command.
    /// </summary>
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ValueList<ATMCommand7> Command { get; init; } = [];

    /// <summary>
    /// Currency Conversion.
    /// </summary>
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion33? CurrencyConversion { get; init; }

    /// <summary>
    /// Currency Exchange.
    /// </summary>
    [DisplayName("Currency Exchange")]
    [IsoXmlTag("CcyXchg")]
    public CurrencyConversion5? CurrencyExchange { get; init; }

    /// <summary>
    /// Customer Service Profile.
    /// </summary>
    [DisplayName("Customer Service Profile")]
    [IsoXmlTag("CstmrSvcPrfl")]
    public ATMCustomerProfile7? CustomerServiceProfile { get; init; }

    /// <summary>
    /// ICC Related Data.
    /// </summary>
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    public IsoMax10000Binary? ICCRelatedData { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier3 TransactionIdentification { get; init; }

    /// <summary>
    /// Transaction Response.
    /// </summary>
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType12 TransactionResponse { get; init; }
}
