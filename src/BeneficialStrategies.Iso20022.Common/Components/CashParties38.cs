// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment processes required to transfer cash from the debtor to the creditor.
/// </summary>
[IsoId("_6svUPffVEeiNZp_PtLohLw")]
[DisplayName("Cash Parties")]
public record CashParties38
{
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("_6svUQffVEeiNZp_PtLohLw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentificationAndAccount177? Debtor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("_6svUW_fVEeiNZp_PtLohLw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public PartyIdentificationAndAccount178? DebtorAgent { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_6svUdffVEeiNZp_PtLohLw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentificationAndAccount177? Creditor { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_6svUj_fVEeiNZp_PtLohLw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public PartyIdentificationAndAccount178? CreditorAgent { get; init; }

    /// <summary>
    /// Financial institution through which the transaction must pass to reach the account with institution.
    /// </summary>
    [IsoId("_6svUqffVEeiNZp_PtLohLw")]
    [DisplayName("Intermediary")]
    [IsoXmlTag("Intrmy")]
    public PartyIdentificationAndAccount178? Intermediary { get; init; }
}
