// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_Pb058Np-Ed-ak6NoX_4Aeg_-1884789497")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount6
{
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_Pb058dp-Ed-ak6NoX_4Aeg_-1934636240")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification25 PartyIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of an account held by Financing Requestor to First Agent. This account is requested to be used for crediting the amount financed, as a result of the financing process.
    /// </summary>
    [IsoId("_Pb058tp-Ed-ak6NoX_4Aeg_1132049413")]
    [DisplayName("Credit Account")]
    [IsoXmlTag("CdtAcct")]
    public CashAccount7? CreditAccount { get; init; }

    /// <summary>
    /// Unambiguous identification of an internal bank account used by First Agent to manage the line of credit granted to Financing Requestor. This account is requested to be used for managing the financing process.
    /// </summary>
    [IsoId("_Pb0589p-Ed-ak6NoX_4Aeg_1145898985")]
    [DisplayName("Financing Account")]
    [IsoXmlTag("FincgAcct")]
    public CashAccount7? FinancingAccount { get; init; }
}
