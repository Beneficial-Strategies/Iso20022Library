// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the information to comply with.
/// </summary>
[IsoId("_r9krMWOKEeW4z96Yfj3Wng")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative32
{
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or Sophisticated Investor Letter (SIL) to be provided.
    /// </summary>
    [IsoId("_sRzOwWOKEeW4z96Yfj3Wng")]
    [DisplayName("Information To Comply With")]
    [IsoXmlTag("InfToCmplyWth")]
    public SimpleValueList<IsoMax350Text> InformationToComplyWith { get; init; } = [];

    /// <summary>
    /// Provides additional information on the delivery details of the outturned (derived) securities. This narrative is only to be used in case the securities are not eligible at the agent/custodian, and may not be used for settlement instructions.
    /// </summary>
    [IsoId("_sR8_xmOKEeW4z96Yfj3Wng")]
    [DisplayName("Delivery Details")]
    [IsoXmlTag("DlvryDtls")]
    public SimpleValueList<IsoMax350Text> DeliveryDetails { get; init; } = [];

    /// <summary>
    /// Provides additional details pertaining to foreign exchange instructions.
    /// </summary>
    [IsoId("_sR8_zmOKEeW4z96Yfj3Wng")]
    [DisplayName("Foreign Exchange Instructions Additional Information")]
    [IsoXmlTag("FXInstrsAddtlInf")]
    public SimpleValueList<IsoMax350Text> ForeignExchangeInstructionsAdditionalInformation { get; init; } =
        [];

    /// <summary>
    /// Provides additional details pertaining to the corporate action instruction.
    /// </summary>
    [IsoId("_sR8_3mOKEeW4z96Yfj3Wng")]
    [DisplayName("Instruction Additional Information")]
    [IsoXmlTag("InstrAddtlInf")]
    public SimpleValueList<IsoMax350Text> InstructionAdditionalInformation { get; init; } = [];
}
