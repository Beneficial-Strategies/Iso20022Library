// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identifier of the group of transactions as assigned by the original instructing party.
/// </summary>
[IsoId("_PhVsEtp-Ed-ak6NoX_4Aeg_453123857")]
public interface IOriginalGroupInformation4 : IIsoComponent
{
    /// <summary>
    /// Point to point reference assigned by the original instructing party to unambiguously identify the original group of individual transactions.
    /// </summary>
    [IsoId("_PhVsE9p-Ed-ak6NoX_4Aeg_453123876")]
    [DisplayName("Original Message Identification")]
    [IsoXmlTag("OrgnlMsgId")]
    IsoMax35Text OriginalMessageIdentification { get; }

    /// <summary>
    /// Specifies the original message name identifier to which the message refers, eg, pacs.003.001.01 or MT103.
    /// </summary>
    [IsoId("_PhVsFNp-Ed-ak6NoX_4Aeg_453123952")]
    [DisplayName("Original Message Name Identification")]
    [IsoXmlTag("OrgnlMsgNmId")]
    IsoMax35Text OriginalMessageNameIdentification { get; }

    /// <summary>
    /// Original date and time at which the message was created.
    /// </summary>
    [IsoId("_PhVsFdp-Ed-ak6NoX_4Aeg_-1547891782")]
    [DisplayName("Original Creation Date Time")]
    [IsoXmlTag("OrgnlCreDtTm")]
    IsoISODateTime? OriginalCreationDateTime { get; }

    /// <summary>
    /// Detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_PhVsFtp-Ed-ak6NoX_4Aeg_-1239359353")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    IEnumerable<ICancellationReasonInformation1> CancellationReasonInformation { get; }
}
