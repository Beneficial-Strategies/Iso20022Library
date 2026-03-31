// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual charges records included in the message.
/// </summary>
[IsoId("_mjXnuSkYEeuBrrgCSpsocg")]
[DisplayName("Group Header")]
public record GroupHeader102
{
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    [IsoId("_mjXnvCkYEeuBrrgCSpsocg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_mjXnwCkYEeuBrrgCSpsocg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Number of individual charges record contained in the message.
    /// </summary>
    [IsoId("_mjXnvSkYEeuBrrgCSpsocg")]
    [DisplayName("Number Of Charges Records")]
    [IsoXmlTag("NbOfChrgsRcrds")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public required IsoMax15NumericText NumberOfChargesRecords { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_mjXnuykYEeuBrrgCSpsocg")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Total amount of charges claimed through this message.
    /// </summary>
    [IsoId("_S8TFASkZEeuBrrgCSpsocg")]
    [DisplayName("Total Charges Amount")]
    [IsoXmlTag("TtlChrgsAmt")]
    public ActiveCurrencyAndAmount? TotalChargesAmount { get; init; }
}
