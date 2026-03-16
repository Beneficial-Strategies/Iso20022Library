// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Further information on the return reason of the transaction.
/// </summary>
[IsoId("_TPTyptp-Ed-ak6NoX_4Aeg_335311982")]
[DisplayName("Return Reason Information")]
public record ReturnReasonInformation5
{
    /// <summary>
    /// Bank transaction code included in the original entry for the transaction.
    /// </summary>
    [IsoId("_TPTyp9p-Ed-ak6NoX_4Aeg_140703755")]
    [DisplayName("Original Bank Transaction Code")]
    [IsoXmlTag("OrgnlBkTxCd")]
    public BankTransactionCodeStructure1? OriginalBankTransactionCode { get; init; }

    /// <summary>
    /// Party issuing the return.
    /// </summary>
    [IsoId("_TPTyqNp-Ed-ak6NoX_4Aeg_335312086")]
    [DisplayName("Return Originator")]
    [IsoXmlTag("RtrOrgtr")]
    public PartyIdentification8? ReturnOriginator { get; init; }

    /// <summary>
    /// Specifies the reason for the return.
    /// </summary>
    [IsoId("_TPdjoNp-Ed-ak6NoX_4Aeg_335312138")]
    [DisplayName("Return Reason")]
    [IsoXmlTag("RtrRsn")]
    public ReturnReason1Choice_? ReturnReason { get; init; }

    /// <summary>
    /// Further details on the return reason.
    /// </summary>
    [IsoId("_TPdjodp-Ed-ak6NoX_4Aeg_335312008")]
    [DisplayName("Additional Return Reason Information")]
    [IsoXmlTag("AddtlRtrRsnInf")]
    public SimpleValueList<IsoMax105Text> AdditionalReturnReasonInformation { get; init; } = [];
}
