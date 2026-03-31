// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information required for the settlement the transaction.
/// </summary>
[IsoId("_QIhn5tp-Ed-ak6NoX_4Aeg_-1159158700")]
[DisplayName("Settlement Information")]
public record SettlementInformation2
{
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_QIhn59p-Ed-ak6NoX_4Aeg_-1159158674")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod2Code SettlementMethod { get; init; }

    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_QIhn6Np-Ed-ak6NoX_4Aeg_-1159158622")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount7? SettlementAccount { get; init; }

    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_QIhn6dp-Ed-ak6NoX_4Aeg_-1159158579")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification1Choice_? ClearingSystem { get; init; }
}
