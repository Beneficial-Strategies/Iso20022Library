// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements that further details the information related to the type of payment.
/// </summary>
[IsoId("_TGOIHNp-Ed-ak6NoX_4Aeg_1553288143")]
[DisplayName("Payment Type Information")]
public record PaymentTypeInformation2
{
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the instruction.
    /// </summary>
    [IsoId("_TGX5ENp-Ed-ak6NoX_4Aeg_1553288455")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority2Code? InstructionPriority { get; init; }

    /// <summary>
    /// Agreement under which or rules under which the transaction should be processed.
    /// </summary>
    [IsoId("_TGX5Edp-Ed-ak6NoX_4Aeg_1553288962")]
    [DisplayName("Service Level")]
    [IsoXmlTag("SvcLvl")]
    public ServiceLevel3Choice_? ServiceLevel { get; init; }

    /// <summary>
    /// Specifies the clearing channel to be used for the instruction.
    /// </summary>
    [IsoId("_TGX5Etp-Ed-ak6NoX_4Aeg_1553288515")]
    [DisplayName("Clearing Channel")]
    [IsoXmlTag("ClrChanl")]
    public ClearingChannel2Code? ClearingChannel { get; init; }

    /// <summary>
    /// User community specific instrument.||Usage: When available, codes provided by local authorities should be used.
    /// </summary>
    [IsoId("_TGX5E9p-Ed-ak6NoX_4Aeg_1553289894")]
    [DisplayName("Local Instrument")]
    [IsoXmlTag("LclInstrm")]
    public LocalInstrument1Choice_? LocalInstrument { get; init; }

    /// <summary>
    /// Identifies the direct debit sequence, eg, first, recurrent, final or one-off.
    /// </summary>
    [IsoId("_TGX5FNp-Ed-ak6NoX_4Aeg_1553288550")]
    [DisplayName("Sequence Type")]
    [IsoXmlTag("SeqTp")]
    public SequenceType1Code? SequenceType { get; init; }

    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.
    /// </summary>
    [IsoId("_TGX5Fdp-Ed-ak6NoX_4Aeg_1553288876")]
    [DisplayName("Category Purpose")]
    [IsoXmlTag("CtgyPurp")]
    public PaymentCategoryPurpose1Code? CategoryPurpose { get; init; }
}
