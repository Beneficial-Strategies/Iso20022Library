// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies additional parameters to the message or transaction.
/// </summary>
[IsoId("_SoVUUTxFEeW5v6FXICU4Ew")]
[DisplayName("Additional Parameters")]
public record AdditionalParameters24
{
    /// <summary>
    /// Specifies whether there exists a pre-confirmation.
    /// </summary>
    [IsoId("_TJNMxTxFEeW5v6FXICU4Ew")]
    [DisplayName("Pre Confirmation")]
    [IsoXmlTag("PreConf")]
    public PreConfirmation1Code? PreConfirmation { get; init; }

    /// <summary>
    /// Specifies partial settlement information.
    /// </summary>
    [IsoId("_TJNMzTxFEeW5v6FXICU4Ew")]
    [DisplayName("Partial Settlement")]
    [IsoXmlTag("PrtlSttlm")]
    public PartialSettlement2Code? PartialSettlement { get; init; }

    /// <summary>
    /// Identification of the confirmation previously sent to confirm the partial settlement of a transaction.
    /// </summary>
    [IsoId("_TJNM1TxFEeW5v6FXICU4Ew")]
    [DisplayName("Previous Partial Confirmation Identification")]
    [IsoXmlTag("PrvsPrtlConfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PreviousPartialConfirmationIdentification { get; init; }
}
