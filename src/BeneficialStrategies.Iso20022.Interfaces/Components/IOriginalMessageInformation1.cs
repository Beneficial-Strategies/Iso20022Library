// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification, as assigned by the original instructing party, to unambiguously identify the message.
/// </summary>
[IsoId("_PgJZVdp-Ed-ak6NoX_4Aeg_1129957204")]
public interface IOriginalMessageInformation1 : IIsoComponent
{
    /// <summary>
    /// Point to point reference, as assigned by the original initiating party, to unambiguously identify the original mandate request message.
    /// </summary>
    [IsoId("_PgJZVtp-Ed-ak6NoX_4Aeg_1215844112")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    IsoMax35Text MessageIdentification { get; }

    /// <summary>
    /// Specifies the message name identifier to which the message refers.
    /// </summary>
    [IsoId("_PgJZV9p-Ed-ak6NoX_4Aeg_1215844113")]
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    IsoMax35Text MessageNameIdentification { get; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_PgTKQNp-Ed-ak6NoX_4Aeg_1215844134")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    IsoISODateTime? CreationDateTime { get; }
}
